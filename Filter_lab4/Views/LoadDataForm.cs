using System;
using System.Linq;
using System.Windows.Forms;
using Filter.Common.Enums;
using Filter.Logic;
using Filter.Logic.Helpers;
using MetroFramework;
using MetroFramework.Components;
using MetroFramework.Controls;
using MetroFramework.Forms;

namespace Filter_lab4.Views
{
    public partial class LoadDataForm : MetroForm
    {
        private bool IsValid
        {
            get
            {
                return cmb_currency_type.SelectedIndex > -1 &&
                    data_time_day1.Value != data_time_day2.Value;
            }
        }

        public LoadDataForm()
        {
            InitializeComponent();
        }

        //private void btn_ok_Click(object sender, System.EventArgs e)
        //{
        //    if (IsValid)
        //    {
        //        //var data = Service.GetApiData((CurrencyType) cmb_currency_type.SelectedIndex, data_time_day1.Value);

        //        data_list.Items.Clear();
        //        var day1 = data_time_day1.Value;
        //        var day2 = data_time_day2.Value;
        //        var type = (CurrencyType)cmb_currency_type.SelectedIndex;

        //        for (DateTime date = day1; date <= day2; date = date.AddDays(1))
        //        {
        //            var rate = Service.GetApiData(type, date);
        //            data_list.Items.Add(String.Format("{0} - {1}", date.ToString("yyyy.MM.dd"), rate));
        //        }
        //    }
        //    else
        //    {
        //        MetroMessageBox.Show(this, "Заповніть всі поля !", "Помилка",
        //            MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
        //    }
        //}

        private void btn_save_Click(object sender, System.EventArgs e)
        {
            if (data_list.Items.Count > 0)
            {
                fd_save_data.Filter = @"CSV (*.csv) | *.csv";
                if (fd_save_data.ShowDialog() == DialogResult.OK)
                {
                    var data = (from object value in data_list.Items select Convert.ToDouble(value)).ToList();
                    Service.SetData(data);
                    Service.Save(fd_save_data.FileName);
                }
            }
            else
            {
                MessageBox.Show("Заповніть всі поля !");
            }
        }

        private void _fill_data_grid(double rate)
        {
            
        }

        private void btn_save_Click_1(object sender, EventArgs e)
        {
            if (data_list.Items.Count > 0)
            {
                fd_save_data.Filter = @"CSV (*.csv) | *.csv";
                if (fd_save_data.ShowDialog() == DialogResult.OK)
                {
                    var data = (from object value in data_list.Items select Convert.ToDouble(value)).ToList();
                    Service.SetData(data);
                    Service.Save(fd_save_data.FileName);
                }
            }
            else
            {
                MessageBox.Show("Заповніть всі поля !");
            }
        }

        private void btn_ok_Click_1(object sender, EventArgs e)
        {
            if (IsValid)
            {
                //var data = Service.GetApiData((CurrencyType) cmb_currency_type.SelectedIndex, data_time_day1.Value);

                data_list.Items.Clear();
                var day1 = data_time_day1.Value;
                var day2 = data_time_day2.Value;
                var type = (CurrencyType)cmb_currency_type.SelectedIndex;

                for (DateTime date = day1; date <= day2; date = date.AddDays(1))
                {
                    var rate = Service.GetApiData(type, date);
                    data_list.Items.Add(rate);
                }
                var data = (from object value in data_list.Items select Convert.ToDouble(value)).ToList();
                Service.SetData(data);
                DialogResult = DialogResult.OK;
            }
            else
            {
                MetroMessageBox.Show(this, "Заповніть всі поля !", "Помилка",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }

        private void dtn_exit_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
