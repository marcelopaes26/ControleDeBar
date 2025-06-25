﻿using ControleDeBar.ConsoleApp.Compartilhado;
using ControleDeBar.ConsoleApp.ModuloConta;

namespace ControleDeBar.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TelaPrincipal telaPrincipal = new TelaPrincipal();

            while (true)
            {
                telaPrincipal.ApresentarMenuPrincipal();

                ITela telaEscolhida = telaPrincipal.ObterTela();

                if (telaEscolhida == null)
                    break;

                char opcaoEscolhida = telaEscolhida.ApresentarMenu();

                if (char.ToUpper(opcaoEscolhida) == 'S')
                    break;

                if (telaEscolhida is TelaConta telaConta)
                {
                    switch (opcaoEscolhida)
                    {
                        case '1': telaConta.CadastrarRegistro(); break;

                        case '2': telaConta.ApresentarMenuGestaoPedidos(); break;

                        case '3': telaConta.VisualizarRegistros(true); break;
                    }
                }
                else
                {
                    switch (opcaoEscolhida)
                    {
                        case '1': telaEscolhida.CadastrarRegistro(); break;

                        case '2': telaEscolhida.EditarRegistro(); break;

                        case '3': telaEscolhida.ExcluirRegistro(); break;

                        case '4': telaEscolhida.VisualizarRegistros(true); break;
                    }
                }

            }
        }
    }
}