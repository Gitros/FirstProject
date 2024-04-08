string? readResult;
string roleName = "";
bool validRole = false;

do
{
    Console.WriteLine("Enter your role name (Administrator, Manager, or User)");
    readResult = Console.ReadLine();
    if (readResult != null)
    {
        roleName = readResult.Trim();
    }

    if (roleName.ToLower() == "administrator" || roleName.ToLower() == "manager" || roleName.ToLower() == "user")
    {
        validRole = true;
    }
    else
    {
        Console.WriteLine($"The role name that you entered, {readResult} is not valid. Enter your role name (Administrator, Manager, or User)");
    }

} while (validRole == false);

Console.WriteLine($"Your input value ({roleName}) has been accepted.");
readResult = Console.ReadLine();