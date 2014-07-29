using System.Drawing;
using System.Windows.Forms;

namespace Atmorithm.Forms
{
    public partial class EditTickRate : Form
    {
        private bool IntervalIsValid = false;

        public EditTickRate()
        {
            InitializeComponent();
            decimal TickRateAsDecimal = Program.Settings.SlideShowTickRate;
            textBoxIntervall.Text = (TickRateAsDecimal / 6000).ToString();
        }

        public MusicPlayer ParentForm
        {
            get
            {
                return (MusicPlayer)this.Owner;
            }
        }

        private void textBoxIntervall_TextChanged(object sender, System.EventArgs e)
        {
            decimal ValidNumber;
            if (decimal.TryParse(textBoxIntervall.Text, out ValidNumber))
            {
                if (ValidNumber * 6000 <= int.MaxValue)
                {
                    IntervalIsValid = true;
                    textBoxIntervall.BackColor = Color.White;
                    buttonSave.Enabled = true;
                    return;
                }
            }
            IntervalIsValid = false;
            buttonSave.Enabled = false;
            textBoxIntervall.BackColor = Color.LightSalmon;
        }

        private void buttonSave_Click(object sender, System.EventArgs e)
        {
            if (!IntervalIsValid)
                return;

            decimal Interval = decimal.Parse(textBoxIntervall.Text);
            Interval = Interval * 6000;

            ParentForm.ChangeTickRate(decimal.ToInt32(Interval));
            Program.Settings.SlideShowTickRate = decimal.ToInt32(Interval);
            this.Close();
        }
    }
}
