using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Diary.Entities;

namespace Diary.Entities
{
    public partial class Employee
    {
        public string FullName
        {
            get
            {
                var fullName = $"{LastName + " "}";
                    fullName += $"{FirstName + " "}";
                if (Surname != null)
                    fullName += $"{Surname + " "}";
                return fullName ;
            }
        }
        public string FLName
        {
            get
            {
                var fullName = $"{LastName + " "}";
                fullName += $"{FirstName + " "}";
                return fullName;
            }
        }
    }
}
