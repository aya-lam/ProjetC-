using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataSearcher
{
    public partial class DataSearcher : Form
    {
        private readonly string filterBoxDefaultValue = "--Select--";
        private SearchEngine searchEngine = new SearchEngine();
        private Point endPoint;
        public DataSearcher()
        {
            InitializeComponent();
            filterBox.SelectedItem = filterBoxDefaultValue;
        }

        // Terminates the application
        private void CloseLabel_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private async void SearchBtnClick(object sender, EventArgs e)
        {
            string queryData = searchBar.Text;
            string queryFilter = filterBox.SelectedItem.ToString();

            Task<PlayerInformationUserControl> querySearch = new Task<PlayerInformationUserControl>(() => Search(queryData, queryFilter));
            querySearch.Start();

            PlayerInformationUserControl playerInformation = await querySearch;

            if (playerInformation != null) {
                informationPanel.Controls.Clear();
                informationPanel.Controls.Add(playerInformation);
            }

        }

        // Makes a query about a player. Returns PlayerInformationUserControl if successful and null if not.
        private PlayerInformationUserControl Search(string _queryData, string _queryFilter)
        {
            if (string.IsNullOrWhiteSpace(_queryData))
            {
                MessageBox.Show("Searchbar is empty or white spaces");
                return null;
            }

            else if (_queryFilter.Equals(filterBoxDefaultValue))
            {
                MessageBox.Show("Pleace add search filter.");
                return null;
            }

            else
            {
                if (_queryFilter.Equals("Name"))
                {
                    Player player = searchEngine.SearchByName(_queryData);

                    PlayerInformationUserControl playerInformation = new PlayerInformationUserControl()
                    {
                        PanelPlayer = player
                    };

                    return playerInformation;
                }
                else
                {
                    Player player = searchEngine.SearchById(_queryData);

                    PlayerInformationUserControl playerInformation = new PlayerInformationUserControl()
                    {
                        PanelPlayer = player
                    };
                    return playerInformation;
                }

            }
        }

        private void SearchBarPanel_MouseDown(object sender, MouseEventArgs e)
        {
            endPoint = new Point(e.X, e.Y);
        }

        private void SearchBarPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - endPoint.X;
                this.Top += e.Y - endPoint.Y;
            }
        }
    }
}
