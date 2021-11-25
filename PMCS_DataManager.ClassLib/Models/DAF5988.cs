using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMCS_DataManager.ClassLib.Models
{
    public class DAF5988
    {
        public int Id { get; set; }
        public int TM_Id { get; set; }
        public int Vehicle_Id { get; set; }
        public VehicleInfo VehicleInfo { get; set; }
        public List<ItemFaultModel> ItemFaultList { get; set; }
    }
}
