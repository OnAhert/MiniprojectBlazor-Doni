$(document).ready(function() {
    $('#loginButton').click(function(e) {
        e.preventDefault();

        var username = $('#user').val();
        var password = $('#pass').val();

        if (username === "" || password === "") {
            alert("Please enter both username and password");
        } else {
            if (username === "admin" && password === "admin123") {
                alert("Login successful!");
                window.location.href = "dashboard.html";
            } else {
                alert("Invalid username or password");
            }
        }
    });
});
