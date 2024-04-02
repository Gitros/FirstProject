string permission = "Manager";
int level = 15;

if (level > 55 && permission.Contains("Admin"))
{
    Console.WriteLine("Welcome, super admin user");
}
else if (level >= 55 && permission.Contains("Admin"))
{
    Console.WriteLine("Welcome, Admin user.");
}
else if (level >= 20 && permission.Contains("Manager"))
{
    Console.WriteLine("Contact an Admin for access.");
}
else if (level < 20 && permission.Contains("Manager"))
{
    Console.WriteLine("You dont have sufficient privileges.");
}
else if (!permission.Contains("Admin") || !permission.Contains("Manager"))
{
    Console.WriteLine("You dont have sufficient privileges.");
}