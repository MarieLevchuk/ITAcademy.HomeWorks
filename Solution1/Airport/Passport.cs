using System;
using System.Collections.Generic;
using System.Text;

namespace Airport
{
    class Passport:Documents
    {
        public Passport()
        {
            DocumentType = "passport";
            Guid guid = Guid.NewGuid();
            DocumentNumber = guid.ToString();
        }
    }
}
