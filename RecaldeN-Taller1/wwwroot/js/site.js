// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$(document).ready(function () {
    // Initialize the carousel
    $('#carouselExampleIndicators').carousel();

    // Function to go to the next slide
    function nextSlide() {
        $('#carouselExampleIndicators').carousel('next');
    }

    // Function to go to the previous slide
    function prevSlide() {
        $('#carouselExampleIndicators').carousel('prev');
    }

    // Function to go to a specific slide (index starts from 0)
    function goToSlide(index) {
        $('#carouselExampleIndicators').carousel(index);
    }

    // Example usage
    $('#nextButton').click(nextSlide);
    $('#prevButton').click(prevSlide);
    $('#goToSlideButton').click(function () {
        goToSlide(2); // Go to the third slide
    });
});