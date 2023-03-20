using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace encryption
{
    public partial class Key : Form
    {
        public Key()
        {
            InitializeComponent();
        }

        private void Key_Load(object sender, EventArgs e)
        {

        }

        private void StringBox_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(StringBox.Text)) //== (OutResult.Text.Length < 4))
            {
                InOutPutDataError.SetError(StringBox, "Нe может быть пустым!");
            }
            //else if (OutResult.Text.Length < 4)
            //{
            //    InOutPutDataError.SetError(OutResult, "Слишком короткое имя!");
            //}
            else
            {
                InOutPutDataError.Clear();
            }
        }

        private void СolumnBox_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(СolumnBox.Text)) //== (OutResult.Text.Length < 4))
            {
                InOutPutDataError.SetError(СolumnBox, "Нe может быть пустым!");
            }
            //else if (OutResult.Text.Length < 4)
            //{
            //    InOutPutDataError.SetError(OutResult, "Слишком короткое имя!");
            //}
            else
            {
                InOutPutDataError.Clear();
            }
        }

        private void Key_FormClosing(object sender, FormClosingEventArgs e)
        {
            DataReform.StringText = StringBox.Text;
            DataReform.СolumnText = СolumnBox.Text;
        }
    }
}
