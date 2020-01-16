function getIncreasing(input) {  // 80/100
    let result = [];
    result.push(input[0]);
    for (let i = 0; i < input.length; i++) {
        if (input[i] > result[result.length-1] && i > 0) {
            result.push(input[i]);
        }
    }
    result.filter(x =>  x !== undefined);
    console.log(result.join(`\n`));
}

getIncreasing([1, 3, 8, 4, 10, 12, 3, 2, 24]);

function getSubsequence(input) {  // 100/100
    let arr = [];

    let biggest;

    input.forEach(function(e){
        if (biggest != undefined){
            if (e >= biggest){
                arr.push(e);
                biggest = e;
            }
        }
        else{
            biggest = e;
            arr.push(e);
        }
    });

    arr.forEach(e => console.log(e));
}
getSubsequence([2, 0, 3, 2, 15, 6, 1]);