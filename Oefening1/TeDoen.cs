using System.Threading.Tasks;

namespace Oefening1
{
    internal class TeDoen
    {
        public event EventHandler Meedelen;
        protected virtual void OnMeedelen(EventArgs e)
        {
            EventHandler handler = Meedelen;
            if(handler != null)
            {
                handler(this, e);   
            }
        }
        public void deelMee(bool bol, bool biep, TextBox text)
        {
            OnMeedelen(EventArgs.Empty);
            string Titel = this.Titel;
            string inhoud = "";
            foreach(string informatie in informatie)
            {
                inhoud += "[" + informatie + "]";
            }
            bool dringend;
            if(this.Tijdstip == null)
            {
                dringend = true;
            }
            else
            {
                dringend = false;
            }
            if(bol == false) {
                if (biep == true)
                {
                    System.Media.SystemSounds.Beep.Play();
                }
                System.Windows.Forms.MessageBox.Show("Titel: " + Titel + "\n\nInhoud:" + inhoud + "\n\nDringend:" + dringend);

            }
            if (bol == true)
            {
                if (biep == true)
                {
                    System.Media.SystemSounds.Beep.Play();
                }
                text.Text = "Titel: " + Titel + Environment.NewLine + "Inhoud:" + inhoud + Environment.NewLine + "Dringend:" + dringend;
            }
        }
        private int id { get;}
        private static int idCount;
        public DateTime? Tijdstip { get; }
        private string Titel;
        private string[] informatie;
        
        public TeDoen(DateTime? tijd, string titel, string[] info) {
            if (tijd != null && tijd > DateTime.Now)
            {
                this.Tijdstip = tijd;
            }
            else
            {
                this.Tijdstip = null;
            }
            this.Titel = titel;
            this.informatie = info;
            idCount++;
            this.id = idCount;

        }

        public override string ToString()
        {
            return this.Titel.ToString();
        }


        public override bool Equals(object? obj)
        {
        if(obj == null) { return false; }
        if(!(obj is TeDoen)) { return false; }
        return (this.id == ((TeDoen)obj).id);
        }
    }
}
