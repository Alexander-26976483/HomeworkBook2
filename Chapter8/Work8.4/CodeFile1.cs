using System;
using System.Windows.Forms;
using System.Drawing;

class MyForm : Form
{
    private CheckBox optionBold;
    private CheckBox optionItalic;
    private TextBox tb;
    private Label lbl;

    public MyForm() : base()
    {
        this.Size = new Size(300, 200);
        this.StartPosition = FormStartPosition.CenterScreen;
        this.Text = "Стили текста";
        this.FormBorderStyle = FormBorderStyle.FixedDialog;
        this.MaximizeBox = false;
        this.Font = new Font("Times New Roman", 13, FontStyle.Regular);

        lbl = new Label();
        Font fontLblBold = new Font(Font.Name, Font.Size, FontStyle.Bold);
        Font fontLblItalic = new Font(Font.Name, Font.Size, FontStyle.Italic);
        Font fontLblRegular = new Font(Font.Name, Font.Size, FontStyle.Regular);
        Font fontLblBoldandItalic = new Font(Font.Name, Font.Size, FontStyle.Bold | FontStyle.Italic);
        lbl.Height = 30;
        lbl.Width = this.Width - 35;
        lbl.Left = 10;
        lbl.Top = 20;
        lbl.BorderStyle = BorderStyle.Fixed3D;
        this.Controls.Add(lbl);

        tb = new TextBox();
        tb.Width = lbl.Width;
        tb.Left = lbl.Left;
        tb.Top = lbl.Bottom + 10;
        tb.TextChanged += (x, y) =>
        {
            lbl.Text = tb.Text;
        };
        this.Controls.Add(tb);

        optionBold = new CheckBox();
        optionBold.Height = 20;
        optionBold.Width = lbl.Width;
        optionBold.Left = 10;
        optionBold.Top = tb.Bottom + 15;
        optionBold.Text = "Включить жирный шрифт";
        optionBold.CheckedChanged += (x, y) =>
        {
            if (optionItalic.Checked == true)
            {
                lbl.Font = fontLblBoldandItalic;
            }
            else
            {
                lbl.Font = fontLblBold;
            }
            if (optionBold.Checked == false & optionItalic.Checked == true)
            {
                lbl.Font = fontLblItalic;
            }
            else if(optionBold.Checked == false & optionItalic.Checked == false)
            {
                lbl.Font = fontLblRegular;
            }
        };
        this.Controls.Add(optionBold);

        optionItalic = new CheckBox();
        optionItalic.Height = 20;
        optionItalic.Width = lbl.Width;
        optionItalic.Left = 10;
        optionItalic.Top = optionBold.Bottom + 10;
        optionItalic.Text = "Включить курсивный шрифт";
        optionItalic.CheckedChanged += (x, y) =>
        {
            if (optionBold.Checked == true)
            {
                lbl.Font = fontLblBoldandItalic;
            }
            else
            {
                lbl.Font = fontLblItalic;
            }
            if (optionItalic.Checked == false & optionBold.Checked == true)
            {
                lbl.Font = fontLblBold;
            }
            else if (optionItalic.Checked == false & optionBold.Checked == false)
            {
                lbl.Font = fontLblRegular;
            }
        };
        this.Controls.Add(optionItalic);
    }

    //private void SetFontStyle(bool optionStatusBold, bool optionStatusItalic)
    //{
        
    //}
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