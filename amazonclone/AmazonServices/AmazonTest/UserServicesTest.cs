using Moq;
using System.ComponentModel;
using UserServices.Entites;
using UserServices.Repository;
using UserServices.Services;

namespace AmazonTest
{
    [TestFixture]
    public class UserServicesTest
    {
        UserS us;
        User u;
        [SetUp]
        public void initialise()//similar to constructor
        {
            //mocking--dummy representaion of dependent class
            
           
            us = new UserS();
            u = new User() { Email = "tharun123@gmail.com", Password = "tharun123" };
        }

        [Test]
        public void TestAddUserSuccess()
        {
            var mockRepo=new Mock<IUserrepository>();
            us = new UserS(mockRepo.Object);
            mockRepo.Setup(s=>s.Add(u)).Returns(true);
            var result = us.Add(u);
            Assert.AreEqual(true,result);
        }
        [Test]
        public void TestAddUserFail()
        {
            Assert.Pass();
        }
        [Test]
        public void TestValidationUserSuccess()
        {
            var mockRepo = new Mock<IUserrepository>();
            us=new UserS(mockRepo.Object);
            mockRepo.Setup(a => a.Validate(u)).Returns(true);
            var result=us.validate(u);
            Assert.AreEqual(true,result);
        }
        [TearDown]
        public void Release()
        {
            u = null;
            us = null;
        }
    }
}