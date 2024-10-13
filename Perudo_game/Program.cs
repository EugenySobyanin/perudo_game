using Perudo_game;


Console.WriteLine("Добро пожаловать в игру!");

Console.Write("Укажите количество игроков:");
int players_count = Convert.ToInt32(Console.ReadLine());

if (players_count < 2 && players_count > 6)
{
    Console.WriteLine("В игру могут играть 2- 6 игроков");
    Console.Write("Укажите количество игроков:");
    players_count = Convert.ToInt32(Console.ReadLine());
}





