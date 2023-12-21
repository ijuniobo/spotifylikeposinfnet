using Spotifylike.Domain.Core.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotifylike.Domain.Streaming.Aggregates
{
    public class Plano
    {
        public Guid Id { get; set; }

        public String Nome { get; set; }

        public String Descricao { get; set; }

        public Monetario Valor { get; set; }
    }
}
