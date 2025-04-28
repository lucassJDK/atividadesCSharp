int numVezesParaRepetir = 30;
int [] numbersFibonnaci = new int[numVezesParaRepetir];
numbersFibonnaci[0] = 1;
numbersFibonnaci[1] = 1;

for(int i = 2; i < numVezesParaRepetir;i++)
{
    numbersFibonnaci[i] = numbersFibonnaci[i - 2] + numbersFibonnaci[i - 1];
}
foreach(int n in numbersFibonnaci)
{
    Console.Write($"{n} ");
}
