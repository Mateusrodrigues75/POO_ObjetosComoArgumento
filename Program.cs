using System;
using POO_ObjetosComoArgumento.classes;

namespace POO_ObjetosComoArgumento
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p1 = new Produto(001, "Notebook Samsung X40", 2500f);
            Produto p2 = new Produto(002, "IPhone 8 Plus", 3400f);
            Produto p3 = new Produto(003, "Televisão Samsung 32'", 2000f);
            Produto p4 = new Produto(004, "Teclado HyperX Alloy Core", 300f);

            Console.Clear();
            Console.WriteLine($"-----Bem Vindo ao Sistema de Compras-----");
            int opcao = 0;
            do
            {
                Console.WriteLine($"Digite a Opção desejada: ");
                Console.WriteLine($"[1] - Mostrar Produtos");
                Console.WriteLine($"[2] - Adicionar Produto ao carrinho");
                Console.WriteLine($"[3] - Mostrar Itens presentes no carrinho");
                Console.WriteLine($"[4] - Remover item do carrinho");
                Console.WriteLine($"[0] - Sair da Aplicação");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:

                        break;
                    case 2:

                        break;
                    case 3:

                        break;
                    case 4:

                        break;
                    case 5:

                        break;
                    default:
                    Console.WriteLine($"Opção Inválida");
                    
                        break;
                }
                
                
                
            } while (opcao !=0);
            
        }
    }
}
