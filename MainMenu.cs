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
                //туть

                //

                // получаем выбранный файл↓
                string filename = saveFileDialog.FileName;
                // сохраняем текст в файл↓
                System.IO.File.WriteAllText(filename, OutResult.Text);
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
        

        //private void нетToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    MessageBox.Show("ТЫ ОБЯЗАН СОХРАНИТЬ!!!");
        //    MessageBox.Show("BITCH!!!", "АБВГДЁЖ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //    this.Close();
        //}
        //private void даToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    MessageBox.Show("Вы уверенны?", "Точно точно?", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    MessageBox.Show("Точно точно уверены в этом?", "Прям точно точно?", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    MessageBox.Show("ну как скажете", "НУ ладно", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //}
    }
}
