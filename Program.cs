Random random = new();

int attackDamage = 0;
int heroHealth = 10;
int monsterHealth = 10;

do
{
    attackDamage = random.Next(1, 11);
    monsterHealth -= attackDamage;

    if (monsterHealth <= 0)
    {
        Console.WriteLine($"Hero killed a monster dealing {attackDamage} damage!");
        break;
    }
    else
        Console.WriteLine($"Hero dealt {attackDamage}! Monster have {monsterHealth} health left.");

    attackDamage = random.Next(1, 11);
    heroHealth -= attackDamage;

    if (heroHealth <= 0)
    {
        Console.WriteLine($"Monster killed a Hero dealing {attackDamage} damage!");
        break;
    }
    else
        Console.WriteLine($"Monster dealt {attackDamage}! Hero have {heroHealth} health left.");
} while (heroHealth! >= 0 || monsterHealth! >= 0);