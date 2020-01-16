function addSticker() {
    let stickerTitle = $('.title');
    let stickerText = $('.content');
    let textInput = stickerText.val();
    let title = stickerTitle.val();

    let ul = $('#sticker-list');
    let li = $(`<li class="note-content"></li>`);
    let button = $(`<a class="button">x</a>`);
    let h2 = $(`<h2>${title}</h2>`);
    let p = $(`<p>${textInput}</p>`);
    if (title !== '' && textInput !== '') {
        ul.append(li);
        li.append(button);
        li.append(h2);
        li.append($('<hr>'));
        li.append(p);
        stickerTitle.val('');
        stickerText.val('')
    }
    button.on('click', function () {
        $(this).parent().remove();
    });
}
