$(function () {
    loadMembershipView("/auth/auth/_login");
    bindMembershipLinks();

});

function bindMembershipLinks() {
    $("#loginLink").click(function (event) {
        event.preventDefault();
        loadMembershipView("/auth/auth/_login");
        return false;
    });

    $("#registerLink").click(function (event) {
        event.preventDefault();
        loadMembershipView("/register/register/_registerCompany");
        return false;
    });
}

function loadMembershipView(url) {
    $.get(url, function (data) {
        $("#swapPanel").html(data);
        prepareLoadedForm();
        bindMembershipLinks();
    });
}

function prepareLoadedForm() {
    var $form = $("#swapPanel").find("form");
    if ($form.exists()) {
        // --Unbind postojecu validaciju
        $form.unbind();
        $form.data("validator", null);
        // --Provjera dokumenta za promjene
        $.validator.unobtrusive.parse(document);
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
                                alert('SUCCESS: Everything went ok');
                            }
                            else {
                                alert('ERROR: ' + data.ErrorMessage);
                            }
                        });

        }
    });
}

    

            