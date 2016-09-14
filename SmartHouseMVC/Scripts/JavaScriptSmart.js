$(function () {
    $(".BAirTU").click(function () {
        var idClick;
        idClick = $(this).attr("id"); //this.id
        var id = idClick.substr(idClick.length - 1);
        $.ajax({
            url: "/api/Values/" + id,
            type: "PUT",
            data: { "": $("#Air").val() },
            success: function (data) {
                var result = "#AirT_" + id;
                $(result).html(data);
            }
        });
    });
    $(".BAirTD").click(function () {
        var idClick;
        idClick = $(this).attr("id"); //this.id
        var id = idClick.substr(idClick.length - 1);
        $.ajax({
            url: "api/values/item/" + id,
            type: "PUT",
            data: { "": $("#Air").val() },
            success: function (data) {
                var result = "#AirT_" + id;
                $(result).html(data);
            }
        });
    });
    $(".BAirSWU").click(function () {
        var idClick;
        idClick = $(this).attr("id"); //this.id
        var id = idClick.substr(idClick.length - 1);
        $.ajax({
            url: "api/values/SWU/" + id,
            type: "PUT",
            data: { "": $("#Air").val() },
            success: function (data) {
                var result = "#AirSW_" + id;
                $(result).html(data);
            }
        });
    });
    $(".BAirSWD").click(function () {
        var idClick;
        idClick = $(this).attr("id"); //this.id
        var id = idClick.substr(idClick.length - 1);
        $.ajax({
            url: "api/values/SWD/" + id,
            type: "PUT",
            data: { "": $("#Air").val() },
            success: function (data) {
                var result = "#AirSW_" + id;
                $(result).html(data);
            }
        });
    });
    $(".BAirDWU").click(function () {
        var idClick;
        idClick = $(this).attr("id"); //this.id
        var id = idClick.substr(idClick.length - 1);
        $.ajax({
            url: "api/values/DWU/" + id,
            type: "PUT",
            data: { "": $("#Air").val() },
            success: function (data) {
                var result = "#AirDW_" + id;
                $(result).html(data);
            }
        });
    });
    $(".BAirDWD").click(function () {
        var idClick;
        idClick = $(this).attr("id"); //this.id
        var id = idClick.substr(idClick.length - 1);
        $.ajax({
            url: "api/values/DWD/" + id,
            type: "PUT",
            data: { "": $("#Air").val() },
            success: function (data) {
                var result = "#AirDW_" + id;
                $(result).html(data);
            }
        });
    });
    $(".BAirD").click(function () {
        var idClick;
        idClick = $(this).attr("id"); //this.id
        var id = idClick.substr(idClick.length - 1);
        $.ajax({
            url: "/api/values/" + id,
            type: "DELETE",
            success: function (data) {
                var result = "#figure_" + id;
                $(result).html(data);
            }
        });
    });
});
