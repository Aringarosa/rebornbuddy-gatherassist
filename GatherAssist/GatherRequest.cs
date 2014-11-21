namespace GatherAssist
{
    public class GatherRequest
    {
        public string ItemName { get; set; }
        public uint CurrentCount { get; set; }
        public int RequestedTotal { get; set; }

        public GatherRequest(string itemName, int requestedTotal)
        {
            ItemName = itemName;
            RequestedTotal = requestedTotal;
            CurrentCount = 0;
        }

        private GatherRequest()
        {
        }
    }
}
