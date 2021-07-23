function changeImage() {
    const sliderPhoto = document.getElementsByClassName('slider-photo')[0];
    const currentImage = sliderPhoto.style.backgroundImage;
    let index = +currentImage.substr(currentImage.indexOf('bg') + 2, 1);

    index = index % 5;
    index++;

    sliderPhoto.style.backgroundImage = 'url(./images/bg' + index + '.jpg)';
}

function onLoad() {
    setInterval(() => changeImage(), 2000);
}

function checkForEnter(event) {
    if (event.key === 'Enter') {
        const input = document.querySelector('.search-input');
        const value = input.value;
        const request = {
            city: value
        };

        const xhttp = new XMLHttpRequest();
        xhttp.onreadystatechange = function () {
            if (this.readyState === 4 && this.status === 200) {
                displayTours(this.response);
            }
        };
        xhttp.open('POST', 'https://localhost:44386/api/tour/search');
        xhttp.setRequestHeader('Content-type', 'application/json');
        xhttp.responseType = 'json';
        xhttp.send(JSON.stringify(request));
    }
}

function displayTours(tours) {
    let template = '';

    for (const tour of tours) {
        template += `<span class="tour-card">
            <img src="${tour.image}" />
            <b>${tour.name}</b>
            <p>
                ${tour.description}
            </p>
            <span class="price-tag">
                قیمت: ${tour.price} تومان
            </span>
        </span>`;
    }

    document.getElementById('tour-result').innerHTML = template;
    scrollTo({ top: document.getElementById('tour-result').offsetTop, behavior: 'smooth' });
}