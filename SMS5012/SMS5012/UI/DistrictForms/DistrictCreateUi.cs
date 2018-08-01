using System;
using System.Windows.Forms;
using SMS5012.BLL;
using SMS5012.Models;

namespace SMS5012.UI.DistrictForms
{
    public partial class DistrictCreateUi : Form
    {
        DistrictManager _districtManager = new DistrictManager();
        public DistrictCreateUi()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                District district = new District();
                district.Name = nameTextBox.Text;
                bool isAdded = _districtManager.Add(district);
                if (isAdded)
                {
                    MessageBox.Show("Added");
                    return;
                }
                MessageBox.Show("Failed");
            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message);
            }
            
        }
    }
}
