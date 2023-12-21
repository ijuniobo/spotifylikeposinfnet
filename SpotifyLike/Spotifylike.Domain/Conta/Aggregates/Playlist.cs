using Spotifylike.Domain.Streaming.Aggregates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotifylike.Domain.Conta.Aggregates
{
    public class Playlist
    {
        public  Guid Id { get; set; }

        public String Nome { get; set; }

        public Boolean Publica { get; set; }

        public Usuario Usuario { get; set; }

        public List<Musica> Musicas { get; set; }

        public  DateTime DtCriacao { get; set; }
    }
}
