using System.Collections.Generic;

/*
 *     Array
 *     Gr�sse Fix, sehr schnell
 *     https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/collections
 */
void arr()
{
    // Deklaration
    int[] intArray;

    // Initiation
    int[] intArray = new int[10];

    // Bef�llen
    intArray[0] = 23;

    // Alternativ, alles zusammen
    int[] intArray = new int[10] { 23, 34, 25 };
}   
/*
*      List
*      Gr�sse dynamisch, langsam
*/
void lis()
{
    // Deklaration
    List<string> liste;

    // Initiation
    List<string> liste = new List<string>();

    // Bef�llen
    liste.Add("test1");
    liste.Add("test2");

    // Alternativ, alles zusammen
    string[] animals = { "Cow", "Camel", "Elephant" };
}

/*
 *     Dictionary
 *     Gr�sse dynamisch, langsam
 */
void dic()
{
    // Deklaration
    Dictionary<int, string> dict;

    // Initiation
    Dictionary<int, string> dict = new Dictionary<int, string>();

    // Bef�llen
    dict.Add(1, "test1");
    dict.Add(2, "test2");

    // Alternativ, alles zusammen
    Dictionary<int, string> dict = new Dictionary<int, string>()
    {
        { 1, "One" },
        { 2, "Two" },
        { 3, "Three" }
    };
}

