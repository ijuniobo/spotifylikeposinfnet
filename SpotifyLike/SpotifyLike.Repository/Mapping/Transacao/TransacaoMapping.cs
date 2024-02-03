using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Spotifylike.Domain.Core.ValueObjects;
using Spotifylike.Domain.Transacao.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyLike.Repository.Mapping.Transacao
{
    public class TransacaoMapping : IEntityTypeConfiguration<Spotifylike.Domain.Transacao.Aggregates.Transacao>
    {
        public void Configure(EntityTypeBuilder<Spotifylike.Domain.Transacao.Aggregates.Transacao> builder)
        {
            builder.ToTable(nameof(Spotifylike.Domain.Transacao.Aggregates.Transacao));

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.DtTransacao).IsRequired();
            builder.Property(x => x.Descricao).IsRequired().HasMaxLength(50);

            builder.OwnsOne<Merchant>(d => d.Merchant, c =>
            {
                c.Property(x => x.Nome).HasColumnName("MerchantNome").IsRequired();
            });

            builder.OwnsOne<Monetario>(d => d.Valor, c =>
            {
                c.Property(x => x.Valor).HasColumnName("ValorTransacao").IsRequired();
            });


        }
    }
}
