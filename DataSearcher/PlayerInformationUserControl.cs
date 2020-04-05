using System.ComponentModel;
using System.Windows.Forms;

namespace DataSearcher
{
    public partial class PlayerInformationUserControl : UserControl
    {
        // Receives a Player objec as parameter on init and sets the values of the textboxes
        // according to the its parameters.
        #region Proparties
        private Player _player;

        [Category("Custom Props")]
        public Player PanelPlayer
        {
            get { return _player; }
            set
            {
                _player = value;

                if (_player == null)
                {
                    MessageBox.Show("There is a problem with the player's data. It is possible that the query data is wrong. Please try another one.");
                }
                else
                {
                    nameLabel.AutoSize = true;
                    nameLabel.Text = "Name: " + _player.Name;
                    dateOfBirthLabel.AutoSize = true;
                    dateOfBirthLabel.Text = "Date of birth: " + _player.DateOfBirth;
                    citizenshipLabel.AutoSize = true;
                    citizenshipLabel.Text = "Citizenship: " + _player.Citizenship;
                    teamLabel.AutoSize = true;
                    teamLabel.Text = "Team: " + _player.Team;
                    positionLabel.AutoSize = true;
                    positionLabel.Text = "Position: " + _player.Position;
                    competitionClassLabel.AutoSize = true;
                    competitionClassLabel.Text = "Competition class: " + _player.CompetitionClass;
                    countryForSportLabel.AutoSize = true;
                    countryForSportLabel.Text = "Country for sport: " + _player.CountryForSport;
                    idLabel.AutoSize = true;
                    idLabel.Text = "Player ID: " + _player.Id;
                }
            }
        }

        #endregion
        public PlayerInformationUserControl()
        {
            InitializeComponent();
        }
    }
}
