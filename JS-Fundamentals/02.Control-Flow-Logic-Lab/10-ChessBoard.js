function chessBoard(size) {
    let html = '<div class="chessboard">\n';
    for (let i = 0; i < size; i++) {
        html += '\t<div>\n';
        let color = (i % 2 == 0) ? 'black' : 'white';
        for (let j = 0; j < size; j++) {
            html += `\t<span class="${color}"></span>\n`;
            color = (color == 'white') ? 'black' : 'white'
        }
        html += '\t</div>\n';
    }
    html += '</div>';
    return html;
}