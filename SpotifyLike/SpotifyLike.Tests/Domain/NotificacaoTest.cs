using Spotifylike.Domain.Conta.Aggregates;
using Spotifylike.Domain.Notificacao;
using Spotifylike.Domain.Streaming.Aggregates;
using Spotifylike.Domain.Transacao.Aggregates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyLike.Tests.Domain
{
    public class NotificacaoTest
    {
        [Fact]
        public async void DeveCriarNotificacaoComSucesso()
        {
            Plano plano = new Plano()
            {
                Descricao = "Lorem ipsum",
                Id = Guid.NewGuid(),
                Nome = "Plano Dummy",
                Valor = 19.90M
            };

            Cartao cartao = new Cartao()
            {
                Id = Guid.NewGuid(),
                Ativo = true,
                Limite = 1000M,
                Numero = "6465465466",
            };

            string nome = "Dummy Usuario";
            string email = "teste@teste.com";
            string senha = "123456";

            Usuario usuarioDestino = new Usuario();

            usuarioDestino.CriarConta(nome, email, senha, DateTime.Now, plano, cartao);

            TipoNotificacao  tipoNotificacao1 = Spotifylike.Domain.Notificacao.TipoNotificacao.Sistema;
            DateTime dtNotificacao = DateTime.Now;
            string mensagem = "Mensagem da Notificação";
            string titulo = "Titulo Mensagem";

            var notificacao = Notificacao.Criar(titulo, mensagem, tipoNotificacao1, usuarioDestino);

            //Assert
            Assert.NotNull(notificacao.UsuarioDestino);

            Assert.NotNull(notificacao.Mensagem);
            Assert.NotNull(notificacao.Titulo);

            Assert.True(usuarioDestino.Assinaturas.Count > 0);
            Assert.Same(usuarioDestino.Assinaturas[0].Plano, plano);
        }

        [Fact]
        public void NaoDeveNotificacaoSemRemetente()
        {
            Plano plano = new Plano()
            {
                Descricao = "Lorem ipsum",
                Id = Guid.NewGuid(),
                Nome = "Plano Dummy",
                Valor = 19.90M
            };

            Cartao cartao = new Cartao()
            {
                Id = Guid.NewGuid(),
                Ativo = true,
                Limite = 1000M,
                Numero = "6465465466",
            };

            string nome = "Dummy Usuario";
            string email = "teste@teste.com";
            string senha = "123456";

            Usuario usuarioDestino = new Usuario();

            usuarioDestino.CriarConta(nome, email, senha, DateTime.Now, plano, cartao);

            TipoNotificacao tipoNotificacao1 = Spotifylike.Domain.Notificacao.TipoNotificacao.Usuario;
            DateTime dtNotificacao = DateTime.Now;
            string mensagem = "Mensagem da Notificação";
            string titulo = "Titulo Mensagem";

            //Act
            Assert.Throws<ArgumentNullException>(() =>
            {
                var notificacao = Notificacao.Criar(titulo, mensagem, tipoNotificacao1, usuarioDestino);

            });

        }

        [Fact]
        public void NaoDeveNotificacaoSemTitulo()
        {
            Plano plano = new Plano()
            {
                Descricao = "Lorem ipsum",
                Id = Guid.NewGuid(),
                Nome = "Plano Dummy",
                Valor = 19.90M
            };

            Cartao cartao = new Cartao()
            {
                Id = Guid.NewGuid(),
                Ativo = true,
                Limite = 1000M,
                Numero = "6465465466",
            };

            string nome = "Dummy Usuario";
            string email = "teste@teste.com";
            string senha = "123456";

            Usuario usuarioDestino = new Usuario();

            usuarioDestino.CriarConta(nome, email, senha, DateTime.Now, plano, cartao);

            TipoNotificacao tipoNotificacao1 = Spotifylike.Domain.Notificacao.TipoNotificacao.Sistema;
            DateTime dtNotificacao = DateTime.Now;
            string mensagem = "Mensagem da Notificação";
            string titulo = "";

            //Act
            Assert.Throws<ArgumentNullException>(() =>
            {
                var notificacao = Notificacao.Criar(titulo, mensagem, tipoNotificacao1, usuarioDestino);

            });

        }

        [Fact]
        public void NaoDeveNotificacaoSemMensagem()
        {
            Plano plano = new Plano()
            {
                Descricao = "Lorem ipsum",
                Id = Guid.NewGuid(),
                Nome = "Plano Dummy",
                Valor = 19.90M
            };

            Cartao cartao = new Cartao()
            {
                Id = Guid.NewGuid(),
                Ativo = true,
                Limite = 1000M,
                Numero = "6465465466",
            };

            string nome = "Dummy Usuario";
            string email = "teste@teste.com";
            string senha = "123456";

            Usuario usuarioDestino = new Usuario();

            usuarioDestino.CriarConta(nome, email, senha, DateTime.Now, plano, cartao);

            TipoNotificacao tipoNotificacao1 = Spotifylike.Domain.Notificacao.TipoNotificacao.Sistema;
            DateTime dtNotificacao = DateTime.Now;
            string mensagem = "";
            string titulo = "Titulo Mensagem";

            //Act
            Assert.Throws<ArgumentNullException>(() =>
            {
                var notificacao = Notificacao.Criar(titulo, mensagem, tipoNotificacao1, usuarioDestino);

            });
        }

    }

}
