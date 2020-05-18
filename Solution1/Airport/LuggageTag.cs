using System;
using System.Collections.Generic;
using System.Text;

namespace Airport
{
    class LuggageTag: Documents
    {
        public LuggageTag()
        {
            DocumentType = "Luggage tag";

            Guid guid = Guid.NewGuid();
            DocumentNumber = guid.ToString();
        }
    }
}
