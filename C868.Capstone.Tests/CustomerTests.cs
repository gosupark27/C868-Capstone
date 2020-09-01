using C868_Capstone;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace C868.Capstone.Tests
{
    public class CustomerTests
    {
        [Fact]
        public void EditCustomer()
        {
            //Arrange
            var expectedFirstName = "John";
            var expectedLastName = "Smith";
            var expectedPhone = "1234567890";
            int editSuccess = 1;
            MainScreen form = new MainScreen();
            var createControl = form.GetType().GetMethod("CreateControl", BindingFlags.Instance | BindingFlags.NonPublic);
            createControl.Invoke(form, new object[] { true });

            //Act - set up values
            //result = 1 if customer info is edited, result = 0 if customer info can not be edited
            int actualResult = form.EditCustomerInfo(expectedFirstName, expectedLastName, expectedPhone);

            //Assertion - The expected output given the known inputs 
            Assert.Equal(editSuccess, actualResult);
        }

        [Fact]
        public void AddCustomer()
        {
            //Arrange
            var expectedFirstName = "John";
            var expectedLastName = "Smith";
            var expectedPhone = "1234567890";
            int addSuccess = 1;
            MainScreen form = new MainScreen();
            var createControl = form.GetType().GetMethod("CreateControl", BindingFlags.Instance | BindingFlags.NonPublic);
            createControl.Invoke(form, new object[] { true });

            //Act - set up values
            //result = 1 if new customer is added, result = 0 if customer can not be added
            int actualResult = form.AddCustomer(expectedFirstName, expectedLastName, expectedPhone);

            //Assertion - The expected output given the known inputs 
            Assert.Equal(addSuccess, actualResult);
        }

        [Fact]
        public void DeleteCustomer()
        {
            //Arrange
            var expectedFirstName = "John";
            var expectedLastName = "Smith";
            var expectedPhone = "1234567890";
            int deleteSuccess = 1;
            MainScreen form = new MainScreen();
            var createControl = form.GetType().GetMethod("CreateControl", BindingFlags.Instance | BindingFlags.NonPublic);
            createControl.Invoke(form, new object[] { true });

            //Act - set up values
            //result = 1 if customer is deleted, result = 0 if cannot be deleted
            int actualResult = form.DeleteCustomer(expectedFirstName, expectedLastName, expectedPhone);

            //Assertion - The expected output given the known inputs 
            Assert.Equal(deleteSuccess, actualResult);
        }
    }
}
