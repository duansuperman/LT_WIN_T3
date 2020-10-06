using Combobox;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboboxUI
{
    public partial class Form2 : Form
    {
        List<CategoryFood> listCategoryFood;
        List<Food> listFood;
        public Form2()
        {
            InitializeComponent();
            loadListCategoryFood();
            loadListFood();
        }
        public void loadListCategoryFood()
        {
            listCategoryFood = new List<CategoryFood>();
            listCategoryFood.Add(new CategoryFood() { id = 1, name = "Mon xao" });
            listCategoryFood.Add(new CategoryFood() { id = 2, name = "Mon chien" });
            listCategoryFood.Add(new CategoryFood() { id = 3, name = "Mon hap" });
            listCategoryFood.Add(new CategoryFood() { id = 4, name = "Do uong" });

            cbCategoryFood.DataSource = listCategoryFood;
            cbCategoryFood.DisplayMember = "name";
        }

        public void loadListFood()
        {
            listFood = new List<Food>();
            listFood.Add(new Food() { id = 1, name = "Mi xao", description = "Ngon, bo, re", categoryFood_id = 1 });
            listFood.Add(new Food() { id = 2, name = "Oc xao", description = "Ngon ngot", categoryFood_id = 1 });
            listFood.Add(new Food() { id = 3, name = "Com chien", description = "Ket hop voi nhieu loai nam", categoryFood_id = 2 });
            listFood.Add(new Food() { id = 4, name = "Ca chien", description = "Beo ngay", categoryFood_id = 2 });
            listFood.Add(new Food() { id = 5, name = "Ngheu hap", description = "Thom ngon", categoryFood_id = 3 });
            listFood.Add(new Food() { id = 6, name = "Ga hap", description = "Tuyet cu meo", categoryFood_id = 3 });
            listFood.Add(new Food() { id = 7, name = "Haniken", description = "Bia chat luong", categoryFood_id = 4 });
            listFood.Add(new Food() { id = 8, name = "Coca", description = "Nuoc giai khat", categoryFood_id = 4 });
        }

        private void cbCategoryFood_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedValue != null)
            {
                CategoryFood categoryFood = cb.SelectedValue as CategoryFood;
                loadListFoodBuCategoryId(categoryFood.id);
            }
        }

        private void loadListFoodBuCategoryId(int id)
        {
            List<Food> listFindedFood = new List<Food>();
            if (listFood == null) return;
            foreach(Food food in listFood)
            {
                if (food.categoryFood_id == id)
                {
                    listFindedFood.Add(food);
                }
            }
            cbFood.DataSource = listFindedFood;
            cbFood.DisplayMember = "name";
        }
    }
}
