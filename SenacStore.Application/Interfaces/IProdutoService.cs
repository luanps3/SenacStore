using SenacStore.Domain.Entities;

namespace SenacStore.Application.Interfaces
{
    public interface IProdutoService
    {
        Task<List<Produto>> ObterTodosAsync();

        Task<List<Produto>> BuscarPorNomeAsync(string termo);

        Task<Produto?> ObterPorIdAsync(Guid id);

        Task<Produto> CriarAsync(Produto produto);

        Task AtualizarAsync(Produto produto);

        Task DeletarAsync(Guid id);
    }
}
