using System;

namespace imc2
{
    class Program
    {
        static void Main(string[] args)
        {
           //imc = massa/altura-altura
          //Abaixo de 17	Muito abaixo do peso
        // Entre 17 e 18,49	Abaixo do peso
        // Entre 18,5 e 24,99	Peso normal
        // Entre 25 e 29,99	Acima do peso
        // Entre 30 e 34,99	Obesidade I
        // Entre 35 e 39,99	Obesidade II (severa)
        // Acima de 40	Obesidade III (mórbida)

         double imc;
         double massa;
         double altura;
         string peso;
         string dieta;
         
            Console.Write("Digite seu Peso: ");
            peso = Console.ReadLine();
            massa = double.Parse(peso);

            Console.Write("Digite sua altura: ");
            dieta = Console.ReadLine();
            altura = double.Parse(dieta);

             imc = massa/(altura*altura);

            Console.Write("Valor " + imc);

            if(imc<17){
                Console.WriteLine(" Muito Abaixo do Peso");
           
            }
            if(imc>=17&& imc<=18.49)
            {
            Console.WriteLine(" Abaixo do Peso");
           }
            if(imc>=18.50&& imc<=24.99)
            {
            Console.WriteLine(" Peso Normal");

            }
            if(imc>=25&& imc<=29.99)
            {
            Console.WriteLine(" Acima do Peso");

            }
            if(imc>=30&& imc<=34.99)
            {
            Console.WriteLine(" Obesidade I");
            }
            if(imc>=35&& imc<=39.99)
            {
            Console.WriteLine(" Obesidade II (Severa)");

            }
            {
            if(imc>=40)            
            Console.WriteLine(" Obesidade III (Mórbida)");

            }

           
    


        }


    }
}
