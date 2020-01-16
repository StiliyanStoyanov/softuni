function printOddPosition(array) {
    let result = [];
    for (let i = 0; i < array.length; i++) {
        if (i % 2 !== 0) {
            result.push(array[i]*2)
        }
    }
    console.log(result.reverse());
}

printOddPosition([10, 15, 20, 25]);

function getOddNumbers(numbers) {
    let oddNumbers = numbers
        .filter((a,b) => b % 2 !== 0)
        .map(a => a * 2)
        .reverse();

    console.log(oddNumbers.join(" "));
}

getOddNumbers([10, 15, 20, 25]);