let map = new Map();

map.set('1', aaa = new Map());
map.set('2', 'test');
map.set('3', 'test');

aaa.set(100, 1);
aaa.set(200, 2);
aaa.set(300, 3);

let test1 = Array.from(aaa);
test1.sort((a, b) => b[0] - a[0]);
map.set('1', new Map(test1));
aaa.set(5, 50);
console.log(test1);
let test2 = map.get('1');
test2.set(1, 1);
let keys = test2.values();
console.log(keys);
let sortedMap = new Map(
    // Sorting With Strings Variant 2
    Array
        .from(map)
        .sort((a, b) => {
            return b[0].localeCompare(a[0]);
        })
);

// let sort = Array.from(sortedMap.get('1').sort((a, b) => {
//     return b[0].localeCompare(a[0]);
// }));
let test = sortedMap.get('1');
let sort = Object.keys(test).sort((a, b) => {
    return b[0].localeCompare(a[0]);
});

console.log(sortedMap);