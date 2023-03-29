namespace OOP
{
    abstract class Character
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Power { get; set; }

        public void  Damage(int damage)
        {
            Health-=damage;
            Console.WriteLine($"{Name} health now is {Health}");
        }
        public abstract void Attack(Character target);
    }

    internal class Player : Character
    {
        public override void Attack(Character target)
        {
            target.Damage(Power);
            Console.WriteLine("Player Attacked Enemy");

        }
    }

    internal class Enemy : Character
    {

        public override void Attack(Character target)
        {
            target.Damage(Power);
            Console.WriteLine($"Eneme Attacked Player");

        }    
    }
}