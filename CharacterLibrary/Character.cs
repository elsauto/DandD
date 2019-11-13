using System;
using System.Text;

namespace CharacterLibrary
{
    public class Character
    {
        #region Propertties

        public string CharacterName { get; set; }

        private int _strength;
        public int Strength
        {
            get { return _strength; }

            set
            {
                if (value >= 3 && value <= 18)
                {
                    _strength = value;
                }
                else
                {
                    throw new Exception("Strength must be between 3 and 18.");
                }
            }
        }

        private int _intelligence;
        public int Intelligence
        {
            get { return _intelligence; }

            set
            {
                if (value >= 3 && value <= 18)
                {
                    _intelligence = value;
                }
                else
                {
                    throw new Exception("Intelligence must be between 3 and 18.");
                }
            }
        }

        private int _wisdom;
        public int Wisdom
        {
            get { return _wisdom; }

            set
            {
                if (value >= 3 && value <= 18)
                {
                    _wisdom = value;
                }
                else
                {
                    throw new Exception("Wisdom must be between 3 and 18.");
                }
            }
        }

        private int _dexterity;
        public int Dexterity
        {
            get { return _dexterity; }

            set
            {
                if (value >= 3 && value <= 18)
                {
                    _dexterity = value;
                }
                else
                {
                    throw new Exception("Dexterity must be between 3 and 18.");
                }
            }
        }

        private int _constitution;
        public int Constitution
        {
            get { return _constitution; }

            set
            {
                if (value >= 3 && value <= 18)
                {
                    _constitution = value;
                }
                else
                {
                    throw new Exception("Constitution must be between 3 and 18.");
                }
            }
        }

        private int _charisma;
        public int Charisma
        {
            get { return _charisma; }

            set
            {
                if (value >= 3 && value <= 18)
                {
                    _charisma = value;
                }
                else
                {
                    throw new Exception("Charisma must be between 3 and 18.");
                }
            }
        }

        public int ExperiencePoints { get; set; }

        // Read-Only property, it has no setter. 
        public int Level
        {
            /*
                We want to return always an INT value, even tough
                not all numbers are divisable by 1000.
                I marked 1000 as decimal with letter "d".
            */

            get { return int.Parse(Math.Floor(ExperiencePoints / 1000d).ToString()); }

        }
        #endregion

        #region Constructors

        public Character(string name)
        {
            CharacterName = name;
        }

        public Character(string name, int str, int wis, int dex)
        {
            CharacterName = name;
            _strength = str;
            _wisdom = wis;
            _dexterity = dex;
        }

        public Character()
        {
            _strength = _intelligence = _wisdom = _dexterity = _constitution = _charisma = 3;
        }

        #endregion

        #region Methods

        private Random rnd = new Random();
        public int RollAttributeScore()
        {
            int score = 0;
            int highestScore = 0;

            for (int i = 0; i < 2; i++)
            {
                score = rnd.Next(3, 18);
                if (score > highestScore)
                {
                    highestScore = score;
                }
            }

            return score;
        }

        public void GenerateCharacter()
        {
            Strength = RollAttributeScore();
            Intelligence = RollAttributeScore();
            Wisdom = RollAttributeScore();
            Dexterity = RollAttributeScore();
            Constitution = RollAttributeScore();
            Charisma = RollAttributeScore();
        }

        public override string ToString()
        {
            StringBuilder characterString = new StringBuilder();
            characterString.AppendLine("Character Name is: " + CharacterName);
            characterString.AppendLine("Character Strength is: " + Strength);
            characterString.AppendLine("Character Intelligence is: " + Intelligence);
            characterString.AppendLine("Character Wisdom is: " + Wisdom);
            characterString.AppendLine("Character Constitution is: " + Constitution);
            characterString.AppendLine("Character Charisma is: " + Charisma);

            return characterString.ToString();
        }

        #endregion

    }
}
