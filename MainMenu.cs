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
        private void Encryption_Load(object sender, EventArgs e)
        {

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
            else
            {
                //Начать шифровку.↓
                string message = "привет";
                int numRows = 6;
                int numColumns = 7;
                int numCharsPerRow = (int)Math.Ceiling((double)message.Length / numRows);

                // Дополним сообщение пробелами до кратности количеству символов в строке
                message = message.PadRight(numCharsPerRow * numRows);

                // Создадим двумерный массив для хранения символов сообщения
                char[,] messageArray = new char[numRows, numCharsPerRow];

                // Заполним массив символами сообщения
                for (int i = 0; i < numRows; i++)
                {
                    for (int j = 0; j < numCharsPerRow; j++)
                    {
                        messageArray[i, j] = message[i * numCharsPerRow + j];
                    }
                }

                // Создадим массив для хранения зашифрованных символов
                char[] encryptedChars = new char[numRows * numCharsPerRow];
                Console.WriteLine(encryptedChars.Length);

                // Заполним массив зашифрованными символами
                for (int i = 0; i < numRows; i++)
                {
                    for (int j = 0; j < numCharsPerRow; j++)
                    {
                        for (int k = 0; k < numCharsPerRow; k++)
                        {
                            int index = i * numCharsPerRow + k;
                            if (index < message.Length)
                            {
                                encryptedChars[i * numCharsPerRow * numCharsPerRow + (j * numCharsPerRow) + k] = messageArray[i, (j * numCharsPerRow + k) % numCharsPerRow];
                            }
                        }
                    }
                }

                // Преобразуем зашифрованные символы в строку
                string encryptedMessage = new string(encryptedChars);

                OutResult.Text += ("Исходное сообщение: " + message);
                OutResult.Text += (" \n ");
                OutResult.Text += ("\nЗашифрованное сообщение: " + encryptedMessage);

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
