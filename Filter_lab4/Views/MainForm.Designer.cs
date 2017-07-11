namespace Filter_lab4.Views
{
    partial class MainForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tab1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.btn1_next = new MetroFramework.Controls.MetroTile();
            this.btn_load_data_from_api = new MetroFramework.Controls.MetroTile();
            this.btn_add_data = new MetroFramework.Controls.MetroTile();
            this.btn_load_data = new MetroFramework.Controls.MetroTile();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.btn2_previous = new MetroFramework.Controls.MetroTile();
            this.btn2_next = new MetroFramework.Controls.MetroTile();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.btn_exit = new MetroFramework.Controls.MetroTile();
            this.btn_previous = new MetroFramework.Controls.MetroTile();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txt_out_result = new MetroFramework.Controls.MetroTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_out_model = new MetroFramework.Controls.MetroTextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txt_out_error = new MetroFramework.Controls.MetroTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.num_epsilon = new System.Windows.Forms.NumericUpDown();
            this.btn_start = new MetroFramework.Controls.MetroTile();
            this.tab1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.metroTabPage3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_epsilon)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tab1
            // 
            this.tab1.Controls.Add(this.metroTabPage1);
            this.tab1.Controls.Add(this.metroTabPage2);
            this.tab1.Controls.Add(this.metroTabPage3);
            this.tab1.Location = new System.Drawing.Point(-1, 25);
            this.tab1.Name = "tab1";
            this.tab1.SelectedIndex = 2;
            this.tab1.Size = new System.Drawing.Size(722, 327);
            this.tab1.Style = MetroFramework.MetroColorStyle.Green;
            this.tab1.TabIndex = 8;
            this.tab1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tab1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.btn1_next);
            this.metroTabPage1.Controls.Add(this.btn_load_data_from_api);
            this.metroTabPage1.Controls.Add(this.btn_add_data);
            this.metroTabPage1.Controls.Add(this.btn_load_data);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(714, 285);
            this.metroTabPage1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Додавання даних";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // btn1_next
            // 
            this.btn1_next.ActiveControl = null;
            this.btn1_next.Location = new System.Drawing.Point(544, 232);
            this.btn1_next.Name = "btn1_next";
            this.btn1_next.Size = new System.Drawing.Size(157, 52);
            this.btn1_next.Style = MetroFramework.MetroColorStyle.Purple;
            this.btn1_next.TabIndex = 16;
            this.btn1_next.Text = "Далі";
            this.btn1_next.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn1_next.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btn1_next.UseSelectable = true;
            this.btn1_next.Click += new System.EventHandler(this.btn1_next_Click);
            // 
            // btn_load_data_from_api
            // 
            this.btn_load_data_from_api.ActiveControl = null;
            this.btn_load_data_from_api.Location = new System.Drawing.Point(458, 44);
            this.btn_load_data_from_api.Name = "btn_load_data_from_api";
            this.btn_load_data_from_api.Size = new System.Drawing.Size(243, 141);
            this.btn_load_data_from_api.Style = MetroFramework.MetroColorStyle.Green;
            this.btn_load_data_from_api.TabIndex = 15;
            this.btn_load_data_from_api.Text = "Завантажити дані з API";
            this.btn_load_data_from_api.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_load_data_from_api.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btn_load_data_from_api.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btn_load_data_from_api.UseSelectable = true;
            this.btn_load_data_from_api.Click += new System.EventHandler(this.btn_load_data_from_api_Click);
            // 
            // btn_add_data
            // 
            this.btn_add_data.ActiveControl = null;
            this.btn_add_data.Location = new System.Drawing.Point(265, 44);
            this.btn_add_data.Name = "btn_add_data";
            this.btn_add_data.Size = new System.Drawing.Size(187, 141);
            this.btn_add_data.Style = MetroFramework.MetroColorStyle.Green;
            this.btn_add_data.TabIndex = 13;
            this.btn_add_data.Text = "Додати дані вручну";
            this.btn_add_data.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_add_data.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btn_add_data.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btn_add_data.UseSelectable = true;
            this.btn_add_data.Click += new System.EventHandler(this.btn_add_data_Click);
            // 
            // btn_load_data
            // 
            this.btn_load_data.ActiveControl = null;
            this.btn_load_data.Location = new System.Drawing.Point(16, 44);
            this.btn_load_data.Name = "btn_load_data";
            this.btn_load_data.Size = new System.Drawing.Size(243, 141);
            this.btn_load_data.Style = MetroFramework.MetroColorStyle.Green;
            this.btn_load_data.TabIndex = 12;
            this.btn_load_data.Text = "Завантажити дані з Exel";
            this.btn_load_data.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_load_data.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btn_load_data.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btn_load_data.UseSelectable = true;
            this.btn_load_data.Click += new System.EventHandler(this.btn_load_data_Click);
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.btn2_previous);
            this.metroTabPage2.Controls.Add(this.btn2_next);
            this.metroTabPage2.Controls.Add(this.chart1);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(714, 287);
            this.metroTabPage2.TabIndex = 2;
            this.metroTabPage2.Text = "Графік курсу валюти";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // btn2_previous
            // 
            this.btn2_previous.ActiveControl = null;
            this.btn2_previous.Location = new System.Drawing.Point(12, 229);
            this.btn2_previous.Name = "btn2_previous";
            this.btn2_previous.Size = new System.Drawing.Size(157, 52);
            this.btn2_previous.Style = MetroFramework.MetroColorStyle.Purple;
            this.btn2_previous.TabIndex = 18;
            this.btn2_previous.Text = "Назад";
            this.btn2_previous.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn2_previous.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btn2_previous.UseSelectable = true;
            this.btn2_previous.Click += new System.EventHandler(this.btn2_previous_Click);
            // 
            // btn2_next
            // 
            this.btn2_next.ActiveControl = null;
            this.btn2_next.Location = new System.Drawing.Point(554, 229);
            this.btn2_next.Name = "btn2_next";
            this.btn2_next.Size = new System.Drawing.Size(157, 52);
            this.btn2_next.Style = MetroFramework.MetroColorStyle.Purple;
            this.btn2_next.TabIndex = 17;
            this.btn2_next.Text = "Далі";
            this.btn2_next.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn2_next.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btn2_next.UseSelectable = true;
            this.btn2_next.Click += new System.EventHandler(this.btn2_next_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 10);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Дані";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(689, 204);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.Controls.Add(this.groupBox2);
            this.metroTabPage3.Controls.Add(this.btn_exit);
            this.metroTabPage3.Controls.Add(this.btn_previous);
            this.metroTabPage3.Controls.Add(this.groupBox5);
            this.metroTabPage3.Controls.Add(this.groupBox3);
            this.metroTabPage3.Controls.Add(this.groupBox4);
            this.metroTabPage3.Controls.Add(this.btn_start);
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.HorizontalScrollbarSize = 10;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(714, 285);
            this.metroTabPage3.TabIndex = 3;
            this.metroTabPage3.Text = "Прогнозування";
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            this.metroTabPage3.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.VerticalScrollbarSize = 10;
            // 
            // btn_exit
            // 
            this.btn_exit.ActiveControl = null;
            this.btn_exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_exit.Location = new System.Drawing.Point(551, 222);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(157, 52);
            this.btn_exit.Style = MetroFramework.MetroColorStyle.Purple;
            this.btn_exit.TabIndex = 48;
            this.btn_exit.Text = "Вихід";
            this.btn_exit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_exit.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btn_exit.UseSelectable = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click_1);
            // 
            // btn_previous
            // 
            this.btn_previous.ActiveControl = null;
            this.btn_previous.Location = new System.Drawing.Point(3, 222);
            this.btn_previous.Name = "btn_previous";
            this.btn_previous.Size = new System.Drawing.Size(157, 52);
            this.btn_previous.Style = MetroFramework.MetroColorStyle.Purple;
            this.btn_previous.TabIndex = 47;
            this.btn_previous.Text = "Назад";
            this.btn_previous.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_previous.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btn_previous.UseSelectable = true;
            this.btn_previous.Click += new System.EventHandler(this.btn_previous_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txt_out_result);
            this.groupBox5.Location = new System.Drawing.Point(245, 118);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(466, 46);
            this.groupBox5.TabIndex = 46;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Прогнозоване значення";
            // 
            // txt_out_result
            // 
            // 
            // 
            // 
            this.txt_out_result.CustomButton.Image = null;
            this.txt_out_result.CustomButton.Location = new System.Drawing.Point(431, 1);
            this.txt_out_result.CustomButton.Name = "";
            this.txt_out_result.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_out_result.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_out_result.CustomButton.TabIndex = 1;
            this.txt_out_result.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_out_result.CustomButton.UseSelectable = true;
            this.txt_out_result.CustomButton.Visible = false;
            this.txt_out_result.Enabled = false;
            this.txt_out_result.Lines = new string[0];
            this.txt_out_result.Location = new System.Drawing.Point(6, 17);
            this.txt_out_result.MaxLength = 32767;
            this.txt_out_result.Name = "txt_out_result";
            this.txt_out_result.PasswordChar = '\0';
            this.txt_out_result.ReadOnly = true;
            this.txt_out_result.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_out_result.SelectedText = "";
            this.txt_out_result.SelectionLength = 0;
            this.txt_out_result.SelectionStart = 0;
            this.txt_out_result.ShortcutsEnabled = true;
            this.txt_out_result.Size = new System.Drawing.Size(453, 23);
            this.txt_out_result.Style = MetroFramework.MetroColorStyle.Green;
            this.txt_out_result.TabIndex = 34;
            this.txt_out_result.UseSelectable = true;
            this.txt_out_result.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_out_result.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_out_model);
            this.groupBox3.Location = new System.Drawing.Point(245, 66);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(466, 46);
            this.groupBox3.TabIndex = 46;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Утворена модель";
            // 
            // txt_out_model
            // 
            // 
            // 
            // 
            this.txt_out_model.CustomButton.Image = null;
            this.txt_out_model.CustomButton.Location = new System.Drawing.Point(431, 1);
            this.txt_out_model.CustomButton.Name = "";
            this.txt_out_model.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_out_model.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_out_model.CustomButton.TabIndex = 1;
            this.txt_out_model.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_out_model.CustomButton.UseSelectable = true;
            this.txt_out_model.CustomButton.Visible = false;
            this.txt_out_model.Enabled = false;
            this.txt_out_model.Lines = new string[0];
            this.txt_out_model.Location = new System.Drawing.Point(6, 17);
            this.txt_out_model.MaxLength = 32767;
            this.txt_out_model.Name = "txt_out_model";
            this.txt_out_model.PasswordChar = '\0';
            this.txt_out_model.ReadOnly = true;
            this.txt_out_model.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_out_model.SelectedText = "";
            this.txt_out_model.SelectionLength = 0;
            this.txt_out_model.SelectionStart = 0;
            this.txt_out_model.ShortcutsEnabled = true;
            this.txt_out_model.Size = new System.Drawing.Size(453, 23);
            this.txt_out_model.Style = MetroFramework.MetroColorStyle.Green;
            this.txt_out_model.TabIndex = 35;
            this.txt_out_model.UseSelectable = true;
            this.txt_out_model.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_out_model.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txt_out_error);
            this.groupBox4.Location = new System.Drawing.Point(245, 170);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(466, 46);
            this.groupBox4.TabIndex = 46;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Горизонт прогнозування";
            // 
            // txt_out_error
            // 
            // 
            // 
            // 
            this.txt_out_error.CustomButton.Image = null;
            this.txt_out_error.CustomButton.Location = new System.Drawing.Point(431, 1);
            this.txt_out_error.CustomButton.Name = "";
            this.txt_out_error.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_out_error.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_out_error.CustomButton.TabIndex = 1;
            this.txt_out_error.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_out_error.CustomButton.UseSelectable = true;
            this.txt_out_error.CustomButton.Visible = false;
            this.txt_out_error.Enabled = false;
            this.txt_out_error.Lines = new string[0];
            this.txt_out_error.Location = new System.Drawing.Point(6, 17);
            this.txt_out_error.MaxLength = 32767;
            this.txt_out_error.Name = "txt_out_error";
            this.txt_out_error.PasswordChar = '\0';
            this.txt_out_error.ReadOnly = true;
            this.txt_out_error.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_out_error.SelectedText = "";
            this.txt_out_error.SelectionLength = 0;
            this.txt_out_error.SelectionStart = 0;
            this.txt_out_error.ShortcutsEnabled = true;
            this.txt_out_error.Size = new System.Drawing.Size(453, 23);
            this.txt_out_error.Style = MetroFramework.MetroColorStyle.Green;
            this.txt_out_error.TabIndex = 36;
            this.txt_out_error.UseSelectable = true;
            this.txt_out_error.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_out_error.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.num_epsilon);
            this.groupBox2.Location = new System.Drawing.Point(3, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(708, 51);
            this.groupBox2.TabIndex = 45;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Задайте максимально допустиму похибку";
            // 
            // num_epsilon
            // 
            this.num_epsilon.Location = new System.Drawing.Point(6, 19);
            this.num_epsilon.Name = "num_epsilon";
            this.num_epsilon.Size = new System.Drawing.Size(218, 20);
            this.num_epsilon.TabIndex = 38;
            // 
            // btn_start
            // 
            this.btn_start.ActiveControl = null;
            this.btn_start.Location = new System.Drawing.Point(35, 77);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(169, 133);
            this.btn_start.Style = MetroFramework.MetroColorStyle.Green;
            this.btn_start.TabIndex = 37;
            this.btn_start.Text = "Розрахувати";
            this.btn_start.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_start.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btn_start.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btn_start.UseSelectable = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click_1);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_exit;
            this.ClientSize = new System.Drawing.Size(720, 353);
            this.Controls.Add(this.tab1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.tab1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.metroTabPage3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.num_epsilon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private MetroFramework.Controls.MetroTabControl tab1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroTile btn_load_data;
        private MetroFramework.Controls.MetroTile btn_add_data;
        private MetroFramework.Controls.MetroTile btn_load_data_from_api;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        private MetroFramework.Controls.MetroTile btn1_next;
        private MetroFramework.Controls.MetroTile btn2_previous;
        private MetroFramework.Controls.MetroTile btn2_next;
        private System.Windows.Forms.GroupBox groupBox5;
        private MetroFramework.Controls.MetroTextBox txt_out_result;
        private System.Windows.Forms.GroupBox groupBox3;
        private MetroFramework.Controls.MetroTextBox txt_out_model;
        private System.Windows.Forms.GroupBox groupBox4;
        private MetroFramework.Controls.MetroTextBox txt_out_error;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown num_epsilon;
        private MetroFramework.Controls.MetroTile btn_start;
        private MetroFramework.Controls.MetroTile btn_exit;
        private MetroFramework.Controls.MetroTile btn_previous;
    }
}

