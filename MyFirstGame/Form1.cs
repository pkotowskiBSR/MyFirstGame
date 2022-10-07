namespace MyFirstGame
{
    public partial class Form1 : Form
    {
        Cannon cannon;


        public Form1()
        {
            InitializeComponent();

            cannon = new Cannon(30 * MathF.PI / 180, 40, 1);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cannon.Angle += 0.1f;

            pictureBox1.Invalidate();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            cannon.Angle -= 0.1f;

            pictureBox1.Invalidate();
        }


        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            cannon.Draw(g, pictureBox1.Height);

        }

    }
}