$(document).ready(function () {
    $(".submenu1").hide();
    var movie = new Movie();
})
class Movie {
    constructor() {
        this.initEvents();
    }
    initEvents() {
        $(".text-search").on("input", this.textChanged);
        $(".text-search").on("remove", this.textChanged);
    }
    textChanged() {
        var data = $(".text-search").val();
        if (data == "") {

            $(".submenu1").hide();
            return;
        } 
        var str=''
        $(".submenu1").show();
        $.ajax({
            type: 'GET',
            url: 'https://localhost:7103/api/SearchFilm?name='+data,
            dataType: 'json',
            success: function (data) {
                $('.dialog').empty();
                $.each(data, function (key, val) {
                    str += `<li class="item-search">
                    <img src="${val.anh}" alt="">
                    <a href="https://localhost:7103/Film/InfoFilm?filmCode=${val.maPhim}">${val.tenPhim}</a>
                    </li>`
                })
                $('.submenu1').html(str)
            }
        })
            $.ajax({
                url: "/api/phim/search?data=" + data,
                method: "GET",
                contentType: "application/json",
                //dataType: "plain/text",
            }).done(function (response) {
               
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