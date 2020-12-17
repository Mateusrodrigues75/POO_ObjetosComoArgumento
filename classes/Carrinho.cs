using System;
using System.Collections.Generic;

namespace POO_ObjetosComoArgumento.classes
{
    public class Carrinho
    {
       public float ValorTotal { get; set; }
       
       List<Produto> carrinho = new List<Produto>();

       public void AdicionarProduto(Produto produto)
       {
            carrinho.Add(produto);
       }

       public void RemoverProduto(Produto produto)
       {
           carrinho.Remove(produto);
       }

       public void AlterarItem(int _codigo, Produto _novoProduto)
       {
           carrinho.Find(x => x.Codigo == _codigo).Nome = _novoProduto.Nome;
           carrinho.Find(x => x.Codigo == _codigo).Preco = _novoProduto.Preco;
       }

       public void MostrarProdutosCarrinho()
       {
           if (carrinho != null)
           {
               foreach (Produto item in carrinho)
               {
                   Console.ForegroundColor = ConsoleColor.Green;
                   Console.WriteLine($"R${item.Preco.ToString("n2")} - {item.Nome}");
                   Console.ResetColor();        
               }
               MostrarTotal();
           }
       }

       public void MostrarTotal()
       {
           Console.ForegroundColor = ConsoleColor.Red;
           if (carrinho != null)
           {
               foreach (Produto item in carrinho)
               {
                   ValorTotal += item.Preco;
               }
               Console.WriteLine($"Total do Carrinho R${ValorTotal.ToString("n2")}");     
           }else
           {
               Console.WriteLine($"Seu carrinho ainda está vazio!");
           }
           Console.ResetColor();
           
       }
       
       
        
    }
}