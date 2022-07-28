/*System.Console.WriteLine("EXERCÍCIO 1");

System.Console.WriteLine("Digite um número: ");
int num = int.Parse(Console.ReadLine());

if (num >= 0 ){
    System.Console.WriteLine("Número não-negativo");
}

else{
    System.Console.WriteLine("Número negativo");
}
System.Console.WriteLine("----------------------------------------------------");
System.Console.WriteLine("EXERCÍCIO 2");

System.Console.WriteLine("Digite o primeiro número: ");
int num1E2 = int.Parse(Console.ReadLine());
System.Console.WriteLine("Digite o segundo número: ");
int num2E2 = int.Parse(Console.ReadLine());

if(num1E2 % num2E2 == 0 || num2E2 % num1E2 == 0){
    System.Console.WriteLine("SÃO MÚLTIPLOS!");
}

else{
    System.Console.WriteLine("NÃO SÃO MÚLTIPLOS!");
}

System.Console.WriteLine("-----------------------------------------------------");
*/
System.Console.WriteLine("EXERCÍCIO 3");

System.Console.WriteLine("Digite a hora inicial do jogo:");
int horaI = int.Parse(Console.ReadLine());
System.Console.WriteLine("Digite a hora final do jogo:");
int horaF = int.Parse(Console.ReadLine());
int tempo;
if (horaI < horaF){
    tempo = horaF - horaI;
}

else{
    tempo = 24 - horaI + horaF;
}

System.Console.WriteLine("O jogo durou "+tempo+" hora(s)");

int idHotDog = 01;
int idXsalada = 02;
int idXbacon = 03;

float valorHotDog = 4.0;
float valorXsalada = 4.5;
float valorXbacon = 5.0;
System.Console.WriteLine($"Digite o código do seu pedido: \n Código do hotdog: {idHotDog}. Valor do hotdog: R$ {valorHotDog}");
System.Console.WriteLine($"Código do X-Salada: {idXsalada}. Valor do X-Salada: R$ {valorXsalada}");
System.Console.WriteLine($"Código do X-Bacon: {idXbacon}. Valor do X-Bacon: R$ {valorXbacon}");