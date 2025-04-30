string pangram = "The quick brown fox jumps over the lazy dog";
char [] pangramChars = pangram.ToCharArray();
string newString = "";

for(int i = pangramChars.Length - 1; i >= 0; i--)
{
    newString += pangramChars[i];
}
Console.WriteLine(newString);