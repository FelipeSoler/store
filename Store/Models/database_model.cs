using System.Data.SqlTypes;

namespace Store.Models
{
    public class database_model
    {
        private int id { 
            get { return id; }
            set { id = value; }
        }
        private string sku {
            get { return sku; }
            set { sku = value; }  }
        string product_name {
            get { return product_name; } 
            set { product_name = value; } 
        }
        SqlMoney price {
            get { return price; } 
            set { price = value; } 
        }

    }
}
