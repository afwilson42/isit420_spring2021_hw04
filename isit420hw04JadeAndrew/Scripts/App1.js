
var uri = 'api/Orders';

$(document).ready(function () {
    $('#saveResponse').text = '';
    $("#markupSales").empty();
    //GetShowData();

});

/*
function GetShowData() {
    // Send an AJAX request
    $.getJSON(uri)
        .done(function (data) {
            // On success, 'data' contains a list of products.
            $('<li>', { text: "Priority: Subject => Details" }).appendTo($('#markupSales'));
            $.each(data, function (key, item) {
                // Add a list item for the product.
                $('<li>', { text: formatItem(item) }).appendTo($('#markupSales'));
            });
        });
}*/

};