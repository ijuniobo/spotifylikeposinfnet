﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotifylike.Domain.Streaming.Aggregates
{
    public class Banda
    {
        public Guid Id { get; set; }

        public String Nome { get; set; }

        public String Descricao { get; set; }

        public String Brackdrop { get; set; }

        public List<Album> Albums { get; set; } = new List<Album>();


    }
}
