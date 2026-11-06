using SenacStore.Domain.Entities;

namespace SenacStore.Application.Interfaces
{
    public interface ITipoUsuarioService
    {
        Task<List<TipoUsuario>> ObterTodosAsync();

        Task<List<TipoUsuario>> BuscarPorNomeAsync(string termo);

        Task<TipoUsuario?> ObterPorIdAsync(Guid id);

        Task<TipoUsuario> CriarAsync(TipoUsuario tipo);

        Task AtualizarAsync(TipoUsuario tipo);

        Task DeletarAsync(Guid id);
    }
}
