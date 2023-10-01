let Text1 = document.getElementById('herotext1');
let Text2 = document.getElementById('herotext2');

function heroScroll() {
        window.addEventListener('scroll', () => {
        let value = window.scrollY;

        Text1.style.left = value * -5 + 'px';
        Text2.style.left = value * -2 + 'px';
    })
};
