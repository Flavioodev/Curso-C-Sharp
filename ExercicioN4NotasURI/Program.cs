using System; 

class URI {

    static void Main(string[] args) { 
        int num = int.Parse(Console.ReadLine());
        System.Console.WriteLine("\n"+num);
        while(num>=1){
            int notas100 = num/100;
            num = num - notas100*100;
            
            int notas50 = num/50;
            num = num - notas50*50;
            
            int notas20 = num/20;
            num = num - notas20*20;
            
            int notas10 = num/10;
            num = num - notas10*10;
            
            int notas5 = num/5;
            num = num - notas5*5;
            
            int notas2 = num/2;
            num = num - notas2*2;
            
            int notas1 = num/1;
            num = num - notas1*1;
            
            System.Console.WriteLine($"{notas100} nota(s) de R$ 100,00\n{notas50} nota(s) de R$ 50,00\n{notas20} nota(s) de R$ 20,00\n{notas10} nota(s) de R$ 10,00\n{notas5} nota(s) de R$ 5,00\n{notas2} nota(s) de R$ 2,00\n{notas1} nota(s) de R$ 1,00\n");                                                            
        }
    }

}