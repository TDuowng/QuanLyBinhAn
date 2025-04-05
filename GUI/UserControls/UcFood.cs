using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class UcFood : UserControl
    {
        public event EventHandler OnSelect = null;
        private bool isSelected = false;
        private int idFood;
        public int IdFood
        {
            get { return idFood; }
            set { idFood = value; }
        }
        public UcFood()
        {
            InitializeComponent();
            this.BorderStyle = BorderStyle.None;

            this.pbImage.Click += UcFood_Click;
            this.lblName.Click += UcFood_Click;
            this.lblPrice.Click += UcFood_Click;
        }

        public void SetFoodData(FoodDTO food)
        {
            this.Tag = food;
            this.IdFood = food.ID;
            lblName.Text = food.Name;
            lblPrice.Text = food.Price.ToString("N0") + " VNĐ";

            if (food.Image != null)
            {
                pbImage.Image = ByteArrayToImage(food.Image);
            }
        }
        public static Image ByteArrayToImage(byte[] imageData)
        {
            if (imageData == null || imageData.Length == 0)
                return null;

            using (MemoryStream ms = new MemoryStream(imageData))
            {
                return Image.FromStream(ms);
            }
        }

        public void SetSelected(bool selected)
        {
            isSelected = selected;

            if (isSelected)
            {
                this.BorderStyle = BorderStyle.FixedSingle;
            }
            else
            {
                this.BorderStyle = BorderStyle.None;
            }

        }

        private void UcFood_Click(object sender, EventArgs e)
        {
            OnSelect?.Invoke(this, e);
        }

        // Gán sự kiện Click cho các thành phần trong Load
        private void UcFood_Load(object sender, EventArgs e)
        {
            // Gán sự kiện Click cho tất cả thành phần
            foreach (Control control in this.Controls)
            {
                control.Click += UcFood_Click;
            }
            this.Click += UcFood_Click;
            this.pbImage.Click += UcFood_Click;
            this.lblName.Click += UcFood_Click;
            this.lblPrice.Click += UcFood_Click;
        }

    }
}
