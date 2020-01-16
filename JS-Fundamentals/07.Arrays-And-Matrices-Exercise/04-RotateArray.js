function rotateArray(array) {
    let rotations = array.pop() % array.length;
    for (let i = 0; i < rotations; i++) {
        let firstElement = array[array.length - 1];
        array.pop();
        array.unshift(firstElement);
    }
    console.log(array.join(" "));
}

rotateArray([1, 3, 8, 4, 10, 12, 3, 2, 24]);