public static class Menu
{
    public static void Show()
    {   
        Console.Clear();

        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.Clear();
        Console.WriteLine("========================");
        Console.WriteLine(" 1 - Saldo");
        Console.WriteLine(" 2 - Extrato");
        Console.WriteLine(" 3 - Pix");
        Console.WriteLine(" 4 - Pagar");
        Console.WriteLine(" 5 - Transferir");
        Console.WriteLine(" 6 - Depositar");
        Console.WriteLine(" 7 - Cartao de credito");
        Console.WriteLine(" Sair");
        Console.WriteLine("========================");
        
        string option = Console.ReadLine();
        
        MenuOption(option);
    }

    public static void MenuOption(string option)
    {
        Console.Clear();
        switch (option)
        {
            case "1": Saldo.MeuSaldo(); break;
            case "2": Extrato.ImpressaoExtrato(); break;
            case "3": Console.WriteLine("Pix"); break;
            case "4": Pagar.PagarConta(); break;
            case "5": Transferir.TransferirValor(); break;
            case "6": Deposito.ShowDepositar(); break;
            case "7": Console.WriteLine("Cartao de credito"); break;
            case "sair":
                {
                    Console.Clear();
                    Environment.Exit(0);
                    break;
                }
            default: Show(); break;
        }   
    }

    public static void Voltar()
    {
        
        Console.WriteLine("========================");
        Console.WriteLine(" 1 - Voltar");
        Console.WriteLine(" 2 - Sair");
        Console.WriteLine("========================");
    }

    public static void VoltarOption(short option)
    {
        switch(option)
        {
            case 1: Show(); break;
            case 2:
                {
                    Console.Clear();
                    Environment.Exit(0);
                    break;
                }
            default: Saldo.MeuSaldo();break;
        }
    }
}