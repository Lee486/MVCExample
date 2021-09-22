
"use strict";

jQuery(document).ready(function ($) {
	loadTimeSeries();
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

function loadCompanyProductionJson() {
    $.ajax({
        url: "/Ajax/GetCompanyProductionData",
        type: 'GET',
        async: false,
        dataType: "json",
        success: function (data) {
            console.log(data);
            $.each(data, function (i, elem) {
                console.log(elem.name);
			});
            generateChart("barchart", "bar");
            generateChart("linechart", "line");
            generateChart("boxplot", "boxplot");
        }
    });
}
function generateChart(chartId, chartType, data) {
    // generate Highcharts chart
    return Highcharts.chart(chartId, {
        chart: {
            type: chartType
        },
        title: {
            text: "Company Production"
        },
        xAxis: {
            type: 'datetime'
        },
        yAxis: {
            title: {
                text: "Production"
            }
        },
        series: [{
            name: 'Production Value: ',
            data: data;
        }]
    });
};
