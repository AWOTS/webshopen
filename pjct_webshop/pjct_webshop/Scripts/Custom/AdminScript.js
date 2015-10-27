$(document).ready(function() {
    $("#AddNewProductButton").click(function() {
        alert($("#NameNewProduct").val() + " " + $("#DescriptionNewProduct").val() + " " + $("#ImageNewProduct").val()
            + " " + $("#NumbersLeftNewProduct").val() + " " + $("#PriceNewProduct").val());
    });
});