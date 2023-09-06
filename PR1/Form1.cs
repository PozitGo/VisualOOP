namespace PR1
{
    public partial class Form1 : Form
    {
        public static int number = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (number <= 9)
            {
                listBox1.Items.Add($"{number++} קטסכמ");
            }
            else
            {
                listBox1.Items.Add("Öטפנ במכüרו םוע");
                button1.Enabled = false;
            }

            textBox1.Text = (number - 1) < 9 ? (number - 1).ToString() : "Öטפנ במכüרו םוע";
        }
    }
}