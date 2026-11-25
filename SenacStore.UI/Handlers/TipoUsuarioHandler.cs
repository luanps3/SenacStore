

using SenacStore.Application.Interfaces;
using SenacStore.UI.Navigation;
using SenacStore.UI.UserControls;

namespace SenacStore.UI.Handlers
{
    public class TipoUsuarioHandler : ICrudHandler
    {
        private readonly ICrudNavigator _nav;
        private readonly ITipoUsuarioService _service;

        public string Titulo => "Tipo de Usuário";

        public TipoUsuarioHandler(ICrudNavigator nav, ITipoUsuarioService service)
        {
            _nav = nav;
            _service = service;
        }

        public async Task<object> ObterTodosAsync()
        {
            var tipos = await _service.ObterTodosAsync();

            return tipos
                .Select(tipo => new { tipo.Id, tipo.Nome })
                .ToList();
        }

        public void Criar()
        {
            _nav.Abrir(new ucTipoUsuario(_nav, _service));
        }

        public async Task<object> BuscarPorNomeAsync(string termo)
        {
            var tipos = await _service.BuscarPorNomeAsync(termo);

            return tipos
                .Select(t => new { t.Id, t.Nome })
                .ToList();
        }

        public void Editar(Guid id)
        {
            _nav.Abrir(new ucTipoUsuario(_nav, _service, id));
        }

        public async Task DeletarAsync(Guid id)
        {
            await _service.DeletarAsync(id);
        }
    }
}
