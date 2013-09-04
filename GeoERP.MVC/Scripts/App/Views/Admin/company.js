$(function () {
    $("#adminMenu").kendoMenu({});

});

$(function() {
    $("#adminViewGrid").kendoGrid({
        dataSource: {
            transport: {
                read: { url: "/admin/admin/company", type: "GET" }
//                update: { url: "/Admin/Admin/AdminCompany", type: "POST" },
//                create: { url: "/Admin/Admin/AdminCompany", type: "POST" },
//                destroy: { url: "/Admin/Admin/AdminCompany", type: "DELETE"}
            },
            pageSize: 5,
            schema: {
                model: {
                    id: "Id"
                }
            }
        },
        columns: [
            { field: "Naziv" },
            { field: "Stranka" },
            { field: "Grupa" },
            { field: "Radnik" },
            { field: "Status" },
            { field: "Tip posla" },
            { field: "Datum" },
            { field: "Kreirao" },
//          { command: ["edit", "destroy"], title: "&nbsp;", width: "240px" }
        ],
        scrollable: true,
//        editable: "popup",
        pageable: { pageSizes: true|[5,10] }
    });
});