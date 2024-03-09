using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InverterString
{
    internal class Program
    {
        static string InverterString(string str)
        {
            char[] caracteres = str.ToCharArray();
            int inicio = 0;
            int fim = caracteres.Length - 1;

            while (inicio < fim)
            {
                char temp = caracteres[inicio];
                caracteres[inicio] = caracteres[fim];
                caracteres[fim] = temp;
                inicio++;
                fim--;
            }

            string textoInvertido = new string(caracteres);
            return textoInvertido;
        }
        static void Main(string[] args)
        {
            Console.Write("Digite uma string para inverter os caracteres: ");
            string texto = Console.ReadLine();
            string textoInvertido = InverterString(texto);
            Console.WriteLine($"String original: {texto}");
            Console.WriteLine($"String invertida: {textoInvertido}");
            Console.ReadKey();
        }
    }

}