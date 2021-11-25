using System;

namespace PMCS_DataManager.ClassLib.Models
{
    public class VehicleInfo
    {
        public int Id { get; set; }
        public string AdminNumber { get; set; }
        public string Model { get; set; }
        public string EquipNoun { get; set; }
        public decimal LastReading { get; set; } = 0;
        public string SN { get; set; }
        public string EquipNum { get; set; }
        public string EquipNSN { get; set; }
        public DateTime LastModified { get; set; }

    }
}