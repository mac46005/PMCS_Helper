using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMCS_DataManager.ClassLib.Models
{
    public class ItemModel
    {
        public int ItemNumber { get; set; }
        public int TM_Id { get; set; }
        public string Interval { get; set; }
        public string Location { get; set; }
        public string Procedure { get; set; }
        public string NotMissionCapIf { get; set; }
    }
}
