/*/*$(document).ready(function () {*/
//     Hacer la solicitud AJAX al controlador para obtener los datos de empresas
//    $.ajax({
//        url: '@Url.Action("ListarEmpresas", "Empresa")', // URL del método ListarEmpresas en el controlador
//        type: 'GET',
//        dataType: 'json',
//        success: function (data) {
//            console.log(data)
//             Llenar la tabla con los datos obtenidos
//            $('#tablaEmpresas').DataTable({
//                data: data.data, // Aquí asumimos que la respuesta JSON tiene una propiedad 'data' que contiene los datos de empresas
//                columns: [
//                    { data: 'idempresa' },
//                    { data: 'descripcion' }
//                ],
//                "language": { // Configuración de idioma para DataTables (opcional)
//                    "url": "//cdn.datatables.net/plug-ins/1.11.5/i18n/Spanish.json" // URL del archivo de idioma español
//                }
//            });
//        },
//        error: function (xhr, status, error) {
//            alert('Error al obtener datos de empresas.' + error);
//        }
//    });
/*});*/

    tabladata = $("#tablaEmpresas").DataTable({
    responsive: true,
    ordering: false,
    "ajax": {
        url: '@Url.Action("ListarEmpresas", "Empresa")',
        type: "GET",
        dataType: "json",
    },
    "columns": [
        { data: 'idempresa' },
        { data: 'descripcion' }
    ],

});