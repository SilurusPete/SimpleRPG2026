using Engine;
using Engine.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

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
        public ObservableCollection<QuestStatus> Quests { get; set; }

        public Player()
        {
            Inventory = new ObservableCollection<GameItem>();
            Quests = new ObservableCollection<QuestStatus>();
        }
    }
}
