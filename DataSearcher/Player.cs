using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSearcher
{
    // The Player class that holds the datam queried from the backend
    // and makes it easier to get passed to different entities inside the code.
    public class Player
    {
        private string _playerId;
        private string _playerName;
        private string _playerDateOfBirth;
        private string _playerCitizenship;
        private string _playerTeam;
        private string _playerPosition;
        private string _playerCompetitionClass;
        private string _playerCountryForSport;

        public string Id
        {
            get { return _playerId; }
            set
            {
                _playerId = value;
            }
        }
        public string Name
        {
            get { return _playerName; }
            set
            {
                _playerName = value;
            }
        }
        public string DateOfBirth
        {
            get { return _playerDateOfBirth; }
            set
            {
 
                _playerDateOfBirth = value;
            }
        }
        public string Citizenship
        {
            get { return _playerCitizenship; }
            set
            { 
                _playerCitizenship = value;
            }
        }
        public string Team
        {
            get { return _playerTeam; }
            set
            {
                _playerTeam = value;
            }
        }
        public string Position
        {
            get { return _playerPosition; }
            set
            {
                _playerPosition = value;
            }
        }
        public string CompetitionClass
        {
            get { return _playerCompetitionClass; }
            set
            {
                _playerCompetitionClass = value;
            }
        }
        public string CountryForSport
        {
            get { return _playerCountryForSport; }
            set
            {
                _playerCountryForSport = value;
            }
        }
    }
}