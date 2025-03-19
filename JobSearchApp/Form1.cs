using System;
using System.Windows.Forms;

namespace JobSearchApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Заповнення списку типів робіт
            listBoxJobs.Items.Add("Системний адміністратор");
            listBoxJobs.Items.Add("Веб-програміст");
            listBoxJobs.Items.Add("Веб-дизайнер");
            listBoxJobs.Items.Add("Модератор сайтів");

            // Заповнення ComboBox зарплатами
            comboBoxSalary.Items.Add("5000");
            comboBoxSalary.Items.Add("7000");
            comboBoxSalary.Items.Add("9000");
            comboBoxSalary.Items.Add("11000");

            // Встановлення початкового вибору для ComboBox
            comboBoxSalary.SelectedIndex = 0; // Початкова зарплата 5000
        }

        private void btnShowResults_Click(object sender, EventArgs e)
        {
            // Перевірка, чи обрано тип роботи
            if (listBoxJobs.SelectedItem == null)
            {
                MessageBox.Show("Будь ласка, виберіть тип роботи!");
                return;
            }

            // Перевірка, чи вибрано зарплату
            if (comboBoxSalary.SelectedItem == null)
            {
                MessageBox.Show("Будь ласка, виберіть зарплату!");
                return;
            }

            // Отримання вибраних даних
            string jobType = listBoxJobs.SelectedItem.ToString();
            string salary = comboBoxSalary.SelectedItem.ToString();
            int experience = (int)numericUpDownExperience.Value;

            // Формування результату
            string result = $"Тип роботи: {jobType}\r\n" +
                            $"Зарплата: {salary} грн.\r\n" +
                            $"Стаж роботи: {experience} років";

            // Виведення результатів у TextBox
            textBoxResults.Text = result;
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void comboBoxSalary_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
