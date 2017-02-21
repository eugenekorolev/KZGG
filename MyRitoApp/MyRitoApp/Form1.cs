using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyRitoApp
{
    public partial class Form1 : Form
    {
        //JSON strings

        //summoner-v1.4
        public const string MyRitoSummonerRunesByName = @"/api/lol/{region}/v1.4/summoner/{summonerIds}/runes";
        public const string MyRitoSummonerMasteriesByName = @"/api/lol/{region}/v1.4/summoner/{summonerIds}/masteries";

        //summoner-v1.4
        public const string MyRitoSummonerByName = @"/api/lol/{region}/v1.4/summoner/by-name/{summonerNames}";
        public const string MyRitoSummonerByID = @"/api/lol/{region}/v1.4/summoner/{summonerIds}";
        public const string MyRitoSummonerByNameID = @"/api/lol/{region}/v1.4/summoner/{summonerIds}/name";

        //stats-v1.3
        public const string MyRitoSummonerRankedByID = @"/api/lol/{region}/v1.3/stats/by-summoner/{summonerId}/ranked";
        public const string MyRitoSummonerSummaryByID = @"/api/lol/{region}/v1.3/stats/by-summoner/{summonerId}/summary";

        //matchlist-v2.2
        public const string MyRitoSummonerMatchListByID = @"/api/lol/{region}/v2.2/matchlist/by-summoner/{summonerId}";

        //match-v2.2
        public const string MyRitoSummonerMatchByID = @"/api/lol/{region}/v2.2/match/{matchId}";

        //lol-status-v1.0
        public const string MyRitoLoLShards = @"/lol/status/v1/shards";
        public const string MyRitoLoLShard = @"/lol/status/v1/shard";

        //lol-static-data-v1.2
        public const string MyRitoVersion = @"/api/lol/static-data/{region}/v1.2/versions";
        public const string MyRitoSummonerSpellByID = @"/api/lol/static-data/{region}/v1.2/summoner-spell/{id}";
        public const string MyRitoSummonersSpells = @"/api/lol/static-data/{region}/v1.2/summoner-spell";
        public const string MyRitoRuneByID = @"/api/lol/static-data/{region}/v1.2/rune/{id}";
        public const string MyRitoRunes = @"/api/lol/static-data/{region}/v1.2/rune";
        public const string MyRitoRealm = @"/api/lol/static-data/{region}/v1.2/realm";
        public const string MyRitoMasteryByID = @"/api/lol/static-data/{region}/v1.2/mastery/{id}";
        public const string MyRitoMasteries = @"/api/lol/static-data/{region}/v1.2/mastery";
        public const string MyRitoMap = @"/api/lol/static-data/{region}/v1.2/map";
        public const string MyRitoLanguage = @"/api/lol/static-data/{region}/v1.2/languages";
        public const string MyRitoLanguageSetiings = @"/api/lol/static-data/{region}/v1.2/language-strings";
        public const string MyRitoItemByID = @"/api/lol/static-data/{region}/v1.2/item/{id}";
        public const string MyRitoItems = @"/api/lol/static-data/{region}/v1.2/item";
        public const string MyRitoChampionByID = @"/api/lol/static-data/{region}/v1.2/champion/{id}";
        public const string MyRitoChampions = @"/api/lol/static-data/{region}/v1.2/champion";

        //league-v2.5
        public const string MyRitoListOfSummoners = @"/api/lol/{region}/v2.5/league/by-summoner/{summonerIds}";
        public const string MyRitoListOfSummonersByID = @"/api/lol/{region}/v2.5/league/by-summoner/{summonerIds}/entry";

        //game-v1.3
        public const string MyRitoGameInfo = @"/api/lol/{region}/v1.3/game/by-summoner/{summonerId}/recent";

        //featured-games-v1.0
        public const string MyRitoFeaturedGames = @"/observer-mode/rest/featured";

        //current-game-v1.0
        public const string MyRitoCurrentGame = @"/observer-mode/rest/consumer/getSpectatorGameInfo/{platformId}/{summonerId}";

        //championmastery
        public const string MyRitoTopChampions = @"/championmastery/location/{location}/player/{playerId}/topchampions";
        public const string MyRitoScore = @"/championmastery/location/{location}/player/{playerId}/score";
        public const string MyRitoChampionsBySummonerID = @"/championmastery/location/{location}/player/{playerId}/champions";
        public const string MyRitoPlayerChampionByID = @"/championmastery/location/{location}/player/{playerId}/champion/{championId}";

        //champion-v1.2
        public const string MyRitoChampionList = @"/api/lol/{region}/v1.2/champion";
        public const string MyRitoChampionsByID = @"/api/lol/{region}/v1.2/champion/{id}";






        public Form1()
        {
            InitializeComponent();
        }
    }
}
