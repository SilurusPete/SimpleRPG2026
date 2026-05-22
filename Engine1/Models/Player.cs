using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Engine.Models
{
    public class Player : INotifyPropertyChanged
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
                OnPropertyChanged("Nickname");
            }
        }

        public string CharacterClass
        {
            get { return _CharacterClass; }
            set
            {
                _CharacterClass = value;
                OnPropertyChanged("CharacterClass");
            }
        }

        public int HP
        {
            get { return _HP; }
            set
            {
                _HP = value;
                OnPropertyChanged("HP");
            }
        }
        public int Exp
        {
            get { return _Exp; }
            set 
            {
                _Exp = value;
                OnPropertyChanged("Exp");
            }
        }
        public int Level
        {
            get { return _Level; }
            set
            {
                _Level = value;
                OnPropertyChanged("Level");
            }
        }

        public int Gold
        {
            get { return _Gold; }
            set
            {
                _Gold = value;
                OnPropertyChanged("Gold");
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
