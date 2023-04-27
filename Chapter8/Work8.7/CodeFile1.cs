using System;
using System.Windows.Forms;
using System.Drawing;

class MyForm : Form
{
    private string[] dataFontName = { "Times New Roman", "Arial", "Calibri", "Tahoma", "Segoe UI" };
    private string[] dataFontColor = { "Black", "Blue", "Yellow", "Red", "Green", "Pink" };

    public MyForm() : base()
    {
        this.Size = new Size(350, 300);
        this.StartPosition = FormStartPosition.CenterScreen;
        this.Text = "Список выбора и раскрывающийся список";
        this.FormBorderStyle = FormBorderStyle.FixedDialog;
        this.MaximizeBox = false;
        this.Font = new Font("Times New Roman", 13, FontStyle.Regular);

        Label lblText = new Label();
        lblText.Height = 30;
        lblText.Width = this.Width - 35;
        lblText.Left = 10;
        lblText.Top = 30;
        lblText.TextAlign = ContentAlignment.MiddleCenter;
        lblText.Text = "Измените шрифт и цвет текста.";
        lblText.BorderStyle = BorderStyle.Fixed3D;
        this.Controls.Add(lblText);

        ListBox selectList = new ListBox();
        selectList.Size = new Size(170, 80);
        selectList.Left = 10;
        selectList.Top = lblText.Top + lblText.Height + 10;
        for (int k = 0; k < dataFontName.Length; k++)
        {
            selectList.Items.Add(dataFontName[k]);
        }
        selectList.SelectedIndexChanged += (x, y) =>
        {
            int index = selectList.SelectedIndex;

            lblText.Font = new Font(dataFontName[index], Font.Size);
        };
        this.Controls.Add(selectList);

        ComboBox dropdownList = new ComboBox();
        dropdownList.Size = new Size(135, 80);
        dropdownList.Left = selectList.Left + selectList.Width + 10;
        dropdownList.DropDownStyle = ComboBoxStyle.DropDownList;
        dropdownList.Top = selectList.Top;
        for (int k = 0; k < dataFontColor.Length; k++)
        {
            dropdownList.Items.Add(dataFontColor[k]);
        }
        dropdownList.SelectedIndex = 0;
        dropdownList.SelectedIndexChanged += (x, y) =>
        {
            int index = dropdownList.SelectedIndex;

            lblText.ForeColor = GetColor(index);
        };
        this.Controls.Add(dropdownList);
    }

    private Color GetColor(int index_)
    {
        switch (index_)
        {
            case 0:
                return Color.Black;
            case 1:
                return Color.Blue;
            case 2:
                return Color.Yellow;
            case 3:
                return Color.Red;
            case 4:
                return Color.Green;
            case 5:
                return Color.Pink;
            default:
                return Color.Black;
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