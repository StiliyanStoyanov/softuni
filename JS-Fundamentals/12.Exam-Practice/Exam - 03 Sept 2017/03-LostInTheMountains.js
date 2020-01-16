function getMessage(key,text) {
    let coordinatesPattern = /(north|east)[^,]*?(\d{2})[^,]*?,[^,]*?(\d{6})/i;
    let match;
    let northMatch;
    let eastMatch;

    while (match = coordinatesPattern.exec(text)){
        text = text.replace(match[0],'');
        console.log(text);
        if(match[1].toLowerCase() === 'east'){
            eastMatch = match;
            continue;
        }

        northMatch = match;
    }

    let messagePattern = new RegExp(key +'(.+)' + key,'g');
    console.log(messagePattern);
    let message = messagePattern.exec(text);

    console.log(`${northMatch[2]}.${northMatch[3]} N`);
    console.log(`${eastMatch[2]}.${eastMatch[3]} E`);
    console.log(`Message: ${message[1]}`);
}

getMessage('<>', 'o u%&lu43t&^ftgv><nortH4276hrv756dcc,  jytbu64574655k <>ThE sanDwich is iN the refrIGErator<>yl i75evEAsTer23,lfwe 987324tlblu6b');