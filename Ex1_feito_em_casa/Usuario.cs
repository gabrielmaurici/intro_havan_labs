using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;

namespace Ex1_feito_em_casa
{
    class Usuario
    {
        public string nome = String.Empty;
        public string sobrenome = String.Empty;
        public int idade = 0;
        public string email = String.Empty;
        public string endereco = String.Empty;

        public void Cadastro()
        {
            Console.WriteLine("\n----------------------------- \nCadastro de Usuário\n");

            Console.Write("Digite seu primeiro nome: ");
            this.nome = Validacao.ValidaString();
            this.nome = Char.ToUpper(this.nome[0]) + this.nome.Substring(1);

            Console.Write("Digite seu sobrenome: ");
            this.sobrenome = Validacao.ValidaString();
            this.sobrenome = Char.ToUpper(this.sobrenome[0]) + this.sobrenome.Substring(1);

            Console.Write("Digite sua Idade: ");
            this.idade = Validacao.ValidaInteiro();

            Console.Write("Digite seu email: ");
            this.email = Validacao.ValidaString();

            Console.Write("Digite seu endereço: ");
            this.endereco = Validacao.ValidaString();

            Console.Clear();

            Console.WriteLine($"Usuário {this.nome} {this.sobrenome} criado com sucesso \n--------------------------------");
        }
    }
}