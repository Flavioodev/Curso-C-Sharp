System.Console.WriteLine("Digite o valor do lado maior (caso de triângulo não equilátero)");
double ladoA = double.Parse(Console.ReadLine());
double ladoB = double.Parse(Console.ReadLine());
double ladoC = double.Parse(Console.ReadLine());

double oldLadoA = ladoA;
double oldLadoB = ladoB;
double oldLadoC = ladoC;

if(ladoB > ladoA || ladoC > ladoA){
    if(ladoB > ladoC){
        ladoA = ladoB;
        ladoB = oldLadoA;
    }
    else if(ladoC > ladoB){
        ladoA = ladoC;
        ladoC = oldLadoA;
    }
}
if(ladoB < ladoC){
    oldLadoB = ladoB;
    ladoB = ladoC;
    ladoC = oldLadoB;
}

if(ladoA >= ladoB + ladoC){
    System.Console.WriteLine("NAO FORMA TRIANGULO");
}

if(Math.Pow(ladoA,2)==Math.Pow(ladoB,2)+Math.Pow(ladoC,2)){
    System.Console.WriteLine("TRIANGULO RETANGULO");
}
if(Math.Pow(ladoA,2) > Math.Pow(ladoB,2) + Math.Pow(ladoC,2)){
    System.Console.WriteLine("TRIANGULO OBTUSANGULO");
}
if(Math.Pow(ladoA,2) < Math.Pow(ladoB,2) + Math.Pow(ladoC,2)){
    System.Console.WriteLine("TRIANGULO ACUTANGULO");
}
if(ladoA==ladoB && ladoC==ladoB){
    System.Console.WriteLine("TRIANGULO EQUILATERO");
}
if(ladoA==ladoB || ladoB==ladoC || ladoC==ladoA){
    System.Console.WriteLine("TRIANGULO ISOSCELES");
}

//System.Console.WriteLine("quadrado de A: "+Math.Pow(ladoA,2));