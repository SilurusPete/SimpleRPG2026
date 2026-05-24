using Engine;
using Engine.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Engine1.Models
{
    public class Player : BaseNotificationClass
    {
        private string _Nickname;
        private string _CharacterClass;
        private int _HP;
        private int _Exp;
        private int _Level;
        private int _Gold;

        public string Nickname
        {
            get { return _Nickname; }
            set
            {
                _Nickname = value;
                OnPropertyChanged(nameof(Nickname));
            }
        }
        public string CharacterClass
        {
            get { return _CharacterClass; }
            set
            {
                _CharacterClass = value;
                OnPropertyChanged(nameof(CharacterClass));
            }
        }
        public int HP
        {
            get { return _HP; }
            set
            {
                _HP = value;
                OnPropertyChanged(nameof(HP));
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
        public int Gold
        {
            get { return _Gold; }
            set
            {
                _Gold = value;
                OnPropertyChanged(nameof(Gold));
            }
        }

        public ObservableCollection<GameItem> Inventory { get; set; }
        public List<GameItem> Weapons => Inventory.Where(i => i is Weapon).ToList();
        public ObservableCollection<QuestStatus> Quests { get; set; }

        public Player()
        {
            Inventory = new ObservableCollection<GameItem>();
            Quests = new ObservableCollection<QuestStatus>();
        }

        public void AddItemToInventory(GameItem item)
        {
            Inventory.Add(item);

            OnPropertyChanged(nameof(Weapons));
        }

        public void RemoveItemFromInventory(GameItem item)
        {
            Inventory.Remove(item);

            OnPropertyChanged(nameof(Weapons));
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
