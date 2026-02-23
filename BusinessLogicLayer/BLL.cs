using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class BLL
    {
        DAL dal = new DAL();

        public int InsertUser(User user)
        {
            return dal.InsertUser(user);
        }
        public int InsertModuleType(User user)
        {
            return dal.InsertModuleType(user);
        }
        public int InsertModule(User user)
        {
            return dal.InsertModule(user);
        }
        public int InsertLectModule(User user)
        {
            return dal.InsertLectModule(user);
        }
        public int InsertStudentModule(User user)
        {
            return dal.InsertStudentModule(user);
        }
        public int InsertAssessmentType(User user)
        {
            return dal.InsertAssessmentType(user);
        }
        public int InsertAssessment(User user)
        {
            return dal.InsertAssessment(user);
        }
        public int UpdateUser(User user)
        {
            return dal.UpdateUser(user);
        }
        public int UpdateModType(User user)
        {
            return dal.UpdateModType(user);
        }
        public int UpdateModule(User user)
        {
            return dal.UpdateModule(user);
        }
        public int UpdateLectMod(User user)
        {
            return dal.UpdateLectMod(user);
        }
        public int UpdateStudMod(User user)
        {
            return dal.UpdateStudMod(user);
        }
        public int UpdateAssessmentStatus(User user)
        {
            return dal.UpdateAssessmentStatus(user);
        }
        public int UpdateAssessmentType(User user)
        {
            return dal.UpdateAssessmentType(user);
        }
        public int UpdateAssessment(User user)
        {
            return dal.UpdateAssessment(user);
        }
        public int DeleteUser(User user)
        {
            return dal.DeleteUser(user);
        }
        public int DeleteModule(User user)
        {
            return dal.DeleteModule(user);
        }
        public int DeleteModuleType(User user)
        {
            return dal.DeleteModuleType(user);
        }
        public int DeleteLectMod(User user)
        {
            return dal.DeleteLectMod(user);
        }
        public int DeleteStudMod(User user)
        {
            return dal.DeleteStudMod(user);
        }
        public int DeleteAssessmentType(User user)
        {
            return dal.DeleteAssessmentType(user);
        }
        public int DeleteAssessment(User user)
        {
            return dal.DeleteAssessment(user);
        }
        public DataTable GetUser()
        {
            return dal.GetUser();
        }
        public DataTable GetModuleType()
        {
            return dal.GetModuleType();
        }
        public DataTable GetModule() 
        {
            return dal.GetModule(); 
        }
        public DataTable GetLectureModule()
        {
            return dal.GetLectureModule();
        }
        public DataTable GetStudMod()
        {
            return dal.GetStudMod();
        }
        public DataTable GetAssessmentType()
        {
            return dal.GetAssessmentType();
        }
        public DataTable GetAssessment()
        {
            return dal.GetAssessment();
        }
        public DataTable GetUserByName(string Name)
        {
            return dal.GetUserByName(Name);
        }
        public DataTable GetNoOfStud()
        {
            return dal.GetNoOfStud();
        }
        public DataTable GetUserByRole(string Role)
        {
            return dal.GetUserByRole(Role);
        }
        public DataTable GetModuleByName(string ModuleName)
        {
            return dal.GetModuleByName(ModuleName);
        }
        public DataTable GetAssessmetByStudentLecturerModuleID(int StudentLecturerModuleID)
        {
            return dal.GetAssessmetByStudentLecturerModuleID(StudentLecturerModuleID);
        }
        public DataTable GetAssessmentByStatus(string AssessmentStatus)
        {
            return dal.GetAssessmentByStatus(AssessmentStatus);
        }
        public DataTable GetStudent(int UserID, string Role)
        {
            return dal.GetStudent(UserID, Role);
        }
        public DataTable AdminLogIn(string LogInPassword)
        {
            return dal.AdminLogIn(LogInPassword);
        }
        public DataTable LectLogIn(string LogInPassword)
        {
            return dal.LectLogIn(LogInPassword);
        }
        public DataTable StudentLogIn(int UserLogInID, string LogInPassword)
        {
            return dal.StudentLogIn(UserLogInID, LogInPassword);
        }
        public DataTable GetModsEnrolledIn(int UserID, string LogInPassword)
        {
            return dal.GetModsEnrolledIn(UserID, LogInPassword);
        }
        public DataTable SearchBetweenDate(string ModuleID, string StartDate, string EndDate)
        {
            return dal.SearchBetweenDate(ModuleID, StartDate, EndDate);
        }
    }
}
