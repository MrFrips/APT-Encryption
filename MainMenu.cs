using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace encryption
{
    public partial class Encryption : Form
    {
        //public DataReform datareform = new DataReform();
        public Encryption()
        {
            InitializeComponent();
            ProgressTimer.Start();
            ProgressTimer.Interval = 600;
        }
        bool savedone = false;
        private void ToolMenu_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            {
                //Фильтра для файла↓
                saveFileDialog.Filter = ("Текстовый Документ (*.txt)|*.txt");
                saveFileDialog.InitialDirectory = ("C:\\Users\\portt\\Desktop");
                saveFileDialog.FilterIndex = 2;
                saveFileDialog.RestoreDirectory = true;
                //Откртытие Диолога↓
                if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                    return;
                //Загрузка Бара
                //туть ↓
                //

                // получаем выбранный файл↓
                string filename = saveFileDialog.FileName;
                // сохраняем текст в файл↓
                System.IO.File.WriteAllText(filename, OutResult.Text);
                savedone = true;
                MessageBox.Show("Файл сохранен", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void открытьФайлСТекстомToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Открытие файла↓
            OpenFileDialog openFileDialog = new OpenFileDialog();
            {
                //Фильтра для файла↓
                openFileDialog.Filter = ("Текстовый Документ (*.txt)|*.txt");
                openFileDialog.InitialDirectory = ("C:\\Users\\portt\\Desktop");
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;
                //Откртытие Диолога↓
                if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                    return;
                //Туть для прогрессбара↓

                //получаем выбранный файл↓
                string filename = openFileDialog.FileName;
                string fileText = System.IO.File.ReadAllText(filename);
                //Запись в текстбокс↓
                savedone = false;
                OutResult.Text = fileText;
            }
                StripProgressBar.Maximum = 100;
            if (StripProgressBar.Value != 100)
            {
                StripProgressBar.Increment(21);
            }
            else
            {
                ProgressTimer.Stop();
                StripProgressBar.Value = 0;
            }   
        }

        private void ввестиКлючToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StringKeyMenu.Text = "String: ";
            ColumnKeyMenu.Text = "Column: ";
            Key f = new Key();
            f.ShowDialog();
            StringKeyMenu.Text += DataReform.StringText;
            ColumnKeyMenu.Text += DataReform.СolumnText;
        }

        private void GoEncryption_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(DataReform.StringText) && (string.IsNullOrEmpty(DataReform.СolumnText)))
            {
                DialogResult result = MessageBox.Show("Прежде чем что то шифровать нужен ключ...\n\nХотите открыть окно с вводом ключа?", "Горе шифровщик...", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    //Открыть форму, если нет то не открывать.
                    Key f = new Key();
                    f.ShowDialog();
                }
                else
                {
                    //Простое закрытие Сообщения←
                }
            }
            else
            {
                //Начать шифровку.↓
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Попытка в закрытие без предупреждения после сохранения.
            //if (savedone = false) { }
            DialogResult result = MessageBox.Show("Акуратрнее возможно вы не сохранили ведённые данные\n\nТочно хотите выйти?", "Горе шифровщик?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                //Простое закрытие←
            }
        }
        //Подправить предотвращения закрытие формы по кнопке...
        private void Encryption_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Акуратрнее возможно вы не сохранили ведённые данные\n\nТочно хотите выйти?", "Горе шифровщик?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                e.Cancel = (result != DialogResult.Yes);
        }
    }
}
