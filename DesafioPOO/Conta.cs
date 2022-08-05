using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioPOO
{
    public abstract class Conta
    {
        public string Nome { get; set; }
        protected int Telefone { get; set; }
        protected string Email { get; set; }
        private string Senha { get; set; }
        public string Cidade { get; set; }
        public int Avaliacao { get; set; }


        public void Cadastrar()
        {
            Console.WriteLine("Insira um nome:");
            Nome = Console.ReadLine();

            var verificacaoNome = int.TryParse(Nome, out var nome1);

            // Valida se foi digitado um nome ao invés de números
            while (verificacaoNome == true)
            {
                Console.WriteLine("Digite um nome válido, sem números!");
                Nome = Console.ReadLine();
                verificacaoNome = int.TryParse(Nome, out nome1);
            }

            Console.WriteLine("Insira um telefone:");
            Telefone = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira um e-mail:");
            Email = Console.ReadLine();

            Console.WriteLine("Insira uma senha:");
            Senha = Console.ReadLine();

            Console.WriteLine("Insira sua cidade:");
            Cidade = Console.ReadLine();

            Console.WriteLine("Cadastro feito com sucesso!"); 
        }

        public void Alterar()
        {
            Nome = Console.ReadLine();
            Telefone = int.Parse(Console.ReadLine());
            Email = Console.ReadLine();
            Senha = Console.ReadLine();
            Cidade = Console.ReadLine();

            Console.WriteLine("Alterações feitas com sucesso!"); 
        }

        public void Excluir()
        {
            Console.WriteLine("Tem certeza que deseja excluir essa conta?");

            Console.WriteLine("Conta excluída.");
            Environment.Exit(0);
        }

        public void Avaliar()
        {
            Console.WriteLine("Avaliar a corrida? (SIM ou PULAR)");
            string avaliacao1 = Console.ReadLine();
            
            if (avaliacao1.ToUpper() == "SIM")
            {
                Console.WriteLine("Avalie numa escala de 1 a 5, onde 1 é POUCO SATISFATÓRIO e 5 é EXCELENTE.");
                Avaliacao = int.Parse(Console.ReadLine());
                Console.WriteLine("Avaliação enviada!");
            }

            if (avaliacao1.ToUpper() == "PULAR")
            {
                Console.WriteLine("Obrigada por viajar conosco. Até a próxima!");
                Environment.Exit(0);
            }

        }

    }
}
