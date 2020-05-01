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
            this.btnAddTovar = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.scrPrice = new System.Windows.Forms.HScrollBar();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbIngred = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.spnSrok = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbRec = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.spnKol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnSrok)).BeginInit();
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
            this.lblKol.Location = new System.Drawing.Point(54, 200);
            this.lblKol.Name = "lblKol";
            this.lblKol.Size = new System.Drawing.Size(66, 13);
            this.lblKol.TabIndex = 1;
            this.lblKol.Text = "Количество";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(54, 247);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(33, 13);
            this.lblPrice.TabIndex = 2;
            this.lblPrice.Text = "Цена";
            // 
            // lblPriceInfo
            // 
            this.lblPriceInfo.AutoSize = true;
            this.lblPriceInfo.Location = new System.Drawing.Point(239, 234);
            this.lblPriceInfo.Name = "lblPriceInfo";
            this.lblPriceInfo.Size = new System.Drawing.Size(19, 13);
            this.lblPriceInfo.TabIndex = 3;
            this.lblPriceInfo.Text = "50";
            // 
            // cmbName
            // 
            this.cmbName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbName.Items.AddRange(new object[] {
            "Белый",
            "Черный",
            "Ржаной"});
            this.cmbName.Location = new System.Drawing.Point(186, 35);
            this.cmbName.Name = "cmbName";
            this.cmbName.Size = new System.Drawing.Size(121, 21);
            this.cmbName.TabIndex = 4;
            // 
            // spnKol
            // 
            this.spnKol.Location = new System.Drawing.Point(188, 193);
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
            1,
            0,
            0,
            0});
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
            this.scrPrice.Location = new System.Drawing.Point(188, 247);
            this.scrPrice.Name = "scrPrice";
            this.scrPrice.Size = new System.Drawing.Size(121, 17);
            this.scrPrice.TabIndex = 9;
            this.scrPrice.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scrPrice_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Ингредиенты";
            // 
            // cmbIngred
            // 
            this.cmbIngred.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIngred.Items.AddRange(new object[] {
            "Кунжутные семечки",
            "Крупа гречневая",
            "Пшеничные отруби"});
            this.cmbIngred.Location = new System.Drawing.Point(186, 75);
            this.cmbIngred.Name = "cmbIngred";
            this.cmbIngred.Size = new System.Drawing.Size(121, 21);
            this.cmbIngred.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Сроки годности(ч)";
            // 
            // spnSrok
            // 
            this.spnSrok.Location = new System.Drawing.Point(186, 113);
            this.spnSrok.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.spnSrok.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spnSrok.Name = "spnSrok";
            this.spnSrok.Size = new System.Drawing.Size(120, 20);
            this.spnSrok.TabIndex = 13;
            this.spnSrok.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Рецепты";
            // 
            // cmbRec
            // 
            this.cmbRec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRec.Items.AddRange(new object[] {
            "Стандартный",
            "Фирменный"});
            this.cmbRec.Location = new System.Drawing.Point(188, 153);
            this.cmbRec.Name = "cmbRec";
            this.cmbRec.Size = new System.Drawing.Size(121, 21);
            this.cmbRec.TabIndex = 15;
            // 
            // frmAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbRec);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.spnSrok);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbIngred);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.scrPrice);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddTovar);
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
            ((System.ComponentModel.ISupportInitialize)(this.spnSrok)).EndInit();
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
        private System.Windows.Forms.Button btnAddTovar;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.HScrollBar scrPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbIngred;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown spnSrok;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbRec;
    }
}