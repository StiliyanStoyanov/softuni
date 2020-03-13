const optionClick = () => {
    console.log(document);
    const elements = document.getElementsByClassName('option');
    const activeEl = document.getElementsByClassName('active');

    const clickerFn = (event) => {
        if (!event.target.className.includes('active')) {
            if (activeEl.length > 0) activeEl[0].classList.remove('active');
            event.target.classList.add('active');
        }
        else {
            if (activeEl.length > 0) activeEl[0].classList.remove('active');
        }
    };
    for (let i=0; i < elements.length; i++) {
        elements.item(i).onclick = clickerFn;
    }
};
optionClick();

