using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace HealthCheck
{
    public partial class FrmHeathCheck : Form
    {
        public FrmHeathCheck()
        {
            InitializeComponent();
            btnAddItem.Enabled = false;
            btnRemove.Enabled = false;
        }

        private void FrmHeathCheck_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            StartPosition = FormStartPosition.CenterScreen;
            
        }



        private void btnAddHeath_Click(object sender, EventArgs e)
        {
            if (txtItemName.Text != "")
            {
                
            }

        }




        /// <summary>
        /// 添加体检项目
        /// </summary>
        private void AddItem()
        { 

        
        }


        /// <summary>
        ///  
        /// </summary>
        private void AddHeathCheck()
        {
 
        }



    }
}
