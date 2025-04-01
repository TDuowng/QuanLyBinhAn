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
    public partial class frmImportMaterial : Form
    {
        public frmImportMaterial()
        {
            InitializeComponent();
            LoadProvide();
            LoadIngredientIntoComboBox();
        }

        #region Methods

        private void LoadProvide()
        {
            cbProvide.DataSource = ProvideBLL.GetListProvide();
            cbProvide.DisplayMember = "NameProvide";
            cbProvide.ValueMember = "IdProvide";
        }

        private void LoadIngredientIntoComboBox()
        {
            cbIngredient.DataSource = IngredientsBLL.GetListIngredients();
            cbIngredient.DisplayMember = "NameIngredient"; 
            cbIngredient.ValueMember = "IdIngredient"; 
        }

        private void LoadListImportBill()
        {
            
        }
        #endregion

        #region Events
        private void btnInsert_Click(object sender, EventArgs e)
        {
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }
        #endregion


    }
}
