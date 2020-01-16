function solve(arr) {
    let k = arr.shift();
    let firstKNums = arr.slice(0,k);
    let lastKNums = arr.slice(arr.length - k);

    console.log(firstKNums);
    console.log(lastKNums);
}

solve([3,
    6]
);