using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Banco
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServicioUbigeo" in both code and config file together.
    public class ServicioUbigeo : IServicioUbigeo
    {
        public List<string> Ubigeo_Departamentos()
        {
            throw new NotImplementedException();
        }

        public List<string> Ubigeo_DistritosProvinciaDepartamento(string strIdDep, string strIdProv)
        {
            throw new NotImplementedException();
        }

        public List<string> Ubigeo_ProvinciasDepartamento(string strIdDep)
        {
            throw new NotImplementedException();
        }
    }
}
