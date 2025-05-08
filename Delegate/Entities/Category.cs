using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Tier { get; set; }

        public Category(int id, string nome, int tier)
        {
            Id = id;
            Nome = nome;
            Tier = tier;
        }
    }
}
