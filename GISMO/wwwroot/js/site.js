// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

// TOP MAIN MENU
function loadHtml(id, filename) {
    //console.log(`div id: ${id}, filename: ${filename}`);

    let xhttp;
    let element = document.getElementById(id);
    let file = filename;
    if (file) {
        xhttp = new XMLHttpRequest();
        xhttp.onreadystatechange = function () {
            if (this.readyState == 4) {
                if (this.status == 200) { element.innerHTML = this.responseText; }
                if (this.status == 404) { element.innerHTML = "<h1> Page not found</h1>"; }
            }
        }
        xhttp.open("GET", `${file}`, true);
        xhttp.send();
        console.log(file);
        return;
    }
}

// VESSEL DETAILS PAGE, TAB PANELS
function openThis(evt, tabCont) {
    // Declare all variables
    var i, tabContentFormat, tablinks;

    // Get all elements with class="tabContentFormat" and hide them
    tabContentFormat = document.getElementsByClassName("tabContentFormat");
    for (i = 0; i < tabContentFormat.length; i++) {
        tabContentFormat[i].style.display = "none";
    }

    // Get all elements with class="tablinks" and remove the class "active"
    tablinks = document.getElementsByClassName("tablinks");
    for (i = 0; i < tablinks.length; i++) {
        tablinks[i].className = tablinks[i].className.replace(" active", "");
    }

    // Show the current tab, and add an "active" class to the button that opened the tab
    document.getElementById(tabCont).style.display = "block";
    evt.currentTarget.className += " active";
}
//document.getElementById("defaultOpen").click();

// IMAGE ENLARGE
// Get the img object using its Id
img = document.getElementById("eventimage");
// Function to increase image size
function enlargeImg() {
    // Set image size to 1.5 times original
    img.style.transform = "scale(1.5)";
    // Animation effect
    img.style.transition = "transform 0.25s ease";
}