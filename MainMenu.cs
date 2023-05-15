using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
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
            //this.Text += " " + Properties.Settings.Default.Version; //Добавляем в название программы, версию.
            Properties.Settings.Default.TrytoEncrypt++; //Добавляем +1 к кол-ву запусков программы.
            TrytoEncryptLabel.Text += Properties.Settings.Default.TrytoEncrypt.ToString(); //выводим в Label2 кол-во запусков программы.
            
            //richTextBox1.Text = Properties.Settings.Default.Save_text; // Загружаем ранее сохраненный текст
            Properties.Settings.Default.Save();  // Сохраняем переменные.
        }
        //bool savedone = false;
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
                ///Загрузка Бара
                ///Туть
                // получаем выбранный файл↓
                string filename = saveFileDialog.FileName;
                // сохраняем текст в файл↓
                System.IO.File.WriteAllText(filename, OutResult.Text);
                //savedone = true;
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
                //savedone = false;
                OutResult.Text = fileText;
            }
        }

        private void ввестиКлючToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StringKeyMenu.Text = "Ключ: ";
            //ColumnKeyMenu.Text = "Column: ";
            //ColumnKeyMenu.Text = "";
            Key f = new Key();
            f.ShowDialog();
            StringKeyMenu.Text += DataReform.KeyStringText;
            //ColumnKeyMenu.Text += DataReform.СolumnText;
        }

        private void GoEncryption_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(DataReform.KeyStringText)) //|| (string.IsNullOrEmpty(DataReform.СolumnText)))
            {
                DialogResult result = MessageBox.Show("Прежде чем что то шифровать нужен ключ...\n\nХотите открыть окно с вводом ключа?", "Горе шифровщик...", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    //Открыть форму, если нет то не открывать.
                    Key f = new Key();
                    f.ShowDialog();
                    StringKeyMenu.Text += DataReform.KeyStringText;
                    //ColumnKeyMenu.Text += DataReform.СolumnText;
                }
                //Простое закрытие Сообщения←
            }
            else if (string.IsNullOrEmpty(OutResult.Text))
            {
                OutResult.BackColor = Color.Red;
                MessageBox.Show("Без слов шифрование бесполезно...", "Как говорил великий: Синь Зунь Ци", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                
            }
            else
            {
                //Начать шифровку.↓
                // исходный текст
                string plaintext = OutResult.Text;

                // ключ шифрования
                int key = Convert.ToInt32(DataReform.KeyStringText);

                // шифрование текста
                string ciphertext = EncryptTransposition(plaintext, key);
                OutResult.Text = ciphertext;
            }
        }
        //РАСШИФРОВКА↓
        private void GoDencript_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(OutResult.Text))
            {
                OutResult.BackColor = Color.Red;
                MessageBox.Show("Без шифрования расшифрование бесполезно...", "Как говорил великий: Синь Зунь Ци II", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string ciphertext = OutResult.Text;
                int key = Convert.ToInt32(DataReform.KeyStringText);

                string decryptedtext = DecryptTransposition(ciphertext, key);
                OutResult.Text = decryptedtext;
            }
        }
        // Функция для шифровки текста с помощью шифра транспонирования
        static string EncryptTransposition(string plaintext, int key)
        {
            int rows = (int)Math.Ceiling((double)plaintext.Length / key);
            int columns = key;
            char[,] matrix = new char[rows, columns];
            int k = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (k < plaintext.Length)
                    {
                        matrix[i, j] = plaintext[k++];
                    }
                    else
                    {
                        matrix[i, j] = ' ';
                    }
                }
            }

            StringBuilder ciphertext = new StringBuilder();
            for (int j = 0; j < columns; j++)
            {
                for (int i = 0; i < rows; i++)
                {
                    ciphertext.Append(matrix[i, j]);
                }
            }

            return ciphertext.ToString();
        }
        // Функция для дешифровки текста, зашифрованного шифром транспонирования
        static string DecryptTransposition(string ciphertext, int key)
        {
            int rows = (int)Math.Ceiling((double)ciphertext.Length / key);
            int columns = key;
            char[,] matrix = new char[rows, columns];
            int k = 0;

            for (int j = 0; j < columns; j++)
            {
                for (int i = 0; i < rows; i++)
                {
                    if (k < ciphertext.Length)
                    {
                        matrix[i, j] = ciphertext[k++];
                    }
                    else
                    {
                        matrix[i, j] = ' ';
                    }
                }
            }

            StringBuilder decryptedtext = new StringBuilder();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    decryptedtext.Append(matrix[i, j]);
                }
            }

            return decryptedtext.ToString();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Попытка в закрытие без предупреждения после сохранения.
            //if (savedone = false) { }
            //DialogResult result = MessageBox.Show("Акуратрнее возможно вы не сохранили ведённые данные\n\nТочно хотите выйти?", "Горе шифровщик?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            //if (result == DialogResult.Yes)
            //{
            //    this.Close();
            //}
            //else
            //{
            //    //Простое закрытие←
            //}
        }
        //Подправить предотвращения закрытие формы по кнопке...
        private void Encryption_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Акуратрнее возможно вы не сохранили ведённые данные\n\nТочно хотите выйти?", "Горе шифровщик?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                e.Cancel = (result != DialogResult.Yes);
        }

        private void OutResult_MouseEnter(object sender, EventArgs e)
        {
            OutResult.BackColor= (Color.FromArgb(51, 51, 51));
        }
    }
}
