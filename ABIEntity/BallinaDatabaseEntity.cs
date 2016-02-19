using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using ABIEntity;

namespace ABIEntity
{
    public class BallinaDatabaseEntity : IBallinaDatabaseEntity
    {

        private BallinaDBEntities objDB = new BallinaDBEntities();

        public string UpdateBatchDataByEquipmentID(string EquipmentID)
        {


            //objDB.spGetOPCTags();

            var simpleQuery =
                from num in objDB.OPC_Tags
                select num;

            foreach (var item in simpleQuery)
            {
                //Debug.Print(item.RID.ToString());
            }

            var Results = objDB.spGetOPCTags1().ToList();


            foreach(var items in Results)
            {
                Debug.Print(items.RID.ToString());
            }
 

            return "";
        }

    }
}
