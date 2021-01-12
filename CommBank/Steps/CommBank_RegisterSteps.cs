using CommBank.Drivers;
using TechTalk.SpecFlow;


namespace CommBank.Objects
{
    [Binding]
    public class CommBank_RegisterSteps : Shared_Functions
    {
        public PageObject CPO = new PageObject();
        [Given(@"I am on Commbank Login Page and I click Register Online Now button")]
        public void GivenIAmOnCommbankLoginPageAndIClickRegisterOnlineNowButton()
        {
            NavigateToURL();
            CPO.ClickRegister();
            
        }


        [Given(@"I select options on registeration Page and click ok")]
        public void GivenISelectOptionsOnRegisterationPageAndClickOk()
        {
            CPO.Registration();

        }

        [When(@"I click next on custom registration information page")]
        public void WhenIClickNextOnCustomRegistrationInformationPage()
        {


            CPO.InformationPage();

        }

        [When(@"i enter details and click next on registration page")]
        public void WhenIEnterDetailsAndClickNextOnRegistrationPage()
        {
            CPO.RegisterationInfo();
        }

        [Then(@"Test is complete")]
        public void ThenRegistrationShouldBeSuccessful()
        {
           
            Shared_Functions.CleanUp();
        }
      }
}
