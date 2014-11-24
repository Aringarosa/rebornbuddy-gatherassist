//-----------------------------------------------------------------------
// <copyright file="GatherRequest.cs" company="Zane McFate">
//      This code file, and this entire plugin, is uncopyrighted.  This means
//       I've put them in the public domain, and released my copyright on all
//       these works.  There is no need to email me for permission -- use my
//       content however you want!  Email it, share it, reprint it with or
//       without credit.  Change it around, break it, and attribute it to me.
//       It's okay.  Attribution is appreciated, but not required.
// </copyright>
// <author>Zane McFate</author>
//-----------------------------------------------------------------------
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
