﻿using AutoMapper;
using SpotifyLike.Application.Conta.Dto;
using Spotifylike.Domain.Conta.Aggregates;
using Spotifylike.Domain.Streaming.Aggregates;
using Spotifylike.Domain.Transacao.Aggregates;
using SpotifyLike.Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpotifyLike.Domain.Core.Extension;

namespace SpotifyLike.Application.Conta
{
    public class UsuarioService
    {
        private IMapper Mapper { get; set; }
        private UsuarioRepository UsuarioRepository { get; set; }
        private PlanoRepository PlanoRepository { get; set; }


        public UsuarioService(IMapper mapper, UsuarioRepository usuarioRepository, PlanoRepository planoRepository)
        {
            Mapper = mapper;
            UsuarioRepository = usuarioRepository;
            PlanoRepository = planoRepository;
        }

        public UsuarioDto Criar(UsuarioDto dto)
        {
            if (this.UsuarioRepository.Exists(x => x.Email == dto.Email))
                throw new Exception("Usuario já existente na base");


            Plano plano = this.PlanoRepository.GetById(dto.PlanoId);

            if (plano == null)
                throw new Exception("Plano não existente ou não encontrado");

            Cartao cartao = this.Mapper.Map<Cartao>(dto.Cartao);

            Usuario usuario = new Usuario();
            usuario.CriarConta(dto.Nome, dto.Email, dto.Senha, dto.DtNascimento, plano, cartao);

            //TODO: GRAVAR MA BASE DE DADOS
            this.UsuarioRepository.Save(usuario);
            var result = this.Mapper.Map<UsuarioDto>(usuario);

            return result;

        }

        public UsuarioDto Obter(Guid id)
        {
            var usuario = this.UsuarioRepository.GetById(id);
            var result = this.Mapper.Map<UsuarioDto>(usuario);
            return result;
        }

        public UsuarioDto Autenticar(String email, String senha)
        {
            var usuario = this.UsuarioRepository.Find(x => x.Email == email && x.Senha == senha.HashSHA256()).FirstOrDefault();
            var result = this.Mapper.Map<UsuarioDto>(usuario);
            return result;
        }

    }
}
