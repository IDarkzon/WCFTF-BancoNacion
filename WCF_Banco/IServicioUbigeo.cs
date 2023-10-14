using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Banco
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServicioUbigeo" in both code and config file together.
    [ServiceContract]
    public interface IServicioUbigeo
    {
        [OperationContract]
        List<String> Ubigeo_Departamentos();
        [OperationContract]
        List<String> Ubigeo_ProvinciasDepartamento(String strIdDep);
        [OperationContract]
        List<String> Ubigeo_DistritosProvinciaDepartamento(String strIdDep, String strIdProv);
    }
}
