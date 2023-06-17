using System.ComponentModel.DataAnnotations;

namespace Cyclix.Entities
{
    public class RepairRequest
    {
        [Key]
        public int id{ get; set; }
        public string cycleType { get; set; }
        public string brandName { get; set; }


        public string servicePricingOption { get; set; }
        public bool skipServicePackage { get; set; }
        public bool isElectricCycle { get; set; }


        public bool tubeOrTire { get; set; }
        public bool wheelCentering { get; set; }
        public bool adjustingGears { get; set; }
        public bool adjectBreaks { get; set; }
        public bool changeBreakPads { get; set; }
        public bool suspension { get; set; }
        public bool completeCleaning { get; set; }
        public bool lightCheck { get; set; }
        public bool functionCheck { get; set; }
        public bool batteryCheck { get; set; }


        public string moreDetailedIssue { get; set; }
        public double estimatedCost { get; set; }


        public string firstName { get; set; }
        public string lastName { get; set; }
        public string street { get; set; }
        public string nr { get; set; }
        public string city { get; set; }
        public string zipCode { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
    }
}
