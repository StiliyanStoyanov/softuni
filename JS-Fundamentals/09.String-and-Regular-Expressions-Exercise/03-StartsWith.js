function startsWith(text, substring) {
    if (text.startsWith(substring)) {
        console.log('true');
        return;
    }

    console.log('false');
}

startsWith('How have you been?', 'how');