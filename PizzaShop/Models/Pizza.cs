﻿namespace PizzaShop.Models
{
    public class Pizza
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public bool IsGlutenFree { get; set; }
        public string? Image { get; set; }
    }
}
