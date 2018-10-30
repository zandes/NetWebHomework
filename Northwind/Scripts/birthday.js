$(function () {
    // make balloon draggable
    $(".ball").draggable({ appendTo: "body" });

    // attach datepicker to textbox
    $('#birthday').datepicker({ dateFormat: "mm-dd" });

    // call attention to Happy Birthday! message
    var animations = new Array("bounce", "flash", "pulse", "rubberBand", "shake", "swing", "tada", "wobble");
    var idx = Math.floor((Math.random() * animations.length));
    $('h1').addClass('animated ' + animations[idx]);
    //$('h1').addClass('animated flash');

    // hide/show balloons based on checkboxes
    $('.bx').each(function () {
        $(this).is(':checked')
            ? $('#' + $(this).attr('id') + 'Img').css('visibility', 'visible')
            : $('#' + $(this).attr('id') + 'Img').css('visibility', 'hidden');
    });

    // attach event listener to checkboxes
    $('.bx').change(function () {
        // make the image visible
        $('#' + $(this).attr('id') + 'Img').css('visibility', 'visible');
        // animate balloon In/Out based on checkbox
        $(this).is(':checked') ?
            $('#' + $(this).attr('id') + 'Img').removeClass().addClass('animated bounceInDown') :
            $('#' + $(this).attr('id') + 'Img').addClass('animated bounceOutUp');
    });

    $("#checkAll").click(function() {
        $('.bx').each(function() {
            this.checked = true;
            $('#' + $(this).attr('id') + 'Img').css('visibility', 'visible');
            $('#' + $(this).attr('id') + 'Img').removeClass().addClass('animated bounceInDown');
        });
    });

    $('#uncheckAll').click(function() {
        $('.bx').each(function() {
            this.checked = false;
            $('#' + $(this).attr('id') + 'Img').addClass('animated bounceOutUp');
        });
    });

    $('.ball').click(function() {
        var imgID = '#' + $(this).attr('id').substring(0, $(this).attr('id').length - 3);
        $(imgID).prop("checked", false);
        $(this).addClass('animated bounceOutUp');
    });
});