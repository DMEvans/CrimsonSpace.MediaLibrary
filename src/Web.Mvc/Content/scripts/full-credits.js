$(function () {
    $(".cast-tab").on("click", function () {
        $("#cast").show();
        $("#crew").hide();
    });

    $(".crew-tab").on("click", function () {
        $("#cast").hide();

        var linkDataGroup = $(this).attr("data-group");

        $(".crew-group").each(function () {
            var $panel = $(this);

            var panelDataGroup = $panel.attr("data-group");

            if (linkDataGroup === "All" || panelDataGroup === linkDataGroup) {
                $panel.show();
            }
            else {
                $panel.hide();
            }
        });

        $("#crew").show();
    });
});