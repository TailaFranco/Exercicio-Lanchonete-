using System;
using System.Collections.Generic;
using lista.produto.classes;

namespace lista.produto
{
    class Program
    {
        static void Main(string[] args)
        {   Console.Clear();
            Console.WriteLine($"--------------------------------------------------");
            Console.WriteLine($"Lanchonete C-Nai");
            Console.WriteLine($"--------------------------------------------------");
            
            List<Produto> produtos = new  List<Produto>();
            Produto cafe = new Produto(2, "Café pequeno", 3.5f);
            produtos.Add(new Produto(1, "Pão na chapa", 2.5f));
            produtos.Add(cafe);
            produtos.Add(new Produto(3, "Coxinha", 5.5f));
            foreach (var item in produtos)
            {
                Console.WriteLine($"Código do produto {item.Codigo} \n Nome:{item.Nome} \n Preço R$ {item.Preco}");
                
            }
        }
    }
}
