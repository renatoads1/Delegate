using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate.Entities
{
    public class Product
    {
        public string Nome { get; set; }
        public double Valor { get; set; }

        public Product(string nome, double valor)
        {
            Nome = nome;
            Valor = valor;
        }
        public override string ToString(){
            return Nome +" - "+ Valor.ToString("F2");
        }
    }

}
