using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;

namespace Class1
{
    class Menu
    {
        public static void MenuOpcoes()
        {
            Cabecalho();
            Opcoes();
            Escolhas();
        }

        private static void Cabecalho()
        {
            Console.WriteLine("======================= Bem - Vindo =======================");
            Console.WriteLine("======================= HAVAN LABS ========================\n");
        }
        private static void Opcoes()
        {
            Console.WriteLine("=================== Escolha uma opção: ====================\n" +
                "\n 1 - Cadastro Usuário \n 2 - Cadastro Produto \n 0 - Sair ");
        }
        private static void Escolhas()
        {
            int change = 0;
            do
            {
                change = Validacao.ValidaInt();
                switch (change)
                {
                    case 0:
                        Console.WriteLine("Saindo..");
                        break;
                    case 1:
                        string resposta = "";
                        List<Usuario> usuarios= new List<Usuario>();
                        do
                        {
                            Usuario user = new Usuario();
                            user.CadastroUsuario();
                            Console.WriteLine("Deseja cadastrar mais 1? y/n");
                            resposta = Console.ReadLine();
                            usuarios.Add(user);
                        } while (resposta == "y");

                        //Usuario userSelect1 = usuarios.FirstOrDefault(u => u.nome.Equals("joelma"));
                        //Usuario userSelect2 = (from u in usuarios where u.nome.Equals ("joelma") select u).First(); 

                        foreach (var item in usuarios)
                        {
                            Console.WriteLine($" Nome: {item.nome} {item.sobrenome}\n Idade: {item.idade}  \n E-mail: {item.email}\n Cidade: {item.cidade}\n" +
                            $" Bairro: {item.bairro}\n Rua: {item.rua}\n Numero da casa: {item.casa}\n");
                            
                        }
                        break;
                    case 2:
                        Console.WriteLine("EM MANUTENÇÃO");
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente!");
                        break;
                        
                }
            }
            while (change < 0 || change > 2);
        }

    }
}
