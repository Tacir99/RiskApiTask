﻿using System.ComponentModel.DataAnnotations.Schema;

namespace Entity.Concrete;

public class Product
{
    public int Id { get; set; }

    public string Title { get; set; }

    public string Description { get; set; }

    public decimal Price { get; set; }

    public Category Category { get; set; }

    [ForeignKey(nameof(Category))]
    public int CategoryId { get; set; }

}
