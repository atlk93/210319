using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsEdit
{
    public partial class FormSearch : Form
    {
        public string sSearch;
        public string sChange;
        //int num;
        //double dNum;
        public FormSearch()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            sSearch = tbSearch.Text;
            //num = int.Parse(tbSearch.Text);     // int형을 넘겨줄 때 parse활용 (문자열->숫자로 바꿔주는 메소드)
            //dNum = double.Parse(tbSearch.Text); // double 넘겨줄 때
        }


    }
}