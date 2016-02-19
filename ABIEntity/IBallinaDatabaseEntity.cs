using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABIEntity
{
    public interface IBallinaDatabaseEntity
    {
        //https://msdn.microsoft.com/nl-nl/library/87d83y5b.aspx

        string UpdateBatchDataByEquipmentID(string EquipmentID);
    }

     
}
