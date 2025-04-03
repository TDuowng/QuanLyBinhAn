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
        public UcFood()
        {
            InitializeComponent();
        }

        public void SetFoodData(string name, float price, byte[] imageData)
        {
            lblName.Text = name;
            lblPrice.Text = price.ToString("N0") + " VNĐ";

            if (imageData != null)
            {
                pbImage.Image = ByteArrayToImage(imageData);
            }
        }
        public static Image ByteArrayToImage(byte[] imageData)
        {
            if (imageData == null || imageData.Length == 0)
                throw new ArgumentException("Dữ liệu ảnh trống hoặc null!");

            using (MemoryStream ms = new MemoryStream(imageData))
            {
                return Image.FromStream(ms);
            }
        }

        private void UcFood_Click(object sender, EventArgs e)
        {
            OnSelect?.Invoke(this, e);
        }

        // Gán sự kiện Click cho các thành phần trong Load
        private void UcFood_Load(object sender, EventArgs e)
        {
            this.Click += UcFood_Click;
            lblName.Click += UcFood_Click;
            lblPrice.Click += UcFood_Click;
            pbImage.Click += UcFood_Click;
        }

    }
}
