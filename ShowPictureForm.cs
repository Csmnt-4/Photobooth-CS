using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Photo_booth
{
    public partial class ShowPictureForm : Form
    {
        public ShowPictureForm()
        {
            InitializeComponent();
        }

        private void ShowPictureForm_Load(object sender, EventArgs e)
        {

        }

        public PictureBox ImagePictureBox { get { return this.pictureBox; } }
    }
}
