
using System;
using System.Collections.Generic;
using System.Globalization;

public static class Extrato
{
    public static List<float> extrato = new List<float>();
    public static List<string> titulo = new List<string>();

    public static void ImpressaoExtrato()
    {
        Console.Clear();
        for (int index = 0; index < extrato.Count; index++)
        {
            Console.Write(titulo[index] );

            float valor = extrato[index];
            Console.WriteLine( valor.ToString(
                "C",
                CultureInfo.CreateSpecificCulture("pt-BR")
                ));
        }
    }

    public static void GuardarDadosNoExtrato(string texto ,float valor)
    {
        extrato.Insert(0, valor);
        titulo.Insert(0, texto);
    }
}