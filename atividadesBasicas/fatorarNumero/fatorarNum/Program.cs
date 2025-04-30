int num = 2;
int total = num;
while(num > 1)
{
    total *= num - 1;
    num--;
}

if (total == 0)
{
    Console.WriteLine("1");
}else
{
Console.WriteLine(total);
}