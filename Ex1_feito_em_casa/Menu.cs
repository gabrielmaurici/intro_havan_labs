﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;

namespace Ex1_feito_em_casa
{
    class Menu
    {
        public static void MontaMenu()
        {
            Cabecalho();
            Opcoes();
            Rodape();
            Escolha();
        }

        private static void Cabecalho()
        {
            Console.WriteLine("************ Bem-Vindo ************ \n************ Havan ************");
        }

        private static void Opcoes()
        {
            Console.WriteLine("0 - Sair \n1 - Cadastro de Usuário \n2 - Cadastro de Produtos");
        }

        private static void Rodape()
        {
            Console.WriteLine("----------------------------------------");
            Console.Write("\nEscolha uma das Opções do Menu: ");
        }

        private static void Escolha()
        {
            int opcao = 0;
            do
            {
                opcao = Validacao.ValidaInteiro();

                switch (opcao)
                {
                    case 0:
                        Console.WriteLine("Tchau");
                        break;
                    case 1:
                        string resposta = "";
                        List<Usuario> usuarios = new List<Usuario> ();
                        do
                        {
                            Usuario user = new Usuario();
                            user.Cadastro();
                            Console.WriteLine("Deseja cadastrar mais 1? (y/n)");
                            resposta = Console.ReadLine();
                            usuarios.Add(user);
                        } while (resposta == "y");

                        foreach(var item in usuarios)
                        {
                            Console.WriteLine($"\nNome: {item.nome} {item.sobrenome} \nIdade: {item.idade} \nEmail: {item.email} \nEndereço: {item.endereco} \n");
                        }

                        break;
                    case 2:
                        Console.WriteLine("Em implementação!!!");
                        break;
                    default:
                        Console.WriteLine("Opção Inválida! Digite uma das opções: ");
                        break;
                }
            } while (opcao < 0 || opcao > 2);
        }
    }
}