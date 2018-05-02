namespace TextAdventure
{
    public class Player : Character
    {
        public Player(string name, string race, string sex, string characterClass, int health, int melee, int range, int magic) :
            base(name, race, sex, characterClass, health, melee, range, magic)
        {
        }
    }
}