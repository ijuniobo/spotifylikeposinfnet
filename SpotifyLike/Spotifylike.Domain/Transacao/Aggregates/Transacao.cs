using Spotifylike.Domain.Core.ValueObjects;
using Spotifylike.Domain.Transacao.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotifylike.Domain.Transacao.Aggregates
{
    public class Transacao
    {
        public Guid Id { set; get; }

        public  DateTime DtTransacao { get; set; }

        public Monetario Valor { get; set; }

        public String Descricao { get; set; }

        public Merchant Merchant { get; set; }

    }
}
