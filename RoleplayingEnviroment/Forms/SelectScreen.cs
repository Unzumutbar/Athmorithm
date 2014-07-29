using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Atmorithm.Forms
{
    public partial class SelectScreen : Form
    {
        private List<Screen> _screenList;

        public SelectScreen()
        {
            InitializeComponent();
        }

        public MusicPlayer ParentForm
        {
            get
            {
                return (MusicPlayer)this.Owner;
            }
        }

        public void SetScreenList(List<Screen> newScreenList)
        {
            _screenList = newScreenList;
            comboBoxScreenList.Items.Clear();
            foreach (var screen in _screenList)
            {
                comboBoxScreenList.Items.Add(screen.DeviceName);
            }
        }

        private void buttonSave_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void comboBoxScreenList_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBoxScreenList.Text))
                return;

            var selectedScreen = _screenList.Where(t => t.DeviceName.ToLower() == comboBoxScreenList.Text.ToLower()).FirstOrDefault();
            if (selectedScreen == null)
                return;

            ParentForm.PictureViewerChangeScreenAndMaximize(selectedScreen);
        }
    }
}
