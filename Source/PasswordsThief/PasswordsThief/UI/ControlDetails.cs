using System.Windows.Forms;
using Core.UIItems;
using System.ComponentModel;

namespace PasswordsThief.UI
{
    public partial class ControlDetails : Form
    {
        private ControlDetails() { }

        public ControlDetails(UIItem uiItem)
        {
            InitializeComponent();

            dgvControlDetails.DataError += On_dgvControlDetails_DataError;
            dgvControlDetails.AutoGenerateColumns = true;
            dgvControlDetails.DataSource = TypeDescriptor.GetProperties(uiItem);

        }

        private void On_dgvControlDetails_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            
        }
    }
}
