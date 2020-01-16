function binaryLogarithm(array) {
    for (let x in array) {
        console.log(Math.log2(array[x]));
    }
}

binaryLogarithm([1,2,3,4,5]);

function logarithm(nums) {
    for (let x of nums) {
        console.log(Math.log2(x));
    }
}

logarithm([1024,1048576,256,1,2]);
