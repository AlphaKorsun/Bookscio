static void Main(string[] args)
{
    int totalteiler = 0;
    for (int zahl = 1; zahl <= 100; zahl++)
    {
        for (int teiler = 1; teiler <= zahl; teiler++)
        {
            if (zahl % teiler == 0)
            {
                totalteiler++;
            }
        }
        if (totalteiler == 2)
        {
            Console.WriteLine(zahl);
            totalteiler = 0;
        }
        else
        {
            totalteiler = 0;
        }
    }
}