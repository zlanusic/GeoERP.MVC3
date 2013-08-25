$(function signOut() {
    $("#login-button").load("@Url.Action("LogOff", "Auth")");
    
});