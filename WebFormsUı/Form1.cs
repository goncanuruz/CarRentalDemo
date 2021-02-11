using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFrameWork;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebFormsUı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ICarService _carService = new CarManager(new EfCarDal());
        IBrandService _brandService = new BrandManager(new EfBrandDal());
        IColorService _colorService = new ColorManager(new EfColorDal());

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        
        private void Form1_Load_1(object sender, EventArgs e)
        {
            ListCarDetails();
            ListCarBrand();
            ListColor();
        }

        private void ListColor()
        {
            cbxUpdateColors.DataSource = _colorService.GetAll();
            cbxUpdateColors.DisplayMember = "Name";
            cbxUpdateColors.ValueMember = "Id";

        }
        private void ListCarDetails()
        {
            dgwCars.DataSource = _carService.GetCarDetails();
        }
        private void ListCarBrand()
        {
         
                cbxBrand.DataSource = _carService.GetCarDetails();
                cbxBrand.DisplayMember = "BrandName";
                cbxBrand.ValueMember = "BrandId";

                cbxUpdateBrands.DataSource = _brandService.GetAll();
                cbxUpdateBrands.DisplayMember = "Name";
                cbxUpdateBrands.ValueMember = "Id";
        }

        private void contextMenuStrip2_Opening(object sender, CancelEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void cbxBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dgwCars.DataSource = _carService.GetByBrandId(Convert.ToInt32(cbxBrand.SelectedValue));

            }
            catch 
            {

            }

        }

        private void tbxSearchCarName_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbxSearchCarName.Text))
            {
                dgwCars.DataSource = _carService.GetByCarName(tbxSearchCarName.Text);
            }
            else
            {
                dgwCars.DataSource = _carService.GetCarDetails();
            }
            
        }

        private void gbxBrand_Enter(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _carService.Add(new Car
            {
                BrandId = Convert.ToInt32(cbxAddBrand.SelectedValue),
                ColorId=Convert.ToInt32(cbxAddColor.SelectedValue),
                Name=tbxAddName.Text,
                Description=tbxAddDescription.Text,
                ModelYear=Convert.ToInt32(tbxAddModelYear.Text),
                DailyPrice=Convert.ToDecimal(tbxAddDailyPrice.Text)
            });
            ListCarDetails();
            MessageBox.Show("Added!");
            

        }

        private void dgwCars_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cbxUpdateBrands.SelectedValue = dgwCars.CurrentRow.Cells[1].Value;
            tbxUpdateName.Text = dgwCars.CurrentRow.Cells[3].Value.ToString();
            cbxUpdateColors.SelectedItem = dgwCars.CurrentRow.Cells[4].Value;
            tbxUpdateModelYear.Text = dgwCars.CurrentRow.Cells[5].Value.ToString();
            tbxUpdateDescription.Text = dgwCars.CurrentRow.Cells[6].Value.ToString();
            tbxUpdateDailyPrice.Text = dgwCars.CurrentRow.Cells[7].Value.ToString();


        }

        private void cbxAddBrand_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _carService.Update(new Car { 
                Id=Convert.ToInt32(dgwCars.CurrentRow.Cells[0].Value),
                BrandId=Convert.ToInt32(cbxUpdateBrands.SelectedValue),
                ColorId = Convert.ToInt32(cbxUpdateColors.SelectedValue),
                Name = tbxUpdateName.Text,
                Description = tbxUpdateDescription.Text,
                ModelYear = Convert.ToInt32(tbxUpdateModelYear.Text),
                DailyPrice=Convert.ToDecimal(tbxUpdateDailyPrice.Text)
            });
            ListCarDetails();
            MessageBox.Show("Updated!");
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            _carService.Delete(new Car { Id=Convert.ToInt32(dgwCars.CurrentRow.Cells[0].Value)
            
            });
            ListCarDetails();
            MessageBox.Show("Deleted!");
        }
    }
}
