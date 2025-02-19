using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    /// <summary>
    /// Represents a prize awarded in the tournament.
    /// </summary>
    public class PrizeModel
    {
        /// <summary>
        /// The numeric place associated with this prize.
        /// </summary>
        public int PlaceNumber { get; set; }
        /// <summary>
        /// The name of the place (e.g., "First Place", "Runner-up").
        /// </summary>
        public string PlaceName { get; set; }
        /// <summary>
        /// The fixed monetary amount awarded for this place.
        /// </summary>
        public decimal PrizeAmount { get; set; }
        /// <summary>
        /// The percentage of the total prize pool awarded for this place.
        /// Used if a percentage-based prize is given instead of a fixed amount.
        /// </summary>
        public double PrizePercentage { get; set; }
    }
}
