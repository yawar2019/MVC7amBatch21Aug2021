using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
namespace ADODotnetExample.Models
{
    class EmployeeContext
    {
        SqlConnection con = new SqlConnection(@"Data Source=AZAM-PC\SQLEXPRESS;Initial Catalog=Employee;Integrated Security=true");

        public List<EmployeeModel> getEmployeeDetails()
        {
            List<EmployeeModel> listObj = new List<Models.EmployeeModel>();
            SqlCommand cmd = new SqlCommand("sp_employee", con);
            cmd.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                EmployeeModel emp = new Models.EmployeeModel();
                emp.EmpId = Convert.ToInt32(dr[0]);
                emp.EmpName = Convert.ToString(dr[1]);
                emp.EmpSalary = Convert.ToInt32(dr[2]);

                listObj.Add(emp);
            }
            return listObj;
        }

        public int SaveEmployee(EmployeeModel emp)
        {

            SqlCommand cmd = new SqlCommand("sp_CreateEmployee", con);//storeprocName
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();

            cmd.Parameters.AddWithValue("@EmpName", emp.EmpName);//PArameter name
            cmd.Parameters.AddWithValue("@EmpSalary", emp.EmpSalary);
            int i = cmd.ExecuteNonQuery();//Execute Query
            con.Close();
            return i;
        }


        

            public EmployeeModel getEmployeeDetailsById(int? id)
        {
            EmployeeModel emp = new EmployeeModel();
            SqlCommand cmd = new SqlCommand("usp_getEmployeesById", con);
            cmd.Parameters.AddWithValue("@EmpId", id);

            cmd.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                emp.EmpId = Convert.ToInt32(dr[0]);
                emp.EmpName = Convert.ToString(dr[1]);
                emp.EmpSalary = Convert.ToInt32(dr[2]);
            }
            return emp;
        }
        public int UpdateEmployee(EmployeeModel emp)
        {

            SqlCommand cmd = new SqlCommand("usp_updateUmeshEmployee", con);//storeprocName
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();

            cmd.Parameters.AddWithValue("@empId", emp.EmpId);//PArameter name
            cmd.Parameters.AddWithValue("@empname", emp.EmpName);//PArameter name
            cmd.Parameters.AddWithValue("@empsalary", emp.EmpSalary);
            int i = cmd.ExecuteNonQuery();//Execute Query
            con.Close();
            return i;
        }

        public int DeleteEmployee(int? id)
        {

            SqlCommand cmd = new SqlCommand("usp_DeleteEmployeeById", con);//storeprocName
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();

            cmd.Parameters.AddWithValue("@EmpId", id);//PArameter name
             
            int i = cmd.ExecuteNonQuery();//Execute Query
            con.Close();
            return i;
        }
    }
}

 
