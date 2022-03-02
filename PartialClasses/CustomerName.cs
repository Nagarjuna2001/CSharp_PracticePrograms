using System;

namespace PartialClasses
{
    public partial class CustomerName
    {
        public string getFullName(string firstname, string lastname)
        {
            return firstname + " " + lastname;
        }
    }
}
