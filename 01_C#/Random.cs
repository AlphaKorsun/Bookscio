static string generateRandomNR(int anzahl, int anfang, int ende)
{
    Random rnd = new Random();
    string result = "";
    for (int i = 1; i < anzahl; i++)
    {
        result = result + Convert.ToString(rnd.Next(anfang, ende)) + ", ";
    }

    return result;
}