using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Text = "�������� �������";
            button2.Text = "�������� ������� ������";
            button3.Text = "�������� ���� ����";
            button4.Text = "�������";
            button5.Text = "����� ����� � �������";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "���� ������";
            button1.Text = "�������� �������";

            // ��������� ����������� ��� PictureBox
            pictureBox1.Image = Image.FromFile("C:\\Users\\Kostik\\source\\repos\\WinFormsApp1\\WinFormsApp1\\img\\Animated-Flag-Russia.gif");

            // ��������� ������� ������ ��� �����
            label1.Font = new Font(label1.Font.FontFamily, 12);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Text = "�������� ������� ������";

            // ����� ����������� ������
            pictureBox1.Left += 10; // �������� �� 10 �������� ������
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Text = "�������� ���� ����";

            // ��������� ����� ���� �����
            this.BackColor = Color.LightBlue; // �������� �� ������ ��� ����
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Text = "�������";

            pictureBox1.Image = Image.FromFile("");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text = "���� ����";
            button5.Text = "����� ����� � �������";
            pictureBox1.Image = Image.FromFile("C:\\Users\\Kostik\\source\\repos\\WinFormsApp1\\WinFormsApp1\\img\\tenor.gif");
            label1.Font = new Font(label1.Font.FontFamily, 12);
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
