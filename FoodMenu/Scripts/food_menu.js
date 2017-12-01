
$(document).ready(function () {
    fillGrid();
});
function fillGrid() {

    $("#listMenus").empty();

    $.ajax({
        url: '@Url.Action("GetMenusByRestaurant", "Menu")',
        data: {
            IDRestaurant: '@Model.IdRestaurant'

        },
        error: function () {

        },
        dataType: 'json',
        success: function (list) {
            var array = [];
            array.push(list);
            var lista = array[0];

            for (var i = 0; i < lista.length; i++) {

                var url = '@Url.Action("Menu", "Menu")' + "?id=" + lista[i].IdMenu;
                var menuline = "<a href='" + url + "' id='" + lista[i].IdMenu + "' data-id='" + lista[i].IdMenu + "' class='list-group-item'>" + lista[i].NamMenu + "</a>";
                $("#listMenus").append(menuline);
            }

        },
        type: 'POST'
    });
}
function salvarMenu(event) {
    event.preventDefault();

    var LNamMenu = $("#NamMenu").val();
    var LDesMenu = $("#DesMenu").val();

    $.ajax({
        url: '@Url.Action("CreateMenu", "Menu")',
        data: {

            NamMenu: LNamMenu,
            DesMenu: LDesMenu,
            IDRestaurant: '@Model.IdRestaurant'

        },
        error: function () {

        },
        dataType: 'json',
        success: function () {

        },
        type: 'POST'
    });

    fillGrid();

}