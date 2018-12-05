
$(function () {
    //We select the element and on hover we execute another function !
    $("[data-admin-menu]").hover(() => {
        //when we hover this function is executed and it toggles the class "open" !
        $('[data-admin-menu]').toggleClass("open");

        let spanClassName = $('[data-admin-menu]').children()[0].children[0].className;

        let newClass = "";

        if (spanClassName === "glyphicon glyphicon-arrow-down") {
            newClass = "glyphicon glyphicon-arrow-up";
        }
        else if (spanClassName === "glyphicon glyphicon-arrow-up") {
            newClass = "glyphicon glyphicon-arrow-down";
        }

        $('[data-admin-menu]').children()[0].children[0].className = newClass;
    });
});


