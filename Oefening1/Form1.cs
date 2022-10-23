namespace Oefening1
{
    public partial class Form1 : Form
    {
        FouteRij<TeDoen> lijst = new FouteRij<TeDoen>();
        private bool melding = false;
        private bool biep = false;
        public Form1()
        {
            
            InitializeComponent();
            updateButtons();
        }
        
        private void makeObject()
        {

        }

        private void b_add_task_Click(object sender, EventArgs e)
        {
            string zin = tb_info.Text;
            string[] informatie = zin.Split(',');
            TeDoen taak = new TeDoen(dtp_date.Value, tb_titel.Text, informatie);
            if (cb_tijdbool.Checked || taak.Tijdstip == null)
            {
                lijst.toevoegen(taak);
                updateFouteRij();
            }
            if (!(cb_tijdbool.Checked) && taak.Tijdstip > DateTime.Now)
            {
                PlanActie(taak);
            }
        }

        private async void PlanActie(TeDoen taak)
        {

            DateTime UitvoerTijd = (DateTime)taak.Tijdstip;
            await Task.Delay((int)UitvoerTijd.Subtract(DateTime.Now).TotalMilliseconds);
            taak.deelMee(melding, biep, tb_multiline);
        }

        private void cb_tijdbool_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_tijdbool.Checked)
            {
                dtp_date.Visible = false;
                l_tijd.Visible = false;
            }
            else
            {
                dtp_date.Visible = true;
                l_tijd.Visible = true;
            }
        }
        private void updateFouteRij()
        {
            tb_fouteRij.Text = lijst.ToString();
        }

        private void b_volgendeTaak_Click(object sender, EventArgs e)
        {
            lijst.volgende();
            lijst.HuidigElement.deelMee(melding,biep, tb_multiline);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(lijst.count != 0)
            {
                lijst.verwijderen();
                updateFouteRij();
            }
        }

        private void b_zetAchteraan_Click(object sender, EventArgs e)
        {
            lijst.ZetAchteraan();
            updateFouteRij();
        }

        private void b_multiline_Click(object sender, EventArgs e)
        {
            melding = true;
            updateButtons();
        }

        private void updateButtons()
        {
            if(melding == false)
            {
                b_multiline.BackColor = Color.Red;
                b_messageBox.BackColor = Color.Green;
            }
            if(melding == true)
            {

                b_multiline.BackColor = Color.Green;
                b_messageBox.BackColor = Color.Red;
            }
            if(biep == false)
            {
                b_biep.BackColor = Color.Red;
            }
            if(biep == true)
            {
                b_biep.BackColor = Color.Green;
            }
        }

        private void b_messageBox_Click(object sender, EventArgs e)
        {
            melding = false;
            updateButtons();
        }

        private void b_biep_Click(object sender, EventArgs e)
        {
            if(biep == true)
            {
                biep = false;
            }
            else
            {
                biep=true;
            }
            updateButtons();
        }
    }
}