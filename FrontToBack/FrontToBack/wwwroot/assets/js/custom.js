

$(document).ready(function () {

    $(".package").eq(0).addClass("active-package");
    

    //let package = $(".active-package")

    $(document).on("click", ".package", function () {

        $(".package").removeClass("active-package");
        $(".package ul").addClass("text-dark");
        $(".package i").addClass("text-secondary");


        $(this).addClass("active-package");
        $(this).first().children().css("color", "white");
        $(this).first().find("ul").removeClass("text-dark")
        $(this).first().find("i").removeClass("text-secondary")



      

    })

});