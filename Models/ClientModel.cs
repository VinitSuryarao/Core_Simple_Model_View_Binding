using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _7_Simple_Model_View_Binding.Models
{
    // Model Must Contains only Business Entity
    // Model structure match with the database table structure
    // Model only contains properties, dont write any function here
    public class ClientModel
    {
        #region Entity
        public string FirstName { get; set; }
        public string LastName { get; set; }

        #endregion

        #region Navigation Property
        public CommunicationModel CommuCommunicationModel { get; set; }
        public LoginModel LoginModel { get; set; }
        #endregion
    }
}
