using System;
using System.Windows.Forms;
using System.Drawing;

class MyForm : Form
{
    private TextBox tb1;
    private TextBox tb2;
    private Label lblInfo;
    private Label lblNumber1;
    private Label lblNumber2;

    public MyForm() : base()
    {
        this.Size = new Size(350, 300);
        this.StartPosition = FormStartPosition.CenterScreen;
        this.Text = "Сравнение чисел";
        this.FormBorderStyle = FormBorderStyle.FixedDialog;
        this.MaximizeBox = false;
        this.Font = new Font("Times New Roman", 13, FontStyle.Regular);

        lblInfo = new Label();
        lblInfo.Height = 30;
        lblInfo.Width = this.Width - 35;
        lblInfo.Left = 10;
        lblInfo.Top = 30;
        lblInfo.Text = "Введите числа";
        lblInfo.BorderStyle = BorderStyle.Fixed3D;
        this.Controls.Add(lblInfo);

        lblNumber1 = new Label();
        lblNumber1.Height = 30;
        lblNumber1.Width = 130;
        lblNumber1.Left = lblInfo.Left;
        lblNumber1.Top = lblInfo.Top + lblInfo.Height + 20;
        lblNumber1.Text = "Первое число";
        this.Controls.Add(lblNumber1);

        lblNumber2 = new Label();
        lblNumber2.Height = lblNumber1.Height;
        lblNumber2.Width = lblNumber1.Width;
        lblNumber2.Left = lblNumber1.Left + lblNumber2.Width + 50;
        lblNumber2.Top = lblNumber1.Top;
        lblNumber2.Text = "Второе число";
        this.Controls.Add(lblNumber2);

        tb1 = new TextBox();
        tb1.Width = lblNumber1.Width;
        tb1.Left = lblNumber1.Left;
        tb1.Top = lblNumber1.Top + lblNumber1.Height + 5;
        tb1.TextChanged += (x, y) =>
        {
            OnFieldsChange();
        };
        this.Controls.Add(tb1);

        tb2 = new TextBox();
        tb2.Width = tb1.Width;
        tb2.Left = lblNumber2.Left;
        tb2.Top = tb1.Top;
        tb2.TextChanged += (x, y) =>
        {
            OnFieldsChange();
        };
        this.Controls.Add(tb2);
    }

    private void OnFieldsChange()
    {
        int number1, number2;

        if (String.IsNullOrWhiteSpace(tb1.Text) || String.IsNullOrWhiteSpace(tb2.Text))
        {
            lblInfo.Text = "Введите числа";
            return;
        }

        if (!Int32.TryParse(tb1.Text, out number1))
        {
            lblInfo.Text = "В первом поле введено не число!";
            return;
        }

        if (!Int32.TryParse(tb2.Text, out number2))
        {
            lblInfo.Text = "Во втором поле введено не число!";
            return;
        }
        lblInfo.Text = CompareNumbers(number1, number2);
    }

    private string CompareNumbers(int _number1, int _number2)
    {
        string msg;
        if (_number1 > _number2)
        {
            msg = "Первое число больше второго";
            return msg;
        }
        else if (_number1 == _number2)
        {
            msg = "Первое число равно второму числу";
            return msg;
        }
        else
        {
            msg = "Второе число больше первого";
            return msg;
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