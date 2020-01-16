function calculateMeals(meals, todo) {
    let counter = 0;
    let isValidIndex = i => i >= 0 && i < meals.length;
    for (let i = 0; i < todo.length; i++) {
        let commands = todo[i].split(' ').filter(x => x !== '');
        let command = commands[0];
        if (command === 'Serve') {
            if (meals.length > 0) {
                let food = meals.pop();
                console.log(`${food} served!`)
            }
        }
        if (command === 'Eat') {
            if (meals.length > 0) {
                let food = meals.shift();
                counter++;
                console.log(`${food} eaten`)
            }
        }
        if (command === 'Add') {
            if (commands.length > 1) {
                let meal = commands[1];
                meals.unshift(meal);
            }
        }
        if (command === 'Consume') {
            if (commands.length > 0) {
                let startIndex = Number(commands[1]);
                let endIndex = Number(commands[2]);
                if (isValidIndex(startIndex) && isValidIndex(endIndex)) {
                    let consumptionCounter = (endIndex - startIndex) + 1;
                    counter += consumptionCounter;
                    meals.splice(startIndex, consumptionCounter);
                    console.log('Burp!');
                }
            }
        }
        if (command === 'Shift') {
            if (commands.length > 3) {
                let x = Number(commands[1]);
                let y = Number(commands[2]);
                if (meals.length > 1) {
                    let firstMeal = meals[x];
                    let secondMeal = meals[y];
                    meals[x] = secondMeal;
                    meals[y] = firstMeal;
                }
            }
        }
        if (command === 'End') {
            if (meals.length > 0) {
                console.log(`Meals left: ${meals.join(', ')}`);
            }
            else {
                console.log('The food is gone')
            }
            console.log(`Meals eaten: ${counter}`);
            break;
        }
    }
}

calculateMeals(['chicken', 'steak', 'eggs'],
    ['Serve',
        'Eat',
        'End',
        'Consume 0 1']

);
console.log('-'.repeat(25));
calculateMeals(['fries', 'fish', 'beer', 'chicken', 'beer', 'eggs'],
    ['Add spaghetti',
        'Shift 0 1',
        'Consume 1 4',
        'End']
);
console.log('-'.repeat(25));
calculateMeals(['carrots', 'apple', 'beet'],
    ['Consume 0 2',
        'End',]

);