using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class DAL
    {
        static string connString = "Data Source = localhost; Initial Catalog = AssessmentDB; Integrated Security = true;";
        SqlConnection dbConn =  new SqlConnection(connString);
        SqlCommand dbComm;
        SqlDataAdapter dbAdapter;
        DataTable dt;

        public int InsertUser(User user)
        {
            dbConn.Open();
            dbComm = new SqlCommand("sp_InsertUser", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@Name", user.Name);
            dbComm.Parameters.AddWithValue("@Surname", user.Surname);
            dbComm.Parameters.AddWithValue("Title", user.Title);
            dbComm.Parameters.AddWithValue("@Role", user.Role);
            dbComm.Parameters.AddWithValue("@Email", user.Email);
            dbComm.Parameters.AddWithValue("@Password", user.Password);
            dbComm.Parameters.AddWithValue("@UserStatus", user.UserStatus);
            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;   
        }
        public int InsertModuleType(User user)
        {
            dbConn.Open();
            dbComm = new SqlCommand("sp_InsertModuleType", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@ModuleTypeDescription", user.ModuleTypeDescription);
            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }
        public int InsertModule(User user)
        {
            dbConn.Open();
            dbComm = new SqlCommand("sp_InsertModule", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@ModuleName", user.ModuleName);
            dbComm.Parameters.AddWithValue("@ModuleDuration", user.ModuleDuration);
            dbComm.Parameters.AddWithValue("@ModuleTypeID", user.ModuleType);
            dbComm.Parameters.AddWithValue("@ModuleStatus", user.ModuleStatus);
            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }
        public int InsertLectModule(User user)
        {
            dbConn.Open();
            dbComm = new SqlCommand("sp_InsertLectureModule", dbConn);
            dbComm.CommandType= CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@UserID", user.LectID);
            dbComm.Parameters.AddWithValue("@ModuleID", user.ModID4Lect);
            dbComm.Parameters.AddWithValue("@Date", user.LectDate);
            dbComm.Parameters.AddWithValue("@ModLectStatus", user.LectStatus);
            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }
        public int InsertStudentModule(User user)
        {
            dbConn.Open();
            dbComm = new SqlCommand("sp_InsertStudentModule", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@UserID", user.StudID);
            dbComm.Parameters.AddWithValue("@LecturerModuleID", user.LectModID);
            dbComm.Parameters.AddWithValue("@Date", user.StudDate);
            dbComm.Parameters.AddWithValue("@StudModStatus", user.StudStatus);
            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }
        public int InsertAssessmentType(User user)
        {
            dbConn.Open();
            dbComm = new SqlCommand("sp_InsertAssessmentType", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@AssessmentTypeDescription", user.AssessmentTypeDescription);
            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }
        public int InsertAssessment(User user)
        {
            dbConn.Open();
            dbComm = new SqlCommand("sp_InsertAssessment", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("StudentLecturerModuleID", user.StudLectMod);
            dbComm.Parameters.AddWithValue("DueDate", user.DueDate);
            dbComm.Parameters.AddWithValue("AssessmentTypeID", user.TypeID);
            dbComm.Parameters.AddWithValue("AssessmentStatus", user.AssessmentStatus);

            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }
        public int UpdateUser(User user)
        {
            dbConn.Open();
            dbComm = new SqlCommand("sp_UpdateUser", dbConn);
            dbComm.CommandType= CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@UserID", user.UserID);
            dbComm.Parameters.AddWithValue("@Surname", user.Surname);
            dbComm.Parameters.AddWithValue("@Title", user.Title);
            dbComm.Parameters.AddWithValue("@Email", user.Email);
            dbComm.Parameters.AddWithValue("@Password", user.Password);
            dbComm.Parameters.AddWithValue("@UserStatus", user.UserStatus);
            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }
        public int UpdateModType(User user)
        {
            dbConn.Open();
            dbComm = new SqlCommand("sp_UpdateModType", dbConn);
            dbComm.CommandType= CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@ModuleTypeID", user.ModuleTypeID);
            dbComm.Parameters.AddWithValue("@ModuleTypeDescription", user.ModuleTypeDescription);
            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }
        public int UpdateModule(User user)
        {
            dbConn.Open();
            dbComm = new SqlCommand("sp_UpdateModule", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@ModuleID", user.ModuleID);
            dbComm.Parameters.AddWithValue("@ModuleDuration", user.ModuleDuration);
            dbComm.Parameters.AddWithValue("@ModuleTypeID", user.ModuleType);
            dbComm.Parameters.AddWithValue("@ModuleStatus", user.ModuleStatus);
            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }
        public int UpdateLectMod(User user)
        {
            dbConn.Open();
            dbComm = new SqlCommand("sp_UpdateLectAssignedModule", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@LecturerModuleID", user.ModLectID);
            dbComm.Parameters.AddWithValue("@ModuleID", user.ModID4Lect);
            dbComm.Parameters.AddWithValue("@Date", user.LectDate);
            dbComm.Parameters.AddWithValue("@ModLecturerStatus", user.LectStatus);
            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }
        public int UpdateStudMod(User user)
        {
            dbConn.Open();
            dbComm = new SqlCommand("sp_UpdateStudAssignedModule", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@StudentModuleID", user.StudModID);
            dbComm.Parameters.AddWithValue("@StudModStatus", user.StudStatus);
            dbComm.Parameters.AddWithValue("@Date", user.StudDate);
            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }
        public int UpdateAssessmentStatus(User user)
        {
            dbConn.Open();
            dbComm = new SqlCommand("sp_UpdateAssessmentStatus", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@AssessmentID", user.AssessmentID);
            dbComm.Parameters.AddWithValue("@AssessmentStatus", user.AssessmentStatus);
            dbComm.Parameters.AddWithValue("@DueDate", user.DueDate);
            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }
        public int UpdateAssessmentType(User user)
        {
            dbConn.Open();
            dbComm = new SqlCommand("sp_UpdateAssessmentType", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@AssessmentTypeID", user.AssessmentTypeID);
            dbComm.Parameters.AddWithValue("@AssessmentTypeDescription", user.AssessmentTypeDescription);
            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }
        public int UpdateAssessment(User user)
        {
            dbConn.Open();
            dbComm = new SqlCommand("sp_UpdateAssessment", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@DueDate", user.DueDate);
            dbComm.Parameters.AddWithValue("@AssessmentTypeID", user.TypeID);
            dbComm.Parameters.AddWithValue("@AssessmentID", user.AssessmentID);
            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;

        }
        public int DeleteUser(User user)
        {
            dbConn.Open();
            dbComm = new SqlCommand("sp_DeleteUser", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@UserID", user.UserID);
            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }

        public int DeleteModule(User user)
        {
            dbConn.Open();
            dbComm = new SqlCommand("sp_DeleteModule", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@ModuleID", user.ModuleID);
            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }
        public int DeleteModuleType(User user)
        {
            dbConn.Open();
            dbComm = new SqlCommand("sp_DeleteModType", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@ModuleTypeID", user.ModuleTypeID);
            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }
        public int DeleteLectMod(User user)
        {
            dbConn.Open();
            dbComm = new SqlCommand("sp_DeleteLectModule", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@LectureModuleID", user.ModLectID);
            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }
        public int DeleteStudMod(User user)
        {
            dbConn.Open();
            dbComm = new SqlCommand("sp_DeleteStudMod", dbConn);
            dbComm.CommandType= CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@StudentModuleID", user.StudModID);
            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }
        public int DeleteAssessmentType(User user)
        {
            dbConn.Open();
            dbComm = new SqlCommand("DeleteAssessmentType", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@AssessmentTypeID", user.AssessmentTypeID);
            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }
        public int DeleteAssessment(User user)
        {
            dbConn.Open();
            dbComm = new SqlCommand("sp_DeleteAssessment", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@AssessmentID", user.AssessmentID);
            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }
        public DataTable GetUser()
        {
            dbComm = new SqlCommand("sp_GetUser", dbConn);
            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            return dt;
        }
        public DataTable GetModule()
        {
            dbComm = new SqlCommand("sp_GetModule", dbConn);
            dbAdapter = new SqlDataAdapter( dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            return dt;
        }
        public DataTable GetModuleType()
        {
            dbComm = new SqlCommand("sp_GetModuleType",dbConn);
            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            return dt;
        }
        public DataTable GetLectureModule()
        {
            dbComm = new SqlCommand("sp_GetLectureModule", dbConn);
            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            return dt;
        }

        public DataTable GetStudMod()
        {
            dbComm = new SqlCommand("sp_GetStudMod", dbConn);
            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            return dt;
        }
        public DataTable GetAssessmentType()
        {
            dbComm = new SqlCommand("sp_GetAssessmentType", dbConn);
            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            return dt;
        }
        public DataTable GetAssessment()
        {
            dbComm = new SqlCommand("sp_GetAssessment", dbConn) ;
            dbAdapter = new SqlDataAdapter( dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            return dt;
        }
        public DataTable GetNoOfStud()
        {
            dbComm = new SqlCommand("sp_GetNoOfStud", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            return dt;
        }
        public DataTable GetUserByName(string Name)
        {
            dbComm = new SqlCommand("sp_GetUserByName", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@Name", Name);
            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            return dt;
        }
        public DataTable GetUserByRole(string Role)
        {
            dbComm = new SqlCommand("sp_GetUserRole", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@Role", Role);
            dbAdapter = new SqlDataAdapter( dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            return dt;
        }
        public DataTable GetModuleByName(string ModuleName)
        {
            dbComm = new SqlCommand("sp_GetModuleByName",dbConn);
            dbComm.CommandType= CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@ModuleName", ModuleName);
            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            return dt;
        }
        public DataTable GetAssessmetByStudentLecturerModuleID(int StudentLecturerModuleID)
        {
            dbComm = new SqlCommand("sp_GetAssessmetByStudentLecturerModuleID", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@StudentLecturerModuleID", StudentLecturerModuleID);
            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            return dt;
        }
        public DataTable GetAssessmentByStatus(string AssessmentStatus)
        {
            dbComm = new SqlCommand("sp_GetAssessmentByStatus", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@AssessmentStatus", AssessmentStatus);
            dbAdapter = new SqlDataAdapter( dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            return dt;
        }
        public DataTable GetStudent(int UserID, string Role)
        {
            dbComm = new SqlCommand("sp_GetStudent", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@UserID", UserID);
            dbComm.Parameters.AddWithValue("@Role", Role);
            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            return dt;
        }
        public DataTable AdminLogIn(string LogInPassword)
        {
            dbComm = new SqlCommand("sp_AdminLogIn", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@Password", LogInPassword);
            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            return dt;
        }
        public DataTable LectLogIn(string LogInPassword)
        {
            dbComm = new SqlCommand("sp_LectLogIn", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@Password", LogInPassword);
            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            return dt;
        }
        public DataTable StudentLogIn(int UserLogInID, string LogInPassword)
        {
            dbComm = new SqlCommand("sp_StudentLogIn", dbConn);
            dbComm.CommandType= CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@UserID", UserLogInID);
            dbComm.Parameters.AddWithValue("@Password", LogInPassword);
            dbAdapter = new SqlDataAdapter( dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            return dt;
        }
        public DataTable GetModsEnrolledIn(int UserLogInID,  string LogInPassword)
        {
            dbComm = new SqlCommand("sp_GetEnrolledModules", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@UserID", UserLogInID);
            dbComm.Parameters.AddWithValue("@Password", LogInPassword);
            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            return dt;
        }
        public DataTable SearchBetweenDate(string ModuleID, string StartDate, string EndDate)
        {
            dbComm = new SqlCommand("sp_SearchBetweenDates", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@ModuleID", ModuleID);
            dbComm.Parameters.AddWithValue("@StartDate", StartDate);
            dbComm.Parameters.AddWithValue("@EndDate", EndDate);
            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            return dt;
        }
       
    }
}
