function getNumber(arr) {
    let result = [];
    for (let i = 0; i < arr.length; i++) {
        arr[i]
            .split(/\D+/)
            .filter(x => x !== '')
            .forEach(x => result.push(x));
    }

    console.log(result.join(' '));
}

getNumber(['The300',
    'What is that?',
    'I think it’s the 3rd movie.',
    'Lets watch it at 22:45']);