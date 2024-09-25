namespace Module03Exercise02.View;

using Module03Exercise02.ViewModel;


public partial class EmployeePage : ContentPage
{
    public EmployeePage()
    {
        InitializeComponent();
        BindingContext = new EmployeeViewModel();

    }

}