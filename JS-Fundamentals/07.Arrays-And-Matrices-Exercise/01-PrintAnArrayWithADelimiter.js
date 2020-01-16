function printArray(array) {
    let delimiter = array[array.length - 1];
    array.pop();
    console.log(array.join(delimiter));

}

printArray(['one', 'two', 'three', '-']);