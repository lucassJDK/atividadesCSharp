/*
 Em uma cidade se deseja sincronizar os semáforos. Com isto, quando um semáforo abre (fica verde), osveículos que nele estavam parados tendem a encontrar osó prximos semáforos téambm abertos. Para queisto seja feóito, os prximos semáforos precisam abrir um pouco depois, dependendo da velocidadepermitida na via e da disâtncia entre eles. Assim, ao abrir o semáforo, um veículo começa a acelerar aétatingir a velocidade permitida, que mantém até chegar ao próximo semáforo, levando um certo tempopara percorrer essa âdistncia. Para que encontre o próximoá semforo aberto, este deve abrir um poucoantes da chegada do veículo (por ex: 3 segundos antes).
  Faça assim um algoritmo que informe quantotempo depois um semáforo deve abrir, dada as seguintes informçaões:
  a.a distância desde o semáforo anterior
   b. avelocidade permitida da via
    c.a acelerçaão típica dos carros
*/

Console.WriteLine("Insira a distância em km:");
float distancia = float.Parse(Console.ReadLine());
Console.WriteLine("insira a velocidade máxima da via:");
float velocidadeMax = float.Parse(Console.ReadLine());
Console.WriteLine("Insira a velocidade padrão dos carros:");
float velocidadeMin = float.Parse(Console.ReadLine());
float velocidadeAtual = 0;
float segundos = 0f;
do{
    if (velocidadeAtual + velocidadeMin > velocidadeMax)
    {
        segundos += velocidadeMax / velocidadeAtual;
        velocidadeAtual += velocidadeMax - velocidadeAtual;
        break;
    }
    velocidadeAtual += velocidadeMin;
    segundos++;
} while(true);
segundos += distancia / velocidadeAtual * 3600;
Console.WriteLine($"O semáforo deve-se abrir em:{segundos:F2} segundos");