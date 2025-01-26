using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aquaters_Capstone_
{
    public partial class PersonalInfo : Form
    {

        public delegate void onClick();
        public event onClick OnClickHandler;
        public PersonalInfo()
        {
            InitializeComponent();
        }

        private void PersonalInfo_Load(object sender, EventArgs e)
        {

        }

        private void txDone_Click(object sender, EventArgs e)
        {
            if (OnClickHandler != null)
            {
                OnClickHandler();
            }
        }
    }
}
