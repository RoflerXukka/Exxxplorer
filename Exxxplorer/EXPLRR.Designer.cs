namespace Exxxplorer
{
    partial class Explrr
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.DRIVERS_OF_COMP = new System.Windows.Forms.DataGridView();
            this.Drivers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataOfDir = new System.Windows.Forms.DataGridView();
            this.Naaaame = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sizeee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CurrentPick = new System.Windows.Forms.TextBox();
            this.StepBack = new System.Windows.Forms.Button();
            this.TIP = new System.Windows.Forms.Label();
            this.TIP2 = new System.Windows.Forms.Label();
            this.TIP3 = new System.Windows.Forms.Label();
            this.EXTNSION_SEARCH = new System.Windows.Forms.TextBox();
            this.TIP4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DRIVERS_OF_COMP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataOfDir)).BeginInit();
            this.SuspendLayout();
            // 
            // DRIVERS_OF_COMP
            // 
            this.DRIVERS_OF_COMP.AllowUserToAddRows = false;
            this.DRIVERS_OF_COMP.AllowUserToDeleteRows = false;
            this.DRIVERS_OF_COMP.AllowUserToResizeColumns = false;
            this.DRIVERS_OF_COMP.AllowUserToResizeRows = false;
            this.DRIVERS_OF_COMP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DRIVERS_OF_COMP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Drivers});
            this.DRIVERS_OF_COMP.Location = new System.Drawing.Point(13, 13);
            this.DRIVERS_OF_COMP.MultiSelect = false;
            this.DRIVERS_OF_COMP.Name = "DRIVERS_OF_COMP";
            this.DRIVERS_OF_COMP.ReadOnly = true;
            this.DRIVERS_OF_COMP.RowHeadersVisible = false;
            this.DRIVERS_OF_COMP.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DRIVERS_OF_COMP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DRIVERS_OF_COMP.Size = new System.Drawing.Size(105, 149);
            this.DRIVERS_OF_COMP.TabIndex = 0;
            // 
            // Drivers
            // 
            this.Drivers.HeaderText = "Диски";
            this.Drivers.Name = "Drivers";
            this.Drivers.ReadOnly = true;
            // 
            // DataOfDir
            // 
            this.DataOfDir.AllowUserToAddRows = false;
            this.DataOfDir.AllowUserToDeleteRows = false;
            this.DataOfDir.AllowUserToResizeColumns = false;
            this.DataOfDir.AllowUserToResizeRows = false;
            this.DataOfDir.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataOfDir.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Naaaame,
            this.Type,
            this.Sizeee});
            this.DataOfDir.Location = new System.Drawing.Point(217, 12);
            this.DataOfDir.MultiSelect = false;
            this.DataOfDir.Name = "DataOfDir";
            this.DataOfDir.ReadOnly = true;
            this.DataOfDir.RowHeadersVisible = false;
            this.DataOfDir.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataOfDir.Size = new System.Drawing.Size(512, 309);
            this.DataOfDir.TabIndex = 1;
            this.DataOfDir.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataOfDir_CellMouseDoubleClick);
            // 
            // Naaaame
            // 
            this.Naaaame.HeaderText = "Имя";
            this.Naaaame.Name = "Naaaame";
            this.Naaaame.ReadOnly = true;
            this.Naaaame.Width = 250;
            // 
            // Type
            // 
            this.Type.HeaderText = "Тип";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            this.Type.Width = 120;
            // 
            // Sizeee
            // 
            this.Sizeee.HeaderText = "Размер";
            this.Sizeee.Name = "Sizeee";
            this.Sizeee.ReadOnly = true;
            this.Sizeee.Width = 120;
            // 
            // CurrentPick
            // 
            this.CurrentPick.Location = new System.Drawing.Point(13, 178);
            this.CurrentPick.Name = "CurrentPick";
            this.CurrentPick.Size = new System.Drawing.Size(160, 20);
            this.CurrentPick.TabIndex = 2;
            this.CurrentPick.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CurrentPick_KeyUp);
            // 
            // StepBack
            // 
            this.StepBack.Enabled = false;
            this.StepBack.Location = new System.Drawing.Point(138, 13);
            this.StepBack.Name = "StepBack";
            this.StepBack.Size = new System.Drawing.Size(73, 53);
            this.StepBack.TabIndex = 3;
            this.StepBack.Text = "Назад";
            this.StepBack.UseVisualStyleBackColor = true;
            this.StepBack.Click += new System.EventHandler(this.StepBack_Click);
            // 
            // TIP
            // 
            this.TIP.AutoSize = true;
            this.TIP.Location = new System.Drawing.Point(29, 205);
            this.TIP.Name = "TIP";
            this.TIP.Size = new System.Drawing.Size(82, 13);
            this.TIP.TabIndex = 4;
            this.TIP.Text = "Жмякните F10";
            // 
            // TIP2
            // 
            this.TIP2.Location = new System.Drawing.Point(13, 255);
            this.TIP2.Name = "TIP2";
            this.TIP2.Size = new System.Drawing.Size(160, 33);
            this.TIP2.TabIndex = 5;
            this.TIP2.Text = "А это то, чего мне не хватало в обычном проводнике";
            // 
            // TIP3
            // 
            this.TIP3.Location = new System.Drawing.Point(10, 288);
            this.TIP3.Name = "TIP3";
            this.TIP3.Size = new System.Drawing.Size(122, 62);
            this.TIP3.TabIndex = 7;
            this.TIP3.Text = "Отобразить в текущей дирректории все файлы с расширением";
            // 
            // EXTNSION_SEARCH
            // 
            this.EXTNSION_SEARCH.Location = new System.Drawing.Point(87, 327);
            this.EXTNSION_SEARCH.Name = "EXTNSION_SEARCH";
            this.EXTNSION_SEARCH.Size = new System.Drawing.Size(73, 20);
            this.EXTNSION_SEARCH.TabIndex = 8;
            this.EXTNSION_SEARCH.KeyUp += new System.Windows.Forms.KeyEventHandler(this.EXTNSION_SEARCH_KeyUp);
            // 
            // TIP4
            // 
            this.TIP4.AutoSize = true;
            this.TIP4.Location = new System.Drawing.Point(166, 337);
            this.TIP4.Name = "TIP4";
            this.TIP4.Size = new System.Drawing.Size(82, 13);
            this.TIP4.TabIndex = 9;
            this.TIP4.Text = "Жмякните F10";
            // 
            // Explrr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 359);
            this.Controls.Add(this.TIP4);
            this.Controls.Add(this.EXTNSION_SEARCH);
            this.Controls.Add(this.TIP3);
            this.Controls.Add(this.TIP2);
            this.Controls.Add(this.TIP);
            this.Controls.Add(this.StepBack);
            this.Controls.Add(this.CurrentPick);
            this.Controls.Add(this.DataOfDir);
            this.Controls.Add(this.DRIVERS_OF_COMP);
            this.Name = "Explrr";
            this.Text = "Проводник (какашка а не проводник)";
            this.Load += new System.EventHandler(this.Explrr_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DRIVERS_OF_COMP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataOfDir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DRIVERS_OF_COMP;
        private System.Windows.Forms.DataGridView DataOfDir;
        private System.Windows.Forms.DataGridViewTextBoxColumn Drivers;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naaaame;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sizeee;
        private System.Windows.Forms.TextBox CurrentPick;
        private System.Windows.Forms.Button StepBack;
        private System.Windows.Forms.Label TIP;
        private System.Windows.Forms.Label TIP2;
        private System.Windows.Forms.Label TIP3;
        private System.Windows.Forms.TextBox EXTNSION_SEARCH;
        private System.Windows.Forms.Label TIP4;
    }
}

