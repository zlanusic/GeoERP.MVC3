$(function () {
    $("#adminMenu").kendoMenu();

});

$(function() {
    $("#adminGrid").kendoGrid({
        columns: [
            {
                field: "posao"
            },
            {
                field: "radnik"
            },
            {
                field: "status"
            },
            {
                field: "itd."
            }
        ],
        scrollable: false,
        editable: true,
        pageable: true
    });
});