using System.ComponentModel.DataAnnotations;

namespace Cyclix.DTOs
{
    public class RepairRequestDto
    {
        [Required]
        public string cycleType { get; set; }
        [Required]
        public string brandName { get; set; }


        public string servicePricingOption { get; set; }
        public bool skipServicePackage { get; set; }
        [Required]
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


        [Required]
        public string moreDetailedIssue { get; set; }
        [Required]
        public double estimatedCost { get; set; }


        [Required]
        public string firstName { get; set; }
        [Required]
        public string lastName { get; set; }
        public string street { get; set; }
        public string nr { get; set; }
        public string city { get; set; }
        public string zipCode { get; set; }
        [Required]
        public string email { get; set; }
        [Required]
        public string phone { get; set; }
    }
}
