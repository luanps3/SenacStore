

using SenacStore.Application.DTOs;
using SenacStore.Application.Interfaces;
using SenacStore.Domain.Entities;

namespace SenacStore.Infrastructure.Services
{
    public class CategoriaService : ICategoriaService
    {
        private const string Rota = "categorias";
        private readonly ApiClient _api;

        public CategoriaService(ApiClient api)
        {
            _api = api;
        }

        public async Task<List<Categoria>> ObterTodosAsync()
        {
            var dtos = await _api.GetAsync<List<CategoriaDto>>(Rota);
            return ParaLista(dtos);
        }

        public async Task<List<Categoria>> BuscarPorNomeAsync(string termo)
        {
            var dtos = await _api.GetAsync<List<CategoriaDto>>($"{Rota}?nome={Uri.EscapeDataString(termo)}");
            return ParaLista(dtos);
        }

        public async Task<Categoria?> ObterPorIdAsync(Guid id)
        {
            var dto = await _api.GetOuNuloAsync<CategoriaDto>($"{Rota}/{id}");
            return dto == null ? null : ParaEntidade(dto);            
        }

        public async Task<Categoria> CriarAsync(Categoria categoria)
        {
            var dto = await _api.PostAsync<CategoriaDto>(Rota, ParaRequest(categoria));
            return ParaEntidade(dto);
        }

        public async Task AtualizarAsync(Categoria categoria)
        {
            await _api.PutAsync($"{Rota}/{categoria.Id}", ParaRequest(categoria));        
        }

        public async Task DeletarAsync(Guid id)
        {
            await _api.DeleteAsync($"{Rota}/{id}");
        }
          


        private static CategoriaRequestDto ParaRequest(Categoria categoria)
        {
            return new CategoriaRequestDto { Nome = categoria.Nome };
        }


        private static List<Categoria> ParaLista(List<CategoriaDto>? dtos)
        {
            return dtos?.Select(ParaEntidade).ToList() ?? new List<Categoria>();
        }

        private static Categoria ParaEntidade(CategoriaDto dto)
        {
            return new Categoria{ Id = dto.Id, Nome = dto.Nome };
        }


    }
}
