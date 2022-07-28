float nota1 = float.Parse(Console.ReadLine());
float nota2 = float.Parse(Console.ReadLine());
float nota3 = float.Parse(Console.ReadLine());
float nota4 = float.Parse(Console.ReadLine());

float media = (nota1*2+nota2*3+nota3*4+nota1*1)/(2+3+4+1);
System.Console.WriteLine("Media: "+media);
System.Console.WriteLine("");

if(media>=7){
    System.Console.WriteLine("Aluno aprovado");
    System.Console.WriteLine("");
}
else if(media<5){
    System.Console.WriteLine("Aluno reprovado");
    System.Console.WriteLine("");
}
if(media>=5 && media<=6.9){
    System.Console.WriteLine("Aluno em exame");
    System.Console.WriteLine("");
    float notaExame = float.Parse(Console.ReadLine());
    System.Console.WriteLine($"Nota do exame: {notaExame:F}");
    System.Console.WriteLine("");
    float mediaFinal =  (notaExame+media)/2;
    if(mediaFinal>=5){
        System.Console.WriteLine("Aluno aprovado");
        System.Console.WriteLine("");
    }
    else if(mediaFinal <=4.9){
        System.Console.WriteLine("Aluno reprovado");
        System.Console.WriteLine("");
    }
    System.Console.WriteLine($"Media final: {mediaFinal:F}");
    }
    
    System.Console.WriteLine("");