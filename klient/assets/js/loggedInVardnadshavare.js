$(document).ready(function(){
    var yetVisited = localStorage['vardnadshavare'];
    if (!yetVisited) {
        window.location.href = "portalVardnadshavare.html";
    }
})