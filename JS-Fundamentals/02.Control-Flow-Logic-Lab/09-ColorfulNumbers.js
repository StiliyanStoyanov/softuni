function printNums(n) {
    let html = "<ul>\n";
    for (let i = 1; i <= n; i++) {
        let color = (i % 2 == 0) ? "blue" : "green";//checking the number if it is even or odd line with ternary operator
        html += `\t<li><span style="color:${color}">${i}</span></li>\n`;
    }
    html += "</ul>\n";
    return html;
}
console.log(printNums(15));