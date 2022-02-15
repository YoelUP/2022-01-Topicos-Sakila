using System;
using System.Collections.Generic;

namespace Topicos.Sakila.Model.Models
{
    public partial class FilmText
    {
        public short FilmId { get; set; }
        public string Title { get; set; } = null!;
        public string? Description { get; set; }
    }
}
