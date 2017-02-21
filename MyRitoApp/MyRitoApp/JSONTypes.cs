using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;


namespace MyRitoApp
{

    //champion-v1.2
    public class ChampionDto
    {
        bool active; // Indicates if the champion is active.
        bool botEnabled; //Bot enabled flag(for custom games).
        bool botMmEnabled; // Bot Match Made enabled flag(for Co-op vs. AI games).
        bool freeToPlay; //Indicates if the champion is free to play.Free to play champions are rotated periodically.
        long id; //Champion ID.For static information correlating to champion IDs, please refer to the LoL Static Data API.
    }


}