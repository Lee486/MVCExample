
"use strict";

jQuery(document).ready(function ($) {
    loadFooJson();
    loadTimeSeries();

});
function loadTimeSeries() {
    $.ajax({
        url: "/Ajax/GetFooData",
        type: 'GET',
        async: false,
        dataType: "json",
        success: function (data) {
            console.log(data);
            $.each(data, function (i, elem) {
                console.log(i);
                console.log(elem);
            });

        }
    });
}

function loadFooJson() {
    if (undefined != $('#meal')) { //should only run if this div exists
    $.ajax({
            url: "/Ajax/GetSomeFood",
            type: 'GET',
            async: false,
            dataType: "json",
        success: function (data) {
            var foo = "";
                console.log(data);
                $.each(data, function (i, elem) {
                    console.log(i);
                    console.log(elem);
                    foo += "<div> " + elem + "</div>";
                });
                $('#meal').html(
                    foo 
                );

            }
        });
    }
}
