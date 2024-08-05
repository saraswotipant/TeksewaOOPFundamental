//Using if-else

Console.WriteLine("Enter the electricity units consumed:");
string electricityUnit = Console.ReadLine();
int unit;
decimal totalAmount = 0;
if (int.TryParse(electricityUnit,out unit))
{
    if (unit >=1 && unit <= 20)
    {
        totalAmount = 100;
    }
    else if ( unit >=21 && unit <= 25)
    {
        totalAmount = 100 + ((unit - 20) * 5);
    }
    else if ( unit >= 26 && unit <= 50)
    {
        totalAmount = 125 + ((unit - 25) * 10);
    }
    else
    {
        totalAmount = 2000;
    }
    Console.WriteLine($"The total electricity bill amount is Rs {totalAmount}");

}



//Switch case

Console.WriteLine("Enter the electricity units consumed:");
string electricityUnitInput = Console.ReadLine();
int units;
decimal totalAmount1 = 0;
if (int.TryParse(electricityUnitInput, out units))
{
    switch (units)
    {
        case int n when (n >= 1 && n <= 20):
        totalAmount1 = 100;
        break;

        case int n when (n >= 21 && n <= 25):
        totalAmount1 = 100+ (units - 20 ) * 5;
        break;

        case int n when (n >= 26 && n <= 50):
        totalAmount1 = 125 + (units - 25) * 10;
        break;

        default:
        totalAmount1 = 2000;
        break;
    }
    Console.WriteLine($"The total electricity bill amount is Rs {totalAmount1}");
    
}
