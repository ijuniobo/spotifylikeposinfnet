﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SpotifyLike.Repository;

#nullable disable

namespace SpotifyLike.Repository.Migrations
{
    [DbContext(typeof(SpotifyLikeContext))]
    partial class SpotifyLikeContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MusicaPlaylist", b =>
                {
                    b.Property<Guid>("MusicasId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("PlaylistsId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("MusicasId", "PlaylistsId");

                    b.HasIndex("PlaylistsId");

                    b.ToTable("MusicaPlaylist");
                });

            modelBuilder.Entity("Spotifylike.Domain.Conta.Aggregates.Assinatura", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit");

                    b.Property<DateTime>("DtAtivacao")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("PlanoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("UsuarioId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("PlanoId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Assinatura", (string)null);
                });

            modelBuilder.Entity("Spotifylike.Domain.Conta.Aggregates.Playlist", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DtCriacao")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("Publica")
                        .HasColumnType("bit");

                    b.Property<Guid>("UsuarioId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Playlist", (string)null);
                });

            modelBuilder.Entity("Spotifylike.Domain.Conta.Aggregates.Usuario", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DtNascimento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Usuario", (string)null);
                });

            modelBuilder.Entity("Spotifylike.Domain.Notificacao.Notificacao", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DtNotificacao")
                        .HasColumnType("datetime2");

                    b.Property<string>("Mensagem")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<int>("TipoNotificacao")
                        .HasColumnType("int");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<Guid>("UsuarioDestinoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("UsuarioRemetenteId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioDestinoId");

                    b.HasIndex("UsuarioRemetenteId");

                    b.ToTable("Notificacao", (string)null);
                });

            modelBuilder.Entity("Spotifylike.Domain.Streaming.Aggregates.Album", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("BandaId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("BandaId");

                    b.ToTable("Album", (string)null);
                });

            modelBuilder.Entity("Spotifylike.Domain.Streaming.Aggregates.Banda", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Backdrop")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Banda", (string)null);
                });

            modelBuilder.Entity("Spotifylike.Domain.Streaming.Aggregates.Musica", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("AlbumId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("AlbumId");

                    b.ToTable("Musica", (string)null);
                });

            modelBuilder.Entity("Spotifylike.Domain.Streaming.Aggregates.Plano", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(1024)
                        .HasColumnType("nvarchar(1024)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Plano", (string)null);
                });

            modelBuilder.Entity("Spotifylike.Domain.Transacao.Aggregates.Cartao", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit");

                    b.Property<string>("Numero")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<Guid?>("UsuarioId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Cartao", (string)null);
                });

            modelBuilder.Entity("Spotifylike.Domain.Transacao.Aggregates.Transacao", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CartaoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("DtTransacao")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CartaoId");

                    b.ToTable("Transacao", (string)null);
                });

            modelBuilder.Entity("MusicaPlaylist", b =>
                {
                    b.HasOne("Spotifylike.Domain.Streaming.Aggregates.Musica", null)
                        .WithMany()
                        .HasForeignKey("MusicasId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Spotifylike.Domain.Conta.Aggregates.Playlist", null)
                        .WithMany()
                        .HasForeignKey("PlaylistsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Spotifylike.Domain.Conta.Aggregates.Assinatura", b =>
                {
                    b.HasOne("Spotifylike.Domain.Streaming.Aggregates.Plano", "Plano")
                        .WithMany()
                        .HasForeignKey("PlanoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Spotifylike.Domain.Conta.Aggregates.Usuario", null)
                        .WithMany("Assinaturas")
                        .HasForeignKey("UsuarioId");

                    b.Navigation("Plano");
                });

            modelBuilder.Entity("Spotifylike.Domain.Conta.Aggregates.Playlist", b =>
                {
                    b.HasOne("Spotifylike.Domain.Conta.Aggregates.Usuario", "Usuario")
                        .WithMany("Playlists")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("Spotifylike.Domain.Notificacao.Notificacao", b =>
                {
                    b.HasOne("Spotifylike.Domain.Conta.Aggregates.Usuario", "UsuarioDestino")
                        .WithMany("Notificacoes")
                        .HasForeignKey("UsuarioDestinoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Spotifylike.Domain.Conta.Aggregates.Usuario", "UsuarioRemetente")
                        .WithMany()
                        .HasForeignKey("UsuarioRemetenteId");

                    b.Navigation("UsuarioDestino");

                    b.Navigation("UsuarioRemetente");
                });

            modelBuilder.Entity("Spotifylike.Domain.Streaming.Aggregates.Album", b =>
                {
                    b.HasOne("Spotifylike.Domain.Streaming.Aggregates.Banda", null)
                        .WithMany("Albums")
                        .HasForeignKey("BandaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Spotifylike.Domain.Streaming.Aggregates.Musica", b =>
                {
                    b.HasOne("Spotifylike.Domain.Streaming.Aggregates.Album", null)
                        .WithMany("Musicas")
                        .HasForeignKey("AlbumId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.OwnsOne("Spotifylike.Domain.Streaming.ValueObjects.Duracao", "Duracao", b1 =>
                        {
                            b1.Property<Guid>("MusicaId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<int>("Valor")
                                .HasMaxLength(50)
                                .HasColumnType("int");

                            b1.HasKey("MusicaId");

                            b1.ToTable("Musica");

                            b1.WithOwner()
                                .HasForeignKey("MusicaId");
                        });

                    b.Navigation("Duracao")
                        .IsRequired();
                });

            modelBuilder.Entity("Spotifylike.Domain.Streaming.Aggregates.Plano", b =>
                {
                    b.OwnsOne("Spotifylike.Domain.Core.ValueObjects.Monetario", "Valor", b1 =>
                        {
                            b1.Property<Guid>("PlanoId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<decimal>("Valor")
                                .HasColumnType("decimal(18,2)");

                            b1.HasKey("PlanoId");

                            b1.ToTable("Plano");

                            b1.WithOwner()
                                .HasForeignKey("PlanoId");
                        });

                    b.Navigation("Valor")
                        .IsRequired();
                });

            modelBuilder.Entity("Spotifylike.Domain.Transacao.Aggregates.Cartao", b =>
                {
                    b.HasOne("Spotifylike.Domain.Conta.Aggregates.Usuario", null)
                        .WithMany("Cartoes")
                        .HasForeignKey("UsuarioId");

                    b.OwnsOne("Spotifylike.Domain.Core.ValueObjects.Monetario", "Limite", b1 =>
                        {
                            b1.Property<Guid>("CartaoId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<decimal>("Valor")
                                .HasColumnType("decimal(18,2)")
                                .HasColumnName("Limite");

                            b1.HasKey("CartaoId");

                            b1.ToTable("Cartao");

                            b1.WithOwner()
                                .HasForeignKey("CartaoId");
                        });

                    b.Navigation("Limite")
                        .IsRequired();
                });

            modelBuilder.Entity("Spotifylike.Domain.Transacao.Aggregates.Transacao", b =>
                {
                    b.HasOne("Spotifylike.Domain.Transacao.Aggregates.Cartao", null)
                        .WithMany("Transacoes")
                        .HasForeignKey("CartaoId");

                    b.OwnsOne("Spotifylike.Domain.Core.ValueObjects.Monetario", "Valor", b1 =>
                        {
                            b1.Property<Guid>("TransacaoId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<decimal>("Valor")
                                .HasColumnType("decimal(18,2)")
                                .HasColumnName("ValorTransacao");

                            b1.HasKey("TransacaoId");

                            b1.ToTable("Transacao");

                            b1.WithOwner()
                                .HasForeignKey("TransacaoId");
                        });

                    b.OwnsOne("Spotifylike.Domain.Transacao.ValueObjects.Merchant", "Merchant", b1 =>
                        {
                            b1.Property<Guid>("TransacaoId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<string>("Nome")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)")
                                .HasColumnName("MerchantNome");

                            b1.HasKey("TransacaoId");

                            b1.ToTable("Transacao");

                            b1.WithOwner()
                                .HasForeignKey("TransacaoId");
                        });

                    b.Navigation("Merchant")
                        .IsRequired();

                    b.Navigation("Valor")
                        .IsRequired();
                });

            modelBuilder.Entity("Spotifylike.Domain.Conta.Aggregates.Usuario", b =>
                {
                    b.Navigation("Assinaturas");

                    b.Navigation("Cartoes");

                    b.Navigation("Notificacoes");

                    b.Navigation("Playlists");
                });

            modelBuilder.Entity("Spotifylike.Domain.Streaming.Aggregates.Album", b =>
                {
                    b.Navigation("Musicas");
                });

            modelBuilder.Entity("Spotifylike.Domain.Streaming.Aggregates.Banda", b =>
                {
                    b.Navigation("Albums");
                });

            modelBuilder.Entity("Spotifylike.Domain.Transacao.Aggregates.Cartao", b =>
                {
                    b.Navigation("Transacoes");
                });
#pragma warning restore 612, 618
        }
    }
}
