using System;
using System.Collections.Generic;
using System.Text;

namespace CapaEntidades
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string BarCode { get; set; }
        public decimal Price { get; set; }
        public int State { get; set; }
        public decimal Stock { get; set; }
        public decimal StockAlmacen { get; set; }
        public decimal CostPrice { get; set; }
        public decimal Utility { get; set; }
        public DateTime DueDate { get; set; }
        public Category Category { get; set; }
        public UMedida UMedida { get; set; }
    }
}
