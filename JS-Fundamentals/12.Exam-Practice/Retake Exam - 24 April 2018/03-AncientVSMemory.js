function ancientVSMemory(input) {           // 100 / 100
    let str = input.join(' ').toString();
    let split = str.split(' ')
        .filter(x => (Number(x)) > 0 && (Number(x)) < 200 && x !== ' ');
    let result = '';
    split.shift();
    for (let i = 0; i < split.length; i++) {
        let convert = String.fromCharCode(split[i]);
        if ((Number(split[i])) <= 15) {
            result += '\n';
        }
        else {
            result += convert;
        }
    }
    console.log(result);
}

function memoryV2(arr) {
    let input = arr.join(' ').toString();
    let result = [];
    for (const resultElement of input) {
        if (resultElement === '32656' && resultElement === '19759' && resultElement === '19759') {
            
        }
    }
}

ancientVSMemory(['32656 19759 32763 0 1 0 51 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 32656 19759 32763 0 7 0 83 111 102 116 117 110 105 0 0 0 0 0 0']);