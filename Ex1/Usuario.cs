using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;

namespace Class1
{
    class Usuario
    {
        public string nome = String.Empty;
        public string sobrenome = String.Empty;
        public int idade = 0;
        public string email = String.Empty;
        public string cidade = String.Empty;
        public string bairro = String.Empty;
        public string rua = String.Empty;
        public int casa = 0;
        public void CadastroUsuario()
        {
            
            Console.WriteLine("Digite seu nome: ");
            this.nome = Validacao.ValidaString();
            this.nome = Char.ToUpper(this.nome[0]) + this.nome.Substring(1);

            Console.WriteLine("Digite seu sobrenome: ");
            this.sobrenome = Validacao.ValidaString();
            this.sobrenome = char.ToUpper(this.sobrenome[0]) + this.sobrenome.Substring(1);

            Console.WriteLine($"{this.nome} {this.sobrenome}, digite sua idade: ");
            this.idade = Validacao.ValidaInt();

            Console.WriteLine($"{this.nome} {this.sobrenome}, digite seu e-mail: ");
            this.email = Console.ReadLine();

            Console.WriteLine("Digite sua cidade: ");
            this.cidade = Console.ReadLine();

            Console.WriteLine("Digite seu bairro: ");
            this.bairro = Console.ReadLine();

            Console.WriteLine("Digite sua rua: ");
            this.rua = Console.ReadLine();

            Console.WriteLine("Digite o número da sua casa: ");
            this.casa = Validacao.ValidaInt();

            Console.Write($" Usuário  {this.nome} {this.sobrenome} cadastrado com sucesso!");
        }

      
    }
}
