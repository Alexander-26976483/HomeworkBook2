using System;
using System.Windows.Forms;
using System.Drawing;


class MyForm : Form
{
    private string[] colors_ = { "Красный", "Желтый", "Зеленый", "Синий", "Черный" };
    private int index = 0;
    private Label region;
    private ComboBox list;

    public MyForm() : base()
    {
        Text = "Цвета";
        Size = new Size(340, 200);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;

        region = new Label();
        region.SetBounds(5, 5, 200, 150);
        region.BorderStyle = BorderStyle.FixedSingle;
        region.BackColor = Color.Red;

        Controls.Add(region);

        list = new ComboBox();
        list.Items.AddRange(colors_);
        list.DropDownStyle = ComboBoxStyle.DropDownList;
        list.SelectedIndex = index;
        list.Left = region.Right + 5;
        list.Top = region.Top;
        list.Size = new Size(110, 50);
        list.Font = new Font("Courier New", 12, FontStyle.Bold);
        list.SelectedIndexChanged += OnItemChanged;

        Controls.Add(list);
    }

    private void OnItemChanged(object obj, EventArgs ea)
    {
        int index = list.SelectedIndex;

        region.BackColor = GetColor(index);
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
                return Color.Red;
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
