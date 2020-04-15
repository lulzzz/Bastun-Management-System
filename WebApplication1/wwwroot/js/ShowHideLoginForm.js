function showHideLoginForm() {
    let button = document.getElementById('loginButton');
    let form = document.getElementById('loginForm');

    if (button.textContent === 'Show login form') {
        button.textContent = 'Hide login form';
    } else {
        button.textContent = 'Show login form';
    }

    if (form.style.display === "none") {
        form.style.display = "block";
    } else {
        form.style.display = "none";
    }
}