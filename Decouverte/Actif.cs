using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decouverte
{
    public class Actions
    {
        public string name;
        public float price;
        public Actions(string nom, float prix)
        {
            name = nom;
            price = prix;
        }
        public void Updateprice(float prix)
        {
            price = prix;
        }

    }
}
