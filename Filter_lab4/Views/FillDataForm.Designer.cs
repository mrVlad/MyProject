namespace Filter_lab4.Views
{
    partial class FillDataForm
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
            this.num_value = new System.Windows.Forms.NumericUpDown();
            this.list_data = new System.Windows.Forms.ListBox();
            this.fd_save_data = new System.Windows.Forms.SaveFileDialog();
            this.btn_exit = new MetroFramework.Controls.MetroTile();
            this.btn_save = new MetroFramework.Controls.MetroTile();
            this.btn_ok = new MetroFramework.Controls.MetroTile();
            this.btn_delete = new MetroFramework.Controls.MetroTile();
            this.btn_add = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.num_value)).BeginInit();
            this.SuspendLayout();
            // 
            // num_value
            // 
            this.num_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.num_value.Location = new System.Drawing.Point(23, 48);
            this.num_value.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.num_value.Name = "num_value";
            this.num_value.Size = new System.Drawing.Size(147, 22);
            this.num_value.TabIndex = 0;
            // 
            // list_data
            // 
            this.list_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.list_data.FormattingEnabled = true;
            this.list_data.ItemHeight = 16;
            this.list_data.Location = new System.Drawing.Point(23, 81);
            this.list_data.Name = "list_data";
            this.list_data.Size = new System.Drawing.Size(147, 196);
            this.list_data.TabIndex = 1;
            // 
            // btn_exit
            // 
            this.btn_exit.ActiveControl = null;
            this.btn_exit.Location = new System.Drawing.Point(188, 234);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(121, 43);
            this.btn_exit.Style = MetroFramework.MetroColorStyle.Purple;
            this.btn_exit.TabIndex = 7;
            this.btn_exit.Text = "Вихід";
            this.btn_exit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_exit.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btn_exit.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btn_exit.UseSelectable = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_save
            // 
            this.btn_save.ActiveControl = null;
            this.btn_save.Location = new System.Drawing.Point(188, 136);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(121, 43);
            this.btn_save.Style = MetroFramework.MetroColorStyle.Green;
            this.btn_save.TabIndex = 8;
            this.btn_save.Text = "Зберегти";
            this.btn_save.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_save.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btn_save.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btn_save.UseSelectable = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_ok
            // 
            this.btn_ok.ActiveControl = null;
            this.btn_ok.Location = new System.Drawing.Point(188, 185);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(121, 43);
            this.btn_ok.Style = MetroFramework.MetroColorStyle.Green;
            this.btn_ok.TabIndex = 10;
            this.btn_ok.Text = "ОК";
            this.btn_ok.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_ok.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btn_ok.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btn_ok.UseSelectable = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.ActiveControl = null;
            this.btn_delete.Location = new System.Drawing.Point(188, 87);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(121, 43);
            this.btn_delete.Style = MetroFramework.MetroColorStyle.Green;
            this.btn_delete.TabIndex = 11;
            this.btn_delete.Text = "Видалити";
            this.btn_delete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_delete.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btn_delete.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btn_delete.UseSelectable = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_add
            // 
            this.btn_add.ActiveControl = null;
            this.btn_add.Location = new System.Drawing.Point(188, 38);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(121, 43);
            this.btn_add.Style = MetroFramework.MetroColorStyle.Green;
            this.btn_add.TabIndex = 12;
            this.btn_add.Text = "Додати";
            this.btn_add.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_add.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btn_add.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btn_add.UseSelectable = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // FillDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 297);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.list_data);
            this.Controls.Add(this.num_value);
            this.Name = "FillDataForm";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Green;
            ((System.ComponentModel.ISupportInitialize)(this.num_value)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown num_value;
        private System.Windows.Forms.ListBox list_data;
        private System.Windows.Forms.SaveFileDialog fd_save_data;
        private MetroFramework.Controls.MetroTile btn_exit;
        private MetroFramework.Controls.MetroTile btn_save;
        private MetroFramework.Controls.MetroTile btn_ok;
        private MetroFramework.Controls.MetroTile btn_delete;
        private MetroFramework.Controls.MetroTile btn_add;
    }
}