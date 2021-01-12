using CommBank.Drivers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;


namespace CommBank.Objects
{

    //public interface IPageObjects
    //{
    //    void ClickRegister();
    //    void CustomRegistration();
    //    void InformationPage();
    //    void RegisterationInfo();
    //}
    public class PageObject : Shared_Functions
    {

        public static string RegisterButton = "#form1>div.regStyle>div.regContent>div>a";
        public static string Frames = "frmRegistration";
        public static string RadioButton = "input[id=rdoAdvanced]";
        public static string CheckBox = "input[id=chkMMFXSelected]";
        public static string NextButton = "input[id=btnNext]";
        public static string Submit = "input[id=btnSubmit]";
        public static string UserName = "input[name=txtUserName]";
        public static string UserText = "Username";
        public static string Password = "input[id=txtPassword]";
        public static string PasswordText = "password";
        public static string PasswordReEnter = "input[id=txtReenterPassword]";
        public static string SecretQuestion1 = "#ddlSecret1>option:nth-child(11)";
        public static string SecretAnswer1 = "input[id=txtSecret1]";
        public static string SecretAnswer1Text = "Blue";
        public static string SecretQuestion2 = "#ddlSecret2>option:nth-child(14)";
        public static string SecretAnswer2 = "input[id=txtSecret2]";
        public static string SecretAnswer2Text = "KIA";
        public static string Register = "input[name=btnSubmit]";
        public static string ScreenshotLocation = "C:\\CommBizRegister-master\\TestResults\\";

        public PageObject()
        {
        }
        public void ClickRegister()
        {
            Driver.SwitchTo().Frame(Frames);
            Driver.TakeScreenshot().SaveAsFile(ScreenshotLocation+"LoginScreen.jpg", ScreenshotImageFormat.Jpeg);
            ClickByCSS(RegisterButton);
        }

        public void Registration()
        {
            WaitforElementVisible(RadioButton);
            ClickByCSS(RadioButton);
            ClickByCSS(CheckBox);
            Driver.TakeScreenshot().SaveAsFile(ScreenshotLocation+"CustomerRegistration.jpg", ScreenshotImageFormat.Jpeg);
            ClickByCSS(NextButton);
        }

        public void InformationPage()
        {
            Driver.TakeScreenshot().SaveAsFile(ScreenshotLocation+"Information.jpg", ScreenshotImageFormat.Jpeg);
            ClickByCSS(Submit);
        }

        public void RegisterationInfo()
        {
            SendKeysByCSS(UserName, UserText);
            SendKeysByCSS(Password, PasswordText);
            SendKeysByCSS(PasswordReEnter, PasswordText);
            ClickByCSS(SecretQuestion1);
            SendKeysByCSS(SecretAnswer1, SecretAnswer1Text);
            ClickByCSS(SecretQuestion2);
            SendKeysByCSS(SecretAnswer2, SecretAnswer2Text);
            Driver.TakeScreenshot().SaveAsFile(ScreenshotLocation+"RegisrationForm.jpg", ScreenshotImageFormat.Jpeg);
            ClickByCSS(Register);
        }
    }
}
