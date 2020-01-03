using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace HandlingNulls.DataModel
{
    public class ClientDocument
    {
        private readonly DocumentAssignment _documentAssignment;
        public ClientDocument(DocumentAssignment documentAssignment)
        {
            _documentAssignment = documentAssignment;
        }
        public string Name { get; set; }
        public int NumberOfDocuments { get; set; } = 6;
        public void Assign(int docs)
        {
            //int docsAssigned = 0;
            //if(_documentAssignment != null)
            //{ 
            //    docsAssigned = _documentAssignment.GetNumberOfDocumentsAssigned(docs);
            //}
            //int totalDocsAssigned = docs + docsAssigned;
            int totalDocsAssigned = _documentAssignment.GetNumberOfDocumentsAssigned(docs);
            NumberOfDocuments += totalDocsAssigned;

            WriteLine($"{Name}'s number of documents {totalDocsAssigned} has increased to {NumberOfDocuments}");
        }
    }
}
