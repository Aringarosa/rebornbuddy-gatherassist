namespace GatherAssist
{
    /// <summary>
    /// A request to gather a certain number of items.  Also used to hold the current available number of the requested item (updated when
    ///  the timer iterates).
    /// </summary>
    public class GatherRequest
    {
        /// <summary>
        /// The name of the item to be gathered.
        /// </summary>
        public string ItemName { get; set; }

        /// <summary>
        /// The current intentory count for this item.
        /// </summary>
        public uint CurrentCount { get; set; }

        /// <summary>
        /// The requested count for this item.
        /// </summary>
        public int RequestedTotal { get; set; }

        /// <summary>
        /// The constructor for GatherRequest.  Creates a new gather request with the supplied values, and a current count of zero, to be
        ///  refreshed when the timer iterates.
        /// </summary>
        /// <param name="itemName">The name of the item to be gahtered.</param>
        /// <param name="requestedTotal">The requested count for this item.</param>
        public GatherRequest(string itemName, int requestedTotal)
        {
            ItemName = itemName;
            RequestedTotal = requestedTotal;
            CurrentCount = 0;
        }

        /// <summary>
        /// Keeps the default constructor from being executed.
        /// </summary>
        private GatherRequest()
        {
        }
    }
}
