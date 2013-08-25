
// --Forme za registraciju i prijavu
$(function () {
    loadMembershipView("/auth/auth/_login");
    //bindMembershipLinks();

});

function bindMembershipLinks() {
    // --Linkovi
    $(".loginLink").click(function (event) {
        event.preventDefault();
        loadMembershipView("/auth/auth/_login");
        return false;
    });

    $(".registerLink").click(function (event) {
        event.preventDefault();
        loadMembershipView("/register/register/_registerCompany");
        return false;
    });

    $("#profilLink").click(function (event) {
        event.preventDefault();
        loadMembershipView("/admin/admin/_editProfil");
        return false;
    });

    $("#aboutLink").click(function (event) {
        event.preventDefault();
        loadMembershipView("/home/_about");
        return false;
    });

    $("#contactLink").click(function (event) {
        event.preventDefault();
        loadMembershipView("/home/_contact");
        return false;
    });

}

// Create a jQuery exists method
jQuery.fn.exists = function() {
    return jQuery(this).length > 0;
};

function loadMembershipView(url) {
    $.get(url, function (data) {
        $("#swapPanel").fadeOut("300", function() {
            $("#swapPanel").html(data);
            prepareLoadedForm();
            $("#swapPanel").fadeIn("400");
            bindMembershipLinks();
        });
    });
}

function prepareLoadedForm() {
    var $form = $("#swapPanel").find("form");
    if ($form.exists()) {
        // --Unbind-a postojecu validaciju
        $form.unbind();
        $form.data("validator", null);
        
        // --Provjera dokumenta ako ima promjena
        //$.validator.unobtrusive.parse(document);
        
        // --bind formu eventa
        bindFormEvent($form);
    }
}

function bindFormEvent($form) {
    $form.submit(function (e) {
        e.preventDefault();

        if ($(this).valid()) {
            var url = $(this).attr('action');
            $.post(url, $(this).serializeObject(),
                function (data) {
                    if (data.Success == true) {
                        alert('USPJEŠNO: Sve pet!');
                    }
                    else {
                        alert('GREŠKA: ' + data.ErrorMessage);
                    }
                });
            }
        });
}