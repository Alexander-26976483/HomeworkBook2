using System;
using System.Windows.Forms;
using System.Drawing;

class MyForm : Form
{
    private string[] colors_ = { "Красный", "Желтый", "Зеленый", "Синий", "Черный" };

    public MyForm() : base()
    {
        this.Size = new Size(350, 300);
        this.StartPosition = FormStartPosition.CenterScreen;
        this.Text = "Цвета из контекстного меню";
        this.FormBorderStyle = FormBorderStyle.FixedDialog;
        this.MaximizeBox = false;
        this.Font = new Font("Times New Roman", 13, FontStyle.Regular);

        Label region = new Label();
        region.SetBounds(5, 5, 325, 250);
        region.BorderStyle = BorderStyle.FixedSingle;
        region.BackColor = Color.Red;
        this.Controls.Add(region);

        ContextMenuStrip menu = new ContextMenuStrip();
        for (int k = 0; k < colors_.Length; k++)
        {
            menu.Items.Add(colors_[k]);
        }
        for (int k = 0; k < menu.Items.Count; k++)
        {
            menu.Items[k].Click += (x, y) =>
            {
                region.BackColor = GetColor(menu.Items.IndexOf((ToolStripItem)x));
            };
        }
        region.ContextMenuStrip = menu;

        menu.Items[0].PerformClick();
    }

    private Color GetColor(int index_)
    {
        switch (index_)
        {
            case 0:
                return Color.Red;
            case 1:
                return Color.Yellow;
            case 2:
                return Color.Green;
            case 3:
                return Color.Blue;
            case 4:
                return Color.Black;
            default:
                return Color.White;
        }
    }
}

class FormDemo
{
    [STAThread]
    static void Main()
    {
        MyForm mf = new MyForm();

        Application.Run(mf);
    }
}
