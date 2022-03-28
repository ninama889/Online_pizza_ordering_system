using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.Data;

namespace AdminControl
{
    [ServiceContract]
    public interface IAdminControl
    {
        //for Categories
        [OperationContract]
        DataSet SelectCategories();
        [OperationContract]
        bool AddCategory(Category ct);
        [OperationContract]
        bool UpdateCategory(Category ct);
        [OperationContract]
        bool DeleteCategory(int CategoryId);
        [OperationContract]
        DataSet SelectCategoryById(int CategoryId);
    }
}
