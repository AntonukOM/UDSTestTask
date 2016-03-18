(function () {

    var onFilterClick = function (e) {
        $.ajax({
            type: "get",
            url: "/User/FilterByTag",
            dataType: "html",
            data: {
                filter: e.target.value
            }
        }).done(function (data) {
            console.log("ajax filter is done!" + e.target.value);
            $("#list").html(data);
            initFilterByTag();
        }).fail(function () {
            console.log("ajax filter is FAIL");
        });
    };

    var initFilterByTag = function() {
        $(".tag").on("click", onFilterClick);
        console.log('Init filter by tag is fine');
    };

    $(function () {
        initFilterByTag();
        console.log('Inits done');
    });
}) ();