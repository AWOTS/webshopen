//$(document).ready(function () {
//    $("#@product.ArtNumber").click(function () {
//        alert($(this).attr('id'));
//    });
//});

$(function () {
    // Document.ready -> link up remove event handler
    $("#@product.ArtNumber").click(function () {
        // Get the id from the link
        var itemToAdd = $(this).attr("data-id");
        if (itemToAdd != '') {
            // Perform the ajax post
            $.post("c:\projects\git\webshopen\pjct_webshop\pjct_webshop\models\kassa_model.cs", { "id": itemToAdd },
                function (data) {
                    // Successful requests get here
                    // Update the page elements
                    if (data.ItemCount == 0) {
                        $('#row-' + data.DeleteId).fadeOut('slow');
                    } else {
                        $('#item-count-' + data.DeleteId).text(data.ItemCount);
                    }
                    $('#cart-total').text(data.CartTotal);
                    $('#update-message').text(data.Message);
                    $('#cart-status').text('Cart (' + data.CartCount + ')');
                });
        }
    });
});