using System;
using System.Windows.Forms;
using System.Drawing;

class MyForm : Form
{
    private string[] dataFontName = { "Times New Roman", "Arial", "Calibri", "Tahoma", "Segoe UI" };
    private int[] dataFontSize = { 12, 14, 16, 18, 20, 22, 24 };
    private string[] dataFontStyle = { "Обычный", "Полужирный", "Курсив" };

    public MyForm() : base()
    {
        this.Size = new Size(500, 400);
        this.StartPosition = FormStartPosition.CenterScreen;
        this.Text = "Текст с главным меню";
        this.FormBorderStyle = FormBorderStyle.FixedDialog;
        this.MaximizeBox = false;

        Font lblFont = new Font("Times New Roman", 12, FontStyle.Regular);
        Label lblText = new Label();
        lblText.SetBounds(5, 10, 475, 300);
        lblText.BorderStyle = BorderStyle.FixedSingle;        
        lblText.TextAlign = ContentAlignment.MiddleCenter;
        lblText.Font = lblFont;
        lblText.Text = GetChangedText(lblFont);

        this.Controls.Add(lblText);

        MainMenu menu = new MainMenu();

        MenuItem fontName = new MenuItem("Шрифт");
        MenuItem fontSize = new MenuItem("Размер шрифта");
        MenuItem fontStyle = new MenuItem("Стиль шрифта");

        for (int k = 0; k < dataFontName.Length; k++)
        {
            fontName.MenuItems.Add(dataFontName[k]);
        }
        for (int k = 0; k < fontName.MenuItems.Count; k++)
        {
            fontName.MenuItems[k].Click += (x, y) =>
            {
                lblText.Font = GetText(fontName.MenuItems[fontName.MenuItems.IndexOf((MenuItem)x)].Text, lblText.Font);
                lblText.Text = GetChangedText(lblText.Font);
            };
        }

        for (int k = 0; k < dataFontSize.Length; k++)
        {
            fontSize.MenuItems.Add(dataFontSize[k].ToString());
        }
        for (int k = 0; k < fontSize.MenuItems.Count; k++)
        {
            fontSize.MenuItems[k].Click += (x, y) =>
            {
                lblText.Font = GetText(Int32.Parse(fontSize.MenuItems[fontSize.MenuItems.IndexOf((MenuItem)x)].Text), lblText.Font);
                lblText.Text = GetChangedText(lblText.Font);
            };
        }

        for (int k = 0; k < dataFontStyle.Length; k++)
        {
            fontStyle.MenuItems.Add(dataFontStyle[k]);
        }
        for (int k = 0; k < fontStyle.MenuItems.Count; k++)
        {
            fontStyle.MenuItems[k].Click += (x, y) =>
            {
                lblText.Font = GetText(GetFontStyle(fontStyle.MenuItems[fontStyle.MenuItems.IndexOf((MenuItem)x)].Text), lblText.Font);
                lblText.Text = GetChangedText(lblText.Font);
            };
        }

        menu.MenuItems.Add(fontName);
        menu.MenuItems.Add(fontSize);
        menu.MenuItems.Add(fontStyle);
        this.Menu = menu;
    }

    private Font GetText(string _fontName, Font currentFont)
    {
        Font F = new Font(_fontName, currentFont.Size, currentFont.Style);

        return F;
    }
    private Font GetText(int _fontSize, Font currentFont)
    {
        Font F = new Font(currentFont.Name, _fontSize, currentFont.Style);

        return F;
    }
    private Font GetText(FontStyle _fontStyle, Font currentFont)
    {
        Font F = new Font(currentFont.Name, currentFont.Size, _fontStyle);

        return F;
    }

    private FontStyle GetFontStyle(string styleName)
    {
        switch (styleName)
        {
            case "Обычный":
                return FontStyle.Regular;

            case "Полужирный":
                return FontStyle.Bold;

            case "Курсив":
                return FontStyle.Italic;
            default:
                return FontStyle.Regular;
        }
    }

    private string GetChangedText(Font font)
    {
        string result = $"Шрифт: \"{font.Name}\" \nРазмер шрифта: {font.Size} \nСтиль шрифта: {GetFontStyle(font)}";

        return result;
    }

    private string GetFontStyle(Font font)
    {
        if (font.Bold)
        {
            return dataFontStyle[1];
        }
        else if (font.Italic)
        {
            return dataFontStyle[2];
        }
        return dataFontStyle[0];
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