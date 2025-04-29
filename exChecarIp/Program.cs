using System.Xml;

string ip = "255.255.255.255";
string [] partesIp = ip.Split(".");

 bool checkIp(string [] octetosId )
{
    foreach(var octeto in octetosId)
    {
      
      if(int.TryParse(octeto,out var octetoInt))
      {
       char [] splitNumber = octeto.ToCharArray();

        if(octetoInt > 255 ||  octetoInt < 0 || splitNumber[0].ToString() == "0")
        {
             Console.WriteLine("IP inválido!");
             return false;
        } else{
            continue;
            
        }
      } else{
        Console.WriteLine("Caractere inválido detectado!");
        return false;
      }
    }
        Console.WriteLine("IP válido!");
        return true;


}
checkIp(partesIp);