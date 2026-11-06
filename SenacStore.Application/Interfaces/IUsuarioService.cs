using SenacStore.Domain.Entities;

namespace SenacStore.Application.Interfaces
{
    public interface IUsuarioService
    {
        Task<List<Usuario>> ObterTodosAsync();

        Task<List<Usuario>> BuscarPorNomeAsync(string termo);

        Task<Usuario?> ObterPorIdAsync(Guid id);

        Task<Usuario> CriarAsync(Usuario usuario);

        Task AtualizarAsync(Usuario usuario);

        Task DeletarAsync(Guid id);
    }
}
