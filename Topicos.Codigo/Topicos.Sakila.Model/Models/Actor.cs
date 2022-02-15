﻿using System;
using System.Collections.Generic;

namespace Topicos.Sakila.Model.Models
{
    public partial class Actor
    {
        public Actor()
        {
            FilmActors = new HashSet<FilmActor>();
        }

        public int ActorId { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public DateTime LastUpdate { get; set; }

        public virtual ICollection<FilmActor> FilmActors { get; set; }
    }
}
