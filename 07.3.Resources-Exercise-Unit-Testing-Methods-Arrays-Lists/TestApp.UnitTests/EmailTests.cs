using NUnit.Framework;
namespace TestApp.UnitTests;

public class EmailTests
{
    // TODO: finish test
    [Test]
    public void Test_IsValidEmail_ValidEmail()
    {
        // Arrange
        string validEmail = "test@example.com";

        // Act
        bool isValid = Email.IsValidEmail(validEmail);
        // Assert
        Assert.IsTrue(isValid, "The email address valid.");
        
    }


    [Test]
    public void Test_IsValidEmail_InvalidEmail()
    {
        //Arrange
        string invalidEmail = "Invalid Email";
        //Act
        bool isValid = Email.IsValidEmail(invalidEmail);
        //Assert
        Assert.IsFalse(isValid, "The email address invalid.");
    }

    [Test]
    public void Test_IsValidEmail_NullInput()
    {
        // Arrange
        string emptyEmail = "";
        string nullEmail = null;

        // Act
        bool isValidEmpty = Email.IsValidEmail(emptyEmail);
        bool isValidNull = Email.IsValidEmail(nullEmail);

        // Assert
        Assert.IsFalse(isValidEmpty, "The email address invalid.");
        Assert.IsFalse(isValidNull, "The email address invalid.");
    

    }
}
