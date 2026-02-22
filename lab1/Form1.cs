using System;
using System.Drawing;
using System.Windows.Forms;
using GalaxyLogic;

namespace lab1
{
    public partial class Form1 : Form
    {
        private GalaxyEngine _engine = new GalaxyEngine();
        private Bitmap _backgroundBmp = null;

        public Form1()
        {
            InitializeComponent();
            comboBoxTypes.Items.Clear();
            comboBoxTypes.Items.AddRange(new string[] { "Спиральная", "Эллиптическая", "Миндалевидная" });
            comboBoxTypes.SelectedIndex = 0;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtSize.Text, out int size)) size = 400;

            Bitmap bmp = (_backgroundBmp != null) ? new Bitmap(_backgroundBmp) : new Bitmap(size, size);
            if (_backgroundBmp == null)
            {
                using (Graphics g = Graphics.FromImage(bmp)) g.Clear(Color.Black);
            }

            int w = bmp.Width;
            int h = bmp.Height;
            double cx = w / 2.0;
            double cy = h / 2.0;
            double maxR = Math.Min(w, h) * 0.45;

            progressBar1.Minimum = 0;
            progressBar1.Maximum = h;
            progressBar1.Value = 0;

            Random rnd = new Random();

            for (int y = 0; y < h; y++)
            {
                for (int x = 0; x < w; x++)
                {
       
                    if (_backgroundBmp == null && _engine.ShouldPlaceBackgroundStar(0.0015))
                    {
                        int n = rnd.Next(50, 150);
                        bmp.SetPixel(x, y, Color.FromArgb(n, n, n));
                    }


                    bool hasStar = false;
                    string selected = comboBoxTypes.SelectedItem.ToString();

                    if (selected == "Спиральная")
                        hasStar = _engine.CalculateSpiral(x, y, cx, cy, maxR);
                    else if (selected == "Эллиптическая")
                        hasStar = _engine.CalculateElliptical(x, y, cx, cy, maxR, 2.0);
                    else
                        hasStar = _engine.CalculateAlmond(x, y, cx, cy, maxR, maxR / 1.8, 1.5);
                    if (hasStar)
                    {
                        double dist = Math.Sqrt(Math.Pow(x - cx, 2) + Math.Pow(y - cy, 2));
                        double ratio = dist / maxR;
                        if (ratio > 1.0) ratio = 1.0;


                        int red = (int)(255 * (1 - ratio * 0.3));
                        int green = (int)(240 * (1 - ratio * 0.5));
                        int blue = 255;

                        int alpha = (int)(230 * Math.Pow(1.0 - ratio, 0.7));
                        bmp.SetPixel(x, y, Color.FromArgb(Math.Max(20, alpha), red, green, blue));
                    }
                }

                progressBar1.Value = y + 1;
                if (y % 15 == 0)
                {
                    lblStatus.Text = $"Прогресс: {(int)((double)y / h * 100)}%";
                    Application.DoEvents();
                }
            }

            pictureBox1.Image = bmp;
            lblStatus.Text = "Готово!";
            progressBar1.Value = progressBar1.Maximum;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null) return;
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Bitmap|*.bmp" })
            {
                if (sfd.ShowDialog() == DialogResult.OK) pictureBox1.Image.Save(sfd.FileName);
            }
        }

        private void btnLoadBackground_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Images|*.bmp;*.jpg;*.png" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    if (!int.TryParse(txtSize.Text, out int size)) size = 400;
                    using (Image img = Image.FromFile(ofd.FileName))
                    {
                        _backgroundBmp = new Bitmap(img, new Size(size, size));
                    }
                    pictureBox1.Image = _backgroundBmp;
                }
            }
        }

        private void btnClearBackground_Click(object sender, EventArgs e)
        {
            _backgroundBmp = null;
            pictureBox1.Image = null;
            lblStatus.Text = "Фон очищен";
        }
    }
}