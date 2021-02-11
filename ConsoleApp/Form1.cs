using DataAccess.Abstract;
using DataAccess.Concrete.EntityFrameWork;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dgwCars_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        ICarDal _carDal = new EfCarDal();
        private void Form1_Load(object sender, EventArgs e)
        {
            dgwCars.DataSource = _carDal.GetAll();
        }
    }
}
