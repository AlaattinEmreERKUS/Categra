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
            this.titleCancelBtn = new System.Windows.Forms.Button();
            this.titleEditBtn = new System.Windows.Forms.Button();
            this.titleSaveBtn = new System.Windows.Forms.Button();
            this.notGroupBox = new System.Windows.Forms.GroupBox();
            this.NewNoteButton = new System.Windows.Forms.Button();
            this.NoteSaveButton = new System.Windows.Forms.Button();
            this.NoteCancelButton = new System.Windows.Forms.Button();
            this.titleTxtbox = new System.Windows.Forms.TextBox();
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.onGosteriGroupBox = new System.Windows.Forms.GroupBox();
            this.onGosteriTxtBox = new System.Windows.Forms.RichTextBox();
            this.editSaveBtn = new System.Windows.Forms.Button();
            this.duzenleGroupBox = new System.Windows.Forms.GroupBox();
            this.notDuzenleLbl = new System.Windows.Forms.Label();
            this.editFontBtn = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.searchBtn = new System.Windows.Forms.Button();
            this.searchTxtBox = new System.Windows.Forms.TextBox();
            this.searchedTreeView = new System.Windows.Forms.TreeView();
            this.tabControl1.SuspendLayout();
            this.mainPageTab.SuspendLayout();
            this.notGroupBox.SuspendLayout();
            this.categoryTab.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.onGosteriGroupBox.SuspendLayout();
            this.duzenleGroupBox.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // noteListBox
            // 
            this.noteListBox.BackColor = System.Drawing.Color.White;
            this.noteListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.noteListBox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.noteListBox.FormattingEnabled = true;
            this.noteListBox.Location = new System.Drawing.Point(49, 93);
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
            this.categoriesComboBox.Location = new System.Drawing.Point(49, 16);
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
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(1, 81);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(948, 530);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 2;
            // 
            // mainPageTab
            // 
            this.mainPageTab.AutoScroll = true;
            this.mainPageTab.BackColor = System.Drawing.Color.White;
            this.mainPageTab.Controls.Add(this.titleCancelBtn);
            this.mainPageTab.Controls.Add(this.titleEditBtn);
            this.mainPageTab.Controls.Add(this.titleSaveBtn);
            this.mainPageTab.Controls.Add(this.notGroupBox);
            this.mainPageTab.Controls.Add(this.titleTxtbox);
            this.mainPageTab.Controls.Add(this.titleLbl);
            this.mainPageTab.Controls.Add(this.richTextBox1);
            this.mainPageTab.Controls.Add(this.noteTitleLbl);
            this.mainPageTab.Controls.Add(this.categoriesComboBox);
            this.mainPageTab.Controls.Add(this.noteListBox);
            this.mainPageTab.Location = new System.Drawing.Point(4, 22);
            this.mainPageTab.Name = "mainPageTab";
            this.mainPageTab.Padding = new System.Windows.Forms.Padding(3);
            this.mainPageTab.Size = new System.Drawing.Size(940, 504);
            this.mainPageTab.TabIndex = 0;
            this.mainPageTab.Text = "Notlar";
            // 
            // titleCancelBtn
            // 
            this.titleCancelBtn.AutoSize = true;
            this.titleCancelBtn.Location = new System.Drawing.Point(821, 5);
            this.titleCancelBtn.Name = "titleCancelBtn";
            this.titleCancelBtn.Size = new System.Drawing.Size(111, 23);
            this.titleCancelBtn.TabIndex = 13;
            this.titleCancelBtn.Text = "İptal";
            this.titleCancelBtn.UseVisualStyleBackColor = true;
            this.titleCancelBtn.Visible = false;
            this.titleCancelBtn.Click += new System.EventHandler(this.titleCancelBtn_Click);
            // 
            // titleEditBtn
            // 
            this.titleEditBtn.AutoSize = true;
            this.titleEditBtn.Location = new System.Drawing.Point(705, 5);
            this.titleEditBtn.Name = "titleEditBtn";
            this.titleEditBtn.Size = new System.Drawing.Size(111, 23);
            this.titleEditBtn.TabIndex = 12;
            this.titleEditBtn.Text = "Düzenle";
            this.titleEditBtn.UseVisualStyleBackColor = true;
            this.titleEditBtn.Visible = false;
            this.titleEditBtn.Click += new System.EventHandler(this.titleEditBtn_Click);
            // 
            // titleSaveBtn
            // 
            this.titleSaveBtn.AutoSize = true;
            this.titleSaveBtn.Location = new System.Drawing.Point(589, 5);
            this.titleSaveBtn.Name = "titleSaveBtn";
            this.titleSaveBtn.Size = new System.Drawing.Size(111, 23);
            this.titleSaveBtn.TabIndex = 11;
            this.titleSaveBtn.Text = "Kaydet";
            this.titleSaveBtn.UseVisualStyleBackColor = true;
            this.titleSaveBtn.Visible = false;
            this.titleSaveBtn.Click += new System.EventHandler(this.titleSaveBtn_Click);
            // 
            // notGroupBox
            // 
            this.notGroupBox.Controls.Add(this.NewNoteButton);
            this.notGroupBox.Controls.Add(this.NoteSaveButton);
            this.notGroupBox.Controls.Add(this.NoteCancelButton);
            this.notGroupBox.Location = new System.Drawing.Point(49, 306);
            this.notGroupBox.Name = "notGroupBox";
            this.notGroupBox.Size = new System.Drawing.Size(168, 128);
            this.notGroupBox.TabIndex = 10;
            this.notGroupBox.TabStop = false;
            this.notGroupBox.Text = "📝 Not İşlemleri";
            // 
            // NewNoteButton
            // 
            this.NewNoteButton.AutoSize = true;
            this.NewNoteButton.Location = new System.Drawing.Point(27, 31);
            this.NewNoteButton.Name = "NewNoteButton";
            this.NewNoteButton.Size = new System.Drawing.Size(111, 23);
            this.NewNoteButton.TabIndex = 8;
            this.NewNoteButton.Text = "Yeni Not Ekle";
            this.NewNoteButton.UseVisualStyleBackColor = true;
            this.NewNoteButton.Click += new System.EventHandler(this.NewNoteButton_Click);
            // 
            // NoteSaveButton
            // 
            this.NoteSaveButton.AutoSize = true;
            this.NoteSaveButton.Location = new System.Drawing.Point(27, 60);
            this.NoteSaveButton.Name = "NoteSaveButton";
            this.NoteSaveButton.Size = new System.Drawing.Size(111, 23);
            this.NoteSaveButton.TabIndex = 6;
            this.NoteSaveButton.Text = "Değişiklikleri Kaydet";
            this.NoteSaveButton.UseVisualStyleBackColor = true;
            this.NoteSaveButton.Click += new System.EventHandler(this.NoteSaveButton_Click);
            // 
            // NoteCancelButton
            // 
            this.NoteCancelButton.AutoSize = true;
            this.NoteCancelButton.Location = new System.Drawing.Point(46, 89);
            this.NoteCancelButton.Name = "NoteCancelButton";
            this.NoteCancelButton.Size = new System.Drawing.Size(75, 23);
            this.NoteCancelButton.TabIndex = 7;
            this.NoteCancelButton.Text = "İptal Et";
            this.NoteCancelButton.UseVisualStyleBackColor = true;
            this.NoteCancelButton.Click += new System.EventHandler(this.NoteCancelButton_Click);
            // 
            // titleTxtbox
            // 
            this.titleTxtbox.Location = new System.Drawing.Point(271, 6);
            this.titleTxtbox.Name = "titleTxtbox";
            this.titleTxtbox.Size = new System.Drawing.Size(201, 20);
            this.titleTxtbox.TabIndex = 9;
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.Location = new System.Drawing.Point(271, 3);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(0, 28);
            this.titleLbl.TabIndex = 5;
            this.titleLbl.Click += new System.EventHandler(this.titleLabel_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.AcceptsTab = true;
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox1.Font = new System.Drawing.Font("Bodoni MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.richTextBox1.Location = new System.Drawing.Point(270, 32);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(662, 441);
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
            this.categoryTab.Size = new System.Drawing.Size(940, 504);
            this.categoryTab.TabIndex = 1;
            this.categoryTab.Text = "Kategori";
            this.categoryTab.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.updateCategoryBtn);
            this.groupBox2.Controls.Add(this.chosenCategoryTxtBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.chosenCategoryTitleTxtBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(614, 248);
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
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.createCategoryBtn);
            this.groupBox1.Controls.Add(this.newCategoryDescriptionLbl);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.newCategoryTitleLbl);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(614, 2);
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
            this.categoriesLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.categoriesLbl.Location = new System.Drawing.Point(249, 111);
            this.categoriesLbl.Name = "categoriesLbl";
            this.categoriesLbl.Size = new System.Drawing.Size(116, 25);
            this.categoriesLbl.TabIndex = 1;
            this.categoriesLbl.Text = "Kategoriler";
            // 
            // categoriesListBox
            // 
            this.categoriesListBox.FormattingEnabled = true;
            this.categoriesListBox.Location = new System.Drawing.Point(165, 143);
            this.categoriesListBox.Name = "categoriesListBox";
            this.categoriesListBox.Size = new System.Drawing.Size(285, 225);
            this.categoriesListBox.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.searchedTreeView);
            this.tabPage1.Controls.Add(this.searchTxtBox);
            this.tabPage1.Controls.Add(this.searchBtn);
            this.tabPage1.Controls.Add(this.onGosteriGroupBox);
            this.tabPage1.Controls.Add(this.duzenleGroupBox);
            this.tabPage1.Controls.Add(this.treeView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(940, 504);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Dosya";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // onGosteriGroupBox
            // 
            this.onGosteriGroupBox.Controls.Add(this.onGosteriTxtBox);
            this.onGosteriGroupBox.Location = new System.Drawing.Point(395, 195);
            this.onGosteriGroupBox.Name = "onGosteriGroupBox";
            this.onGosteriGroupBox.Size = new System.Drawing.Size(273, 279);
            this.onGosteriGroupBox.TabIndex = 5;
            this.onGosteriGroupBox.TabStop = false;
            this.onGosteriGroupBox.Text = "Ön Gösterim";
            // 
            // onGosteriTxtBox
            // 
            this.onGosteriTxtBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.onGosteriTxtBox.Location = new System.Drawing.Point(1, 27);
            this.onGosteriTxtBox.Name = "onGosteriTxtBox";
            this.onGosteriTxtBox.Size = new System.Drawing.Size(270, 251);
            this.onGosteriTxtBox.TabIndex = 0;
            this.onGosteriTxtBox.Text = "Suyun kaynama noktası 100 derecedir.";
            // 
            // editSaveBtn
            // 
            this.editSaveBtn.AutoSize = true;
            this.editSaveBtn.Location = new System.Drawing.Point(157, 48);
            this.editSaveBtn.Name = "editSaveBtn";
            this.editSaveBtn.Size = new System.Drawing.Size(85, 32);
            this.editSaveBtn.TabIndex = 2;
            this.editSaveBtn.Text = "✔️ Kaydet";
            this.editSaveBtn.UseVisualStyleBackColor = true;
            this.editSaveBtn.Click += new System.EventHandler(this.editSaveBtn_Click);
            // 
            // duzenleGroupBox
            // 
            this.duzenleGroupBox.Controls.Add(this.notDuzenleLbl);
            this.duzenleGroupBox.Controls.Add(this.editSaveBtn);
            this.duzenleGroupBox.Controls.Add(this.editFontBtn);
            this.duzenleGroupBox.Location = new System.Drawing.Point(396, 47);
            this.duzenleGroupBox.Name = "duzenleGroupBox";
            this.duzenleGroupBox.Size = new System.Drawing.Size(272, 127);
            this.duzenleGroupBox.TabIndex = 1;
            this.duzenleGroupBox.TabStop = false;
            this.duzenleGroupBox.Text = "Not Düzenle";
            // 
            // notDuzenleLbl
            // 
            this.notDuzenleLbl.AutoSize = true;
            this.notDuzenleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.notDuzenleLbl.Location = new System.Drawing.Point(28, 54);
            this.notDuzenleLbl.Name = "notDuzenleLbl";
            this.notDuzenleLbl.Size = new System.Drawing.Size(0, 26);
            this.notDuzenleLbl.TabIndex = 1;
            // 
            // editFontBtn
            // 
            this.editFontBtn.AutoSize = true;
            this.editFontBtn.Location = new System.Drawing.Point(34, 48);
            this.editFontBtn.Name = "editFontBtn";
            this.editFontBtn.Size = new System.Drawing.Size(91, 32);
            this.editFontBtn.TabIndex = 0;
            this.editFontBtn.Text = "Font Düzenle";
            this.editFontBtn.UseVisualStyleBackColor = true;
            this.editFontBtn.Click += new System.EventHandler(this.editFontBtn_Click);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(50, 47);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(314, 426);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Location = new System.Drawing.Point(-1, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(948, 617);
            this.panel1.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(392, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 54);
            this.label5.TabIndex = 3;
            this.label5.Text = "Categra";
            // 
            // searchBtn
            // 
            this.searchBtn.AutoSize = true;
            this.searchBtn.Location = new System.Drawing.Point(767, 162);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 32);
            this.searchBtn.TabIndex = 6;
            this.searchBtn.Text = "Arama Yap";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // searchTxtBox
            // 
            this.searchTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.searchTxtBox.Location = new System.Drawing.Point(727, 97);
            this.searchTxtBox.Name = "searchTxtBox";
            this.searchTxtBox.Size = new System.Drawing.Size(156, 26);
            this.searchTxtBox.TabIndex = 7;
            // 
            // searchedTreeView
            // 
            this.searchedTreeView.Location = new System.Drawing.Point(727, 222);
            this.searchedTreeView.Name = "searchedTreeView";
            this.searchedTreeView.Size = new System.Drawing.Size(156, 162);
            this.searchedTreeView.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(947, 608);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Categra";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.mainPageTab.ResumeLayout(false);
            this.mainPageTab.PerformLayout();
            this.notGroupBox.ResumeLayout(false);
            this.notGroupBox.PerformLayout();
            this.categoryTab.ResumeLayout(false);
            this.categoryTab.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.onGosteriGroupBox.ResumeLayout(false);
            this.duzenleGroupBox.ResumeLayout(false);
            this.duzenleGroupBox.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Button NoteCancelButton;
        private System.Windows.Forms.Button NoteSaveButton;
        private System.Windows.Forms.Button NewNoteButton;
        private System.Windows.Forms.TextBox titleTxtbox;
        private System.Windows.Forms.GroupBox notGroupBox;
        private System.Windows.Forms.Button titleSaveBtn;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button titleCancelBtn;
        private System.Windows.Forms.Button titleEditBtn;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button editSaveBtn;
        private System.Windows.Forms.GroupBox duzenleGroupBox;
        private System.Windows.Forms.GroupBox onGosteriGroupBox;
        private System.Windows.Forms.RichTextBox onGosteriTxtBox;
        private System.Windows.Forms.Label notDuzenleLbl;
        private System.Windows.Forms.Button editFontBtn;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.TextBox searchTxtBox;
        private System.Windows.Forms.TreeView searchedTreeView;
    }
}

