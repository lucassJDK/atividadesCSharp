Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

if(daysUntilExpiration == 0) {
    Console.WriteLine("Sua conta foi inspirada.");
}
else if (daysUntilExpiration == 1) {
    discountPercentage = 20;
    Console.WriteLine(@$"sua assinatura irá inspirar em {daysUntilExpiration} dia!     
      Você ganhou um desconto de {discountPercentage}%");
      }

else if(daysUntilExpiration <= 5) {    
    discountPercentage = 10;   
     Console.WriteLine(@$"sua assinatura irá inspirar em {daysUntilExpiration} dias
       Você ganhou um desconto de {discountPercentage}%");}

else if(daysUntilExpiration <= 10) {
    Console.WriteLine("sua assinatura irá expirar em breve.");
} else{
    Console.WriteLine("A conta está com a assinatura em dia e sem proximidade da inspiração.");
}
