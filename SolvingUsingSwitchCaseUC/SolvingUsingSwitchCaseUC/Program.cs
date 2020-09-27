using System;

namespace SolvingUsingSwitchCaseUC
{
    class Program
    {
        public String presence(int status)
        {   

            switch(status)
            {
                case 1:
                    return "Employee Present Full Time";
                    
                case 2:
                    return "Employee is working part time";
                    
                case 3:
                    return "Employee is absent";
                   
                default:
                    throw new InvalidOperationException("status must be in range 1-3");

            } 

            
        }
    }
}
