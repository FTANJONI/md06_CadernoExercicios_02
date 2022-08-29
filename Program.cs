using System;

namespace md06_CadernoExercicios_02
{
    class Program
    /*
     2. Crie um algoritmo que calcula o desconto previdenciário de um funcionário.
        Dado um salário, o programa deve retornar o valor do desconto proporcional
        ao mesmo. O cálculo segue a regra: o desconto é de 11% do valor do salário,
        entretanto, o valor máximo de desconto é 720,00. Sendo assim, ou o
        algoritmo retorna o valor equivalente a 11% sobre o salário ou 720,00.
        O programa deve perguntar se o usuário deseja encerrar a aplicação.
        Números devem ser tratados
     */
    {
        static void Main(string[] args)
        {
            double salBruto, SalLiq, percentualDesc=0.11, valorDesc;
            string s = "S";
            do
            {
                Console.WriteLine("Informe o salário:");
                salBruto = Convert.ToDouble(Console.ReadLine());
                valorDesc = salBruto * percentualDesc;
                if (valorDesc > 720.00)
                {
                    valorDesc = 720.00;
                }
                SalLiq = salBruto - valorDesc;

                Console.WriteLine("\nSalário Bruto: R$ {0}\nDesconto Previdenciário: R$ - {1}\n" +
                    "Salário Líquido: R$ {2}",salBruto.ToString("0.00"),valorDesc.ToString("0.00"),
                    SalLiq.ToString("0.00"));
                Console.WriteLine("\nPara sair do sistema digite (S) ou (N) para permanecer.");
                s = Console.ReadLine();

                if (s.Equals("s"))
                {
                    s = "S";
                }
                if (s.Equals("n"))
                {
                    s = "N";
                }

            } while (s=="N");

            
        }
    }
}
