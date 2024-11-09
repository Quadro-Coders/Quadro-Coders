using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Text = "Изменить надпись";
            button2.Text = "Сдвинуть рисунок вправо";
            button3.Text = "Изменить цвет фона";
            button4.Text = "Мозаика";
            button5.Text = "Смена флага и надписи";
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
            label1.Text = "Флаг России";
            button1.Text = "Изменить надпись";

            // Установка изображения для PictureBox
            pictureBox1.Image = Image.FromFile("C:\\Users\\Kostik\\source\\repos\\WinFormsApp1\\WinFormsApp1\\img\\Animated-Flag-Russia.gif");

            // Установка размера шрифта для метки
            label1.Font = new Font(label1.Font.FontFamily, 12);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Text = "Сдвинуть рисунок вправо";

            // Сдвиг изображения вправо
            pictureBox1.Left += 10; // сдвигаем на 10 пикселей вправо
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Text = "Изменить цвет фона";

            // Изменение цвета фона формы
            this.BackColor = Color.LightBlue; // Замените на нужный вам цвет
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Text = "Мозаика";

            pictureBox1.Image = Image.FromFile("");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text = "Флаг СССР";
            button5.Text = "Смена флага и надписи";
            pictureBox1.Image = Image.FromFile("C:\\Users\\Kostik\\source\\repos\\WinFormsApp1\\WinFormsApp1\\img\\tenor.gif");
            label1.Font = new Font(label1.Font.FontFamily, 12);
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
