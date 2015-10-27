$(document).ready(function () {
    $("#kknapp").click(function () {
        alert($("#kförnamn").val() + $("#kefternamn").val() + $("#kadress").val()
            + $("#kstad").val() + $("#kpostnummer").val() + $("#kemail").val()
            + $("#ktelefonnummer").val() + $("#kmeddelande").val());
    });
});