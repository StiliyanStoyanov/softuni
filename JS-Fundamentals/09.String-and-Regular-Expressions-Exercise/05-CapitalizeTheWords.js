function capitalizeTheWords(string) {
    let pattern = /\w+/g;
    let match;
    while (match = pattern.exec(string)) {
        let newWord = match[0][0].toUpperCase();
        newWord += match[0].slice(1).toLowerCase();
        string = string.replace(match[0], newWord);
    }

    console.log(string);
}

capitalizeTheWords('Capitalize these words');