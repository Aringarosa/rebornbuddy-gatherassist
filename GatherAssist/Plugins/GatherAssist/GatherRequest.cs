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
        /// Initializes a new instance of the <see cref="GatherRequest" /> class.  Creates a new gather request with the supplied values,
        ///  and a current count of zero, to be refreshed when the timer iterates.
        /// </summary>
        /// <param name="itemName">The name of the item to be gathered.</param>
        /// <param name="requestedTotal">The requested count for this item.</param>
        public GatherRequest(string itemName, int requestedTotal)
        {
            this.ItemName = itemName;
            this.RequestedTotal = requestedTotal;
            this.CurrentCount = 0;
        }

        /// <summary>
        /// Prevents a default instance of the <see cref="GatherRequest" /> class from being created.
        /// </summary>
        private GatherRequest()
        {
        }

        /// <summary>
        /// Gets or sets the name of the item to be gathered.
        /// </summary>
        public string ItemName { get; set; }

        /// <summary>
        /// Gets or sets the current inventory count for this item.
        /// </summary>
        public uint CurrentCount { get; set; }

        /// <summary>
        /// Gets or sets the requested count for this item.
        /// </summary>
        public int RequestedTotal { get; set; }
    }
}
