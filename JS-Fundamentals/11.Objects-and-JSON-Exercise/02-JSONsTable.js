let test = {};

test['echo'] = {key: [1,2,3]};

for (let testElement in test) {
    console.log(testElement);
    for (let testElementKey in test) {
        test[testElement].key = 1;
        console.log(test[testElement].key);
    }
}
console.log('-'.repeat(25));
console.log(test);