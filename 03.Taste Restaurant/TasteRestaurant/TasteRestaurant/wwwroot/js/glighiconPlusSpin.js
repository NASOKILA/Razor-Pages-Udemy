
$(function () {

    $(".createCategoryBtn").hover(() => {

        let oldClassList = $(".createCategoryBtn")[0].children[0].classList;

        console.log(oldClassList);

        if (!oldClassList.contains("fast-right-spinner")) {
            
            if (!oldClassList.contains("fast-left-spinner")) {
                oldClassList = $(".createCategoryBtn")[0].children[0].classList.add("fast-right-spinner");

            }
            else {
                oldClassList = $(".createCategoryBtn")[0].children[0].classList.replace("fast-left-spinner", "fast-right-spinner");
            }

        }
        else {    

            let oldClassList = $(".createCategoryBtn")[0]
                .children[0]
                .classList
                .replace("fast-right-spinner", "fast-left-spinner");
        }

    });
})
