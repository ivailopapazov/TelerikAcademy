function onButtonClick(event, args) {
    var myWindow = window;
    var myBrowser = myWindow.navigator.appCodeName;
    if (myBrowser == "Mozilla") {
        alert("Yes");
    }
    else {
        alert("No");
    }
}