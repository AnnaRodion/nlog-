using System;
using System.Windows.Forms;
using NLog;

namespace Nlog1
{
    public partial class Form1 : Form
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MultiplyByItself();
            }
            catch (OverflowException ex)
            {
                logger.Error("Произошла ошибка при умножении переменной на саму себя: " + ex.Message);
                MessageBox.Show("Произошла ошибка при умножении переменной на саму себя. Подробности смотрите в логах.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MultiplyByItself()
        {
            int num = Convert.ToInt32(textBox1.Text);
            while (true)
            {
                checked
                {
                    num *= num;
                }
            }
        }
    }
}
