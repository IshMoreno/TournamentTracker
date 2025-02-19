using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    /// <summary>
    /// Represents a tournament, including teams, entry fees, prizes, and matchups.
    /// </summary>
    public class TournamentModel
    {
        /// <summary>
        /// The name of the tournament.
        /// </summary>
        public string TournamentName { get; set; }
        /// <summary>
        /// The amount required for each team to enter the tournament.
        /// </summary>
        public decimal EntryFee { get; set; }
        /// <summary>
        /// The list of teams that have entered the tournament.
        /// </summary>
        public List<TeamModel> EnteredTeam { get; set; } = new List<TeamModel>();
        /// <summary>
        /// The prizes awarded to the winning teams.
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();
        /// <summary>
        /// The rounds of matchups for the tournament, organized as a list of lists.
        /// Each inner list represents a round, containing matchups for that round.
        /// </summary>
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();
    }
}