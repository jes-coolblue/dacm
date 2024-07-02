namespace ContentDistributionApp.Models
{
    public class OrderList
    {
        public required string OrderNumber { get; set; }
        public required string RequesterName { get; set; }
        public required DateTime OrderDate { get; set; }
        public required string CampaignName { get; set; }
        public required int TotalBriefs { get; set; }
        public required List<Brief> Briefs { get; set; }

       
    }
}
