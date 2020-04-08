using System;
using System.Drawing;
using System.Windows.Forms;
using word = Microsoft.Office.Interop.Word;

namespace WindowsForm
{
    public partial class Statement : Form
    {
        public Statement()
        {
            InitializeComponent();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Close_MouseEnter(object sender, EventArgs e)
        {
            Close.ForeColor = Color.Red;
        }

        private void Close_MouseLeave(object sender, EventArgs e)
        {
            Close.ForeColor = Color.Black;
        }

        private void Confirm_MouseEnter(object sender, EventArgs e)
        {
            Confirm.ForeColor = Color.Black;
        }

        private void Confirm_MouseLeave(object sender, EventArgs e)
        {
            Confirm.ForeColor = Color.White;
        }

        private void Replacingtext(string stubToReplace, string text, word.Document wordDocument)
        {
            word.Range range = wordDocument.Content;
            range.Find.ClearFormatting();
            range.Find.Execute(FindText: stubToReplace, ReplaceWith: text);
        }

        private void Confirm_Click_1(object sender, EventArgs e)
        {
            var name = FIO.Text;
            var date = Date.Value.ToShortDateString();
            var group = Group.Text;

            var wordApp = new word.Application();
            wordApp.Visible = true;
            var wordDocument = wordApp.Documents.Open(@":\07.04.20\WindowsForm\Zayavlenie.docx"); // Укажите путь файла Zayavlenie
                                                                                                   // (находится в корневой папке проекта)
            if (FIO.Text == "Коновалова Любава Филипповна")
            {
                Replacingtext("{ФИО1}", "Коноваловой Любавы Филипповны", wordDocument);
                Replacingtext("{ФИО2}", "Коноваловой Л.Ф.", wordDocument);
                Replacingtext("{ФИО3}", "Коновалова Л.Ф.", wordDocument);
                Replacingtext("{группа}", group, wordDocument);
                Replacingtext("{ДАТА}", date, wordDocument);
            }
            if (FIO.Text == "Кудрин Гаврила Валериевич")
            {
                Replacingtext("{ФИО1}", "Кудрина Гаврилы Валериевича", wordDocument);
                Replacingtext("{ФИО2}", "Кудрину Г.В.", wordDocument);
                Replacingtext("{ФИО3}", "Кудрин Г.В.", wordDocument);
                Replacingtext("{группа}", group, wordDocument);
                Replacingtext("{ДАТА}", date, wordDocument);

            }
            if (FIO.Text == "Мурзакова Стела Борисовна")
            {
                Replacingtext("{ФИО1}", "Мурзаковой Стелы Борисовны", wordDocument);
                Replacingtext("{ФИО2}", "Мурзаковой С.Б.", wordDocument);
                Replacingtext("{ФИО3}", "Мурзакова С.Б.", wordDocument);
                Replacingtext("{группа}", group, wordDocument);
                Replacingtext("{ДАТА}", date, wordDocument);
            }
            if (FIO.Text == "Каржаубаев Кирилл Гордеевич")
            {
                Replacingtext("{ФИО1}", "Каржаубаева Кирилла Гордеевича", wordDocument);
                Replacingtext("{ФИО2}", "Каржаубаеву К.Г.", wordDocument);
                Replacingtext("{ФИО3}", "Каржаубаев К.Г.", wordDocument);
                Replacingtext("{группа}", group, wordDocument);
                Replacingtext("{ДАТА}", date, wordDocument);
            }
            if (FIO.Text == "Паршиков Арсений Ипатович")
            {
                Replacingtext("{ФИО1}", "Паршикова Арсения Ипатовича", wordDocument);
                Replacingtext("{ФИО2}", "Паршикову А.И.", wordDocument);
                Replacingtext("{ФИО3}", "Паршиков А.И.", wordDocument);
                Replacingtext("{группа}", group, wordDocument);
                Replacingtext("{ДАТА}", date, wordDocument);
            }

            Close();
        }

        Point lastPoint;

        private void Statement_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void Statement_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
    }
}

