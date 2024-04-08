string? readResult;

int numericValue = 0;
bool validNumber = false;

Console.WriteLine("Please enter a value between 5 and 10");

do
{
    readResult = Console.ReadLine();
    validNumber = int.TryParse(readResult, out numericValue);

    if (readResult != null)
    {
        if (validNumber != true)
        {
            Console.WriteLine("Sorry, you entered an invalid number, please try again");
        }
        else if (numericValue < 5 || numericValue > 10)
        {
            validNumber = false;
            Console.WriteLine("Value invalid, please enter a value between 5 and 10");
        }
        else
        {
            Console.WriteLine("your value has been accepted.");
            break;
        }
    }

} while (validNumber == false);