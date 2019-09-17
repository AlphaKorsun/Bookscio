string readText(string path)
{
    Directory.SetCurrentDirectory(@"C:\Users\Alpha\source\repos\ReadText");
    string result = "";
    try
    {
        using (StreamReader sr = new StreamReader(path))
        {
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                result = result + "\n" + line;
            }
        }
    }
    catch (Exception e)
    {
        Response.Write("Failed: ");
        Response.Write(e.Message);
    }
    return result;
}

