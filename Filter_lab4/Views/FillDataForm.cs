using System;
using System.Linq;
using System.Windows.Forms;
using Filter.Logic;
using MetroFramework.Forms;
using MetroFramework.Components;

namespace Filter_lab4.Views
{
    public partial class FillDataForm : MetroForm
    {
        private bool IsValid
        {
            get { return num_value.Value > 0; }
        }

        public FillDataForm()
        {
            InitializeComponent();
            list_data.Items.Clear();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (IsValid)
            {
                list_data.Items.Add(num_value.Value);
            }
            else
            {
                MessageBox.Show("Введіть значення !");
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (list_data.SelectedIndex != -1)
            {
                list_data.Items.RemoveAt(list_data.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Виділіть значення для видалення !");
            }
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (list_data.Items.Count > 0)
            {
                var data = (from object value in list_data.Items select Convert.ToDouble(value)).ToList();
                Service.SetData(data);
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Додайте данні !");
                DialogResult = DialogResult.None;
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (list_data.Items.Count > 0)
            {
                fd_save_data.Filter = @"CSV (*.csv) | *.csv";
                if (fd_save_data.ShowDialog() == DialogResult.OK)
                {
                    var data = (from object value in list_data.Items select Convert.ToDouble(value)).ToList();
                    Service.SetData(data);
                    Service.Save(fd_save_data.FileName);
                }
            }
            else
            {
                MessageBox.Show("Додайте данні !");
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
