let test = {};

test['echo'] = {what: [1,2,3]};

for (let testElement in test) {
    console.log(testElement);
    for (let testElementKey in test) {
        for (let testKey in test[testElementKey]) {
            console.log(test[testElementKey][testKey]);
        }
    }
}
console.log('-'.repeat(25));
console.log(test);