function showHideDepMovementBtn() {
    let form = document.getElementById('depForm');
    let button = document.getElementById('depBtn');

    if (form.style.display === 'none') {
        form.style.display = 'block';
    } else {
        form.style.display = 'none';
    }

    if (button.textContent === 'Display') {
        button.textContent = 'Hide';
    } else {
        button.textContent = 'Display'
    }
}

function showHideDepLDM() {
    let button = document.getElementById('ldmBtn');
    let form = document.getElementById('ldmForm');

    if (form.style.display === 'none') {
        form.style.display = 'block';
    } else {
        form.style.display = 'none'; 
    }


    if (button.textContent === 'Display outbound LDM') {
        button.textContent = 'Hide outbound LDM';
    } else {
        button.textContent = 'Display outbound LDM';
    }
}

function showHideDepPSM() {
    let button = document.getElementById('psmBtn');
    let form = document.getElementById('psmForm');


    if (form.style.display === 'none') {
        form.style.display = 'block';
    } else {
        form.style.display = 'none';
    }

    if (button.textContent === 'Display outbound PSM') {
        button.textContent = 'Hide outbound PSM';
    } else {
        button.textContent = 'Display outbound PSM';
    }
}

function showHideDepCPM() {
    let button = document.getElementById('cpmBtn');
    let form = document.getElementById('cpmForm');

    if (form.style.display === 'none') {
        form.style.display = 'block';
    } else {
        form.style.display = 'none';
    }

    if (button.textContent === 'Display outbound CPM') {
        button.textContent = 'Hide outbound CPM';
    } else {
        button.textContent = 'Display outbound CPM';
    }
}

function showHideDepUCM() {
    let button = document.getElementById('ucmBtn');
    let form = document.getElementById('ucmForm');

    if (form.style.display === 'none') {
        form.style.display = 'block';
    } else {
        form.style.display = 'none';
    }

    if (button.textContent === 'Display outbound UCM') {
        button.textContent = 'Hide outbound UCM';
    } else {
        button.textContent = 'Display outbound UCM';
    }
}