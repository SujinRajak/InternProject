// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


//to swtich between the pages in the profile section
if (document.getElementById("myprofile")) {

    var one = document.getElementById("viewprofile");
    var two = document.getElementById("changepassword");
    var three = document.getElementById("delete1");
    var four = document.getElementById("logoutt1");
    one.style.display = "block";
    two.style.display = "none";
    three.style.display = "none";
    four.style.display = "none";
    var col = document.getElementById("ViewProfile");
    col.style.backgroundColor = "#a14dff";
}

function show1() {
    var one = document.getElementById("viewprofile");
    var two = document.getElementById("changepassword");
    var three = document.getElementById("delete1");
    var four = document.getElementById("logoutt1");
    one.style.display = "block";
    two.style.display = "none";
    three.style.display = "none";
    four.style.display = "none";
}

function show2() {
    var one = document.getElementById("viewprofile");
    var two = document.getElementById("changepassword");
    var three = document.getElementById("delete1");
    var four = document.getElementById("logoutt1");
    one.style.display = "block";
    two.style.display = "none";
    three.style.display = "none";
    four.style.display = "none";
}


function show3() {
    var one = document.getElementById("viewprofile");
    var two = document.getElementById("changepassword");
    var three = document.getElementById("delete1");
    var four = document.getElementById("logoutt1");
    one.style.display = "none";
    two.style.display = "block";
    three.style.display = "none";
    four.style.display = "none";
}

function show4() {
    var one = document.getElementById("viewprofile");
    var two = document.getElementById("changepassword");
    var three = document.getElementById("delete1");
    var four = document.getElementById("logoutt1");
    one.style.display = "none";
    two.style.display = "none";
    three.style.display = "block";
    four.style.display = "none";
}

function show5() {
    var one = document.getElementById("viewprofile");
    var two = document.getElementById("changepassword");
    var three = document.getElementById("delete1");
    var four = document.getElementById("logoutt1");
    one.style.display = "none";
    two.style.display = "none";
    three.style.display = "none";
    four.style.display = "block";
}



//to switch colour between the selected section


function color2() {

    var one = document.getElementById("ViewProfile");
    var two = document.getElementById("ChangePassword");
    var three = document.getElementById("Delete");
    var four = document.getElementById("logout");
    one.style.backgroundColor = "#a14dff";
    two.style.backgroundColor = "";
    three.style.backgroundColor = "";
    four.style.backgroundColor = "";
}


function color3() {

    var one = document.getElementById("ViewProfile");
    var two = document.getElementById("ChangePassword");
    var three = document.getElementById("Delete");
    var four = document.getElementById("logout");
    one.style.backgroundColor = "";
    two.style.backgroundColor = "#a14dff";
    three.style.backgroundColor = "";
    four.style.backgroundColor = "";
}

function color4() {
    var one = document.getElementById("ViewProfile");
    var two = document.getElementById("ChangePassword");
    var three = document.getElementById("Delete");
    var four = document.getElementById("logout");
    one.style.backgroundColor = "";
    two.style.backgroundColor = "";
    three.style.backgroundColor = "#a14dff";
    four.style.backgroundColor = "";
}

function color5() {

    var one = document.getElementById("ViewProfile");
    var two = document.getElementById("ChangePassword");
    var three = document.getElementById("Delete");
    var four = document.getElementById("logout");
    one.style.backgroundColor = "";
    two.style.backgroundColor = "";
    three.style.backgroundColor = "";
    four.style.backgroundColor = "#a14dff";
}