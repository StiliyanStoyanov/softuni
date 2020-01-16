function solve(array) {
    let number = (Number)(array[0]);

    for(let i = 1; i <= array.length - 1; i++){
        let operation = array[i];

        switch (operation){
            case "chop":
                number /= 2;
                console.log(number);
                break;
            case  "dice":
                number = Math.sqrt(number);
                console.log(number);
                break;
            case  "spice":
                ++number;
                console.log(number );
                break;
            case "bake":
                number *= 3;
                console.log(number);
                break;
            case  "fillet":
                number -= number * 0.2;
                console.log(number);
                break;
        }
    }
}

solve(['32', 'chop', 'chop', 'chop', 'chop', 'chop']);