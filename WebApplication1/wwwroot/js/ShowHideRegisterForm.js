function showHideRegisterForm() {
    let displayButton = document.getElementById('registerButton');
    let form = document.getElementById('registerForm');

    if (displayButton.textContent === "Show register") {
        displayButton.textContent = "Hide";
    } else {
        displayButton.textContent = "Show register";
    }

    if (form.style.display === "none") {
        form.style.display = "block";
    } else {
        form.style.display = "none";
    }

}