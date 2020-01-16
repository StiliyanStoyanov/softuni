function solve(input) {
    let companies = input[0].split(input[1]).filter(x => x !== '');
    let validSentance = [];
    let invalidSentance = [];
    for (let i = 2; i < input.length; i++) {
        let current = input[i].toLowerCase();
        if (companies.every(item => current.includes(item))) {
            validSentance.push(input[i].toLowerCase());
        }
        else {
            invalidSentance.push(input[i].toLowerCase());
        }
    }
    if (validSentance.length > 0) {
        console.log('ValidSentences');
        for (let i = 0; i < validSentance.length; i++) {
            console.log(`${(i+1)}. ${validSentance[i]}`)
        }
    }
    if (invalidSentance.length > 0) {
        console.log('='.repeat(30));
        console.log('InvalidSentences');
        for (let i = 0; i < invalidSentance.length; i++) {
            console.log(`${(i+1)}. ${invalidSentance[i]}`)
        }

    }
}

solve(["bulgariatour@, minkatrans@, koftipochivkaltd",
    "@,",
    "Mincho e KoftiPochivkaLTD Tip 123  ve MinkaTrans BulgariaTour",
    "dqdo mraz some text but is KoftiPochivkaLTD MinkaTrans",
    "someone continues as no "]
);