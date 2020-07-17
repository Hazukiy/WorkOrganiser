window.onload = setupElements;

var ip = $("#txtIpAddress");
var port = $("#txtPort");
var username = $("#txtUserName");
var password = $("#txtPassword");

function setupElements() {
    //Dynamically add a button
    var element = document.createElement("input");
    element.type = 'button';
    element.value = "Import Connection Details";
    element.width = "10px";
    element.height = "10px";
    element.name = "btnImportConnectionDetails";
    element.classList.add("btn-blue-small");
    element.classList.add("inline");
    element.setAttribute("onClick", "importButtonClick()");

    //Dynamically add button to page
    document.getElementById("divServerConnectionDetails").appendChild(element);
}

function importButtonClick() {
    //Read in clipboard value
    navigator.clipboard.readText()
        .then(text => {
            var data = JSON.parse(text.trim());
            console.log(`Content: ${data}`);

            if (data != null && data != "" && data != "undefined") {
                //Set values
                ip.val(data.Host);
                port.val(data.Port);
                username.val(data.Username);
                password.val(data.Password);
            }
        })
        .catch(err => {
            console.error('Failed to read clipboard contents: ', err);
        });
}