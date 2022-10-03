using RealEstate.EntityLayer.Entities;
using RealEstate.FacadeLayer.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.BusinessLayer.Validation
{
    public class BLEmployee
    {
        public static List<Employee> BLEmployeeList()
        {
            return DALEmployee.EmployeeList();
        }
        public static List<Employee> BLEmployeeList2(string name, string surname)
        {
            return DALEmployee.EmployeeListByFilter(name, surname);
        }

        public static void BLEmployeeInsert(Employee employee)
        {
            if(employee.EmployeeName!="" && employee.EmployeeSurname!="" && employee.EmployeeCity.Length > 2)
            {
                DALEmployee.EmployeeInsert(employee);
            }
            else
            {
                //hata mesajları
            }
        }
    }
}
