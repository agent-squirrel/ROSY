using System;
using System.Windows.Forms;


//ROSY, the OSIRiS Recovery System.
//For use when a customer finds OSIRiS on their newly bought display/demo machine.
//ROSY has it's BATCH and powershell scripts embedded to avoid issues with customers loosing loose files.


namespace ROSY
{
    public partial class ROSY_mainwindow : Form
    {
        public ROSY_mainwindow()
        {
            InitializeComponent();
        }

        private void about_button_Click(object sender, EventArgs e)
        {
            var form = new AboutBox();
            form.Show(this);
        }

        private void runbutton_Click(object sender, EventArgs e)
        {

            if (newusername.Text == "")
            {
                MessageBox.Show("Woops! Looks like you didn't enter a username.", "Blank User Name");
                return;
            }
            DialogResult areyousure = MessageBox.Show("The following steps will be performed." 
                + Environment.NewLine + "1. ROSY will remove all accounts from this machine and create a new one for you."
                + Environment.NewLine + "2. ROSY will reset this machine's power settings and shutdown timers."
                + Environment.NewLine + "3. ROSY will reboot this machine and launch your new account."
                + Environment.NewLine + ""
                + Environment.NewLine + "Be advised that data stored in this account will be deleted, please ensure you have a backup."
                + Environment.NewLine + "Officeworks takes no responsibility for any data lost during this process."
                + Environment.NewLine + "Would you like to proceed?", "Machine Recovery", MessageBoxButtons.YesNo);
            if (areyousure == DialogResult.Yes)
            {
                var form = new progress(newusername.Text);
                form.Show(this);
                this.Hide();
            }

            if (areyousure == DialogResult.No)
                {
                return;
                }
        }

    }
}
