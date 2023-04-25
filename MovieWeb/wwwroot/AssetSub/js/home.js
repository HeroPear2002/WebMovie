$(document).ready(function () {
    var movieJS = new MovieJS();
})
class MovieJS {
    constructor() {
        this.initEvents();
    }
    initEvents() {
        $(".txtSearch").on("input", this.textChanged);
        $(".txtSearch").on("remove", this.textChanged);
    }
    textChanged() {
        var data = $(".txtSearch").val();
        if (data == "") {

            $(".dialog").hide();
            return;
        } else {
            $(".dialog").show();
            $.ajax({
                url: "/api/phim/search?data=" + data,
                method: "GET",
                contentType: "application/json",
                //dataType: "plain/text",
            }).done(function (response) {
                $('.dialog').empty();
                $.each(response, function (index, item) {
                    var trHTML = $(
                        `<li class="rowSearch">
                        <img class="imgSearch" src="../UploadAnh/Anh/`+ item.anh + `"/>
                        <label class="lblSearch">`+ item.tenPhim + `</label>
                    </li>`);
                    $('.dialog').append(trHTML);
                })
            }).fail(function (response) {

            })
        }

    }
}