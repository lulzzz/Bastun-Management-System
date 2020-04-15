function showHideLoginForm() {
    let button = document.getElementById('loginButton');
    let form = document.getElementById('loginForm');

    if (button.textContent === 'Display') {
        button.textContent = 'Hide';
    } else {
        button.textContent = 'Display';
    }

    if (form.style.display === "none") {
        form.style.display = "block";
    } else {
        form.style.display = "none";
    }
}