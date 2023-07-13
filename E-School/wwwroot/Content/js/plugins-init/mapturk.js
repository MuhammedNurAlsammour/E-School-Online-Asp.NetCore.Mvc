var svgTurkeyMap = document.getElementById("svg-turkey-map").getElementsByTagName("path");
var cityName = document.getElementById("city-name");

for (i = 0; i < svgTurkeyMap.length; i++) {

    svgTurkeyMap[i].addEventListener("mousemove", function () {
        cityName.classList.add("show-city-name--active");
        cityName.style.left = (event.clientX + 20 + "px");
        cityName.style.top = (event.clientY + 20 + "px")
        cityName.innerHTML = this.getAttribute("title");
    });

    svgTurkeyMap[i].addEventListener("mouseleave", function () {
        cityName.classList.remove("show-city-name--active");
    });

    svgTurkeyMap[i].addEventListener("click", function () {
        window.location.href = this.getAttribute("data-city-name");
    });

}