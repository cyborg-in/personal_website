$(function() {

    $("#button").on("click", function(){
        var request = $.ajax({
            url: "/home/content"
        });
        
        request.done(function(data){
            console.log("success");

            var insertHere = document.getElementById("insertHere");
            console.log(insertHere);

            insertHere.innerHTML = data;

        });

        request.fail(function(){
            console.log("fail")
        });

    });
    
});