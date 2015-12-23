$(document).ready(function() {
  $("h1").click(function() {
//      $(this).add("p").css("background-color", "red");
//      $("p").not("p.second").css("background-color", "red");
//      $("div").next().css("background-color", "red");
//      $("h1").next("div").css("background-color", "red");
//      $(this).next().css("background-color", "red");
//      $("p").prev().css("background-color", "red");
//      $(this).parent().css("background-color", "red");
//      $("div").find("p").css("background-color", "red");
//      $("p").first().css("background-color", "red");
//      $("p").last().css("background-color", "red");
      $("p").eq(1).css("background-color", "red");
  });
});