$(document).ready(function()  {

/*  $("h1").mousedown(function() {
        $(this).css("background-color","red");
  });*/
    
    $("h1").mouseenter(function() {
        $(this).css("background-color","red");
    });    

/*  $("h1").mouseup(function() {
        $(this).css("background-color","yellow"); 
    });*/
    
    $("h1").mouseleave(function() {
        $(this).css("background-color","yellow");    
        $("*").undbind("mouseleave");
 
  });
});