
{
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("Hello world, it's zodiac angle calculator for price market! Developer Mr. Touraj Ostovari 8/8/2024");
    double Price = 0;
    Console.WriteLine("Enter Price Market: ");
    Price = double.Parse(Console.ReadLine());
    int temp = 0;
    char temp_ = 'A';
    while (temp == 0)
    {
        Console.WriteLine("3 Ragami Price: Zarb A | Taghsim B >>  1. 10 2. 100 3. 1,000 4. 10,000 5. 100,000 << Enter 1 till 5: ");
        temp =  byte.Parse(Console.ReadLine());
        Console.WriteLine("Zarb A | Taghsim B");
        temp_ = char.Parse(Console.ReadLine());
    }
    if('b' == char.ToLower(temp_))
    switch (temp)
    {
        case 1:
            Price /= 10;
            break;
        case 2:
            Price /= 100;
            break;
        case 3:
            Price /= 1000;
            break;
        case 4:
            Price /= 10000;
            break;
        case 5:
            Price /= 100000;
            break;
        default:
            return 1;
            break;
    }
    if('a' == char.ToLower(temp_))
        switch (temp)
        {
            case 1:
                Price *= 10;
                break;
            case 2:
                Price *= 100;
                break;
            case 3:
                Price *= 1000;
                break;
            case 4:
                Price *= 10000;
                break;
            case 5:
                Price *= 100000;
                break;
            default:
                return 1;
                break;
        }
    while (Price > 360)
    {
        Price -= 360;
    }
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("\nAngle on Zodiac: "+Math.Round(Price));
    return 0;
}

