using System;
using System.Collections.Generic;
using System.Text;

namespace HandlingNulls
{
    public abstract class DocumentAssignment
    {
       public abstract int GetNumberOfDocumentsAssigned(int typeOfCustomer);

        public static DocumentAssignment Null { get; } = new NullDocuments();
        private class NullDocuments : DocumentAssignment
        {
            public override int GetNumberOfDocumentsAssigned(int typeOfCustomer)
            {
                return 0; //donothingbehavior
            }
        }
        
    }
}
