namespace Module03Exercise02.View;
using Module03Exercise02.Services;

public partial class LoginPage : ContentPage
{
    private readonly IConfigurationService _myService; //Field for the service

    public LoginPage(IConfigurationService myService)
    {
        InitializeComponent();
        _myService = myService;

        var message = _myService.GetMessage();
        MyLabel.Text = message;
    }

    private async void OnLoginButtonClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//EmployeePage");
    }

    private async void OnSignupButtonClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//AddEmployee");
    }
}