using System;
using MetroFramework.Controls;

namespace Filter_lab4.Views
{
    partial class LoadDataForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.data_time_day1 = new MetroFramework.Controls.MetroDateTime();
            this.data_time_day2 = new MetroFramework.Controls.MetroDateTime();
            this.cmb_currency_type = new MetroFramework.Controls.MetroComboBox();
            this.fd_save_data = new System.Windows.Forms.SaveFileDialog();
            this.data_list = new System.Windows.Forms.ListBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.btn_ok = new MetroFramework.Controls.MetroTile();
            this.btn_save = new MetroFramework.Controls.MetroTile();
            this.dtn_exit = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // data_time_day1
            // 
            this.data_time_day1.Location = new System.Drawing.Point(132, 79);
            this.data_time_day1.MinimumSize = new System.Drawing.Size(0, 29);
            this.data_time_day1.Name = "data_time_day1";
            this.data_time_day1.Size = new System.Drawing.Size(200, 29);
            this.data_time_day1.TabIndex = 0;
            // 
            // data_time_day2
            // 
            this.data_time_day2.Location = new System.Drawing.Point(430, 79);
            this.data_time_day2.MinimumSize = new System.Drawing.Size(0, 29);
            this.data_time_day2.Name = "data_time_day2";
            this.data_time_day2.Size = new System.Drawing.Size(200, 29);
            this.data_time_day2.TabIndex = 1;
            // 
            // cmb_currency_type
            // 
            this.cmb_currency_type.FormattingEnabled = true;
            this.cmb_currency_type.ItemHeight = 23;
            this.cmb_currency_type.Items.AddRange(new object[] {
            "Євро (EUR)",
            "Американський долар (USD)",
            "Британский фунт (GBP)       ",
            "Польский злотий (PLN)",
            "Білоруський рубль (BYN)",
            "Турецька ліра (TRY)",
            "Китайський юань (CNY)"});
            this.cmb_currency_type.Location = new System.Drawing.Point(178, 129);
            this.cmb_currency_type.Name = "cmb_currency_type";
            this.cmb_currency_type.Size = new System.Drawing.Size(452, 29);
            this.cmb_currency_type.TabIndex = 3;
            this.cmb_currency_type.UseSelectable = true;
            // 
            // data_list
            // 
            this.data_list.FormattingEnabled = true;
            this.data_list.Location = new System.Drawing.Point(636, 27);
            this.data_list.Name = "data_list";
            this.data_list.Size = new System.Drawing.Size(121, 225);
            this.data_list.TabIndex = 8;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 79);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(103, 19);
            this.metroLabel1.TabIndex = 9;
            this.metroLabel1.Text = "Початкова дата";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(338, 79);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(86, 19);
            this.metroLabel2.TabIndex = 10;
            this.metroLabel2.Text = "Кінцева дата";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(23, 129);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(149, 19);
            this.metroLabel3.TabIndex = 11;
            this.metroLabel3.Text = "Найменування валюти";
            // 
            // btn_ok
            // 
            this.btn_ok.ActiveControl = null;
            this.btn_ok.Location = new System.Drawing.Point(156, 188);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(109, 55);
            this.btn_ok.Style = MetroFramework.MetroColorStyle.Green;
            this.btn_ok.TabIndex = 12;
            this.btn_ok.Text = "OK";
            this.btn_ok.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_ok.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btn_ok.UseSelectable = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click_1);
            // 
            // btn_save
            // 
            this.btn_save.ActiveControl = null;
            this.btn_save.Location = new System.Drawing.Point(271, 188);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(109, 55);
            this.btn_save.Style = MetroFramework.MetroColorStyle.Green;
            this.btn_save.TabIndex = 13;
            this.btn_save.Text = "Зберегти";
            this.btn_save.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_save.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btn_save.UseSelectable = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click_1);
            // 
            // dtn_exit
            // 
            this.dtn_exit.ActiveControl = null;
            this.dtn_exit.Location = new System.Drawing.Point(386, 188);
            this.dtn_exit.Name = "dtn_exit";
            this.dtn_exit.Size = new System.Drawing.Size(109, 55);
            this.dtn_exit.Style = MetroFramework.MetroColorStyle.Purple;
            this.dtn_exit.TabIndex = 14;
            this.dtn_exit.Text = "Вихід";
            this.dtn_exit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dtn_exit.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.dtn_exit.UseSelectable = true;
            this.dtn_exit.Click += new System.EventHandler(this.dtn_exit_Click);
            // 
            // LoadDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 266);
            this.Controls.Add(this.dtn_exit);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.data_list);
            this.Controls.Add(this.cmb_currency_type);
            this.Controls.Add(this.data_time_day2);
            this.Controls.Add(this.data_time_day1);
            this.Name = "LoadDataForm";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Завантаження даних";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroDateTime data_time_day1;
        private MetroFramework.Controls.MetroDateTime data_time_day2;
        private MetroFramework.Controls.MetroComboBox cmb_currency_type;
        private System.Windows.Forms.SaveFileDialog fd_save_data;
        private System.Windows.Forms.ListBox data_list;
        private MetroLabel metroLabel1;
        private MetroLabel metroLabel2;
        private MetroLabel metroLabel3;
        private MetroTile btn_ok;
        private MetroTile btn_save;
        private MetroTile dtn_exit;
    }
}