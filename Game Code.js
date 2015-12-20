$(document).ready(function() {
    var imageName = ["floatingball.gif", "redball.gif", "eightball.gif"];
    var indexNum = 0;
//    var lineNum = 0;
//    var aNumber = 5;
//    lineNum = aNumber - 4;
    
    
      
//    $("#picture").click(function() {
//        $("#picture").attr("src", imageName[indexNum]);
//        indexNum++;
//        if (indexNum > 2) {indexNum = 0;}
        
        $("#picture").click(function() {

            $("#picture").fadeOut(1000, function() {
                $("#picture").attr("src", imageName[indexNum]);
                indexNum++;	
                if (indexNum > 2) {indexNum = 0;}
                $("#picture").fadeIn(1000);                
            });
            $("#btn1").click(function() {
               $("#picture").animate({height: "200px"});                
            });
            $("#btn2").click(function() {
               $("#picture").animate({height: "50px"});                
            });
             $("#btn3").click(function() {
               $("#picture").animate({height: "400px"});                
            });
            
              
//        $("p").css("background-color", "yellow");
//        $("p").eq(lineNum).css("background-color", "red");
//        lineNum++;
//        if (lineNum > 2) {lineNum = 0;}
        
    
//       var hText = "The heading text is " + $("#head1").text();
//       var text1 = "The heading text is "+;
//       var text2 = text1 + hText;

     
//    $("p").text(hText);
  });
});