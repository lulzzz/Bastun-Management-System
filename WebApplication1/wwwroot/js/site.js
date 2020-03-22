// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function displayRegisterFlight() {
   
    let inputForm = document.getElementById('flightToAdd');

    if (inputForm.style.display === 'none') {
        inputForm.style.display = 'block';
    } else {
        inputForm.style.display = 'none';
    }
    
}

function changeDisplayButtonContent() {
    let button = document.getElementById('displayButton');
    let daily = document.getElementById('dailyMovements');
    

    if (daily.style.display === 'none') {
        daily.style.display = 'block';
    } else {
        daily.style.display = 'none';
    }

    if (button.textContent === 'Display daily') {
        button.textContent = 'Hide daily';
    } else {
        button.textContent = 'Display daily';
        
    }
}