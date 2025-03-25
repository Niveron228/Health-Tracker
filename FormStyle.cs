using System;
using System.Drawing;
using System.Drawing.Drawing2D;
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
    }
}
