function addOrRemove(command) {
    let result = [];
    for (let i = 0; i < command.length; i++) {
        if (command[i] === 'add') {
            result.push(i + 1);
        }
        else {
            result.splice(result.length - 1);
        }
    }
    if (result === undefined || result.length === 0) {
        console.log('Empty');
    }
    else {
        console.log(result.join(`\n`));
    }
}

addOrRemove(["add", "add", 'remove', "remove", "remove"]);