function sum3Numbers(numbers) {
    let sum = 0;
    if (numbers.length === 3){
        for (let i = 0; i < numbers.length; i++) {
            sum += numbers[i];
        }
        console.log(sum);
    }
}