using System.Diagnostics;
using System.Reflection;
using System.Text.RegularExpressions;

namespace Programming.Models.Classes
{
    internal class Contact
    {
        private string _name;
        private string _surName;
        public string Name
        {
            get { return AssertStringContainsOnlyLetters(_name); }
            set
            {
                _name = AssertStringContainsOnlyLetters(value);
            }
        }
        
        public string SurName
        {
            get { return AssertStringContainsOnlyLetters(_surName); }
            set
            {
                _surName = AssertStringContainsOnlyLetters(value);
            }
        }
        
        private int Number { get; set; }

        private string Address { get; set; }

        private string Post { get; set; }

        public Contact(string name,string surName, int number, string adress, string post)
        {
            Name = name;
            SurName = surName;
            Address = adress;
            Post = post;
        }

        private string AssertStringContainsOnlyLetters(string value)
        {
            StackTrace stackTrace = new StackTrace();
            MethodBase caller = stackTrace.GetFrame(1)?.GetMethod() ?? throw new InvalidOperationException();
            
            if (!Regex.IsMatch(value, "^[a-zA-Z]+$"))
            {
                throw new ArgumentException(String.Format("{0} should contain only English letters.", caller.Name));
            }

            return value;
        }
    }
}