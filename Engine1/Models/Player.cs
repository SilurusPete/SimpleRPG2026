using System;
using System.Collections.ObjectModel;
using System.Linq;

namespace Engine1.Models
{
    public class Player : LivingEntity
    {
        #region Properties

        private string _CharacterClass;
        private int _Exp;

        public string CharacterClass
        {
            get { return _CharacterClass; }
            set
            {
                _CharacterClass = value;
                OnPropertyChanged();
            }
        }

        public int Exp
        {
            get { return _Exp; }
            private set
            {
                _Exp = value;

                OnPropertyChanged();

                SetLevelAndMaximumHitPoints();
            }
        }

        public ObservableCollection<QuestStatus> Quests { get; }
        public ObservableCollection<Recipe> Recipes { get; }

        #endregion

        public event EventHandler OnLeveledUp;

        public Player(string name, string characterClass, int experiencePoints,
                      int maximumHitPoints, int currentHitPoints, int gold) :
            base(name, maximumHitPoints, currentHitPoints, gold)
        {
            CharacterClass = characterClass;
            Exp = experiencePoints;

            Quests = new ObservableCollection<QuestStatus>();
            Recipes = new ObservableCollection<Recipe>();
        }

        public void AddExperience(int experiencePoints)
        {
            Exp += experiencePoints;
        }

        public void LearnRecipe(Recipe recipe)
        {
            if (!Recipes.Any(r => r.ID == recipe.ID))
            {
                Recipes.Add(recipe);
            }
        }

        private void SetLevelAndMaximumHitPoints()
        {
            int originalLevel = Level;

            Level = (Exp / 100) + 1;

            if (Level != originalLevel)
            {
                MaximumHitPoints = Level * 10;

                OnLeveledUp?.Invoke(this, System.EventArgs.Empty);
            }
        }
    }
}
