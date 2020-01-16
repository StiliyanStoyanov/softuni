function letterOccurrences(letterOccurrence) {
    let wordSplit = letterOccurrence[0].split("");
    let counter = 0;
    for (let i = 0; i < wordSplit.length; i++) {
        if (wordSplit[i] === letterOccurrence[1]){
            counter++;
        }
    }
    console.log(counter);
}

function letterCount(text,letter) {
    let regex = new RegExp(letter,"g");
    let count = (text.match(regex)).length;
    console.log(count);
}

letterCount("hello", "l");

letterOccurrences(['hello', 'l']);