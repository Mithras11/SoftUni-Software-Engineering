using System;
using System.Collections.Generic;
using System.Text;

namespace BirthdayCelebrations
{
    public interface IBirthday
    {
        string Birthdate { get; set; }

        bool FindYear(string year);
        
            
        

        
    }
}
