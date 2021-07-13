using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;

namespace Ex1_feito_em_casa
{
    class ModuloUsuario
    {
        UsuarioRepository repository = new UsuarioRepository();
        public void Create()
        {
            string resposta = "";
            do
            {
                Console.WriteLine("\n----------------------------- \nCadastro de Usuário\n");

                Console.Write("Digite seu primeiro nome: ");
                string nome = Validacao.ValidaString();
                nome = Char.ToUpper(nome[0]) + nome.Substring(1);

                Console.Write("Digite seu sobrenome: ");
                string sobrenome = Validacao.ValidaString();
                sobrenome = Char.ToUpper(sobrenome[0]) + sobrenome.Substring(1);

                Console.Write("Digite sua Idade: ");
                int idade = Validacao.ValidaInteiro();

                Console.Write("Digite seu email: ");
                string email = Validacao.ValidaString();

                Console.Write("Digite seu endereço: ");
                string endereco = Validacao.ValidaString();

                Console.Clear();

                Console.WriteLine($"Usuário {nome} {sobrenome} criado com sucesso \n--------------------------------");
                Usuario model = new Usuario(nome, sobrenome, idade, email, endereco);
                repository.Create(model);

                Console.WriteLine("Deseja cadastrar mais 1? (y/n)");
                resposta = Console.ReadLine();
            } while (resposta == "y");
        }
    }
}
