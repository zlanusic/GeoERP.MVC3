$(function () {
    // --Kendo UI DropdownList za odabir banke.
    $("#ddlBank").kendoComboBox();

    // --Kendo UI Modal Dialog za dodavanje banke.
    //$("#addBank").kendoWindow();

    // --Kendo UI Upload kontrola za dodavanje slike.
    //$("#uploadWrapper").kendoUpload();

});

// --GET zahtjev za pregled, kada korisnik pritisne profil link
$(function() {
    $(".profilLink").click(function() {

        var getProfileById = {};

        getProfileById.Id = 1;

        $.get("admin/admin/profile", getProfileById, function(result) {
            if (result.success) 
            {
                $(".status").text(result.msg);
            }
            else 
            {
                $(".status").text(result.msg);
            }
        });

//        $.ajax({
//            url: "/admin/admin/profile",
//            contentType: "json",
//            type: "GET",
//            // --callback fja koja se izvrsava kada server vrati success code 200, green status light
//            success: function(company) {
//                
//            }
//        });
    });
});

// --POST zahtjev za azuriranje, kada korisnik pritisne "promjeni" button
    $(function() {
        $("#btnUpdate").click(function() {

            // --profil objekt
            var updateProfile = {};
            
            updateProfile.Id = "0",
            updateProfile.FullName = $("#txtFullName").val();
            updateProfile.ShortName = $("#txtShortName").val();
            updateProfile.City = $("#txtTown").val();
            updateProfile.Address = $("#txtAddress").val();
            updateProfile.Owner = $("#txtOwner").val();
            updateProfile.OibNum = $("#txtOib").val();
            updateProfile.PdvNum = $("#txtPdv").val();
            updateProfile.Mb = $("#txtMb").val();
            updateProfile.Phone = $("#txtPhone").val();
            updateProfile.Mobile = $("#txtTown").val();
            updateProfile.Fax = $("#txtFax").val();
            updateProfile.Url = $("#txtUrl").val();
            updateProfile.Email1 = $("#txtEmail1").val();
            updateProfile.Email2 = $("#txtEmail2").val();
            updateProfile.Email3 = $("#txtEmail3").val();
            updateProfile.Username = $("#txtUserName").val();
            updateProfile.Pwd = $("#txtPwd").val();

            // -- za debbuging u firebugu
            console.log(updateProfile);

            // --convert javascript objekt u JSON objekt
            var dto = { 'UpdateProfile': updateProfile };
            JSON.stringify(dto);

            $.post("/admin/admin/profile", updateProfile, function(result) {

                if (result.success) 
                {
                    $(".status").text(result.msg);
                }
                else 
                {
                    alert("Greška na serveru! Vjerojatno naš WCF nije prilagođen za JSON. Mora biti webHttp binding omogućen.");
                }
            }, "json").error(function() {
                
            });

//        $.ajax({
//            type: "POST",
//            contentType: "application/json; charset=utf-8",
//            url: "/admin/admin/_profile",
//            data: updateProfile,
//            dataType: "json",
//            // --callback fja koja se izvrsava kada server vrati success code 200, green status light
//            success: function (data) {
//                alert('Dodano');
//            }
//        }).fail(function (xhr, txtStatus, err) {
//            alert(err);
//        });
        });
    });