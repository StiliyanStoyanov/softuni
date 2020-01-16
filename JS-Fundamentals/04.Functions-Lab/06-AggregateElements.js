function solve(array) {
    let sumArray = 0;
    let inverseSum = 0;
    let concatArray = "";
    for (let i = 0; i < array.length; i++) {
        sumArray += array[i];
        inverseSum += (1 / array[i]);
        concatArray = array.join('');
    }
    console.log(sumArray);
    console.log(inverseSum);
    console.log(concatArray);
}

solve([1, 2, 3]);