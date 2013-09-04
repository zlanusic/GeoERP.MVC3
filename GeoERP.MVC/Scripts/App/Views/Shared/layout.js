/* Upotreba JavaScript API-a umjesto HTML Helpers-a kako bi dobili potpunu kontrolu nad Kendo UI Web kontrolama */

// --Forma za prijavu korisnika kao pocetni view prilikom dolaska na site app
//$(function () {
//    loadMembershipView("/auth/auth/_login");
//    //bindMembershipLinks();

//});

//function bindMembershipLinks() {
//    // --Linkovi
//    $(".loginLink").click(function (event) {
//        event.preventDefault();
//        loadMembershipView("/auth/auth/_login");
//        return false;
//    });

//    $(".registerLink").click(function (event) {
//        event.preventDefault();
//        loadMembershipView("/register/register/_registerCompany");
//        return false;
//    });

//    $(".profileLink").click(function (event) {
//        event.preventDefault();
//        loadMembershipView("/admin/admin/_profile");
//        return false;
//    });

//    $(".aboutLink").click(function (event) {
//        event.preventDefault();
//        loadMembershipView("/home/_about");
//        return false;
//    });

//    $(".contactLink").click(function (event) {
//        event.preventDefault();
//        loadMembershipView("/home/_contact");
//        return false;
//    });

//}

//// --jQuery exists() metoda
//jQuery.fn.exists = function() {
//    return jQuery(this).length > 0;
//};

//function loadMembershipView(url) {
//    $.get(url, function (data) {
//        $("#swapPanel").fadeOut("50", function() {
//            $("#swapPanel").html(data);
//            prepareLoadedForm();
//            $("#swapPanel").fadeIn("400");
//            bindMembershipLinks();
//        });
//    });
//}

//function prepareLoadedForm() {
//    // --Nadi formu u "#swapPanel" sekciji
//    var $form = $("#swapPanel").find("form");
//    // --Ako neka forma vec postoji...
//    if ($form.exists()) {
//        // --Unbind-aj tu postojecu formu
//        $form.unbind();
//        $form.data("validator", null);
//        
//        // --Provjerava dokument ako ima promjena
//        //$.validator.unobtrusive.parse(document);
//        
//        // --bind-aj iz eventa
//        //bindFormEvent($form);
//    }
//}

// --Validacija pri Login-u ili Register-ciji 
//function bindFormEvent($form) {
//    $form.submit(function (e) {
//        e.preventDefault();

//        if ($(this).valid()) {
//            var url = $(this).attr('action');
//            $.post(url, $(this).serializeObject(),
//                function (data) {
//                    if (data.Success == true) {
//                        alert('USPJEŠNO: Sve pet!');
//                    }
//                    else {
//                        alert('GREŠKA: ' + data.ErrorMessage);
//                    }
//                });
//            }
//        });
//}