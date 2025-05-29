namespace CategraReal
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.noteListBox = new System.Windows.Forms.ListBox();
            this.categoriesComboBox = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.mainPageTab = new System.Windows.Forms.TabPage();
            this.titleLbl = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.noteTitleLbl = new System.Windows.Forms.Label();
            this.categoryTab = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.updateCategoryBtn = new System.Windows.Forms.Button();
            this.chosenCategoryTxtBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chosenCategoryTitleTxtBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.createCategoryBtn = new System.Windows.Forms.Button();
            this.newCategoryDescriptionLbl = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.newCategoryTitleLbl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.categoriesLbl = new System.Windows.Forms.Label();
            this.categoriesListBox = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.mainPageTab.SuspendLayout();
            this.categoryTab.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // noteListBox
            // 
            this.noteListBox.BackColor = System.Drawing.Color.White;
            this.noteListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.noteListBox.ForeColor = System.Drawing.SystemColors.Window;
            this.noteListBox.FormattingEnabled = true;
            this.noteListBox.Location = new System.Drawing.Point(49, 115);
            this.noteListBox.Name = "noteListBox";
            this.noteListBox.Size = new System.Drawing.Size(168, 143);
            this.noteListBox.Sorted = true;
            this.noteListBox.TabIndex = 0;
            this.noteListBox.SelectedIndexChanged += new System.EventHandler(this.noteListBox_SelectedIndexChanged);
            // 
            // categoriesComboBox
            // 
            this.categoriesComboBox.BackColor = System.Drawing.Color.White;
            this.categoriesComboBox.ForeColor = System.Drawing.SystemColors.MenuText;
            this.categoriesComboBox.FormattingEnabled = true;
            this.categoriesComboBox.Location = new System.Drawing.Point(49, 32);
            this.categoriesComboBox.Name = "categoriesComboBox";
            this.categoriesComboBox.Size = new System.Drawing.Size(168, 21);
            this.categoriesComboBox.TabIndex = 1;
            this.categoriesComboBox.Text = "Kategoriler";
            this.categoriesComboBox.SelectedIndexChanged += new System.EventHandler(this.categoriesComboBox_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.mainPageTab);
            this.tabControl1.Controls.Add(this.categoryTab);
            this.tabControl1.Location = new System.Drawing.Point(-1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(863, 545);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 2;
            // 
            // mainPageTab
            // 
            this.mainPageTab.AutoScroll = true;
            this.mainPageTab.BackColor = System.Drawing.Color.White;
            this.mainPageTab.Controls.Add(this.titleLbl);
            this.mainPageTab.Controls.Add(this.richTextBox1);
            this.mainPageTab.Controls.Add(this.noteTitleLbl);
            this.mainPageTab.Controls.Add(this.categoriesComboBox);
            this.mainPageTab.Controls.Add(this.noteListBox);
            this.mainPageTab.Location = new System.Drawing.Point(4, 22);
            this.mainPageTab.Name = "mainPageTab";
            this.mainPageTab.Padding = new System.Windows.Forms.Padding(3);
            this.mainPageTab.Size = new System.Drawing.Size(855, 519);
            this.mainPageTab.TabIndex = 0;
            this.mainPageTab.Text = "Notlar";
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.Location = new System.Drawing.Point(271, 3);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(0, 28);
            this.titleLbl.TabIndex = 5;
            // 
            // richTextBox1
            // 
            this.richTextBox1.AcceptsTab = true;
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox1.Font = new System.Drawing.Font("Bodoni MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.richTextBox1.Location = new System.Drawing.Point(270, 32);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(577, 476);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // noteTitleLbl
            // 
            this.noteTitleLbl.AutoSize = true;
            this.noteTitleLbl.BackColor = System.Drawing.Color.Transparent;
            this.noteTitleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.noteTitleLbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.noteTitleLbl.Location = new System.Drawing.Point(265, 3);
            this.noteTitleLbl.Name = "noteTitleLbl";
            this.noteTitleLbl.Size = new System.Drawing.Size(0, 26);
            this.noteTitleLbl.TabIndex = 3;
            // 
            // categoryTab
            // 
            this.categoryTab.Controls.Add(this.groupBox2);
            this.categoryTab.Controls.Add(this.groupBox1);
            this.categoryTab.Controls.Add(this.categoriesLbl);
            this.categoryTab.Controls.Add(this.categoriesListBox);
            this.categoryTab.Location = new System.Drawing.Point(4, 22);
            this.categoryTab.Name = "categoryTab";
            this.categoryTab.Padding = new System.Windows.Forms.Padding(3);
            this.categoryTab.Size = new System.Drawing.Size(855, 519);
            this.categoryTab.TabIndex = 1;
            this.categoryTab.Text = "Kategori";
            this.categoryTab.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.updateCategoryBtn);
            this.groupBox2.Controls.Add(this.chosenCategoryTxtBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.chosenCategoryTitleTxtBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(533, 252);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(317, 256);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Seçilen Kategoriyi Güncelle";
            // 
            // updateCategoryBtn
            // 
            this.updateCategoryBtn.Location = new System.Drawing.Point(119, 165);
            this.updateCategoryBtn.Name = "updateCategoryBtn";
            this.updateCategoryBtn.Size = new System.Drawing.Size(75, 23);
            this.updateCategoryBtn.TabIndex = 4;
            this.updateCategoryBtn.Text = "Güncelle";
            this.updateCategoryBtn.UseVisualStyleBackColor = true;
            this.updateCategoryBtn.Click += new System.EventHandler(this.updateCategoryBtn_Click);
            // 
            // chosenCategoryTxtBox
            // 
            this.chosenCategoryTxtBox.Location = new System.Drawing.Point(119, 114);
            this.chosenCategoryTxtBox.Multiline = true;
            this.chosenCategoryTxtBox.Name = "chosenCategoryTxtBox";
            this.chosenCategoryTxtBox.Size = new System.Drawing.Size(134, 20);
            this.chosenCategoryTxtBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(22, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Açıklama";
            // 
            // chosenCategoryTitleTxtBox
            // 
            this.chosenCategoryTitleTxtBox.Location = new System.Drawing.Point(119, 75);
            this.chosenCategoryTitleTxtBox.Name = "chosenCategoryTitleTxtBox";
            this.chosenCategoryTitleTxtBox.Size = new System.Drawing.Size(134, 20);
            this.chosenCategoryTitleTxtBox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(22, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Başlık";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.createCategoryBtn);
            this.groupBox1.Controls.Add(this.newCategoryDescriptionLbl);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.newCategoryTitleLbl);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(533, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(317, 238);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yeni Kategori Oluştur";
            // 
            // createCategoryBtn
            // 
            this.createCategoryBtn.Location = new System.Drawing.Point(119, 165);
            this.createCategoryBtn.Name = "createCategoryBtn";
            this.createCategoryBtn.Size = new System.Drawing.Size(75, 23);
            this.createCategoryBtn.TabIndex = 4;
            this.createCategoryBtn.Text = "Ekle";
            this.createCategoryBtn.UseVisualStyleBackColor = true;
            this.createCategoryBtn.Click += new System.EventHandler(this.createCategoryBtn_Click);
            // 
            // newCategoryDescriptionLbl
            // 
            this.newCategoryDescriptionLbl.Location = new System.Drawing.Point(119, 114);
            this.newCategoryDescriptionLbl.Multiline = true;
            this.newCategoryDescriptionLbl.Name = "newCategoryDescriptionLbl";
            this.newCategoryDescriptionLbl.Size = new System.Drawing.Size(134, 20);
            this.newCategoryDescriptionLbl.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(22, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Açıklama";
            // 
            // newCategoryTitleLbl
            // 
            this.newCategoryTitleLbl.Location = new System.Drawing.Point(119, 75);
            this.newCategoryTitleLbl.Name = "newCategoryTitleLbl";
            this.newCategoryTitleLbl.Size = new System.Drawing.Size(134, 20);
            this.newCategoryTitleLbl.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(22, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Başlık";
            // 
            // categoriesLbl
            // 
            this.categoriesLbl.AutoSize = true;
            this.categoriesLbl.Location = new System.Drawing.Point(167, 147);
            this.categoriesLbl.Name = "categoriesLbl";
            this.categoriesLbl.Size = new System.Drawing.Size(57, 13);
            this.categoriesLbl.TabIndex = 1;
            this.categoriesLbl.Text = "Kategoriler";
            // 
            // categoriesListBox
            // 
            this.categoriesListBox.FormattingEnabled = true;
            this.categoriesListBox.Location = new System.Drawing.Point(97, 174);
            this.categoriesListBox.Name = "categoriesListBox";
            this.categoriesListBox.Size = new System.Drawing.Size(200, 173);
            this.categoriesListBox.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(862, 543);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Categra";
            this.tabControl1.ResumeLayout(false);
            this.mainPageTab.ResumeLayout(false);
            this.mainPageTab.PerformLayout();
            this.categoryTab.ResumeLayout(false);
            this.categoryTab.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox noteListBox;
        private System.Windows.Forms.ComboBox categoriesComboBox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage mainPageTab;
        private System.Windows.Forms.TabPage categoryTab;
        private System.Windows.Forms.Label noteTitleLbl;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label categoriesLbl;
        private System.Windows.Forms.ListBox categoriesListBox;
        private System.Windows.Forms.TextBox newCategoryDescriptionLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox newCategoryTitleLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button createCategoryBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button updateCategoryBtn;
        private System.Windows.Forms.TextBox chosenCategoryTxtBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox chosenCategoryTitleTxtBox;
        private System.Windows.Forms.Label label4;
    }
}

