using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TGG_Model;

namespace TGG_DAL
{
    public class EmployeeDAO : BaseDAO
    {
        public EmployeeDAO() : base(TGGCollections.Employees) { }
    }
}
