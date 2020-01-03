using Microsoft.VisualStudio.TestTools.UnitTesting;
using HandlingNulls;
using System;
using HandlingNulls.DataModel;

namespace TestKataCode
{
    [TestClass]
    public class ValidateNullValues
    {
        [TestMethod]
        public void StringNulls_AllNullsHandled()
        {
            var returnedValue = CheckStringsFowNulls.ChecIsNullOrEmpty("");
            Console.Out.WriteLine($"this is returned value {returnedValue}");
        }
        [TestMethod]
        public void NullableOfType_CheckingDate_DoesNotReturnException()
        {
            Customer? customer = new Customer(null);
                
            var dateHasValue = customer.DateBecameCustomer.HasValue;
            Assert.IsTrue(dateHasValue.Equals(false), "Date has value");

        }
        [TestMethod]
        public void NullableOfType_WriteNumberOfDays_DefaultDays()
        {
            Customer? customer = new Customer(null);
            NullableOfType.WriteDays(customer);
            

        }
        [TestMethod]
        public void NullableOfT_WriteNumberOfDaysPositive()
        {
            Customer? customer = new Customer(null);
            customer.Name = "";
            customer.NumberOfDays = 42;
            NullableOfType.WriteDays(customer);

        }
        /// <summary>
        /// Handling array with nulls
        /// </summary>
        [TestMethod]
        public void NullableOfT_NullConditional_Array()
        {
            //Client[] inputClients = new Client[3]
            //{
            //    new Client { Name = "Darlene"},
            //    new Client(),
            //    null

            //};

            Customer[] inputCustomers = null;
            string c1 = inputCustomers?[0]?.Name;
            string c2 = inputCustomers?[1]?.Name;
            string c3 = inputCustomers?[2]?.Name;

        }
        [TestMethod]
        public void ClientDocuments_AssignedBasedOnType_DocumentsWithChildren()
        {
            ClientDocument clientDocument = new ClientDocument(new DocumentsWithChildren())
            {
                Name = "Paul"
            };
            clientDocument.Assign(1);
            ClientDocument documentsForNate = new ClientDocument(new DocumentsWithChildren())
            {
                Name = "Nate"
            };
            documentsForNate.Assign(1);
        }
        [TestMethod]
        public void ClientDocuments_AssignedBasedOnType_DocumentsNoChildren()
        {
            
           
            ClientDocument documentsForNate = new ClientDocument(new DocumentsWithoutChildren())
            {
                Name = "Nate"
            };
            documentsForNate.Assign(1);
        }
        [TestMethod]
        public void ClientDocuments_AssignedBasedOnType_NoCustType()
        {
            
            ClientDocument documentsForNate = new ClientDocument(DocumentAssignment.Null)
            {
                Name = "Nate"
            };
        }

    }
}
