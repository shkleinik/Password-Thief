using System.Windows.Forms;
using Core.UIItems.WindowItems;
using Core.UIItems;

namespace PasswordsThief.UI
{
    public partial class ControlsView : Form
    {
        private ControlsView() { }

        public ControlsView(Window windowToView)
        {

                InitializeComponent();
                dgvControlsView.DataError += On_dgvControlsView_DataError;
                dgvControlsView.AutoGenerateColumns = true;
                dgvControlsView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;

                dgvControlsView.DataSource = windowToView.Items;

        }

        private void On_dgvControlsView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            
        }

        private void On_dgvControlsView_RowHeaderDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            (new ControlDetails((UIItem)dgvControlsView.SelectedRows[0].DataBoundItem)).ShowDialog();
        }
    }
}
