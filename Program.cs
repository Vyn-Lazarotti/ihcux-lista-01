using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Bem-vindo a Stomach Lanches");
        bool xyz = true;

        do
        {
            Console.WriteLine("Digite uma opção entre 1 e 3: "); // Heurística #3 (Controle e Liberdade)
            int opcao;
            bool validInput = int.TryParse(Console.ReadLine(), out opcao);

            if (!validInput)
            {
                Console.WriteLine("Entrada inválida. Por favor, digite um número.");
                continue;
            }

            if (opcao == 1)
            {
                Console.WriteLine("[Estágio 1 de 3] Escolha de lanche"); // Heurística #1 (Visibilidade do Status)
                Console.WriteLine("Digite um código entre 1 e 10: ");
                int lanche;
                validInput = int.TryParse(Console.ReadLine(), out lanche);

                if (!validInput)
                {
                    Console.WriteLine("Entrada inválida. Por favor, digite um número.");
                }
                else if (lanche < 1 || lanche > 10)
                {
                    Console.WriteLine("Código " + lanche + " é inválido."); // Heurística #9 (Ajuda e Erros)
                }
                else
                {
                    Console.WriteLine("Combo " + lanche + " selecionado");
                }
            }

            if (opcao == 2)
            {
                Console.WriteLine("[Estágio 2 de 3] Identificação"); //Heurística #1 (Visibilidade do Status)
                Console.WriteLine("Digite seu nome: ");
                string nome = Console.ReadLine();
            }

            if (opcao == 3)
            {
                Console.WriteLine("[Estágio 3 de 3] Pagamento"); //Heurística #1 (Visibilidade do Status)
                Random rnd = new Random();
                int randomInt = rnd.Next(0, 21);
                Console.WriteLine("Total: R$ " + randomInt + ".00");
                Console.WriteLine("Pagamento concluído! Tenha uma boa refeição!");
            }

            //break;

        } while (xyz == true);
    }
}
