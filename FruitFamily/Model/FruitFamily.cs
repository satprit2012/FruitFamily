using System;
using System.Collections.Generic;

namespace FruitFamily.Model;

public partial class FruitFamilyModel
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Family { get; set; }
    public string? Genus { get; set; }
    public string? FruitOrder { get; set; }
    public Nutrition? Nutrition { get; set; }
}
public class Nutrition
{
    public double? Carbohydrates { get; set; }
    public double? Protein { get; set; }
    public double? Fat { get; set; }
    public double? Calories { get; set; }
    public double? Sugar { get; set; }
}