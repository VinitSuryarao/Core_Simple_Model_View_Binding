using _7_Simple_Model_View_Binding.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _7_Simple_Model_View_Binding.ViewModel
{
    public class ClientUIModel
    {
        #region Entity
        public string ViewParamter { get; set; }

        #endregion

        #region Navigation Property
        public ClientModel ClientModel { get; set; }
      
        #endregion
    }
}
