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

/**
* Template Name: Mamba - v2.5.1
* Template URL: https://bootstrapmade.com/mamba-one-page-bootstrap-template-free/
* Author: BootstrapMade.com
* License: https://bootstrapmade.com/license/
*/
!(function ($) {
    "use strict";

    // Toggle .header-scrolled class to #header when page is scrolled
    $(window).scroll(function () {
        if ($(this).scrollTop() > 100) {
            $('#header').addClass('header-scrolled');
        } else {
            $('#header').removeClass('header-scrolled');
        }
    });

    if ($(window).scrollTop() > 100) {
        $('#header').addClass('header-scrolled');
    }

    // Stick the header at top on scroll
    $("#header").sticky({
        topSpacing: 0,
        zIndex: '50'
    });

    // Smooth scroll for the navigation menu and links with .scrollto classes
    var scrolltoOffset = $('#header').outerHeight() - 2;
    $(document).on('click', '.nav-menu a, .mobile-nav a, .scrollto', function (e) {
        if (location.pathname.replace(/^\//, '') == this.pathname.replace(/^\//, '') && location.hostname == this.hostname) {
            var target = $(this.hash);
            if (target.length) {
                e.preventDefault();

                var scrollto = target.offset().top - scrolltoOffset;

                if ($(this).attr("href") == '#header') {
                    scrollto = 0;
                }

                $('html, body').animate({
                    scrollTop: scrollto
                }, 1500, 'easeInOutExpo');

                if ($(this).parents('.nav-menu, .mobile-nav').length) {
                    $('.nav-menu .active, .mobile-nav .active').removeClass('active');
                    $(this).closest('li').addClass('active');
                }

                if ($('body').hasClass('mobile-nav-active')) {
                    $('body').removeClass('mobile-nav-active');
                    $('.mobile-nav-toggle i').toggleClass('icofont-navigation-menu icofont-close');
                    $('.mobile-nav-overly').fadeOut();
                }
                return false;
            }
        }
    });

    // Activate smooth scroll on page load with hash links in the url
    $(document).ready(function () {
        if (window.location.hash) {
            var initial_nav = window.location.hash;
            if ($(initial_nav).length) {
                var scrollto = $(initial_nav).offset().top - scrolltoOffset;
                $('html, body').animate({
                    scrollTop: scrollto
                }, 1500, 'easeInOutExpo');
            }
        }
    });

    // Mobile Navigation
    if ($('.nav-menu').length) {
        var $mobile_nav = $('.nav-menu').clone().prop({
            class: 'mobile-nav d-lg-none'
        });
        $('body').append($mobile_nav);
        $('body').prepend('<button type="button" class="mobile-nav-toggle d-lg-none"><i class="icofont-navigation-menu"></i></button>');
        $('body').append('<div class="mobile-nav-overly"></div>');

        $(document).on('click', '.mobile-nav-toggle', function (e) {
            $('body').toggleClass('mobile-nav-active');
            $('.mobile-nav-toggle i').toggleClass('icofont-navigation-menu icofont-close');
            $('.mobile-nav-overly').toggle();
        });

        $(document).on('click', '.mobile-nav .drop-down > a', function (e) {
            e.preventDefault();
            $(this).next().slideToggle(300);
            $(this).parent().toggleClass('active');
        });

        $(document).click(function (e) {
            var container = $(".mobile-nav, .mobile-nav-toggle");
            if (!container.is(e.target) && container.has(e.target).length === 0) {
                if ($('body').hasClass('mobile-nav-active')) {
                    $('body').removeClass('mobile-nav-active');
                    $('.mobile-nav-toggle i').toggleClass('icofont-navigation-menu icofont-close');
                    $('.mobile-nav-overly').fadeOut();
                }
            }
        });
    } else if ($(".mobile-nav, .mobile-nav-toggle").length) {
        $(".mobile-nav, .mobile-nav-toggle").hide();
    }

    // Navigation active state on scroll
    var nav_sections = $('section');
    var main_nav = $('.nav-menu, .mobile-nav');

    $(window).on('scroll', function () {
        var cur_pos = $(this).scrollTop() + 200;

        nav_sections.each(function () {
            var top = $(this).offset().top,
                bottom = top + $(this).outerHeight();

            if (cur_pos >= top && cur_pos <= bottom) {
                if (cur_pos <= bottom) {
                    main_nav.find('li').removeClass('active');
                }
                main_nav.find('a[href="#' + $(this).attr('id') + '"]').parent('li').addClass('active');
            }
            if (cur_pos < 300) {
                $(".nav-menu ul:first li:first").addClass('active');
            }
        });
    });

    // Intro carousel
    var heroCarousel = $("#heroCarousel");
    var heroCarouselIndicators = $("#hero-carousel-indicators");
    heroCarousel.find(".carousel-inner").children(".carousel-item").each(function (index) {
        (index === 0) ?
            heroCarouselIndicators.append("<li data-target='#heroCarousel' data-slide-to='" + index + "' class='active'></li>") :
            heroCarouselIndicators.append("<li data-target='#heroCarousel' data-slide-to='" + index + "'></li>");
    });

    heroCarousel.on('slid.bs.carousel', function (e) {
        $(this).find('h2').addClass('animate__animated animate__fadeInDown');
        $(this).find('p, .btn-get-started').addClass('animate__animated animate__fadeInUp');
    });

    // Back to top button
    $(window).scroll(function () {
        if ($(this).scrollTop() > 100) {
            $('.back-to-top').fadeIn('slow');
        } else {
            $('.back-to-top').fadeOut('slow');
        }
    });

    $('.back-to-top').click(function () {
        $('html, body').animate({
            scrollTop: 0
        }, 1500, 'easeInOutExpo');
        return false;
    });

    // Initiate the venobox plugin
    $(window).on('load', function () {
        $('.venobox').venobox();
    });

    // jQuery counterUp
    $('[data-toggle="counter-up"]').counterUp({
        delay: 10,
        time: 1000
    });

    // Porfolio isotope and filter
    $(window).on('load', function () {
        var portfolioIsotope = $('.portfolio-container').isotope({
            itemSelector: '.portfolio-item',
            layoutMode: 'fitRows'
        });

        $('#portfolio-flters li').on('click', function () {
            $("#portfolio-flters li").removeClass('filter-active');
            $(this).addClass('filter-active');

            portfolioIsotope.isotope({
                filter: $(this).data('filter')
            });
            aos_init();
        });

        // Initiate venobox (lightbox feature used in portofilo)
        $(document).ready(function () {
            $('.venobox').venobox();
        });
    });

    // Portfolio details carousel
    $(".portfolio-details-carousel").owlCarousel({
        autoplay: true,
        dots: true,
        loop: true,
        items: 1
    });

    // Init AOS
    function aos_init() {
        AOS.init({
            duration: 1000,
            easing: "ease-in-out-back",
            once: true
        });
    }
    $(window).on('load', function () {
        aos_init();
    });

})(jQuery);