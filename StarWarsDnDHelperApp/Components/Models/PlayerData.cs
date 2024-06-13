using System.Xml.Linq;

namespace StarWarsDnDHelperApp.Components.Models
{
    public class PlayerData
    {
        private int id;
        private string name;
        private string characterName;
        private int baseHitPoints;
        private int hitPoints;
        // dice number
        private int rollNumber = 1;
        // bool for UI, if we want to include player for rolling in "Roll All"
        private bool rollAll = true;

        public PlayerData(int id, string name, string characterName, int baseHitPoints)
        {
            this.id = id;
            this.name = name;
            this.characterName = characterName;
            this.baseHitPoints = baseHitPoints;
            this.hitPoints = baseHitPoints;
        }

        public PlayerData()
        {
        }

        public int getId() { return id; }

        public void setId(int id) { this.id = id; }

        public string getName() { return name; }

        public void setName(string name) { this.name = name; }

        public string getCharacterName() { return characterName; }

        public void setCharacterName(string characterName) { this.characterName = characterName; }

        public int getBaseHitPoints() { return baseHitPoints; }

        public void setBaseHitPoints(int baseHitPoints) { this.baseHitPoints = baseHitPoints; }

        public int getHitPoints() { return hitPoints; }

        public void setHitPoints(int hitPoints) { this.hitPoints = hitPoints; }

        public int getRollNumber() { return rollNumber; }

        public void setRollNumber(int rollNumber) { this.rollNumber = rollNumber; }

        public bool isRollAll() { return rollAll; }

        public void setRollAll(bool rollAll) { this.rollAll = rollAll; }

    }
}
