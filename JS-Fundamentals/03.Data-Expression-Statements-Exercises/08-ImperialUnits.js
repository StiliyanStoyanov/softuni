function solve(inches) {
    let feet = Math.trunc(inches / 12);
    let inch = inches % 12;
    console.log(`${feet}'-${inch}"`)
}


solve(36);