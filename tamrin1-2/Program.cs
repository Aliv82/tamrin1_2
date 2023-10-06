
// Ali vahedi
// Adadd_Aval project

Console.WriteLine("please insert your first number : ");
int aval_Baze = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("please insert your second number : ");
int akhar_Baze = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("\n" + "prime number : " + "\n");

for (int i = aval_Baze; i < akhar_Baze; i++)
{
    if (mohasebeh(i) && i >= 2)
    {
        Console.Write("\t" + i);
    }
}

Console.WriteLine("");
Console.WriteLine("\n" + "mirror number : " + "\n");


for (int i = aval_Baze; i <= akhar_Baze; i++)
{
    if (i.ToString().Equals(Reverse(i.ToString())) && 11 <= i)
        Console.Write("\t" + i);

}
Console.ReadLine();

static string Reverse(string s)
{
    char[] charArray = s.ToCharArray();
    Array.Reverse(charArray);
    return new string(charArray);
}

static bool mohasebeh(int number)
{
    for (int j = 2; j < number; j++)
    {
        if (number % j == 0 && number != j)
        {
            return false;
        }

    }
    return true;
}









