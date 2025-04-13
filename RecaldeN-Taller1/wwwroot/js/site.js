// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

//Esta funcion calcula los puntos cada vez que se cambia el valor de los partidos ganados o empatados
function calcularPuntos() {
    var ganados = parseInt(document.getElementById("PartidosGanados").value);
    var empatados = parseInt(document.getElementById("PartidosEmpatados").value);

    var puntos = (ganados * 3) + (empatados * 1);
    document.getElementById("total").textContent = "Total de puntos: " + puntos;
}
//Utilice JQuery porque es mas facil hacer que se actualize el valor de los partidos ganados y empatados al cambiar el valor de los inputs
$("#PartidosGanados, #PartidosEmpatados").on("input", calcularPuntos);
calcularPuntos(); 

//Esta funcion la hice porque como no se pidio que se pueda borrar el equipo, no lo hice, pero le di una funcionalidad al boton de borrar
function Borrar()
{
    var equipo = document.getElementById("nombre").textContent;
    alert("Por motivos de seguridad aún no se pueden borrar el equipo " + equipo + ", agradecemos su comprensión");
}

