using Northwind.Business.Abstract;
using Northwind.Business.Concrete;
using Northwind.DataAccess.Concrete.EntityFramework;
using Northwind.DataAccess.Concrete.NHibernate;
using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Northwind.WebFormsUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            _productService=new ProductManager(new EfProductDal());
            _categoryService = new CategoryManager(new EfCategoryDal());
        }
        private IProductService _productService;
        private ICategoryService _categoryService;
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProducts();
            LoadCategories();
        }
        //olmayan bir methodu yazıp sonradan oluşturmaya internal programmin denir
        private void LoadCategories()
        {
            cbxCategory.DataSource = _categoryService.GetAll();
            cbxCategory.DisplayMember = "CategoryName";
            cbxCategory.ValueMember = "CategoryId";

            cbxCategoryId.DataSource = _categoryService.GetAll();
            cbxCategoryId.DisplayMember = "CategoryName";
            cbxCategoryId.ValueMember = "CategoryId";

            cbxUpdateCategory.DataSource = _categoryService.GetAll();
            cbxUpdateCategory.DisplayMember = "CategoryName";
            cbxUpdateCategory.ValueMember = "CategoryId";

        }

        private void LoadProducts()
        {
            dgwProduct.DataSource = _productService.GetAll();
        }

        private void gbxProductName_Enter(object sender, EventArgs e)
        {

        }

        private void cbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dgwProduct.DataSource = _productService.GetProducsByCategory(Convert.ToInt32(cbxCategory.SelectedValue));   
            }
            catch 
            {

                
            }
            
        }

        private void tbxProductName_TextChanged(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(tbxProductName.Text))
            {
                dgwProduct.DataSource = _productService.GetProductByName(tbxProductName.Text);
            }
            else
            {
                LoadProducts();
            }
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                _productService.Add(new Product()
                {
                    CategoryId = Convert.ToInt32(cbxCategoryId.SelectedValue),
                    ProductName = tbxProduct.Text,
                    QuantityPerUnit = tbxQuantityPer.Text,
                    UnitPrice = Convert.ToDecimal(tbxUnitPrice.Text),
                    UnitsInStock = Convert.ToInt16(tbxStock.Text)



                });
                MessageBox.Show("Ürün Kaydedildi");
                LoadProducts();
            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message);
            }
           
        }

        private void tbxProduct_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                _productService.Updated(new Product()
                {
                    ProductId = Convert.ToInt32(dgwProduct.CurrentRow.Cells[0].Value),
                    ProductName = tbxUpdateProductName.Text,
                    CategoryId = Convert.ToInt32(cbxUpdateCategory.SelectedValue),
                    UnitsInStock = Convert.ToInt16(tbxUpdateStockAmount.Text),
                    QuantityPerUnit = tbxUpdateQuantityPerUnit.Text,
                    UnitPrice = Convert.ToDecimal(tbxUpdateUnitPrice.Text)
                });
                MessageBox.Show("Ürün Güncellendi");
                LoadProducts();
            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message);
            }
            
        }

        private void dgwProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxUpdateProductName.Text = dgwProduct.CurrentRow.Cells[1].Value.ToString();
            cbxUpdateCategory.SelectedValue = dgwProduct.CurrentRow.Cells[2].Value;
            tbxUpdateUnitPrice.Text= dgwProduct.CurrentRow.Cells[3].Value.ToString();
            tbxUpdateQuantityPerUnit.Text= dgwProduct.CurrentRow.Cells[4].Value.ToString();
            tbxUpdateStockAmount.Text= dgwProduct.CurrentRow.Cells[5].Value.ToString();

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
          
                _productService.Delete(new Product
                {
                    ProductId = Convert.ToInt32(dgwProduct.CurrentRow.Cells[0].Value)
                });
                MessageBox.Show("Ürün Silindi");
                LoadProducts();
            
           
           
            
        }

        private void gbxCategory_Enter(object sender, EventArgs e)
        {

        }
    }
}
