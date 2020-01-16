// function sumByTown(input) {
//     let townsUnsorted = new Map();
//     for (let i = 0; i < input.length; i+=2) {
//         let town = input[i];
//         let value = Number(input[i+1]);
//         if (!townsUnsorted.has(town)) {
//             townsUnsorted.set(town, value);
//         }
//         else {
//             let updatedValue = townsUnsorted.get(town) + value;
//             townsUnsorted.set(town, updatedValue);
//         }
//     }
//     let towns = new Map(
//         Array
//             .from(townsUnsorted)
//             .sort((a, b) => {
//                 // a[0], b[0] is the key of the map
//                 return b[1] - a[1];
//             })
//     );
//     let arr = Array.from(towns);
//     console.log(arr);
//     console.log('------------');
//     console.log(townsUnsorted);
// }
//
// sumByTown(['Sofia', '1', 'Varna', '3', 'Sofia', '5', 'Varna', '4']);

// let test = {};
//
// test['echo'] = {key: [1,2,3]};
// test['abc'] = {sort: [4,5,6]};
//
// for (let testElement in test) {
//     console.log(testElement);
//     for (let testKey in test[testElement]) {
//         let arr = [test[testElement]].sort((a, b) => {
//             return a[testElement] - b[testElement];
//         });
//         console.log(arr);
//     }
// }
// console.log('-'.repeat(25));
// console.log(test);

var map = new Map();

map.set("orange", 10);
map.set("apple", 5);
map.set("banana", 20);
map.set("cherry", 13);
console.log(map);
map[Symbol.iterator] = function* () {
    yield* [...this.entries()].sort((a, b) => a[1] - b[1]);
};

for (let [key, value] of map) {     // get data sorted
    console.log(key + ' ' + value);
}
console.log([...map]);              // sorted order
console.log([...map.entries()]);    // original insertation order

for (let mapElement of map) {
    console.log(`${mapElement[0]} => ${mapElement[1]}`);
}
console.log(map[3]);

