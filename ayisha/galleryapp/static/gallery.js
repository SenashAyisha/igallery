const images = document.querySelectorAll(".gimg");

images.forEach(img => {
    img.addEventListener("mouseover", () => {
        img.style.transform = "scale(1.8)";
    });
    img.addEventListener("mouseout", () => {
        img.style.transform = "scale(1)";
    });
});
