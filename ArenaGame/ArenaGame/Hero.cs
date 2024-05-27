namespace ArenaGame
{
    public enum Weapon 
    {
        None,
        Sword,
        Knife,
        Bow,
        Axe,
        Spear
    }
    public class Hero
    {
        public string Name { get; private set; }

        public int Health { get; private set; }

        public int Strength { get; private set; }

        protected int StartingHealth { get; private set; }

        public bool IsDead { get { return Health <= 0; } }

        public Weapon WeaponOfChoice { get; private set; }

        public Hero(string name)
        {
            Name = name;
            Health = 500;
            StartingHealth = Health;
            Strength = 100;
            WeaponOfChoice = Weapon.None;
        }
        public Hero(string name, Weapon weaponOfChoice)
        {
            Name = name;
            Health = 500;
            StartingHealth = Health;
            Strength = 100;
            WeaponOfChoice = weaponOfChoice;

            switch (weaponOfChoice)
            {
                case Weapon.Sword:
                    Strength = Strength + 100;
                    break;
                case Weapon.Knife:
                    Strength = Strength + 25;
                    break;
                case Weapon.Bow:
                    Strength = Strength + 50;
                    break;
                case Weapon.Axe:
                    Strength = Strength + 90;
                    break;
                case Weapon.Spear:
                    Strength = Strength + 75;
                    break;
                default:
                    break;
            }
        }

        public virtual int Attack()
        {
            return (Strength * Random.Shared.Next(80, 121)) / 100;
        }

        public virtual void TakeDamage(int incomingDamage)
        {
            if (incomingDamage < 0) return;
            Health = Health - incomingDamage;
        }

        protected bool ThrowDice(int chance)
        {
            int dice = Random.Shared.Next(101);
            return dice <= chance;
        }

        protected void Heal(int value)
        {
            Health = Health + value;
            if (Health > StartingHealth) Health = StartingHealth;
        }
    }
}
