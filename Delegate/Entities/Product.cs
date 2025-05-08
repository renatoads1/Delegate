using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Valor { get; set; }
        public double Price { get; set; }
        public Category Category { get; set; }

        public Product(string nome, double valor)
        {
            Nome = nome;
            Valor = valor;
        }
        public Product(int id, string nome, double valor, double price)
        {
            Id = id;
            Nome = nome;
            Valor = valor;
            Price = price;
        }

        public override string ToString(){
            return Id+" - "
                + Nome +" - "
                + Valor.ToString("F2")
                + " - "+ Price.ToString("F2")+" - "
                + Category.Nome+" - "
                + Category.Tier;
        }
    }

}
