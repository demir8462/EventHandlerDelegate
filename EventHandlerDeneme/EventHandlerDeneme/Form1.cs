namespace EventHandlerDeneme
{
    public partial class Form1 : Form
    {
        public static EventHandler textDegisti;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textDegisti += veriGuncelle;
            textDegisti += textKontrol;
        }
        public static void veriGuncelle(object sender, EventArgs e)
        {
            Form1 form = (Form1)sender;
            TextBox box = form.textBox1;
            int karekter = box.Text.Length, bosluk = box.Text.ToString().Count(f => (f == ' ')); // ÖÐREN BUNU
            int boslukcount=0;
            form.label4.Text = karekter.ToString();
            form.label5.Text = bosluk.ToString();
        }
        public static void textKontrol(object sender,EventArgs e)
        {
            if (((Form1)sender).textBox1.Text.Length%50 == 0)
                MessageBox.Show("KARAKTER SAYISI : " + (((Form1)sender).textBox1.Text.Length).ToString());
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textDegisti(this,e);
        }

    }
}