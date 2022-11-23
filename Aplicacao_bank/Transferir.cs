using System;
using System.ComponentModel.Design;
using System.Threading;

namespace Aplicacao_bank
{

    public static class Transferir
    {
        public static float taxa_doc = 10.90F;
        public static float taxa_ted = 12.90F;
        public static void TransferirValor()
        {
            Console.Clear();
            Show();
            Opcao();
        }

        public static void Show()
        {

            Console.WriteLine("========================");
            Console.WriteLine("======TRANSFERIR VALOR=======");
            Console.WriteLine("");
            Console.WriteLine("1 - DOC");
            Console.WriteLine("2 - TED");
            Console.WriteLine("3 - Voltar");
            Console.WriteLine("========================");
        }

        public static void Opcao()
        {
            var opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1: Doc(); break;
                case 2: Ted(); break;
                case 3: Menu.Show(); break;
                default: TransferirValor(); break;
            }
        }

        public static void Doc()
        {
            Console.Clear();
            Console.WriteLine("========================");
            Console.WriteLine("======TRANSFERIR POR DOC======");
            Console.WriteLine("");

            Console.Write("Digite o n�mero da conta: ");
            var numero_conta = float.Parse(Console.ReadLine());
            Console.Write("CPF do destinat�rio: ");
            var numero_cpf = float.Parse(Console.ReadLine());
            Console.Write("Valor: R$ ");
            var valor = float.Parse(Console.ReadLine());

            Console.WriteLine("Taxa Doc: R$ 10,90");

            Console.WriteLine($"Total : {Soma(valor, taxa_doc).ToString("C")}");
            Console.WriteLine("========================");

            Thread.Sleep(3000);


            var total = Soma(valor, taxa_doc);
            if (total <= Deposito.saldo_hoje)
            {
                RetirarSaldoTransferencia(valor, taxa_doc);
                Extrato.GuardarDadosNoExtrato("Doc:", total);
                Console.Clear();
                Console.WriteLine("========================");
                Console.WriteLine("TRANSFER�NCIA REALIZADA COM SUCESSO");
                Console.WriteLine("");
                Console.WriteLine("========================");
                Thread.Sleep(3000);
                Console.Clear();
                TransferirValor();
            }
            else
            {
                Console.WriteLine("========================");
                Console.WriteLine("ATEN��O: Saldo insuficiente para realizar a transfer�ncia !");
                Console.WriteLine("========================");
                Thread.Sleep(3000);
                Console.Clear();
                TransferirValor();
            }
        }

        public static void Ted()
        {
            Console.Clear();
            Console.WriteLine("========================");
            Console.WriteLine("======TRANSFERIR POR TED======");
            Console.WriteLine("");
            Console.Write("Digite o n�mero da conta: ");
            var numero_conta = float.Parse(Console.ReadLine());
            Console.Write("CPF do destinat�rio: ");
            var numero_cpf = float.Parse(Console.ReadLine());
            Console.Write("Valor: R$ ");
            var valor = float.Parse(Console.ReadLine());

            Console.WriteLine("Taxa Doc: R$ 10,90");

            Console.WriteLine($"Total : R$ {Soma(valor, taxa_ted).ToString("F")}");
            Console.WriteLine("========================");

            Thread.Sleep(2000);
            var total = Soma(valor, taxa_ted);
            if (total <= Deposito.saldo_hoje)
            {
                RetirarSaldoTransferencia(valor, taxa_ted);
                Extrato.GuardarDadosNoExtrato("Ted:", total);
                Console.Clear();
                Console.WriteLine("========================");
                Console.WriteLine("TRANSFER�NCIA REALIZADA COM SUCESSO");
                Console.WriteLine("");
                Console.WriteLine("========================");
                Thread.Sleep(3000);
                Console.Clear();
                TransferirValor();
            }
            else
            {
                Console.WriteLine("========================");
                Console.WriteLine("ATEN��O: Saldo insuficiente para realizar a transfer�ncia !");
                Console.WriteLine("========================");
                Thread.Sleep(3000);
                Console.Clear();
                TransferirValor();
            }
        }

        public static float Soma(float valor1, float valor2)
        {
            var total = valor1 + valor2;
            return total;
        }

        public static void RetirarSaldoTransferencia(float valor, float taxa)
        {
            float taxa_valor = valor + taxa;
            Deposito.saldo_hoje -= taxa_valor;
        }
    }

}


   