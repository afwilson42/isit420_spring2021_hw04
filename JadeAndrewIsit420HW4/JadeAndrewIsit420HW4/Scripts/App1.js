
var uri = 'api/Orders';

$(document).ready(function () {
    GetSalesPersonDropdown();
    GetStoreDropdown();
});

function GetSalesPersonDropdown() {
    $.getJSON('api/Query2')
        .done(function (data) {
            // On success, 'data' contains a list of products.
            $.each(data, function (key, item) {
                // Add a list item for the product.
                $('<option id=' + item.dtoSalesPersonID + '>' + item.dtoFirstName + " " + item.dtoLastName + '</option>').appendTo($('#spDropdown'));
            });
        });
}

function GetStoreDropdown() {
    $.getJSON('api/Query3')
        .done(function (data) {
            // On success, 'data' contains a list of products.
            $.each(data, function (key, item) {
                // Add a list item for the product.
                console.log(item.dtoStoreID);
                $('<option id=' + item.dtoStoreID + '>' + item.dtoCity + '</option>').appendTo($('#storeDropdown'));
            });
        });
}

function getMarkups() {
    $("#notes").empty(); //$('#SearchId').val();
    $.getJSON('api/Query1/')
        .done(function (data) {
            console.log(data);
            $.each(data, function (key, item) {
                // Add a list item for the product.
                $('<li>', { text: 'Store ' + item.StoreID + ':   ' + item.Count + ' CDs over $13.' }).appendTo($('#notes'));
            });      
        })
        .fail(function (jqXHR, textStatus, err) {
            $('#note1').text('Error: ' + err);
        });
}

function getEmpSales() {
    var id = $('#spDropdown option:selected').attr('id');
    $.getJSON('api/Query2/' + id)
        .done(function (data) {
            console.log(data);
            $('#spSum').text($('#spDropdown option:selected').text() + ' sold $' + data + ' for the year. ');
        })
        .fail(function (jqXHR, textStatus, err) {
            $('#note').text('Error: ' + err);
        });

}

function getStoreSales() {
    alert($('#storeDropdown option:selected').attr('id'));
}
