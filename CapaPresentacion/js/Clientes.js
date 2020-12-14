
var tabla, data;


    function addRowDT(data) {
        tabla = $("#tbl_clientes").DataTable();

        for (var i = 0; i < data.length; i++) {
            tabla.fnAddData([
                
                data[i].Clie_codigo,
                (data[i].Clie_nombre + " " + data[i].Clie_apellidos),
                data[i].Clie_direccion,
                data[i].Clie_celular,
                data[i].Clie_correo,
                data[i].Clie_clave,
                data[i].Clie_tp_documento,
                data[i].Clie_nro_documento,
                ((data[i].Clie_estado==0)?"activo":"inactivo"),
               '<button type="button" value="Actualizar" title="Actualizar" class="btn btn-primary btn-edit" data-target="#imodal" data-toggle="modal"><i class="fa fa-check-square-o" aria-hidden="true"></i></button>&nbsp;' +
                '<button type="button" value="Eliminar" title="Eliminar" class="btn btn-danger btn-delete"><i class="fa fa-minus-square-o" aria-hidden="true"></i></button>'

            ]);
        }

    }


    function sendDataAjax() {
        $.ajax({
            type: "POST",
            url: "FrmClientes.aspx/ListarCliente",
            data: {},
            contentType: 'application/json; charset=utf-8',
            error: function (xhr, ajaxOptions, thrownError) {
                console.log(xhr.status + " \n" + xhr.responseText, "\n" + thrownError);
            },
            success: function (data) {
                console.log(data)
              addRowDT(data);
            }
        });
    }


    // Llamando a la funcion de ajax al cargar el documento
    sendDataAjax();