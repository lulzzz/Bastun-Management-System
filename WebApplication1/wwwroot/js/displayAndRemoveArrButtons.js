function displayArrMovement() {
    let form = document.getElementById('arrMovementForm');
    let button = document.getElementById('arrBtn');

    if (form.style.display === 'none') {
        form.style.display = 'block';
    } else {
        form.style.display = 'none';
    }

    if (button.textContent === 'Display') {
        button.textContent = 'Hide';
    } else {
        button.textContent = 'Display';
    }
}

function showHideLDMForm() {
    let button = document.getElementById('ldmBtn');
    let ldmForm = document.getElementById('ldmForm');

    if (ldmForm.style.display === 'none') {
        ldmForm.style.display = 'block';
    } else {
        ldmForm.style.display = 'none';
    }

    if (button.textContent === 'Display LDM') {
        button.textContent = 'Hide LDM';
    } else {
        button.textContent = 'Display LDM';
    }
}

function showHideCPMForm() {
    let button = document.getElementById('cpmBtn');
    let form = document.getElementById('cpmForm');

    if (form.style.display === 'none') {
        form.style.display = 'block';
    } else {
        form.style.display = 'none';
    }

    if (button.textContent === 'Display CPM') {
        button.textContent = 'Hide CPM';
    } else {
        button.textContent = 'Display CPM';
    }
}


function showHidePSMForm() {
    let button = document.getElementById('psm');
    let form = document.getElementById('psmForm');

    if (form.style.display === 'none') {
        form.style.display = 'block';
    } else {
        form.style.display = 'none';
    }

    if (button.textContent === 'Display PSM') {
        button.textContent = 'Hide PSM';
    } else {
        button.textContent = 'Display PSM';
    }
}

function showHideUCM() {
    let button = document.getElementById('ucmButton');
    let form = document.getElementById('ucmForm');

    
        if (form.style.display === 'none') {
            form.style.display = 'block';
        } else {
            form.style.display = 'none';
        }

        if (button.textContent === 'Display UCM') {
            button.textContent = 'Hide UCM';
        } else {
            button.textContent = 'Display UCM';
        }
   
}