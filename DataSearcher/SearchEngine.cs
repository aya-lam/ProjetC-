using System;
using System.Net;
using System.IO;
using System.Windows.Forms;
using JsonHandler;

namespace DataSearcher
{
    public class SearchEngine
    {
        private static HttpWebRequest queryRequest;

        // Makes a web query that requests player information by name, packs it into a Player class instance and returns it to the caller.
        public Player SearchByName(string playerName)
        {
            try
            {
                string queryString = "https://query.wikidata.org/sparql?query=SELECT%20?itemLabel%20?_____________________Label%20?_______Label%20?competition_classLabel%20?_______________%20?___________Label%20?country_for_sportLabel%20?Basketball_Reference_com_NBA_player_ID%20WHERE%20{%20SERVICE%20wikibase:label%20{%20bd:serviceParam%20wikibase:language%20%22en%22.%20}%20?item%20wdt:P31%20wd:Q5;%20wdt:P106%20wd:Q3665646;%20rdfs:label%20?itemLabel.%20OPTIONAL%20{%20?item%20wdt:P54%20?_____________________.%20}%20OPTIONAL%20{%20?item%20wdt:P413%20?_______.%20}%20OPTIONAL%20{%20?item%20wdt:P2094%20?competition_class.%20}%20OPTIONAL%20{%20?item%20wdt:P569%20?_______________.%20}%20OPTIONAL%20{%20?item%20wdt:P27%20?___________.%20}%20OPTIONAL%20{%20?item%20wdt:P1532%20?country_for_sport.%20}%20OPTIONAL%20{%20?item%20wdt:P2685%20?Basketball_Reference_com_NBA_player_ID.%20}%20FILTER(CONTAINS(LCASE(?itemLabel),%20%22"+playerName.ToLower()+"%22))%20FILTER((LANG(?itemLabel))%20=%20%22en%22)%20OPTIONAL%20{%20%20}%20}%20LIMIT%201&format=json";
                queryRequest = (HttpWebRequest)WebRequest.Create(queryString);

                queryRequest.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/80.0.3987.149 Safari/537.36";

                HttpWebResponse queryResponse = (HttpWebResponse)queryRequest.GetResponse();

                string responseString = new StreamReader(queryResponse.GetResponseStream()).ReadToEnd();

                ServerResponse jsonHandler = ServerResponse.FromJson(responseString);

                // Returns a Player instance with all parameters set to "Unknown" if the bindings array is emtpy, indicating that the player does not exist.
                if (jsonHandler.Results.Bindings.Length == 0)
                {
                    return new Player()
                    {
                        Id = "Not Found",
                        Name = "Unknown",
                        DateOfBirth = "Unknown",
                        Citizenship = "Unknown",
                        Team = "Unknown",
                        Position = "Unknown",
                        CompetitionClass = "Unknown",
                        CountryForSport = "Unknown"
                    };
                }

                // Packs the received information insied a Player instance.
                Player foundPlayer = new Player()
                {
                    Id = jsonHandler.Results.Bindings[0].BasketballReferenceComNbaPlayerId.Value,
                    Name = jsonHandler.Results.Bindings[0].ItemLabel.Value,
                    DateOfBirth = jsonHandler.Results.Bindings[0].DateOfBirth.Value.ToString("dd-MM-yyyy"),
                    Citizenship = jsonHandler.Results.Bindings[0].CitizenshipCountry.Value,
                    Team = jsonHandler.Results.Bindings[0].Team.Value,
                    Position = jsonHandler.Results.Bindings[0].Position.Value,
                    CompetitionClass = jsonHandler.Results.Bindings[0].CompetitionClass.Value,
                    CountryForSport = jsonHandler.Results.Bindings[0].CountryForSport.Value

                };

                return foundPlayer;
            }
            catch (Exception exception)
            {
                MessageBox.Show("An exception occured: "+ exception.ToString());
                return null;
            }
        }
        // Makes a web query that requests player information by ID, packs it into a Player class instance and returns it to the caller.
        public Player SearchById(string playerId)
        {
            try
            {
                string queryString = "https://query.wikidata.org/sparql?query=SELECT%20DISTINCT%20?itemLabel%20?_____________________Label%20?_______Label%20?competition_classLabel%20?_______________%20?___________Label%20?country_for_sportLabel%20WHERE%20{%20SERVICE%20wikibase:label%20{%20bd:serviceParam%20wikibase:language%20%22en%22.%20}%20?item%20wdt:P31%20wd:Q5;%20wdt:P106%20wd:Q3665646;%20wdt:P2685%20?id.%20OPTIONAL%20{%20?item%20wdt:P54%20?_____________________.%20}%20OPTIONAL%20{%20?item%20wdt:P413%20?_______.%20}%20OPTIONAL%20{%20?item%20wdt:P2094%20?competition_class.%20}%20OPTIONAL%20{%20?item%20wdt:P569%20?_______________.%20}%20OPTIONAL%20{%20?item%20wdt:P27%20?___________.%20}%20OPTIONAL%20{%20?item%20wdt:P1532%20?country_for_sport.%20}%20FILTER(?id%20=%20%22" + playerId + "%22)%20}%20LIMIT%201&format=json";

                queryRequest = (HttpWebRequest)WebRequest.Create(queryString);

                queryRequest.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/80.0.3987.149 Safari/537.36";

                HttpWebResponse queryResponse = (HttpWebResponse)queryRequest.GetResponse();

                string responseString = new StreamReader(queryResponse.GetResponseStream()).ReadToEnd();

                ServerResponse jsonHandler = ServerResponse.FromJson(responseString);


                // Returns a Player instance with all parameters set to "Unknown" if the bindings array is emtpy, indicating that the player does not exist.
                if(jsonHandler.Results.Bindings.Length == 0)
                {
                    return new Player()
                    {
                        Id = "Not Found",
                        Name = "Unknown",
                        DateOfBirth = "Unknown",
                        Citizenship = "Unknown",
                        Team = "Unknown",
                        Position = "Unknown",
                        CompetitionClass = "Unknown",
                        CountryForSport = "Unknown"
                    };
                }

                // Packs the received information insied a Player instance.
                Player foundPlayer = new Player()
                {
                    Id = playerId,
                    Name = jsonHandler.Results.Bindings[0].ItemLabel.Value,
                    DateOfBirth = jsonHandler.Results.Bindings[0].DateOfBirth.Value.ToString("dd-MM-yyyy"),
                    Citizenship = jsonHandler.Results.Bindings[0].CitizenshipCountry.Value,
                    Team = jsonHandler.Results.Bindings[0].Team.Value,
                    Position = jsonHandler.Results.Bindings[0].Position.Value,
                    CompetitionClass = jsonHandler.Results.Bindings[0].CompetitionClass.Value,
                    CountryForSport = jsonHandler.Results.Bindings[0].CountryForSport.Value

                };
                return foundPlayer;
            }

            //Shows a message box with information about an exception whenever it occurs.
            catch (Exception exception)
            {
                MessageBox.Show("An exception occured: " + exception);
                return null;
            }
        }
    }
}

