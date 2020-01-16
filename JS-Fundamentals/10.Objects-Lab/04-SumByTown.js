function sumByTown(input) {
    let towns = new Map();
    for (let i = 0; i < input.length; i+=2) {
        let town = input[i];
        let value = Number(input[i+1]);
        if (!towns.has(town)) {
            towns.set(town, value);
        }
        else {
            let updatedValue = towns.get(town) + value;
            towns.set(town, updatedValue);
        }
    }

    let numberSort = new Map(
        // Sorting With Numbers
        Array
            .from(towns)
            .sort((a, b) => {
                // a[0], b[0] is the key of the map
                return a[0] - b[0];
            })
    );

    let sortMapByString1 = Array.from(towns).sort(function(a, b){
        // Sorting Strings Variant 1
        let nameA=a[0].toLowerCase(), nameB=b[0].toLowerCase();
        if (nameA < nameB) //sort string ascending
            return -1;
        if (nameA > nameB)
            return 1;
        return 0; //default return value (no sorting)
    });
    let stringSort = new Map(sortMapByString1);

    let sortMapByString2 = new Map(
        // Sorting With Strings Variant 2
        Array
            .from(towns)
            .sort((a, b) => {
                return a[0].localeCompare(b[0]);
            })
    );
    console.log('String SORT 1 - localCompare:');
    console.log(sortMapByString2);
    console.log('-'.repeat(50));
    console.log('String SORT 2:');
    console.log(stringSort);
    console.log('-'.repeat(50));
    console.log('Number SORT:');
    console.log(numberSort);
}

sumByTown(['Sofia', '3', 'Varna', '3', 'Sofia', '2', 'Varna', '4', 'Burgas', '15']);