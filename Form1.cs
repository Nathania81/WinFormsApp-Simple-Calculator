namespace WinFormsApp1_Test
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double angka1 = Convert.ToDouble(textBox1.Text);
                double angka2 = Convert.ToDouble(textBox2.Text);
                string operasi = comboBox1.SelectedItem?.ToString();

                if (string.IsNullOrEmpty(operasi))
                {
                    MessageBox.Show("Pilih operator terlebih dahulu!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                double hasil = 0;

                switch (operasi)
                {
                    case "+":
                        hasil = angka1 + angka2;
                        break;
                    case "-":
                        hasil = angka1 - angka2;
                        break;
                    case "x":
                        hasil = angka1 * angka2;
                        break;
                    case "/":
                        if (angka2 != 0)
                        {
                            hasil = angka1 / angka2;
                        }
                        else
                        {
                            MessageBox.Show("Tidak bisa membagi dengan nol!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        break;
                    default:
                        MessageBox.Show("Operator tidak valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                }

                MessageBox.Show($"Hasil: {hasil}", "Hasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (FormatException)
            {
                MessageBox.Show("Input tidak valid! Masukkan angka yang benar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
