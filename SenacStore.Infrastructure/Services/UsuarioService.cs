using SenacStore.Application.DTOs;
using SenacStore.Application.Interfaces;
using SenacStore.Domain.Entities;

namespace SenacStore.Infrastructure.Services
{
    public class UsuarioService : IUsuarioService
    {
        private const string Rota = "usuarios";
        private readonly ApiClient _api;

        public UsuarioService(ApiClient api)
        {
            _api = api;
        }

        public async Task<List<Usuario>> ObterTodosAsync()
        {
            var dtos = await _api.GetAsync<List<UsuarioDto>>(Rota);
            return ParaLista(dtos);
        }

        public async Task<List<Usuario>> BuscarPorNomeAsync(string termo)
        {
            var dtos = await _api.GetAsync<List<UsuarioDto>>($"{Rota}?nome={Uri.EscapeDataString(termo)}");
            return ParaLista(dtos);
        }

        public async Task<Usuario?> ObterPorIdAsync(Guid id)
        {
            var dto = await _api.GetOuNuloAsync<UsuarioDto>($"{Rota}/{id}");
            return dto == null ? null : ParaEntidade(dto);
        }


        public async Task<Usuario> CriarAsync(Usuario usuario)
        {
            var dto = await _api.PostAsync<UsuarioDto>(Rota, ParaRequest(usuario));
            return ParaEntidade(dto);
        }

        public async Task AtualizarAsync(Usuario usuario)
        {
            await _api.PutAsync($"{Rota}/{usuario.Id}", ParaRequest(usuario));
        }

        public async Task DeletarAsync(Guid id)
        {
            await _api.DeleteAsync($"{Rota}/{id}");
        }


        private static List<Usuario> ParaLista(List<UsuarioDto>? dtos)
        {
            return dtos?.Select(ParaEntidade).ToList() ?? new List<Usuario>();
        }

        internal static Usuario ParaEntidade(UsuarioDto dto)
        {
            return new Usuario
            {
                Id = dto.Id,
                Nome = dto.Nome,
                Email = dto.Email,
                TipoUsuarioId = dto.TipoUsuarioId,
            };
        }

        private static UsuarioRequestDto ParaRequest(Usuario usuario)
        {
            return new UsuarioRequestDto
            {
                Nome = usuario.Nome,
                Email = usuario.Email,
                Senha = usuario.Senha,
                TipoUsuarioId = usuario.TipoUsuarioId
            };
        }

    }
}
