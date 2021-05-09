﻿
var uri = 'api/Orders';
var wasReady = false;

$(document).ready(function () {
    //GetShowData();
});

function GetShowData() {
    // Send an AJAX request
    $.getJSON(uri)
        .done(function (data) {
            // On success, 'data' contains a list of products.
            $.each(data, function (key, item) {
                // Add a list item for the product.
                //console.log(key, item);
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

}

function getStoreSales() {

}

function formatItem(item) {
    return item.StoreID + ':   ' + item.Count;
}

function find() {
    $('#saveResponse').text = '';
    $("#notes").empty();
    var id = $('#SearchId').val();
    $.getJSON(uri + '/' + id)
        .done(function (data) {
            $('#note').text(formatItem(data));
        })
        .fail(function (jqXHR, textStatus, err) {
            $('#note').text('Error: ' + err);
        });
}

function saveNote() {
    $('#saveResponse').text = '';
    $("#notes").empty();
    var note = {
        subject: $('#Subject').val(),
        details: $('#Details').val(),
        priority: $('#Priority').val()
    };

    $.ajax({
        url: uri + "/Notes",
        type: "POST",
        contentType: "application/json",
        data: JSON.stringify(note),
        success: function (data) {
            //self.notes.push(data);
            $("#notes").empty();
            GetShowData();
            $('#saveResponse').text("Success: Saved Note");
            $("#Subject").val('');
            $("#Details").val('');
            $("#Priority").val('');
        },
        error: function () {
            $('#saveResponse').text("Error: Save Failed");
        }
    });
}


function deleteNote() {
    $('#saveResponse').text = '';
    $("#notes").empty();
    var id = $('#deleteNote').val();
    $.ajax({
        url: uri + "/" + id,
        type: "DELETE",
        contentType: "application/json",
        success: function () {
            $("#notes").empty();
            GetShowData();
            $('#saveResponse').text("Success: Note Deleted");
            $("#deleteNote").val('');
        },
        error: function () {
            $('#saveResponse').text("Error: Delete Failed");
        }
    });
};