namespace modul12_1302220093
{
    public partial class Form1 : Form
    {
        // deklarasi komponen form
        public Form1()
        {
            InitializeComponent();
        }

        // deklarasi textbox1
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        // deklarasi textbox2
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        // deklarasi label1
        private void label1_Click(object sender, EventArgs e)
        {

        }

        // deklarasi button
        private void button1_Click(object sender, EventArgs e)
        {
            // deklarasi try catch exception untuk cek inputan textbox1 dan textbox2
            try
            {
                // konversi string ke int dari textbox1 dan textbox2
                int var1 = Convert.ToInt32(textBox1.Text);
                int var2 = Convert.ToInt32(textBox2.Text);

                // konversi int ke string dari hasil perhitungan pangkat
                label1.Text = Pangkat.CariNilaiPangkat(var1, var2).ToString();
            } catch
            {
                // jika salah satu atau kedua inputan bukan berupa integer
                label1.Text = "Input harus berupa integer";
            }
        }
    }
}
