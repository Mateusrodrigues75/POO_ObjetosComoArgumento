using System;
using System.Collections.Generic;

namespace POO_ObjetosComoArgumento.classes
{
    public class Produto
    {

        List<Produto> produtos = new List<Produto>();
        public int Codigo { get; set; }
        public string Nome { get; set; }
        
        public float Preco { get; set; }
        public Produto()
        {
        }

        public Produto(int _codigo, string _nome, float _preco)
        {
            Codigo = _codigo;
            Nome = _nome;
            Preco = _preco;
        }
        
        
    }
}