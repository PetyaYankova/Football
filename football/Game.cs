using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using football.Models;

namespace football
{
    public class Game
    {
        public Team Team1 { get; set; }
        public Team Team2 { get; set; }
        public Referee Referee { get; set; }
        public AssisstantReferee AssisstantReferee { get; set; }
        public List<string> Goals { get; set; }
        public string Result { get; set; }
        public Team Winner { get; set; }
    }
}
