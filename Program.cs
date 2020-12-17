using System;
using System.Collections.Generic;
using POO_ObjetosComoArgumento.classes;

namespace POO_ObjetosComoArgumento
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Produto> produtos = new List<Produto>();
            Carrinho newCarrinho = new Carrinho();
            Produto p1 = new Produto(1, "Notebook Samsung X40", 2500f);
            Produto p2 = new Produto(2, "IPhone 8 Plus", 3400f);
            Produto p3 = new Produto(3, "Televisão Samsung 32'", 2000f);
            Produto p4 = new Produto(4, "Teclado HyperX Alloy Core", 300f);
            produtos.Add(p1);
            produtos.Add(p2);
            produtos.Add(p3);
            produtos.Add(p4);

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
                        Console.ForegroundColor = ConsoleColor.Green;
                        foreach (Produto item in produtos)
                        {
                            Console.WriteLine($"Código {item.Codigo} - Nome: {item.Nome} R${item.Preco}");
                        }
                        Console.ResetColor();
                        break;
                    case 2:
                    int escolha;
                    do
                    {
                    Console.WriteLine($"Digite o código do produto que deseja que seja adicionado no carrinho: ");
                    Console.WriteLine($"Se não quiser adicionar nenhum item ao carrinho, digite 0");
                    
                    escolha = int.Parse(Console.ReadLine());
                    switch (escolha)
                    {
                        case 1:
                        newCarrinho.AdicionarProduto(p1);
                            break;
                        case 2:
                        newCarrinho.AdicionarProduto(p2);
                            break;
                        case 3:
                        newCarrinho.AdicionarProduto(p3);
                            break;
                        case 4:
                        newCarrinho.AdicionarProduto(p4);
                            break;
                        case 0:
                            return;
                        default:
                        Console.WriteLine($"Código Inválido");
                            break;
                        }
                    } while (escolha != 0);
                    
                    
                        break;
                    case 3:
                    newCarrinho.MostrarProdutosCarrinho();
                        break;
                    case 4:
                    do
                    {
                    Console.WriteLine($"Digite o código do produto que deseja que seja removido no carrinho: ");
                    Console.WriteLine($"Se não quiser remover nenhum item ao carrinho, digite 0");
                    
                    escolha = int.Parse(Console.ReadLine());
                    switch (escolha)
                    {
                        case 1:
                        newCarrinho.RemoverProduto(p1);
                            break;
                        case 2:
                        newCarrinho.RemoverProduto(p2);
                            break;
                        case 3:
                        newCarrinho.RemoverProduto(p3);
                            break;
                        case 4:
                        newCarrinho.RemoverProduto(p4);
                            break;
                        case 0:
                            return;
                        default:
                        Console.WriteLine($"Código Inválido");
                            break;
                        }
                    } while (escolha != 0);

                        break;
                    case 5:

                        break;
                    default:
                    Console.WriteLine($"Opção Inválida");
                    
                        break;
                }
                
                
                
            } while (opcao !=0);
            
        }

        private static void MostrarProdutos()
        {
            throw new NotImplementedException();
        }
    }
}
