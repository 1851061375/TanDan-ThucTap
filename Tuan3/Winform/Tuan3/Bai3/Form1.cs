using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai3
{
    public partial class Form1 : Form
    {
        List<Food> listFood = new List<Food>();
        public Form1()
        {
            InitializeComponent();
            
            listFood.Add(new Food()
            {
                tenMon = "Chân giò hun khói",
                gia = 120000
            });
            listFood.Add(new Food()
            {
                tenMon = "Cua rang muối",
                gia = 110000
            });
            listFood.Add(new Food()
            {
                tenMon = "Sụn lợn rang muối",
                gia = 120000
            });

        }
        #region events
        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Food item in listFood)
            {
                ListViewItem lv_item = new ListViewItem(item.tenMon);
                lv_item.SubItems.Add(item.gia.ToString());
                lvMenu.Items.Add(lv_item);
            }
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            dtgResult.Rows.Clear();
            List<Food> resultListFood = new List<Food>();
            resultListFood = getValueSelectedFormListView();
            for (int i = 0; i < resultListFood.Count; i++)
            {
                this.dtgResult.Rows.Add(resultListFood[i].tenMon, resultListFood[i].gia.ToString());
            }

        }
        #endregion events
        private List<Food> getValueSelectedFormListView()
        {
            var result = new List<Food>();
            ListView.CheckedListViewItemCollection checkedItems = lvMenu.CheckedItems;
            foreach (ListViewItem item in checkedItems)
            {
                Food food = new Food();
                food.tenMon = item.Text;
                food.gia = Convert.ToDouble(item.SubItems[1].Text);
                result.Add(food);
            }
            return result;
        }

        public class Food
        {
            public string tenMon { get; set; }
            public double gia { get; set; }
        }
    }
}
