using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.EntityLayer.Entities
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeSurname { get; set; }
        public string EmployeeCity { get; set; }
    }
}
/*
 Generic
 Tekrardan kurtarıyor
 Süreklilik
 Hata Yönetimi
 Modülerlik
 Esneklik

(CodeFirst)
 Class-->Table
 Prop-->Column


(DbFirst)
Table-->Class
Column-->Prop


 */
