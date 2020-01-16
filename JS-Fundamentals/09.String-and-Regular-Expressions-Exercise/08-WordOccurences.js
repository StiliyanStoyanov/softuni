function main(sentence, word) {
    word = `\\b` + word + `\\b`;
    let reg = new RegExp(word, 'gi');
    let counter = 0;
    let match = reg.exec(sentence);

    while (match) {
        counter++;
        match = reg.exec(sentence);
    }
    console.log(counter);
}

main('The waterfall was so high, that the child couldn’t see its peak.', 'the');