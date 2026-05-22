using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    class Player
    {
        string Nickname {  get; set; }
        string CharacterClass { get; set; }
        int HP { get; set; }
        int Exp { get; set; }
        int Level { get; set; }
        int Gold { get; set; }
    }
}
