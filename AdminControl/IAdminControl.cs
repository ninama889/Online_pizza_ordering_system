using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace AdminControl
{
    [ServiceContract]
    public interface IAdminControl
    {
        //for Categories
        [OperationContract]
        bool AddCategory(Category ct);
        [OperationContract]
        bool UpdateCategory(Category ct);
    }
}
