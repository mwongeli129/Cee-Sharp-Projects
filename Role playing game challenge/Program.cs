﻿Random dice = new Random();   

int hero = 10;
int monster = 10;

do
{
    int roll = dice.Next(1, 11);
    monster -= roll;
    Console.WriteLine($"Monster was damaged and lost{roll} health and now has {monster} health. ");

    if (monster <= 0) continue;
    {
        roll = dice.Next(1, 11);
        hero -= roll;
        Console.WriteLine($"Heero was changed and lost {roll} health and now has {hero} health. ");
    }

} while (hero > 0 && monster > 0);
Console.WriteLine(hero > monster ? "Hero wins!" : "Monster wins!");