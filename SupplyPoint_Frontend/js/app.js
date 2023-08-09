let signUpBtn = document.getElementById("signUpBtn");
        let signInBtn = document.getElementById("signInBtn");
        let nameField = document.getElementById("nameField");
        let loginTitle = document.getElementById("loginTitle");


        const slides = document.querySelectorAll(".slide");
        const btnPrev = document.querySelector("#prev");
        const btnNext = document.querySelector("#next");
        const headerSpan = document.querySelector(".header h1 span");


        let autoSlider = true;
        let sliderInterval;
        let timerInterval;
        let counter;
        let intervalTime = 3000;

        btnPrev.addEventListener("click", function () {
            prevSlide();/
            againInterval();
        });

        btnNext.addEventListener("click", function () {
            nextSlide();
            againInterval();
        });

        function prevSlide() {
            let activeSlide = document.querySelector(".active");
            activeSlide.classList.remove("active");
            if (activeSlide.previousElementSibling) {
                activeSlide.previousElementSibling.classList.add("active");
            } else {
                slides[slides.length - 1].classList.add("active");
            }
        }

        function nextSlide() {
            let activeSlide = document.querySelector(".active");
            activeSlide.classList.remove("active");
            if (activeSlide.nextElementSibling && activeSlide.nextElementSibling.classList.contains("slide")) {
                activeSlide.nextElementSibling.classList.add("active");
            } else {
                slides[0].classList.add("active");
            }
        }

        function againInterval() {
            if (autoSlider) {
                clearInterval(sliderInterval);
                clearInterval(timerInterval);
                counter = 1;

                sliderInterval = setInterval(nextSlide, intervalTime);
                timerInterval = setInterval(timerDisplay, 1000);
            }
        };

        if (autoSlider) {
            againInterval();
        }

        function timerDisplay() {
            counter++;

            if (counter > 5) againInterval();
        }



        // let viewLessBtn = document.getElementById("viewLessBtn");
        // let viewMoreBtn = document.getElementById("viewMoreBtn");
        // let newsArrivals2 = document.getElementById("news-arrivals-2");

        // viewMoreBtn.onclick = function () {
        //     newsArrivals2.classList.show();
        //     viewMoreBtn.classList.hide("disable-view");
        //     viewLessBtn.classList.show("disable-view");
        // }
        // viewLessBtn.onclick = function () {
        //     newsArrivals2.hide();
        //     viewMoreBtn.classList.show("disable-view");
        //     viewLessBtn.classList.hide("disable-view");
        // }



        signInBtn.onclick = function () {
            nameField.style.maxHeight = "0";
            loginTitle.innerHTML = "Sign In";
            signUpBtn.classList.add("disable");
            signInBtn.classList.remove("disable");
        }
        signUpBtn.onclick = function () {
            nameField.style.maxHeight = "60px";
            loginTitle.innerHTML = "Sign Up";
            signUpBtn.classList.remove("disable");
            signInBtn.classList.add("disable");
        }

        $(document).ready(function () {
            $('.contact-us').click(function () {
                $('.modal-contact-us').show();
            });
            $('.close').click(function () {
                $('.modal-contact-us').hide();
            });
        });
        $(document).ready(function () {
            $('.login').click(function () {
                $('.modal-login').show();
                $('#login-modal-container').show();
            });
            $('.close').click(function () {
                $('.modal-login').hide();
                $('#login-modal-container').hide();
            });
        });
        $(document).ready(function () {
            $('.sale-product-details').click(function () {
                $('.sale-modal-container').show();
            });
            $('.close').click(function () {
                $('.sale-modal-container').hide();
            });
        });
        $(document).ready(function () {
            $('.sale-product-details').click(function () {
                $('.sale-modal-container').show();
            });
            $('.close').click(function () {
                $('.sale-modal-container').hide();
            });
        });

        $(document).ready(function () {
            $('#viewMoreBtn').click(function () {
                $('#new-arrivals-hided').show();
                $('#viewMoreBtn').hide();
                $('#viewLessBtn').show();
            });
            $('#viewLessBtn').click(function () {
                $('#new-arrivals-hided').hide();
                $('#viewLessBtn').hide();
                $('#viewMoreBtn').show();
            });
        });
        $(document).ready(function () {
            $('#search-icon').click(function () {
                $('.header-content-input').show();
            });
        });
        $(document).ready(function () {
            $('#categories').click(function () {
                $('.header-content-input').hide();
            });
        });

