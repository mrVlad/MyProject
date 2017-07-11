using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Filter.Logic;
using MetroFramework.Controls;
using MetroFramework.Forms;

namespace Filter_lab4.Views
{
    public partial class MainForm : MetroForm
    {
        private bool IsValid
        {
            get
            {
                return num_epsilon.Value > 0 && Service.GetData().Any();
            }
        }

        public MainForm()
        {
            InitializeComponent();
        }

        private void FillChart(List<double> data)
        {
            chart1.Series[0].Points.Clear();
            foreach (var item in data)
            {
                chart1.Series[0].Points.AddY(item);
            }
        }

        private void btn_load_data_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = @"CSV (*.csv) | *.csv";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Service.Load(openFileDialog1.FileName);
            }
            FillChart(Service.GetData().ToList());
        }

        private void btn_add_data_Click(object sender, EventArgs e)
        {
            using (FillDataForm formFill = new FillDataForm())
            {
                formFill.ShowDialog();
            }
            FillChart(Service.GetData().ToList());
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            if (IsValid)
            {
                var result = Service.Coef(1).ToList();
                txt_out_result.Text = String.Format("{0}", Service.GetNextValue(result, 1));
                //if (cmb_select_amount.SelectedIndex == 0)
                //{
                //    txt_out_error.Text = @"1 крок";
                //}
                //else
                {
                    //var error = Service.GetError(result, (double)num_epsilon.Value);
                    var error = 3;
                    if (error == 1)
                    {
                        txt_out_error.Text = String.Format("{0} крок", error);
                    }
                    else
                    {
                        txt_out_error.Text = String.Format(error > 4 || error == 0 ? "{0} кроків" : "{0} кроки", error);
                    }
                }

                switch (1)
                {
                    case 0:
                        txt_out_model.Text = String.Format("F = {0:N2} + ({1:N2}) * Fn-1", result[0], result[1]);
                        break;
                    case 1:
                        txt_out_model.Text = String.Format("F = {0:N2} + ({1:N2}) * Fn-1 + ({2:N2}) * Fn-2 + ({3:N2}) * Fn-1 * Fn-2",
                            result[0], result[1], result[2], result[3]);
                        break;
                }
            }

        }

        private void btn_load_data_from_api_Click(object sender, EventArgs e)
        {
            using (LoadDataForm loadDataForm = new LoadDataForm())
            {
                loadDataForm.ShowDialog();
            }
            FillChart(Service.GetData().ToList());
        }

        private void btn1_next_Click(object sender, EventArgs e)
        {
            tab1.SelectTab(1);
        }

        private void btn2_previous_Click(object sender, EventArgs e)
        {
            tab1.SelectTab(0);
        }

        private void btn2_next_Click(object sender, EventArgs e)
        {
            tab1.SelectTab(2);
        }

        private void btn_previous_Click(object sender, EventArgs e)
        {
            tab1.SelectTab(1);
        }

        private void btn_exit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_start_Click_1(object sender, EventArgs e)
        {
            if (IsValid)
            {
                var result = Service.Coef(1).ToList();
                txt_out_result.Text = String.Format("{0}", Service.GetNextValue(result, 1));
                //if (cmb_select_amount.SelectedIndex == 0)
                //{
                //    txt_out_error.Text = @"1 крок";
                //}
                //else
                {
                    //var error = Service.GetError(result, (double)num_epsilon.Value);
                    var error = 3;
                    if (error == 1)
                    {
                        txt_out_error.Text = String.Format("{0} крок", error);
                    }
                    else
                    {
                        txt_out_error.Text = String.Format(error > 4 || error == 0 ? "{0} кроків" : "{0} кроки", error);
                    }
                }

                switch (1)
                {
                    case 0:
                        txt_out_model.Text = String.Format("F = {0:N2} + ({1:N2}) * Fn-1", result[0], result[1]);
                        break;
                    case 1:
                        txt_out_model.Text = String.Format("F = {0:N2} + ({1:N2}) * Fn-1 + ({2:N2}) * Fn-2 + ({3:N2}) * Fn-1 * Fn-2",
                            result[0], result[1], result[2], result[3]);
                        break;
                }
            }
        }
    }
}
