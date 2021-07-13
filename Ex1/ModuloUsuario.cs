using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;

namespace Class1

{
    class ModuloUsuario
    {
        UsuarioRepository repository = new UsuarioRepository();
        public void Create()
        {
            string change = "";
            do
            {
                Console.WriteLine("Digite seu nome: ");
                string nome = Validacao.ValidaString();
                nome = Char.ToUpper(nome[0]) + nome.Substring(1);
                Console.WriteLine("Digite seu sobrenome: ");
                string sobrenome = Validacao.ValidaString();
                sobrenome = char.ToUpper(sobrenome[0]) + sobrenome.Substring(1);
                Console.WriteLine($"{nome} {sobrenome}, digite sua idade: ");
                int idade = Validacao.ValidaInt();
                Console.WriteLine($"{nome} {sobrenome}, digite seu e-mail: ");
                string email = Console.ReadLine();
                Console.WriteLine("Digite seu endereço: ");
                string endereco = Console.ReadLine();

                Usuario model = new Usuario(nome, sobrenome, idade, email, endereco);
                repository.Create(model);       
                Console.WriteLine("Deseja cadastrar mais 1? y/n");
                change = Console.ReadLine();
            } while (change == "y");
                
        }
    }
}
