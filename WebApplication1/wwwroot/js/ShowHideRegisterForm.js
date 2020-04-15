function showHideRegisterForm() {
    let displayButton = document.getElementById('registerButton');
    let form = document.getElementById('registerForm');

    if (displayButton.textContent === "Display") {
        displayButton.textContent = "Hide";
    } else {
        displayButton.textContent = "Display";
    }

    if (form.style.display === "none") {
        form.style.display = "block";
    } else {
        form.style.display = "none";
    }

}