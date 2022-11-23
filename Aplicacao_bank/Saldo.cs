namespace Aplicacao_bank
{

    public static class Saldo
    {
        //static float saldo_hoje = 0;
        public static void MeuSaldo()
        {

            Console.WriteLine("========================");
            Console.Write("Saldo: ");
            Console.WriteLine(Deposito.saldo_hoje.ToString("C"));

            Console.WriteLine("");

            Voltar();
        }

        public static void Voltar()
        {

            Console.WriteLine("========================");
            Console.WriteLine(" 1 - Voltar");
            Console.WriteLine(" 2 - Sair");
            Console.WriteLine("========================");

            var opcao = short.Parse(Console.ReadLine());
            Menu.VoltarOption(opcao);
        }
    }
}