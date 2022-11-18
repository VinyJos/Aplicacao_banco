

using System;
using System.ComponentModel.Design;

public static class Pagar
{
    public static void PagarConta()
    {
        Show();

        var opcao = int.Parse(Console.ReadLine());
        switch (opcao)
        {
            case 1: ShowBoleto(); break;
            case 2: Console.WriteLine("cartão"); break;
            case 3: Menu.Show();break;
        }

        
    }

    public static void PagarBoleto()
    {
        
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

        Console.Write("Digite o código de barras : ");
        var codigo = float.Parse(Console.ReadLine());

        Console.Write("Digite o valor do boleto : ");
        var valor = float.Parse(Console.ReadLine());

        Console.WriteLine("========================");


        if (valor <= Deposito.saldo_hoje)
        {
            RetirarSaldo(valor);
            Console.Clear();
            Console.WriteLine("========================");
            Console.WriteLine("======BOLETO PAGO=======");
            Console.WriteLine("")
            Console.WriteLine("")
            Console.WriteLine("========================");

        }
        else
        {
            Console.WriteLine("========================");
            Console.WriteLine("ATENÇÃO: Saldo insuficiente para pagar esse boleto!");
            Console.WriteLine("========================");
        }
        Console.Clear();
        Pagar.Show();

    }

    public static void RetirarSaldo(float valor)
    {
        //float saldo_hoje = 0;
        Deposito.saldo_hoje -= valor;


    }



}