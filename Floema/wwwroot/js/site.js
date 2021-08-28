// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

// Initialize Flickty
$('.main-carousel').flickity({
    // options
    cellAlign: 'left',
    contain: true
});

//$('.wrapper-product-grid').packery({
//    // options
    
//});


var $grid = $('.wrapper-product-grid').imagesLoaded(function() {
    $grid.packery({
        itemSelector: '.product-grid-item',
        gutter: 10
    });
});