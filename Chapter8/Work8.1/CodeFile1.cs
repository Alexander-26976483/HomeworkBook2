using System;
using System.Windows.Forms;
using System.Drawing;

class MyForm : Form
{
    private Color baseColor;

    public MyForm(string txt) : base()
    {
        Text = txt;
        Height = 200;
        Width = 300;
        FormBorderStyle = FormBorderStyle.Fixed3D;
        BackColor = Color.Yellow;
        baseColor = BackColor;

        MouseEnter += (a, b) =>
        {
            BackColor = Color.Green;
        };
        MouseLeave += (a, b) =>
        {
            BackColor = baseColor;
        };
        MouseDown += (a, b) =>
        {
            Height = (Height / 10) + Height;
            Width = (Width / 10) + Width;
        };
    }

    public static void ShowMyForm(string txt)
    {
        Application.Run(new MyForm(txt));
    }
}

class FormDemo
{
    [STAThread]
    static void Main()
    {
        MyForm.ShowMyForm("Мое окно");
    }
}