function solveRectangle(a, b) {
    let area = a * b;
    let perimeter = 2*(a+b);
    return [area, perimeter];
}

solveRectangle([2,2]);