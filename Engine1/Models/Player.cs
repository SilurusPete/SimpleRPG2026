using Engine;
using Engine.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Engine1.Models
{
    public class Player : LivingEntity
    {

        private string _CharacterClass;
        private int _Exp;
        private int _Level;

        public string CharacterClass
        {
            get { return _CharacterClass; }
            set
            {
                _CharacterClass = value;
                OnPropertyChanged(nameof(CharacterClass));
            }
        }
        
        public int Exp
        {
            get { return _Exp; }
            set 
            {
                _Exp = value;
                OnPropertyChanged(nameof(Exp));
            }
        }
        public int Level
        {
            get { return _Level; }
            set
            {
                _Level = value;
                OnPropertyChanged(nameof(Level));
            }
        }

        public ObservableCollection<QuestStatus> Quests { get; set; }

        public Player()
        {
            Inventory = new ObservableCollection<GameItem>();
            Quests = new ObservableCollection<QuestStatus>();
        }

        public bool HasAllTheseItems(List<ItemQuantity> items)
        {
            foreach (ItemQuantity item in items)
            {
                if (Inventory.Count(i => i.ItemTypeID == item.ItemID) < item.Quantity)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
