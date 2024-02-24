﻿using Spotifylike.Domain.Conta.Aggregates;
using Spotifylike.Domain.Transacao.Aggregates;
using SpotifyLike.Application.Conta.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyLike.Application.Conta.Profile
{
    public class UsuarioProfile : AutoMapper.Profile
    {
        public UsuarioProfile()
        {
            CreateMap<UsuarioDto, Usuario>();

            CreateMap<Usuario, UsuarioDto>()
            .AfterMap((s, d) =>
            {
                var plano = s.Assinaturas?.FirstOrDefault(a => a.Ativo)?.Plano;

                if (plano != null)
                    d.PlanoId = plano.Id;

                d.Senha = "xxxxxxxxx";

            });

            CreateMap<CartaoDto, Cartao>()
                .ForPath(x => x.Limite.Valor, m => m.MapFrom(f => f.Limite))
                .ReverseMap();
        }
    }
}
