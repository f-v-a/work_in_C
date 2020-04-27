namespace client
{
    partial class frmAdd
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblKol = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblPriceInfo = new System.Windows.Forms.Label();
            this.cmbName = new System.Windows.Forms.ComboBox();
            this.spnKol = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbYesParam = new System.Windows.Forms.RadioButton();
            this.rdbNoParam = new System.Windows.Forms.RadioButton();
            this.btnAddTovar = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.scrPrice = new System.Windows.Forms.HScrollBar();
            ((System.ComponentModel.ISupportInitialize)(this.spnKol)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(54, 38);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(83, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Наименование";
            // 
            // lblKol
            // 
            this.lblKol.AutoSize = true;
            this.lblKol.Location = new System.Drawing.Point(54, 97);
            this.lblKol.Name = "lblKol";
            this.lblKol.Size = new System.Drawing.Size(66, 13);
            this.lblKol.TabIndex = 1;
            this.lblKol.Text = "Количество";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(54, 164);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(33, 13);
            this.lblPrice.TabIndex = 2;
            this.lblPrice.Text = "Цена";
            // 
            // lblPriceInfo
            // 
            this.lblPriceInfo.AutoSize = true;
            this.lblPriceInfo.Location = new System.Drawing.Point(240, 151);
            this.lblPriceInfo.Name = "lblPriceInfo";
            this.lblPriceInfo.Size = new System.Drawing.Size(19, 13);
            this.lblPriceInfo.TabIndex = 3;
            this.lblPriceInfo.Text = "50";
            // 
            // cmbName
            // 
            this.cmbName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbName.Items.AddRange(new object[] {
            "Тетрадь",
            "Ручка",
            "Карандаш"});
            this.cmbName.Location = new System.Drawing.Point(186, 35);
            this.cmbName.Name = "cmbName";
            this.cmbName.Size = new System.Drawing.Size(121, 21);
            this.cmbName.TabIndex = 4;
            // 
            // spnKol
            // 
            this.spnKol.Location = new System.Drawing.Point(186, 97);
            this.spnKol.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.spnKol.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spnKol.Name = "spnKol";
            this.spnKol.Size = new System.Drawing.Size(120, 20);
            this.spnKol.TabIndex = 5;
            this.spnKol.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbYesParam);
            this.groupBox1.Controls.Add(this.rdbNoParam);
            this.groupBox1.Location = new System.Drawing.Point(57, 210);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(249, 87);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Конструктор";
            // 
            // rdbYesParam
            // 
            this.rdbYesParam.AutoSize = true;
            this.rdbYesParam.Location = new System.Drawing.Point(142, 38);
            this.rdbYesParam.Name = "rdbYesParam";
            this.rdbYesParam.Size = new System.Drawing.Size(104, 17);
            this.rdbYesParam.TabIndex = 8;
            this.rdbYesParam.TabStop = true;
            this.rdbYesParam.Text = "С параметрами";
            this.rdbYesParam.UseVisualStyleBackColor = true;
            // 
            // rdbNoParam
            // 
            this.rdbNoParam.AutoSize = true;
            this.rdbNoParam.Location = new System.Drawing.Point(6, 38);
            this.rdbNoParam.Name = "rdbNoParam";
            this.rdbNoParam.Size = new System.Drawing.Size(108, 17);
            this.rdbNoParam.TabIndex = 7;
            this.rdbNoParam.TabStop = true;
            this.rdbNoParam.Text = "Без параметров";
            this.rdbNoParam.UseVisualStyleBackColor = true;
            // 
            // btnAddTovar
            // 
            this.btnAddTovar.Location = new System.Drawing.Point(86, 317);
            this.btnAddTovar.Name = "btnAddTovar";
            this.btnAddTovar.Size = new System.Drawing.Size(75, 23);
            this.btnAddTovar.TabIndex = 7;
            this.btnAddTovar.Text = "Добавить";
            this.btnAddTovar.UseVisualStyleBackColor = true;
            this.btnAddTovar.Click += new System.EventHandler(this.btnAddTovar_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(205, 317);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Отменить";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // scrPrice
            // 
            this.scrPrice.Location = new System.Drawing.Point(186, 164);
            this.scrPrice.Name = "scrPrice";
            this.scrPrice.Size = new System.Drawing.Size(121, 17);
            this.scrPrice.TabIndex = 9;
            this.scrPrice.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scrPrice_Scroll);
            // 
            // frmAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.scrPrice);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddTovar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.spnKol);
            this.Controls.Add(this.cmbName);
            this.Controls.Add(this.lblPriceInfo);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblKol);
            this.Controls.Add(this.lblName);
            this.Name = "frmAdd";
            this.Text = "frmAdd";
            this.Load += new System.EventHandler(this.frmAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spnKol)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblKol;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblPriceInfo;
        private System.Windows.Forms.ComboBox cmbName;
        private System.Windows.Forms.NumericUpDown spnKol;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbYesParam;
        private System.Windows.Forms.RadioButton rdbNoParam;
        private System.Windows.Forms.Button btnAddTovar;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.HScrollBar scrPrice;
    }
}