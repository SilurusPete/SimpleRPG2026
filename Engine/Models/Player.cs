using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class Player
    {
        public string Nickname {  get; set; }
        public string CharacterClass { get; set; }
        public int HP { get; set; }
        public int Exp { get; set; }
        public int Level { get; set; }
        public int Gold { get; set; }
    }
}
 