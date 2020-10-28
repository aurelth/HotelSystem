using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelSystem
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            pnlLogin.Location = new Point((this.Width / 2) - 166, (this.Height / 2) - 170);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
