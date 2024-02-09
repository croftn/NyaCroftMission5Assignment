// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

// Function to calculate cost of my kayaking services
function calculateTotal() {
    var hours = parseFloat($('#hours').val());
    var rate = parseFloat($('#rate').val().replace('$', '')); // Remove '$' symbol
    var total = 0;

    if (!isNaN(hours) && hours > 0 && !isNaN(rate)) { // Check if hours and rate are valid numbers
        total = hours * rate;
        $('#total').val("$" + total.toFixed(2));
    } else {
        alert("Please enter a valid positive number for hours.");
        $('#hours').focus();
    }
}
