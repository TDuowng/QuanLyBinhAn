using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmCook : Form
    {
        public BindingList<FoodDTO> FoodList { get; set; }
        public frmCook()
        {
            InitializeComponent();
            LoadFoodList();
        }
        #region Methods
        private void LoadFoodList()
        {
            FoodList = FoodBLL.GetFoodList();
            LoadFoodIntoFlowPanel();
        }
        private void LoadFoodIntoFlowPanel()
        {
            flowFood.Controls.Clear();
            foreach (var food in FoodList)
            {
                UcFood uc = new UcFood();
                uc.SetFoodData(food.Name, food.Price, food.Image);
                flowFood.Controls.Add(uc);
            }
        }
        #endregion
        #region Events

        #endregion
    }
}
