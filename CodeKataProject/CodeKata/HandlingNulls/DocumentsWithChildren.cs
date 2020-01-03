using System;
using System.Collections.Generic;
using System.Text;

namespace HandlingNulls
{
    public class DocumentsWithChildren : DocumentAssignment
    {
        public override int GetNumberOfDocumentsAssigned(int typeOfCustomer)
        {
            return 10;
        }
    }
}
