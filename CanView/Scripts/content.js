$(document).ready(function () {
    $('.nav-collapse').click('li', function () {
        $('.nav-collapse').collapse('hide');
    });

    var checkScrollBars = function () {
        var b = $('body');
        var normalw = 0;
        var scrollw = 0;
        if (b.prop('scrollHeight') > b.height()) {
            normalw = window.innerWidth;
            scrollw = normalw - b.width();
            $('.container-fluid').css({ marginRight: '-' + scrollw + 'px' });
        }
    }


    //// run test on initial page load
    //checkSize();
    //// run test on resize of the window
    //$(window).resize(checkSize);

    ////Function to the css rule
    //function checkSize() {
    //    if ($(".float-right").css("float") == "right") {
    //        // your code here
    //    }
    //}

    //Initializing Flickity Carousel
    $('.main-gallery').flickity({
        // options
        cellAlign: 'left',
        contain: true,
        autoPlay: 4000,
        wrapAround: true,
        pageDots: false,
        pauseAutoPlayOnHover: false
    });

    //Instantiating animatedModal
    $("#demo01").animatedModal({
        animatedIn: 'zoomIn',
        animatedOut: 'zoomOut',
        width: '100%',
        height: '100%',
        top: '70px',
        left: '0px',
        color: '#123679',
        opacityIn: '1',
        opacityOut: '0',
        overflow: 'visible',
        zIndexIn: '9999',
        zIndexOut: '-9999',
        overflow: 'scroll'
    });

    //Change snackbox content on click
    jQuery(function () {
        jQuery('.snackbox').click(function () {
            jQuery('.this').hide();
            jQuery('#div' + $(this).attr('target')).show();
        });
    });

    //set active tab in navigation
    $(function () {
        $('a').each(function () {
            if ($(this).prop('href') == window.location.href) {
                $(this).addClass('current');
            }
        });
    });
});