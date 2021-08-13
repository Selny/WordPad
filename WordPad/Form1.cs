using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordPad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            //Koda desteklerine gore Ebdul ve Nicata twk
            InitializeComponent();
            cbColor.Items.Clear();
            string[] colores = Enum.GetNames(typeof(System.Drawing.KnownColor));
            cbColor.Items.AddRange(colores);
        }
        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            main.Font = new Font(combo_fonts.Text, int.Parse(combo_size.Text), FontStyle.Italic);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            main.Font = new Font(combo_fonts.Text, int.Parse(combo_size.Text), FontStyle.Underline);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            main.Font = new Font(combo_fonts.Text, int.Parse(combo_size.Text), FontStyle.Bold);
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var fontFamily in FontFamily.Families)
            {
                combo_fonts.Items.Add(fontFamily.Name);
            }

            combo_size.SelectedIndex = 0;
            combo_fonts.SelectedIndex = 0;

        }

        private void cbColor_DrawItem_1(object sender, DrawItemEventArgs e)
        {
            try
            {
                e.DrawBackground();
                string texto = cbColor.Items[e.Index].ToString();
                Brush border = new SolidBrush(e.ForeColor);
                Color color = Color.FromName(texto);
                Brush pincel = new SolidBrush(color);
                Pen boli = new Pen(e.ForeColor);
                e.Graphics.DrawRectangle(boli, new Rectangle(e.Bounds.Left + 2, e.Bounds.Top + 2, 24, e.Bounds.Height - 4));
                e.Graphics.FillRectangle(pincel, new Rectangle(e.Bounds.Left + 3, e.Bounds.Top + 3, 22, e.Bounds.Height - 6));
                e.Graphics.DrawString(texto, e.Font, border, e.Bounds.Left + 30, e.Bounds.Top + 2);

                e.DrawFocusRectangle();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void cbColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            main.SelectionColor = Color.FromName(cbColor.SelectedItem.ToString());
        }

        private void combo_fonts_SelectedIndexChanged(object sender, EventArgs e)
        {
            main.Font = new Font(combo_fonts.Text, int.Parse(combo_size.Text));
        }

        private void combo_size_SelectedIndexChanged(object sender, EventArgs e)
        {
            main.Font = new Font(combo_fonts.Text, int.Parse(combo_size.Text));
        }
    }
}
