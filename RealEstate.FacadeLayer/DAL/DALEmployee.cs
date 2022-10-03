using RealEstate.EntityLayer.Entities;
using RealEstate.FacadeLayer.Connection;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.FacadeLayer.DAL
{
    public class DALEmployee
    {

        public static List<Employee> EmployeeList()
        {
            List<Employee> employees = new List<Employee>();
            SqlCommand command = new SqlCommand("Select * From TblEmployee", DbConnection.sqlConnection);
            DbConnection.sqlConnection.Open();
            SqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                Employee employee = new Employee();
                employee.EmployeeID = int.Parse(dataReader["EmployeeID"].ToString());
                employee.EmployeeName = dataReader["EmployeeName"].ToString();
                employee.EmployeeSurname = dataReader["EmployeeSurname"].ToString();
                employee.EmployeeCity = dataReader["EmployeeCity"].ToString();
                employees.Add(employee);
            }
            DbConnection.sqlConnection.Close();
            return employees;
        }
        public static void EmployeeInsert(Employee employee)
        {
            DbConnection.sqlConnection.Open();
            SqlCommand command = new SqlCommand("insert into TblEmployee (EmployeeName,EmployeeSurname,EmployeeCity) values (@p1,@p2,@p3)", DbConnection.sqlConnection);
            command.Parameters.AddWithValue("@p1", employee.EmployeeName);
            command.Parameters.AddWithValue("@p2", employee.EmployeeSurname);
            command.Parameters.AddWithValue("@p3", employee.EmployeeCity);
            command.ExecuteNonQuery();
            DbConnection.sqlConnection.Close();
        }

        public static void EmployeeDelete(int id)
        {
            DbConnection.sqlConnection.Open();
            SqlCommand command = new SqlCommand("Delete From TblEmployee where EmployeeID=@p1", DbConnection.sqlConnection);
            command.Parameters.AddWithValue("@p1", id);
            command.ExecuteNonQuery();
            DbConnection.sqlConnection.Close();
        }

        public static void UpdateEmployee(Employee employee)
        {
            DbConnection.sqlConnection.Open();
            SqlCommand command = new SqlCommand("Update TblEmployee Set EmployeeName=@p1,EmployeeSurname=@p2,EmployeeCity=@p3 where EmployeeID=@p4", DbConnection.sqlConnection);
            command.Parameters.AddWithValue("@p1", employee.EmployeeName);
            command.Parameters.AddWithValue("@p2", employee.EmployeeSurname);
            command.Parameters.AddWithValue("@p3", employee.EmployeeCity);
            command.Parameters.AddWithValue("@p4", employee.EmployeeID);
            command.ExecuteNonQuery();
            DbConnection.sqlConnection.Close();
        }
        public static List<Employee> EmployeeListByFilter(string Name,string Surname)
        {
            List<Employee> employees = new List<Employee>();
            DbConnection.sqlConnection.Open();
            SqlCommand command = new SqlCommand("Select * From TblEmployee where EmployeeName=@p1 or EmployeeSurname=@p2", DbConnection.sqlConnection);
            command.Parameters.AddWithValue("@p1", Name);
            command.Parameters.AddWithValue("@p2", Surname);
            SqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                Employee employee = new Employee();
                employee.EmployeeID = int.Parse(dataReader["EmployeeID"].ToString());
                employee.EmployeeName = dataReader["EmployeeName"].ToString();
                employee.EmployeeSurname = dataReader["EmployeeSurname"].ToString();
                employee.EmployeeCity = dataReader["EmployeeCity"].ToString();
                employees.Add(employee);
            }
            DbConnection.sqlConnection.Close();
            return employees;
        }
    }
}
