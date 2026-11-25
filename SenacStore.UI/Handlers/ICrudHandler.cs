// Finalidade: Interface que define as operações CRUD que os
// handlers devem implementar.
// Cada handler adapta um serviço/entidade ao ucCrudPadrao
// (criar, listar, editar, deletar)

namespace SenacStore.UI.Handlers
{
    public interface ICrudHandler
    {
        string Titulo { get; }

        Task<object> ObterTodosAsync();

        Task<object> BuscarPorNomeAsync(string termo);

        void Criar();

        void Editar(Guid id);

        Task DeletarAsync(Guid id);
    }
}
