using System;
using System.Collections.Generic;
using System.Text;

namespace HandlingNulls
{
    public class NoDocuments : DocumentAssignment
    {
        /// <summary>
        /// Returns nothing if no customer type is provided
        /// </summary>
        /// <param name="typeOfCustomer"></param>
        /// <returns></returns>
        public override int GetNumberOfDocumentsAssigned(int typeOfCustomer)
        {
            return 0;//no operation no action behavior
        }
    }
}
