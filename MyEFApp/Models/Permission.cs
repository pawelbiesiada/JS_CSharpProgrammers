using System;
using System.Collections.Generic;

namespace MyEFApp.Models;

public partial class Permission
{
    public int Id { get; set; }

    public string Permission1 { get; set; } = null!;

    public string? Description { get; set; }

    public virtual ICollection<Group> Groups { get; } = new List<Group>();
}
