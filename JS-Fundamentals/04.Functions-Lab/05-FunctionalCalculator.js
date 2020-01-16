function calculator(num1, num2, operator) {
    let result = 0;
    if (operator=="+"){
        result = num1 + num2;
    }else if(operator == "-"){
        result = Math.abs(num1 - num2);
    }else if(operator == "*"){
        result = num1 * num2;
    }else if(operator == "/"){
        result = num1 / num2;
    }else if(operator == "%"){
        result = num1 % num2;
    }
    console.log(result);  // Probably Switch Case is More Optimal
}
calculator(2, 4, '+');