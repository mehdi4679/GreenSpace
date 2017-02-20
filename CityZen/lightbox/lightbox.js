$(document).ready(function () {
    var id = $(".LiBo").val();
    var id2 = $(".LiBo2").val();
    if (id != '') {
        $("#" + id + "1").fadeIn(0);
        $("#" + id + "2").css({ 'top': '100px' }, 0);
        
    }
  if (id2 != '') {
        $("#" + id2 + "1").fadeIn(0);
        $("#" + id2 + "2").css({ 'top': '100px' }, 0);
    }
    $('.boxclose').click(function () {
        $(".LiBo").val("");
        $(".LiBo2").val("");
        $(this).parent().animate({ 'top': '-1000px' }, 500, function () {
            $(this).prev("div").fadeOut('fast');
        });
    });
    $(".Lishow").click(function () {      
        var idd = $(this).attr("id");
        //alert(idd);
        $("#" + idd + "1").fadeIn('fast', function () {
            $("#" + idd + "2").animate({ 'top': '100px' }, 500);
        });
        $(".LiBo").val(idd);
    });
});