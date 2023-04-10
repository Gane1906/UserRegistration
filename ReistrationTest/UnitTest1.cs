using UserRegistration;

namespace ReistrationTest
{
    public class Tests
    {
        [Test]
        public void GivenFirstName_WhenValidate_ShouldReturnValid()
        {
            string name = "Ganesh";
            UserValidation validation = new UserValidation();
            var result=validation.ValidateFirstName(name);
            Assert.AreEqual("Valid first name", result);
        }
        [Test]
        public void GivenLastName_WhenValidate_ShouldReturnValid()
        {
            string name = "Doppani";
            UserValidation validation = new UserValidation();
            string result = validation.ValidateLastName(name);
            Assert.AreEqual("Valid Last name", result);
        }
        [Test]
        public void GivenEmail_WhenValidate_ShouldReturnValid()
        {
            string email = "abc.xyz@bridgelabz.co.in";
            UserValidation validation = new UserValidation();
            string result = validation.ValidateEmail(email);
            Assert.AreEqual("Valid email", result);
        }
        [Test]
        public void GivenPhoneNumber_WhenValidate_ShouldReturnValid()
        {
            string phone = "9876543219";
            UserValidation validation = new UserValidation();
            string result = validation.ValidateMobileNumber(phone);
            Assert.AreEqual("Valid mobile number", result);
        }
        [Test]
        public void GivenPassword_WhenValidate_ShouldReturnValid()
        {
            string pwd = "Agtf@1234";
            UserValidation validation = new UserValidation();
            string result = validation.ValidatePassWord(pwd);
            Assert.AreEqual("Valid password", result);
        }
    }
}