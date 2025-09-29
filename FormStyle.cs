using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    static class FormStyle
    {
        public static void ButtonStyle(Button btn)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.BackColor = Color.FromArgb(41, 39, 40);
            btn.ForeColor = Color.White;
            btn.Font = new Font("Arial", 12, FontStyle.Bold);
        }

        public static void FadeIn(Form form)
        {
            for (double i = 0; i <= 1; i += 0.1)
            {
                form.Opacity = i;
                System.Threading.Thread.Sleep(20);
            }
        }

        public static void FadeOut(Form form)
        {
            for (double i = 1; i >= 0; i -= 0.1)
            {
                form.Opacity = i;
                System.Threading.Thread.Sleep(20);
            }
        }

        public static void ApplyGradient(Form form, Color startColor, Color endColor)
        {
            form.Paint += (sender, e) =>
            {
                using (LinearGradientBrush brush = new LinearGradientBrush(
                    form.ClientRectangle, startColor, endColor, 45F))
                {
                    e.Graphics.FillRectangle(brush, form.ClientRectangle);
                }
            };
        }

        public static void RoundButton(Button btn)
        {
            int radius = 50;
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(btn.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(btn.Width - radius, btn.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, btn.Height - radius, radius, radius, 90, 90);
            path.CloseAllFigures();
            btn.Region = new Region(path);
        }




        public static void RoundTextBox(TextBox tb)
        {
            int radius = 30;
            if (tb == null) return;

            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(new Rectangle(0, 0, radius, radius), 180, 90);
            path.AddArc(new Rectangle(tb.Width - radius, 0, radius, radius), 270, 90);
            path.AddArc(new Rectangle(tb.Width - radius, tb.Height - radius, radius, radius), 0, 90);
            path.AddArc(new Rectangle(0, tb.Height - radius, radius, radius), 90, 90);
            path.CloseFigure();

            tb.Region = new Region(path);




        }

    }
}
