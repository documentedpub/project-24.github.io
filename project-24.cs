Random x = new();
int y = 0;

int heroHealthPoints = 10;
int monsterHealthPoints = 10;

do
{
    y = x.Next(1, 11);
    monsterHealthPoints -= y;
    System.Console.WriteLine($"Monster was damaged and lost {y} health and now has {monsterHealthPoints} health.");
    if (monsterHealthPoints > 0)
    {
        y = x.Next(1, 11);
        heroHealthPoints -= y;
        System.Console.WriteLine($"Hero was damaged and lost {y} health and now has {heroHealthPoints} health.");
    }
}
while ((monsterHealthPoints > 0) && (heroHealthPoints > 0));
// if (hero > monster)
// {
//     System.Console.WriteLine("Hero Wins!");
// }
// if (monster > hero)
// {
//     System.Console.WriteLine("Monster Wins!");
// }
System.Console.WriteLine(heroHealthPoints > 0 ? "Hero Wins!": "Monster Wins!");
