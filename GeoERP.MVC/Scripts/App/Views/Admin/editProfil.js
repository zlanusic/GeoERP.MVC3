$(function () {
    // --Kendo UI DropdownList za odabir banke.
    $("#ddlBank").kendoDropDownList();

    // --Kendo UI Modal Dialog za dodavanje banke.
    $("#addBank").kendoWindow();

    // --Kendo UI Upload kontrola za dodavanje slike.
    $("#uploadWrapper").kendoUpload();
});