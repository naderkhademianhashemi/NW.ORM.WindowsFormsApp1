using Arian.NorthW.WindowsFormsApp1.REPO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NW.ORM.WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var CATS = CatRepo.Get();
            var CT = CatRepo.Get(1);
            //var id = new CatRepo() { CategoryName = "clothes", Description = "..." }.Insert();
            var I = new CatRepo() { CategoryID = 9, CategoryName = "clothes ... ", Description = "123" }.Update();
        }
    }
}
