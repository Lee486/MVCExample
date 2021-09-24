
"use strict";

jQuery(document).ready(function ($) {
    if (undefined != typeof($('#barchart')) && $('#barchart').length) {
        loadSupplierJson();
        $('.tablinks').on('click', function (evt) {
            showChart($(this).attr('data-content'));
            $(this).removeClass('active').addClass('active');
        });
    }
    showRegressionalData();
});
function loadSupplierJson() {
    $.ajax({
        url: "/Ajax/SupplierData",
        type: 'GET',
        async: false,
        dataType: "json",
        success: function (data) {
            console.log(data);
            $.each(data, function (i, elem) {
                console.log(elem.name);
            });
            generateChart("barchart", "bar", data);
            generateChart("linechart", "line", data);
            generateChart("boxplot", "boxplot", data);
        }
    });
}

function showChart(chartName) {
    $('.tabcontent').removeClass('hidden').addClass('hidden'); // hide all tabcontent elements
    $('.tablinks').removeClass('active'); // make all tablinks elements inactive
    $('#' + chartName).removeClass('hidden'); // show the chart
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
        yAxis: {
            title: {
                text: "Production"
            }
        },
        series: data
    });
};


// print out the regressional stuff
function showRegressionalData(data) {
    console.log("Regressional Data: ")
}