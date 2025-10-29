using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
     class Pessoa
    {
        public Pessoa() {}
        public int id { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
        public Pessoa(string n)
        {
            this.Nome = n;
        }

        public Pessoa(string n,string s)
        {
            this.Nome = n;
            this.Senha = s;
        }
        public void CadastrarUsuario()
        {
            Console.WriteLine("qual seu numero de identificacao?");
            this.id = int.Parse(Console.ReadLine());
            Console.WriteLine("qual seu nome");
            this.Nome = Console.ReadLine();
            Console.WriteLine("qual sua senha");
            this.Senha = Console.ReadLine();

        }
   
    }
}
