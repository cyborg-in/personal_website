$(function() {

    $("input[type=submit]").on("submit", function(event){
        event.preventDefault();

        console.log(event); 

        var request = $.ajax({
            url: "/home/content"
        });
        
        request.done(function(data){
            console.log("success");

            var insertHere = document.getElementById("insertHere");
            insertHere.innerHTML = data;
        });

        request.fail(function(){
            console.log("fail");
        });

    });
    
});