using system;
namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Character player = new Plaayer();
            Character enemy = new Enemy();
            Random rand = new Random();
            
            enemy.Name = "Sub-Zero";
            enemy.Health = 100;
            enemy.Power = 10;

            player.Name = "Scorpion";
            player.Health = 100;
            player.Power = 10;

            while(player.Health !=0 || enemy.Health != 0){
                int enemyRand = rand.Next(1, 100);
                int plahyerRand = rand.Next(1, 100);

                if(enemyRand>plahyerRand){
                    enemy.Attack(player);
                }
                else if(plahyerRand>enemyRand){
                    player.Attack(enemy);
                }
                else{
                    enemy.Attack(player);
                    player.Attack(enemy);
                }
            }
            if(player.Health==0){
                Console.WriteLine("Scorpion is dead. Sub-zero win.");
            }
            else if(enemy.Health==0){
                Console.WriteLine("Sub-Zero is dead. Scorpion win.");

            }
            
}
}
}