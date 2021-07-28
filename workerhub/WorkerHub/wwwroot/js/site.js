// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


//to swtich between the pages in the profile section
if (document.getElementById("myprofile")) {

    var one = document.getElementById("viewprofile");
    var two = document.getElementById("basicinfo1");
    var three = document.getElementById("myresume1");
    var four = document.getElementById("delete1");
    var five = document.getElementById("logoutt1");
    one.style.display = "block";
    two.style.display = "none";
    three.style.display = "none";
    four.style.display = "none";
    five.style.display = "none";
    var col = document.getElementById("ViewProfile");
    col.style.backgroundColor = "#a14dff";
}

function show1() {
    var one = document.getElementById("viewprofile");
    var two = document.getElementById("basicinfo1");
    var three = document.getElementById("myresume1");
    var four = document.getElementById("delete1");
    var five = document.getElementById("logoutt1");
    one.style.display = "block";
    two.style.display = "none";
    three.style.display = "none";
    four.style.display = "none";
    five.style.display = "none";
}

function show2() {
    var one = document.getElementById("viewprofile");
    var two = document.getElementById("basicinfo1");
    var three = document.getElementById("myresume1");
    var four = document.getElementById("delete1");
    var five = document.getElementById("logoutt1");
    one.style.display = "block";
    two.style.display = "none";
    three.style.display = "none";
    four.style.display = "none";
    five.style.display = "none";
}


function show3() {
    var one = document.getElementById("viewprofile");
    var two = document.getElementById("basicinfo1");
    var three = document.getElementById("myresume1");
    var four = document.getElementById("delete1");
    var five = document.getElementById("logoutt1");
    one.style.display = "none";
    two.style.display = "block";
    three.style.display = "none";
    four.style.display = "none";
    five.style.display = "none";
}

function show4() {
    var one = document.getElementById("viewprofile");
    var two = document.getElementById("basicinfo1");
    var three = document.getElementById("myresume1");
    var four = document.getElementById("delete1");
    var five = document.getElementById("logoutt1");
    one.style.display = "none";
    two.style.display = "none";
    three.style.display = "block";
    four.style.display = "none";
    five.style.display = "none";
}
function show5() {
    var one = document.getElementById("viewprofile");
    var two = document.getElementById("basicinfo1");
    var three = document.getElementById("myresume1");
    var four = document.getElementById("delete1");
    var five = document.getElementById("logoutt1");
    one.style.display = "none";
    two.style.display = "none";
    three.style.display = "none";
    four.style.display = "block";
    five.style.display = "none";
}
function show6() {
    var one = document.getElementById("viewprofile");
    var two = document.getElementById("basicinfo1");
    var three = document.getElementById("myresume1");
    var four = document.getElementById("delete1");
    var five = document.getElementById("logoutt1");
    one.style.display = "none";
    two.style.display = "none";
    three.style.display = "none";
    four.style.display = "none";
    five.style.display = "block";
}


//to switch colour between the selected section


function color2() {
    var one = document.getElementById("ViewProfile");
    var two = document.getElementById("BasicInfo");
    var three = document.getElementById("resumeinfo");
    var four= document.getElementById("Delete");
    var five = document.getElementById("logout");
    one.style.backgroundColor = "#a14dff";
    two.style.backgroundColor = "";
    three.style.backgroundColor = "";
    four.style.backgroundColor = "";
    five.style.backgroundColor = "";

}


function color3() {

    var one = document.getElementById("ViewProfile");
    var two = document.getElementById("BasicInfo");
    var three = document.getElementById("resumeinfo");
    var four = document.getElementById("Delete");
    var five = document.getElementById("logout");
    one.style.backgroundColor = "";
    two.style.backgroundColor = "#a14dff";
    three.style.backgroundColor = "";
    four.style.backgroundColor = "";
    five.style.backgroundColor = "";
}

function color4() {
    var one = document.getElementById("ViewProfile");
    var two = document.getElementById("BasicInfo");
    var three = document.getElementById("resumeinfo");
    var four = document.getElementById("Delete");
    var five = document.getElementById("logout");
    one.style.backgroundColor = "";
    two.style.backgroundColor = "";
    three.style.backgroundColor = "#a14dff";
    four.style.backgroundColor = "";
    five.style.backgroundColor = "";
}

function color5() {
    var one = document.getElementById("ViewProfile");
    var two = document.getElementById("BasicInfo");
    var three = document.getElementById("resumeinfo");
    var four = document.getElementById("Delete");
    var five = document.getElementById("logout");
    one.style.backgroundColor = "";
    two.style.backgroundColor = "";
    three.style.backgroundColor = "";
    four.style.backgroundColor = "#a14dff";
    five.style.backgroundColor = "";
}
function color6() {
    var one = document.getElementById("ViewProfile");
    var two = document.getElementById("BasicInfo");
    var three = document.getElementById("resumeinfo");
    var four = document.getElementById("Delete");
    var five = document.getElementById("logout");
    one.style.backgroundColor = "";
    two.style.backgroundColor = "";
    three.style.backgroundColor = "";
    four.style.backgroundColor = "";
    five.style.backgroundColor = "#a14dff";
}



//tab js//
$(document).ready(function (e) {


    $('.form').find('input, textarea').on('keyup blur focus', function (e) {

        var $this = $(this),
            label = $this.prev('label');

        if (e.type === 'keyup') {
            if ($this.val() === '') {
                label.removeClass('active highlight');
            } else {
                label.addClass('active highlight');
            }
        } else if (e.type === 'blur') {
            if ($this.val() === '') {
                label.removeClass('active highlight');
            } else {
                label.removeClass('highlight');
            }
        } else if (e.type === 'focus') {

            if ($this.val() === '') {
                label.removeClass('highlight');
            }
            else if ($this.val() !== '') {
                label.addClass('highlight');
            }
        }

    });

    $('.tab a').on('click', function (e) {

        e.preventDefault();

        $(this).parent().addClass('active');
        $(this).parent().siblings().removeClass('active');
        target = $(this).attr('href');

        $('.tab-content > div').not(target).hide();

        $(target).fadeIn(600);

    });
    //canvas off js//
    $('#menu_icon').click(function () {
        if ($("#content_details").hasClass('drop_menu')) {
            $("#content_details").addClass('drop_menu1').removeClass('drop_menu');
        }
        else {
            $("#content_details").addClass('drop_menu').removeClass('drop_menu1');
        }


    });

    //search box js//


    $("#flip").click(function () {
        $("#panel").slideToggle("5000");
    });

    // sticky js//

    $(window).scroll(function () {
        if ($(window).scrollTop() >= 500) {
            $('nav').addClass('stick');
        }
        else {
            $('nav').removeClass('stick');
        }
    });


  
});

