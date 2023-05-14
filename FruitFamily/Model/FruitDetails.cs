using System;
using System.Collections.Generic;

namespace FruitFamily.Model;

public partial class FruitDetails
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? family { get; set; }

    public string? genus { get; set; }

    public string? order { get; set; }
}
