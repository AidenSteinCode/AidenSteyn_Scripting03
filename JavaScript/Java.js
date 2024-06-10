document.addEventListener("DOMContentLoaded", function() {
    const sElement = document.getElementById("animated-s");
    sElement.style.top = "-100px"; // Reset position
    sElement.style.animation = "none"; // Reset animation
    // Trigger reflow
    sElement.offsetHeight;
    sElement.style.animation = "dropS 2s ease forwards";
});
