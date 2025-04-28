string[] values = { "12.3", "45", "ABC", "11", "DEF" };
string sumWords = "";
float sumNumbers = 0f;

foreach(string items in values) 
{
    float floatNumber = 0f;
    int intNumber = 0;

    if(float.TryParse(items,out floatNumber))
    {
        sumNumbers += floatNumber;
    }

    else if(int.TryParse(items,out intNumber))
    {
        sumNumbers += intNumber;
    } else {
        sumWords += items;
    }
}
Console.WriteLine($"Strings: {sumWords} \n Numbers: {sumNumbers}");