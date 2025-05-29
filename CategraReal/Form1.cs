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

namespace CategraReal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Kategoriler = new List<Kategori>();
        }

        private List<Kategori> Kategoriler { get; set; }
        private void noteListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void createCategoryBtn_Click(object sender, EventArgs e)
        {
            Kategoriler.Add(new Kategori(newCategoryTitleLbl.Text,newCategoryDescriptionLbl.Text));
            categoriesComboBox.Items.Add(newCategoryTitleLbl.Text);
            categoriesListBox.Items.Add(newCategoryTitleLbl.Text);
        }

        private void updateCategoryBtn_Click(object sender, EventArgs e)
        {
            int selectedIndex = categoriesListBox.SelectedIndex;
            Kategori selectedCategory = Kategoriler[selectedIndex];
            if (selectedCategory != null)
            {
                selectedCategory.Update(chosenCategoryTitleTxtBox.Text,newCategoryDescriptionLbl.Text);
                categoriesComboBox.Items[selectedIndex] = newCategoryTitleLbl.Text;
                categoriesListBox.Items[selectedIndex] = newCategoryTitleLbl.Text;
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
    }
}
