using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class User
    {
        public int UserID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Title { get; set; }
        public string Role { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string UserStatus { get; set; }

        public int ModuleTypeID { get; set; }
        public string ModuleTypeDescription { get; set; }
        public int ModuleID { get; set; }
        public string ModuleName { get; set; }
        public string ModuleDuration { get; set; }
        public string ModuleType { get; set; }
        public string ModuleStatus { get; set; }

        public int ModLectID { get; set; }
        public string LectID { get; set; }
        public string ModID4Lect { get; set; }
        public string LectStatus{ get; set;}
        public string LectDate { get; set; }

        public int StudModID { get; set; }
        public string StudID { get; set; }
        public string LectModID { get; set; }
        public string StudDate { get; set; }
        public string StudStatus { get; set; }

        public int AssessmentTypeID { get; set; }
        public string AssessmentTypeDescription { get; set; }

        public int AssessmentID { get; set; }
        public string StudLectMod { get; set;}
        public string DueDate { get; set; }
        public string TypeID { get; set; }
        public string AssessmentStatus { get; set;}

        public int UserLogInID { get; set; }
        public string LogInPassword { get; set; }

        public int StudentLecturerModuleID { get; set; }


    }
}
