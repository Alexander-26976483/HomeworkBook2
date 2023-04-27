using System;
using System.Windows.Forms;
using System.Drawing;

class MyForm : Form
{
    public MyForm(string msg, string title) : base()
    {
        Text = title;
        Size = new Size(305, 140);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;

        Label label = new Label();
        label.Text = msg;
        label.Location = new Point(10, 10);
        label.Width = 270;
        label.Height = 40;
        label.TextAlign = ContentAlignment.MiddleCenter;
        label.BorderStyle = BorderStyle.Fixed3D;

        Font F = new Font("Arial", 15);

        label.Font = F;
        label.ForeColor = Color.Blue;

        Controls.Add(label);

        Button btnPlusOne = new Button();
        btnPlusOne.Text = "+1";
        btnPlusOne.Bounds = new Rectangle(10, 60, 90, 30);
        btnPlusOne.Font = new Font(btnPlusOne.Font.Name, btnPlusOne.Font.Size + 3, FontStyle.Bold);
        btnPlusOne.Click += delegate (object a, EventArgs b)
        {
            label.Text = (Int32.Parse(label.Text) + 1).ToString();
        };

        Button btnMinusOne = new Button();
        btnMinusOne.Text = "-1";
        btnMinusOne.Bounds = new Rectangle(100, 60, 90, 30);
        btnMinusOne.Font = new Font(btnMinusOne.Font.Name, btnMinusOne.Font.Size + 3, FontStyle.Bold);
        btnMinusOne.Click += delegate (object a, EventArgs b)
        {
            label.Text = (Int32.Parse(label.Text) - 1).ToString();
        };

        Button btnExit = new Button();
        btnExit.Text = "Выход";
        btnExit.Bounds = new Rectangle(190, 60, 90, 30);
        btnExit.Font = new Font(btnExit.Font.Name, btnExit.Font.Size + 3, FontStyle.Bold);
        btnExit.Click += delegate (object a, EventArgs b)
        {
            Application.Exit();
        };

        Controls.Add(btnPlusOne);
        Controls.Add(btnMinusOne);
        Controls.Add(btnExit);
    }
}
class FormDemo
{
    [STAThread]
    static void Main()
    {
        MyForm mf = new MyForm("0", "Кнопки");

        Application.Run(mf);
    }
}