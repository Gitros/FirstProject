Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;

string extraCalculation = "";

if (roll1 == roll2 || roll2 == roll3 || roll1 == roll3)
{
    total += 2;
    extraCalculation = "+ 2";
}

if (roll1 == roll2 && roll1 == roll3 && roll2 == roll3)
{
    total += 6;
    extraCalculation = "+ 6";
}

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} {extraCalculation} = {total}");
if (total >= 15)
{
    Console.WriteLine("You won!");
}
else
{
    Console.WriteLine("You lost.");
}



