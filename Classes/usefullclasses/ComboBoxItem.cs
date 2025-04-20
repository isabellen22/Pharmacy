using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.Classes.UsefullClasses
{
    public class ComboBoxItem
    {
        public int RoleID { get; set; }
        public string RoleName { get; set; }

        public ComboBoxItem(int roleID, string roleName)
        {
            RoleID = roleID;
            RoleName = roleName;
        }

        public override string ToString()
        {
            return RoleName; // Display RoleName in the ComboBox
        }
    }

}
