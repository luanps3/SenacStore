using SenacStore.Infrastructure.Services;
using SenacStore.UI.Handlers;
using SenacStore.UI.InterfacesUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SenacStore.UI.UserControls
{
    public partial class ucCrudPadrao : UserControl, IRefreshable
    {
        private const int EsperaBuscaMs = 300; // Tempo de espera para buscar os dados após digitar no campo de busca (em milissegundos).
        private readonly ICrudHandler _handler;
        private List<object> _allData = new List<object>();
        private int _consultaAtual;

        public ucCrudPadrao(ICrudHandler handler)
        {
            InitializeComponent();
            _handler = handler;
        }

        public async Task RefreshGridAsync()
        {
            var consulta = ++_consultaAtual; // Esta passa a ser a consulta mais recente

            try
            {
                var data = await _handler.ObterTodosAsync() as System.Collections.IEnumerable; // Obtém dados via handler

                if (consulta != _consultaAtual || IsDisposed) return; // Resultado velho ou tela fechada: descarta

                dgvDados.DataSource = null; // Remove fonte para forçar rebind limpo
                _allData = data?.Cast<object>().ToList() ?? new List<object>(); // Converte e armazena no cache
                dgvDados.DataSource = _allData; // Atribui a lista ao DataGridView
            }
            catch (ApiException ex)
            {
                // Mostra o erro apenas se esta ainda for a consulta mais recente
                if (consulta == _consultaAtual)
                    mdMessage.Show(ex.Message, "Erro");
            }
        }


    }
}
