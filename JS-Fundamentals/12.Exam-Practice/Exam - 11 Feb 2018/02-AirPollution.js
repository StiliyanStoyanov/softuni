function trackPollution(array, commands) {
    let matrix = [];
    for (let i = 0; i < array.length; i++) {
        let currentRow = array[i];
        matrix.push(currentRow.split(' ').map(Number));
    } // Mapping Matrix
    for (let i = 0; i < commands.length; i++) {
        let todo = commands[i].split(' ');
        let command = todo[0];
        let value = Number(todo[1]);
        if (command === 'breeze') {
            for (let j = 0; j < array.length; j++) {
                if (matrix[value][j] - 15 < 0) {
                    matrix[value][j] = 0;
                }
                else {
                    matrix[value][j] -= 15;
                }
            }
        }
        if (command === 'gale') {
            for (let j = 0; j < array.length; j++) {
                if (matrix[j][value] - 20 < 0) {
                    matrix[j][value] = 0
                }
                else {
                    matrix[j][value] -= 20
                }
            }
        }
        if (command === 'smog') {
            for (let j = 0; j < matrix.length; j++) {
                for (let k = 0; k < matrix.length; k++) {
                    matrix[j][k] += value;
                }
            }
        }
    } // Executing Commands

    let polutedAreas = [];
    for (let i = 0; i < matrix.length; i++) {
        for (let j = 0; j < matrix[i].length; j++) {
            if (matrix[i][j] >= 50) {
                polutedAreas.push(`[${i}-${j}]`);
            }
        }
    } // Preparing For Printing
    console.log(polutedAreas);
    if (polutedAreas.length > 0) {
        console.log(`Polluted areas: ${polutedAreas.join(', ')}`);
    }
    else {
        console.log('No polluted areas');
    }
}

trackPollution(
    [
        "5 7 72 14 4",
        "41 35 37 27 33",
        "23 16 27 42 12",
        "2 20 28 39 14",
        "16 34 31 10 24",
    ],
    [
        "breeze 1", "gale 2", "smog 25"
    ]
);