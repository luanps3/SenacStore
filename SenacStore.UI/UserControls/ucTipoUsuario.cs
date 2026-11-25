using SenacStore.Application.Interfaces;
using SenacStore.UI.Navigation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SenacStore.UI.UserControls
{
    public partial class ucTipoUsuario : UserControl
    {
        private readonly ICrudNavigator _nav;
        private readonly ITipoUsuarioService _service;
        private readonly Guid? _id;

        public ucTipoUsuario(ICrudNavigator nav, ITipoUsuarioService service, Guid? id = null)
        {
            InitializeComponent();
            _nav = nav;
            _service = service;
            _id = id;
        }
    }
}
