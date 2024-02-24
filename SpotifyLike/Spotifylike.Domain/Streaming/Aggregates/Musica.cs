using Spotifylike.Domain.Conta.Aggregates;
using Spotifylike.Domain.Streaming.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotifylike.Domain.Streaming.Aggregates
{
    public class Musica
    {
        public Guid Id { get; set; }

        public String Nome { get; set; }

        public Duracao Duracao { get; set; }

        public virtual IList<Playlist> Playlists { get; set; } = new List<Playlist>();


    }
}
