function buildMap(obj) {
    let map = new Map();
    Object.keys(obj).forEach(key => {
        map.set(key, obj[key]);
    });
    return map;
}


let testObj = {a: 1, b: 2, c: 3};
let map = buildMap(testObj);
let sortedKeys = Object.keys(testObj).sort((a, b) => b.localeCompare(a));
console.log(sortedKeys);
console.log(map);


