using System;
using System.ComponentModel.DataAnnotations;
using System.Net.Mime;
using System.Reflection;

namespace ProductsApplication.Models
{
    public class Products
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public string Email { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime Registered_DateTime { get; set; }
    }
}