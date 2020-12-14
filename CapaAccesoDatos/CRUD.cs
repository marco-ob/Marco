using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaAccesoDatos
{
    interface CRUD<T>
    {

        List<T> Listar();
        int Registrar(T t);
        int Actualizar(T t);
        int Borrar(int id);

    }
}
