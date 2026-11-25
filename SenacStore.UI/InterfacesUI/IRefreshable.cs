//Finalidade: Interface para definir o contrato de que é responsável pelo recarregamento das informações dos grids na UI
namespace SenacStore.UI.InterfacesUI
{
    public interface IRefreshable
    {
        Task RefreshGridAsync();
    }
}
