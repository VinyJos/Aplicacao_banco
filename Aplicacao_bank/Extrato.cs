using System;
using System.Collections.Generic;
using System.Globalization;

namespace Aplicacao_bank
{
    public static class Extrato
    {
        public static List<float> extrato = new List<float>();
        public static List<string> titulo = new List<string>();

        public static void ImpressaoExtrato()
        {
            Console.Clear();

            Console.WriteLine("=========EXTRATO========");
            Console.WriteLine("");
            for (int index = 0; index < extrato.Count; index++)
            {
                Console.Write(titulo[index]);

                float valor = extrato[index];
                Console.WriteLine(valor.ToString(
                    "C",
                    CultureInfo.CreateSpecificCulture("pt-BR")
                    ));
            }
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Saldo.Voltar();
        }

        public static void GuardarDadosNoExtrato(string texto, float valor)
        {
            extrato.Insert(0, valor);
            titulo.Insert(0, texto);
        }

        public static void Opcoes()
        {
            Console.WriteLine("");
        }
    }

}