using System;
using System.Collections.Generic;
using System.Text;

namespace HandlingNulls
{
    public class DocumentsWithoutChildren : DocumentAssignment
    {
        public override int GetNumberOfDocumentsAssigned(int typeOfCustomer)
        {
            return 5;
        }
    }
}
