using System.Globalization;

// este código mostrará como iniciar uma variável de um certo tipo com valor de outro tipo, distinto
//mostrará também como transformar string em int, em double, em float...
float x = 4.5f;

double y = x;
System.Console.WriteLine(y);//não há perda de dados, pois double abrange todos os valores float


//o contrário só é possível usando 'Casting':
double k = 18.4579878;

float z = (float)k;
System.Console.WriteLine(z);


//perda de valores com int
double num1 = 6.5;

int num2 = (int)num1;//é PRECISO usar o (int) - chamado de 'casting' - para funcionar a atribuição
System.Console.WriteLine(num2);


//divisão de dois números inteiros
int a = 5;
int b = 2;
double resultado = (double)a/b;//só assim o resultado é 2,5. Do contrário, imprime-se 2
System.Console.WriteLine(resultado);


//transformando string em outros tipos - exercício
System.Console.WriteLine("Entre com seu nome completo: ");
string fullName = Console.ReadLine();

System.Console.WriteLine("Quantos quartos tem na sua casa?");
int quartos = int.Parse(Console.ReadLine());

System.Console.WriteLine("Entre com o preço de um produto: ");
double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

System.Console.WriteLine("Entre com seu último nome, ideade e altura (mesma linha): ");




