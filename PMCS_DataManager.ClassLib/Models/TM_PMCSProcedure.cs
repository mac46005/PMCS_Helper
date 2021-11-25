using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMCS_DataManager.ClassLib.Models
{
    public class TM_PMCSProcedure
    {
        public int Id { get; set; }
        public string TM_Id { get; set; }
        public List<ItemModel> Items { get; set; }
    }
}
