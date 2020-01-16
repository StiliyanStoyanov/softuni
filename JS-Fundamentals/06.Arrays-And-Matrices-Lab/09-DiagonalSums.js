function getDiagonalsSums(matrix) {
    let sumFirstDiagonal = 0;
    let sumSecondDiagonal = 0;

    for(let row = 0; row < matrix.length; row++){
        sumFirstDiagonal += matrix[row][row];
        sumSecondDiagonal += matrix[row][matrix.length - row - 1];
    }

    let result = `${sumFirstDiagonal} ${sumSecondDiagonal}`;
    console.log(result);
}

getDiagonalsSums([[20, 40],
                  [10, 60]]);