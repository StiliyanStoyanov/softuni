const cubeModel = require('../models/cube');

function index(req, res, next) {
    const { from, to, search } = req.query;
    const findFn = item => {
        let result = true;
        if (search) {
            result = item.name.toLowerCase().includes(search);
        }
        if (result && from) {
            result = +item.difficultyLevel >= +from;
        }
        if (result && to) {
            result = +item.difficultyLevel <= +to;
        }
        return result;
    };
    cubeModel.find(findFn).then(cubes => {
        res.render('index.hbs', { cubes, search, from, to });
    }).catch(next);
}

function details(req, res, next) {
    const id = +req.params.id;
    cubeModel.getOne(id).then(cube => {
        if (!cube) { res.redirect('/not-found'); return; }
        res.render('details.hbs', { cube });
    }).catch(next);

}

function getCreate(req, res) {
    res.render('create.hbs');
}

function postCreate(req, res) {
    const { name = null, description = null, imageUrl = null, difficultyLevel = null } = req.body;
    const newCube = cubeModel.create(name, description, imageUrl, difficultyLevel);
    cubeModel.insert(newCube).then(() => {
        res.redirect('/')
    });

}

function notFound(req, res) {
    res.render('404.hbs');
}

function about(req, res) {
    res.render('about.hbs');
}

module.exports = {
    index,
    details,
    getCreate,
    postCreate,
    notFound,
    about
};