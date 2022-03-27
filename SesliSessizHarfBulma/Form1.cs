namespace SesliSessizHarfBulma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSessizHarf_Click(object sender, EventArgs e)
        {
            string girilen = rchText.Text;
            char[] cgirilen = new char[girilen.Length];
            char[] sessizHarf = new char[] { 'b', 'c', '�', 'd', 'h', 'g', 'l', 't', 'v', 'z', 'y', 's', '�', 'r', 'p', 'n', '�', 'j', 'k', 'm' };
            string sonuc1 = "";
            string sonuc2 = "";
            string sonucSon = "";

            foreach (char c in girilen)
            {
                sonuc1 = c.ToString().ToLower();
                foreach (char s in sessizHarf)
                {
                    sonuc2 = s.ToString().ToLower();

                    if (sonuc1 == sonuc2)
                    {
                        sonucSon += sonuc2;

                        txtSonuc.Text = sonucSon;

                    }
                }
            }
        }



        private void btnSesliHarf_Click(object sender, EventArgs e)
        {
            {
                string girilen = rchText.Text;
                char[] cgirilen = new char[girilen.Length];
                char[] sesliHarf = new char[] { 'a', 'e', '�', 'i', 'o', '�', 'u', '�' };
                string sonuc1 = "";
                string sonuc2 = "";
                string sonucSon = "";

                foreach (char c in girilen)
                {
                    sonuc1 = c.ToString().ToLower();
                    foreach (char s in sesliHarf)
                    {
                        sonuc2 = s.ToString().ToLower();

                        if (sonuc1 == sonuc2)
                        {
                            sonucSon += sonuc2;

                            txtSonuc.Text = sonucSon;

                        }
                    }
                }
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtSonuc.Text = "";
            rchText.Text = "";
        }
    }
}

      

        
        
    


