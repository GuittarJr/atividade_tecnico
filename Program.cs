// See https://aka.ms/new-console-template for more information
using System.Net.Http.Headers;

namespace meuapp;

public class Program{
    public static void Main(string[] args)
    {
        /* 
        /////////////////////////////////Exercicio 1/////////////////////////////////////

        Console.WriteLine("Digite sua idade");
        int idade = Convert.ToInt32(Console.ReadLine());
        string resultado;
        if (idade < 18)
        {
            resultado="Menor de idade";
        }else{
            resultado="Maior de idade";
        }
        Console.WriteLine("Resultado: " + resultado);

        */
        /*
        /////////////////////////////////Exercicio 2/////////////////////////////////////
        double nota = 0;

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("Digite a " + (i + 1) + " nota");
            nota += Convert.ToInt32(Console.ReadLine());
        }

        double media = nota / 3;
        string resultado = "";
        if (media >= 7)
        {
            resultado = "Aprovado";
        }
        else
        {
            resultado = "Reprovado";
        }

        Console.WriteLine($"Media: {media}\nResultado: {resultado}");
        /*
        /*
        /////////////////////////////////Exercicio 3/////////////////////////////////////
        Console.WriteLine("Digite um numero: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        string resultado = numero > 0 ? "Positivo" : "Negativo";
        Console.WriteLine($"O numero: {numero} é {resultado}");
        */

        /*
        ////////////Exercicio 4 ///////////////
        Console.WriteLine("Digite um numero: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        if(numero % 2 ==0){
            Console.WriteLine("Par");
        }else{
            Console.WriteLine("Impar");
        }
        */
        /*
        ////////////Exercicio 5 ///////////////
        Console.WriteLine("Digite um numero: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        int dobro = numero * 2;
        Console.WriteLine(dobro);
         */
        /*
        ////////////Exercicio 6 ///////////////
        Console.WriteLine("Digite um numero: ");
        int numero = Convert.ToInt32(Console.ReadLine());

         if(numero % 3 ==0){
            Console.WriteLine("É divisivel");
        }else{
            Console.WriteLine("Não é divisivel ");
        }
        */
        /*
       ////////////Exercicio 7 ///////////////
       Console.WriteLine("Digite um numero: ");
       int numero = Convert.ToInt32(Console.ReadLine());
       int soma = 0;
       if(numero > 0){
           for (int i = 1; i <= numero; i++)
           {
               soma += i;
           }
       }
       Console.WriteLine(soma);
        */
        /*
      ////////////Exercicio 8 ///////////////

          int numero;
          int contador = 0;
          int pares = 0;

          while (contador < 10)
          {
              Console.WriteLine("Digite um numero: ");
              numero = Convert.ToInt32(Console.ReadLine());
              if(numero % 2 == 0){
                  pares +=1;
              }
              contador++;
          }

          Console.WriteLine("Quantidadade de numeros pares: " + pares);
        */
    }
}
