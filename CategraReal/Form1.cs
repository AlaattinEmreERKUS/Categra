using CategraReal.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;

namespace CategraReal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Kategoriler = new List<Kategori>();
            titleTxtbox.Visible = false;

            Kategoriler = new List<Kategori>()
            {
                new Kategori("Genel","Genel Notlar"),
                new Kategori("İş","İşle Alakalı Notlar"),
                new Kategori("Okul","Okul ile Alakalı Notlar"),
            };
            foreach (var item in Kategoriler)
            {
                categoriesComboBox.Items.Add(item.Name);
                categoriesListBox.Items.Add(item.Name);
                treeView1.Nodes.Add(item.Name);

            }
        }


        private string dosyaYolu = "notlar.json";
        private string titleTemp;
        private string descriptionTemp;
        private List<Kategori> Kategoriler { get; set; }
        private void noteListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (noteListBox.SelectedIndex < 0) return;
            titleLbl.Text = Kategoriler[categoriesComboBox.SelectedIndex].Notlar[noteListBox.SelectedIndex].Baslik;
            richTextBox1.Text = Kategoriler[categoriesComboBox.SelectedIndex].Notlar[noteListBox.SelectedIndex].Icerik;
            titleTemp = titleLbl.Text;
            descriptionTemp = richTextBox1.Text;
        }

        private void createCategoryBtn_Click(object sender, EventArgs e)
        {
            Kategori yeni = new Kategori(newCategoryTitleLbl.Text, newCategoryDescriptionLbl.Text);
            Kategoriler.Add(yeni);
            categoriesComboBox.Items.Add(newCategoryTitleLbl.Text);
            categoriesListBox.Items.Add(newCategoryTitleLbl.Text);
            treeView1.Nodes.Add(newCategoryTitleLbl.Text);
        }

        private void updateCategoryBtn_Click(object sender, EventArgs e)
        {
            int selectedIndex = categoriesListBox.SelectedIndex;
            Kategori selectedCategory = Kategoriler[selectedIndex];
            if (selectedCategory != null)
            {
                selectedCategory.Update(chosenCategoryTitleTxtBox.Text, chosenCategoryTxtBox.Text);
                categoriesComboBox.Items[selectedIndex] = chosenCategoryTitleTxtBox.Text;
                categoriesListBox.Items[selectedIndex] = chosenCategoryTitleTxtBox.Text;
                treeView1.Nodes[selectedIndex].Text = chosenCategoryTitleTxtBox.Text;
            }
            else
            {
                MessageBox.Show("Lütfen güncellemek istediğiniz kategoriyi seçin.");
            }

        }

        private void categoriesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            noteListBox.Items.Clear();
            for (int i = 0; i < Kategoriler[categoriesComboBox.SelectedIndex].Notlar.Count; i++)
            {
                noteListBox.Items.Add(Kategoriler[categoriesComboBox.SelectedIndex].Notlar[i].Baslik);
            }
        }

        private void NewNoteButton_Click(object sender, EventArgs e)
        {
            titleTxtbox.Text = "";
            richTextBox1.Text = "";
            titleLbl.Text = "Başlık Giriniz.";

        }

        private void titleLabel_Click(object sender, EventArgs e)
        {
            titleLbl.Visible = false;
            titleTxtbox.Visible = true;
            titleSaveBtn.Visible = true;
        }

        private void NoteSaveButton_Click(object sender, EventArgs e)
        {

            Not yeni = new Not(titleLbl.Text, richTextBox1.Text, SearchCategory(categoriesComboBox.Items[categoriesComboBox.SelectedIndex].ToString()));
            Kategoriler[categoriesComboBox.SelectedIndex].Notlar.Add(yeni);
            noteListBox.Items.Add(yeni.Baslik);
            treeView1.Nodes[categoriesComboBox.SelectedIndex].Nodes.Add(yeni.Baslik);

        }

        private Kategori SearchCategory(string categoryName)
        {
            for (int i = 0; i < Kategoriler.Count; i++)
            {
                if (Kategoriler[i].Name.Equals(categoryName))
                {
                    return Kategoriler[i];
                }
            }
            return null;
        }
        private void NoteCancelButton_Click(object sender, EventArgs e)
        {
            titleLbl.Text = titleTemp;
            richTextBox1.Text = descriptionTemp;
        }

        private void titleSaveBtn_Click(object sender, EventArgs e)
        {
            titleLbl.Text = titleTxtbox.Text;
            titleTxtbox.Visible = false;
            titleSaveBtn.Visible = false;
            titleLbl.Visible = true;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }


        private void editSaveBtn_Click(object sender, EventArgs e)
        {
            richTextBox1.Font = onGosteriTxtBox.Font;
        }

        private void titleEditBtn_Click(object sender, EventArgs e)
        {
            titleTxtbox.Visible = true;
            titleLbl.Visible = false;
            titleTemp = titleLbl.Text;
            
        }

        private void titleCancelBtn_Click(object sender, EventArgs e)
        {
            titleTxtbox.Visible = false;
            titleLbl.Visible = true;
            titleLbl.Text = titleTemp;
        }

        private List<IAranabilir> Search(List<IAranabilir> items, string aranan)
        {
            if (string.IsNullOrEmpty(aranan))
            {
                return items;
            }

            return items.Where(item => item.AranabilirText().ToLower().Contains(aranan.ToLower()))
                        .ToList();
        }


        private void editFontBtn_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                onGosteriTxtBox.Font = fontDialog1.Font;

            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            var aranabilirKategoriler = Kategoriler.Cast<IAranabilir>().ToList();
            var aranabilirNotlar = Kategoriler.SelectMany(k => k.Notlar).Cast<IAranabilir>().ToList();
            var sonuc1 = Search(aranabilirKategoriler, searchTxtBox.Text);
            var sonuc2 = Search(aranabilirNotlar, searchTxtBox.Text);

            searchedTreeView.Nodes.Clear();
            searchedTreeView.Nodes.Add("Kategoriler");
            searchedTreeView.Nodes.Add("Notlar");
            foreach (var item in sonuc1)
            {
                if (item.AramaTuru() == SearchableType.Kategori)
                {
                    searchedTreeView.Nodes[0].Nodes.Add(item.BaslikGetir());
                }
                else if (item.AramaTuru() == SearchableType.Not)
                {
                    searchedTreeView.Nodes[1].Nodes.Add(item.BaslikGetir());
                }
            }
            foreach (var item in sonuc2)
            {
                if (item.AramaTuru() == SearchableType.Kategori)
                {
                    searchedTreeView.Nodes[0].Nodes.Add(item.BaslikGetir());
                }
                else if (item.AramaTuru() == SearchableType.Not)
                {
                    searchedTreeView.Nodes[1].Nodes.Add(item.BaslikGetir());
                }
            }
        }
    }
}
