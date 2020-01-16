function dollarsV1(n) {
    let print = "$";
    for (let i = 1; i <= n; i++) {
        console.log(print);
        print += "$";
    }
}

function dollarsV2(n){
    for (let i = 1; i <= n; i++) {
        console.log(new Array(i + 1).join('$'));
    }
}

function dollarsV3(n){
    for (let i = 1; i <= n; i++) {
        console.log('$'.repeat(i));
    }
}

dollarsV1(3);
dollarsV2(3);
dollarsV3(3);