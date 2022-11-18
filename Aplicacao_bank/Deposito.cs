
public static class Deposito
{
    public static float saldo_hoje = 0;
    public static void ShowDepositar()
    {
        Console.Clear();
        Console.WriteLine("========================");
        Console.Write(" Digite o valor a ser depositado: R$ ");
        var valor = float.Parse(Console.ReadLine());
        Console.WriteLine("========================");
        Depositar(valor);
        OpcoesDP();

        var option = int.Parse(Console.ReadLine());
       

        switch(option)
        {
            case 1: ShowDepositar(); break;
            case 2: Menu.Show(); break;
            default: OpcoesDP(); break;
        }

    }

    public static void Depositar(float valor)
    {
        //float saldo_hoje = 0;
        saldo_hoje += valor;
        

    }

    public static void OpcoesDP()
    {
        Console.Clear();
        Console.WriteLine("========================");
        Console.WriteLine("DEPOSITO FEITO COM SUCESSO");
        Console.WriteLine();
        Console.WriteLine("1 - Depositar outro valor");
        Console.WriteLine("2 - Voltar ao menu inicial");
        Console.WriteLine("========================");

    }

}