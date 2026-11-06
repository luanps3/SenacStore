using SenacStore.Domain.Entities;

namespace SenacStore.Application.Interfaces
{
    public interface ICategoriaService
    {
        Task<List<Categoria>> ObterTodosAsync();

        // termo se refere ao texto que a pessoa ira pesquisar, caso ele não seja preenchido geralmente por padrão são retornadas todas categorias
        Task<List<Categoria>> BuscarPorNomeAsync(string termo);

        Task<Categoria?> ObterPorIdAsync(Guid id);

        Task<Categoria> CriarAsync(Categoria categoria);

        Task AtualizarAsync(Categoria categoria);

        Task DeletarAsync(Guid id);
            

    }
}
