1. Using C#, Selenium with Specflow and use chrome for my project. 
2. WebDriver.cs class initialises the ChromeDriver and navigate to CommBank login page, and it also contains selenium functionality as well as Cleanup procedure. 
3. CommBank_Register.featurecs file consists of specflow scenario
4. RegisterPageObjects.cs consists of all the UI elements and methods. 
5. Reusable Functions consists of all the shared Functions which we can use repetedly 
6. Before Execution please update PageObject Variable "C:\\CommBizRegister-master\\TestResults\\" to user's project location.


Loading plugin C:\CommBizRegister-master\CommBank\bin\Debug\net472\TechTalk.SpecFlow.MSTest.SpecFlowPlugin.dll
-> Using default config
Given I am on Commbank Login Page and I click Register Online Now button
-> done: CommBank_RegisterSteps.GivenIAmOnCommbankLoginPageAndIClickRegisterOnlineNowButton() (15.1s)
And I select options on registeration Page and click ok
-> done: CommBank_RegisterSteps.GivenISelectOptionsOnRegisterationPageAndClickOk() (4.1s)
When I click next on custom registration information page
-> done: CommBank_RegisterSteps.WhenIClickNextOnCustomRegistrationInformationPage() (1.3s)
When i enter details and click next on registration page
-> done: CommBank_RegisterSteps.WhenIEnterDetailsAndClickNextOnRegistrationPage() (2.9s)
Then Test is complete
Cleanup process started
-> done: CommBank_RegisterSteps.ThenRegistrationShouldBeSuccessful() (12.5s)

