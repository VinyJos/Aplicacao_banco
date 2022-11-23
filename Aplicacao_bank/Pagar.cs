using System;
using System.ComponentModel.Design;
using System.Globalization;
using System.Threading;

namespace Aplicacao_bank
{
    public static class Pagar
    {
        public static float codigo;

        public static void PagarConta()
        {

            Show();
            Boleto();
        }

        public static void Boleto()
        {
            var opcao = int.Parse(Console.ReadLine());
            switch (opcao)
            {
                case 1: ShowBoleto(); break;
                case 2: Console.WriteLine("cartão"); break;
                case 3: Menu.Show(); break;
                default: Show(); break;
            }
        }

        public static void Show()
        {

            Console.WriteLine("========================");
            Console.WriteLine("======PAGAR CONTA=======");
            Console.WriteLine("");
            Console.WriteLine("1 - Pagar Boleto");
            Console.WriteLine("2 - Pagar Cartão de Credito");
            Console.WriteLine("3 - Voltar");
            Console.WriteLine("========================");
        }

        public static void ShowBoleto()
        {
            Console.Clear();
            Console.WriteLine("========================");
            Console.WriteLine("======PAGAR BOLETO=======");
            Console.WriteLine("");


            try
            {
                Console.Write("Digite o código de barras : ");
                codigo = float.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Código inválido ! ");
                Console.WriteLine($"Aceita apenas números {ex.InnerException}");
                Thread.Sleep(5000);
                ShowBoleto();
            }

            Console.Write("Digite o valor do boleto : ");
            var valor = float.Parse(Console.ReadLine());
            Console.WriteLine("========================");


            if (valor <= Deposito.saldo_hoje)
            {
                RetirarSaldo(valor);
                Extrato.GuardarDadosNoExtrato("Boleto:", valor);
                Console.Clear();
                Console.WriteLine("========================");
                Console.WriteLine("======BOLETO PAGO=======");
                Console.WriteLine("");
                Console.WriteLine("========================");
                Thread.Sleep(2000);
                Console.Clear();
                PagarConta();
            }
            else
            {
                Console.WriteLine("========================");
                Console.WriteLine("ATENÇÃO: Saldo insuficiente para pagar esse boleto!");
                Console.WriteLine("========================");
                Thread.Sleep(3000);
                Console.Clear();
                PagarConta();
            }

        }

        public static void RetirarSaldo(float valor)
        {
            //float saldo_hoje = 0;
            Deposito.saldo_hoje -= valor;

        }

    }
}
        
            

        

        


