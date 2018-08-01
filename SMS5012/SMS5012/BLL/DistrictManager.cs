using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SMS5012.DAL;
using SMS5012.Models;

namespace SMS5012.BLL
{
    public class DistrictManager
    {
        //DistrictDal
        DistrictRepository _districtRepository= new DistrictRepository();
        public bool Add(District district)
        {
            // Business Related Logic And Validation Goes Here
        
            // After Completed All Logic/ Validation
            if (district.Name.Length<3)
            {
                throw new Exception("Name Length Must be....");
            }

            bool isAdded = _districtRepository.Add(district);
            return isAdded;
        }
    }
}
