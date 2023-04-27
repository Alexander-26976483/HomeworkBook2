using System;
using System.Windows.Forms;
using System.Drawing;

class MyForm : Form
{
    private Label lblPicture;
    private string path = "e:/Visual Studio/HomeworkBook2/pictures/";
    private string[] files = { "Alfa Romeo 4C Concept.jpg", "Ariel Atom.jpg", "Aston Martin V12 Vantage.jpg",
    "Audi A1 Clubsport Quattro.jpg", "Audi R8 GT Spyder.jpg", "BAC Mono.jpg", "Bentley Continental Supersports Convertible.jpg",
    "BMW M3 E92 1.jpg"};
    private int index = 0;

    public MyForm() : base()
    {
        this.Size = new Size(1000, 800);
        this.StartPosition = FormStartPosition.CenterScreen;
        this.Text = "Просмотр изображений";
        this.FormBorderStyle = FormBorderStyle.FixedDialog;
        this.MaximizeBox = false;
        this.Font = new Font("Times New Roman", 13, FontStyle.Regular);

        Button btnNext = new Button();
        btnNext.Text = "Следующее изображение >>";
        btnNext.Bounds = new Rectangle(515, 720, 250, 30);
        btnNext.Click += delegate (object a, EventArgs b)
        {
            if (index == files.Length -1)
            {
                index = -1;
            }
            lblPicture.Image = Image.FromFile(path + files[++index]);
        };
        this.Controls.Add(btnNext);

        Button btnPrev = new Button();
        btnPrev.Text = "<< Предыдущее изображение";
        btnPrev.Bounds = new Rectangle(235, 720, 250, 30);
        btnPrev.Click += delegate (object a, EventArgs b)
        {
            if (index != 0)
            {
                lblPicture.Image = Image.FromFile(path + files[--index]);
                return;
            }
            index = files.Length - 1;
            lblPicture.Image = Image.FromFile(path + files[index]);
        };
        this.Controls.Add(btnPrev);

        lblPicture = new Label();
        lblPicture.SetBounds(5, 5, 975, 700);
        lblPicture.BorderStyle = BorderStyle.FixedSingle;
        lblPicture.Image = Image.FromFile(path + files[index]);
        this.Controls.Add(lblPicture);
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