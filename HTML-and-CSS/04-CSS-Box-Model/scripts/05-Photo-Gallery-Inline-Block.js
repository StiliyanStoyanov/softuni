// 05 - Fill with JS for fun

window.addEventListener("load", () => {
    let body = document.getElementsByTagName("body")[0];
    let ul = document.createElement("ul");
    ul.setAttribute('class', 'gallery');
    let counter = 1;
    let picturesToDisplay = 24;
    for (let i = 1; i <= picturesToDisplay; i++) {
        let imageSrc = `styles/img/picture${counter}.jpg`;
        let img = document.createElement("img");
        img.setAttribute('src', `${imageSrc}`);
        let li = document.createElement("li");
        li.appendChild(img);
        if (counter % 3 === 0) {
            ul.appendChild(li);
            body.appendChild(ul);
            ul = ul.cloneNode();
            if (counter === 6) {
                counter = 1;
                continue;
            }
            counter++;
            continue;
        }
        ul.appendChild(li);
        counter++;
        if (i === picturesToDisplay) {
            body.appendChild(ul);
        }
    }

});