function goldCollected(input) {
    let totalGold = 0;
    let specialized = ['Programming', 'Hardware maintenance', 'Cooking', 'Translating', 'Designing'];
    let average = ['Driving', 'Managing', 'Fishing', 'Gardening'];
    let clumsy = ['Singing', 'Accounting', 'Teaching', 'Exam-Making', 'Acting', 'Writing', 'Lecturing', 'Modeling', 'Nursing'];
    let counter = 1;
    let specializedcounter = 1;
    for (let i = 0; i < input.length; i++) {
        let split = input[i].split(' : ');
        let profession = split[0];
        let gold = Number(split[1]);
        if (specialized.includes(profession) && gold >= 200) {
            totalGold += gold * 0.80;
            if (specializedcounter % 2 === 0) {
                totalGold += 200;
            }
            specializedcounter++;
        }
        if (average.includes(profession)) {
            totalGold += gold;
        }
        if (clumsy.includes(profession)) {
            if (counter % 2 === 0) {
                gold = gold * 0.95;
                totalGold += gold;
                counter++;
            }
            else if (counter % 3 === 0) {
                gold = gold * 0.90;
                totalGold += gold;
                counter++;
            }
            else {
                totalGold += gold;
                counter++;
            }
        }
    }
    totalGold.toString();
    if (totalGold > 1000) {
        let moreEarned = totalGold - 1000;
        console.log(`Final sum: ${totalGold.toFixed(2)}\nMariyka earned ${moreEarned.toFixed(2)} gold more.`);
    }
    else if (totalGold < 1000) {
        let moreNeeded = 1000 - totalGold;

        console.log(`Final sum: ${totalGold.toFixed(2)}\nMariyka need to earn ${moreNeeded.toFixed(2)} gold more to continue in the next task.`)
    }
}

goldCollected(["Programming : 500", "Driving : 243", "Singing : 100", "Cooking : 199"]);
goldCollected(["Programming : 500", "Driving : 243.55", "Acting : 200", "Singing : 100", "Cooking : 199", "Hardware maintenance : 800", "Gardening : 700", "Programming : 500"]);