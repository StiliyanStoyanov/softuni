const fs = require('fs');
const path = require('path');

class cubeModel {
    constructor() {
        this.data = require('../config/database');
    }

    _write(newData, resolveData) {
        return new Promise(((resolve, reject) => {
            fs.writeFile(path.resolve('config/database.json'), JSON.stringify(newData, null, 2), (err) => {
                if (err) { reject(err); return; }
                this.data = newData;
                resolve(resolveData);
            });
        }));
    }
    create(name, description, imageUrl, difficultyLevel) {
        return {name, description, imageUrl, difficultyLevel};
    }

    insert(newCube) {
        const newIndex = ++this.data.lastIndex || 0;
        newCube = {id: newIndex, ...newCube};
        const newData = {
            lastIndex: newIndex,
            entities: this.data.entities.concat(newCube)
        };

        return this._write(newData, newCube);
    }

    find(predFn) {
        return Promise.resolve(this.data.entities.filter(predFn));
    }

    getOne(id) {
        return this.find(({id: i}) => i === id).then(res => res[0] || null);
    }

    getAll() {
        return Promise.resolve(this.data.entities);
    }
}

module.exports = new cubeModel();