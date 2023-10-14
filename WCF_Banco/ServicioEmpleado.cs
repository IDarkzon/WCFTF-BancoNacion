using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Banco
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServicioEmpleado" in both code and config file together.
    public class ServicioEmpleado : IServicioEmpleado
    {
        public bool ActualizarEmpleado(EmpleadoDC objEmpleado)
        {
            throw new NotImplementedException();
        }

        public EmpleadoDC ConsultarEmpleado(string strCodigo)
        {
            throw new NotImplementedException();
        }

        public bool EliminarEmpleado(string strCodigo)
        {
            throw new NotImplementedException();
        }

        public bool InsertarEmpleado(EmpleadoDC objEmpleado)
        {
            throw new NotImplementedException();
        }

        public List<EmpleadoDC> ListarEmpleado()
        {
            throw new NotImplementedException();
        }
    }
}
