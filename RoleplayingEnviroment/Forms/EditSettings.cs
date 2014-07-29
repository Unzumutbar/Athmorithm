using System.Drawing;
using System.Windows.Forms;

namespace Atmorithm.Forms
{
    public partial class EditSettings : Form
    {
        private bool IntervalIsValid = false;
        private bool FadingDurationIsValid = false;

        public EditSettings()
        {
            InitializeComponent();
            var currentSettings = Program.Settings;

            decimal TickRateAsDecimal = currentSettings.SlideShowTickRate;
            decimal FadingDurationAsDecimal = currentSettings.FadingDuration;
            checkBoxFading.Checked = currentSettings.FadingIsActive;
            textBoxIntervall.Text = (TickRateAsDecimal / 60000).ToString();
            labelDatabaseVersion.Text = currentSettings.DatabaseVersionString;
            textBoxFadingTime.Text = (FadingDurationAsDecimal / 1000).ToString();
            textBoxFadingTime.Enabled = currentSettings.FadingIsActive;
        }

        public MusicPlayer ParentForm
        {
            get
            {
                return (MusicPlayer)this.Owner;
            }
        }

        private bool CanSave
        {
            get { return IntervalIsValid && FadingDurationIsValid; }
        }

        private void textBoxIntervall_TextChanged(object sender, System.EventArgs e)
        {
            decimal ValidNumber;
            if (decimal.TryParse(textBoxIntervall.Text, out ValidNumber))
            {
                if (ValidNumber * 60000 <= int.MaxValue && ValidNumber > 0)
                {
                    IntervalIsValid = true;
                    textBoxIntervall.BackColor = Color.White;
                    buttonSave.Enabled = CanSave;
                    return;
                }
            }
            IntervalIsValid = false;
            buttonSave.Enabled = false;
            textBoxIntervall.BackColor = Color.LightSalmon;
        }

        private void buttonSave_Click(object sender, System.EventArgs e)
        {
            if (!CanSave)
                return;

            decimal Interval = decimal.Parse(textBoxIntervall.Text);
            Interval = Interval * 60000;

            decimal FadingDuration = decimal.Parse(textBoxFadingTime.Text);
            FadingDuration = FadingDuration * 1000;

            ParentForm.ChangeTickRate(decimal.ToInt32(Interval));
            Program.Settings.SlideShowTickRate = decimal.ToInt32(Interval);
            Program.Settings.FadingIsActive = checkBoxFading.Checked;
            Program.Settings.FadingDuration = decimal.ToInt32(FadingDuration);
            this.Close();
        }

        private void checkBoxFading_CheckedChanged(object sender, System.EventArgs e)
        {
            if (checkBoxFading.Checked)
                labelFadingActivated.Text = "Aktiviert";
            else
                labelFadingActivated.Text = "Deaktiviert";

            textBoxFadingTime.Enabled = checkBoxFading.Checked;
        }

        private void textBoxFadingTime_TextChanged(object sender, System.EventArgs e)
        {
            decimal ValidNumber;
            if (decimal.TryParse(textBoxFadingTime.Text, out ValidNumber))
            {
                if (ValidNumber * 100 <= int.MaxValue && ValidNumber > 0)
                {
                    FadingDurationIsValid = true;
                    textBoxFadingTime.BackColor = Color.White;
                    buttonSave.Enabled = CanSave;
                    return;
                }
            }
            FadingDurationIsValid = false;
            buttonSave.Enabled = CanSave;
            textBoxFadingTime.BackColor = Color.LightSalmon;
        }
    }
}
