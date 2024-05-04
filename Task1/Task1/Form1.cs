using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Task1.Classes;

namespace Task1
{
    public partial class Form1 : Form
    {
        private Bank bank;
        private Owner owner;
        private Account account;

        public Form1()
        {
            InitializeComponent();
            bank = new Bank();
        }

        private void FillListBox(List<Account> accounts)
        {
            listBox1.Items.Clear();

            foreach (Account account in accounts)
            {
                listBox1.Items.Add($"Номер счета: {account.Number}");
                listBox1.Items.Add($"Тип счета: {account.AccountType}");
                listBox1.Items.Add($"Баланс счета: {account.Balance}");
                listBox1.Items.Add($"Дата открытия счета: {account.OpeningDate}");
                listBox1.Items.Add($"Смс оповещение: {(account.SmsNotification ? "Включено" : "Выключено")}");
                listBox1.Items.Add($"Интернет-банкинг: {(account.InternetBanking ? "Подключен" : "Не подключен")}");
                listBox1.Items.Add("Владелец:");
                listBox1.Items.Add($"ФИО: {account.Owner.FullName}");
                listBox1.Items.Add($"Дата рождения: {account.Owner.DateOfBirth}");
                listBox1.Items.Add($"Паспортные данные: {account.Owner.PassportData}");
                listBox1.Items.Add("\n");
            }
        }

        private void ClearRecords()
        {
            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
        }

        private void BttnAddOwner_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Вы не ввели ФИО владельца.", "Ошибка");
                return;
            }

            if (string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Вы не ввели паспортные данные.", "Ошибка");
                return;
            }

            try
            {
                string name = textBox2.Text;
                DateTime dateOfBirth = dateTimePicker2.Value.Date;
                string passport = textBox3.Text;

                owner = new Owner()
                {
                    FullName = name,
                    DateOfBirth = dateOfBirth,
                    PassportData = passport
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }

        private void BttnCreateAcc_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Вы не ввели тип аккаунта", "Ошибка");
                return;
            }
            
            if (owner == null)
            {
                MessageBox.Show("Вы не добавили владельца", "Ошибка");
                return;
            }

            try
            {
                int num = Convert.ToInt32(numericUpDown1.Value);
                string typeAcc = textBox1.Text;
                decimal balance = numericUpDown2.Value;
                DateTime dateOfOpen = dateTimePicker1.Value.Date;
                bool smsNot = checkBox1.Checked;
                bool netBank = checkBox2.Checked;

                account = new Account() { 
                    Number = num,
                    AccountType = typeAcc,
                    Balance = balance,
                    OpeningDate = dateOfOpen,
                    SmsNotification = smsNot,
                    InternetBanking = netBank,
                    Owner = owner
                };

                bank.AddAccount(account);

                FillListBox(bank.GetAccounts());
                ClearRecords();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }

        private void BttnSortByType_Click(object sender, EventArgs e)
        {
            FillListBox(bank.SortByAccountType());
        }

        private void BttnSortByDate_Click(object sender, EventArgs e)
        {
            FillListBox(bank.SortByOpeningDate());
        }

        private void BttnFindByNum_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            listBox1.Items.Add("Поиск по номеру счета:");

            Account acc = bank.FindByNumber(Convert.ToInt32(numericUpDown3.Value));

            FillListBox(new List<Account>(1) { acc });
        }

        private void BttnFindByName_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox4.Text))
            {
                MessageBox.Show("Вы не ввели ФИО владельца для поиска", "Ошибка");
                return;
            }

            listBox1.Items.Clear();

            listBox1.Items.Add("Поиск по ФИО владельца:");

            FillListBox(bank.FindByOwner(textBox4.Text));
        }

        private void BttnFindByBal_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            listBox1.Items.Add("Поиск по балансу");

            FillListBox(bank.FindByBalance(numericUpDown4.Value));
        }

        private void BttnFindByType_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox5.Text))
            {
                MessageBox.Show("Вы не ввели тип счета для поиска", "Ошибка");
                return;
            }

            listBox1.Items.Clear();

            listBox1.Items.Add("Поиск по типу");

            FillListBox(bank.FindByAccountType(textBox5.Text));
        }
    }
}
