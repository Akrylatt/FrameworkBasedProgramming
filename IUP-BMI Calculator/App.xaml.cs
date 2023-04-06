using IUP_BMI_Calculator.Repository;
using IUP_BMI_Calculator.ViewModel;

namespace IUP_BMI_Calculator;

public partial class App : Application
{
    public  static BMIResultRepository repository { get; set; }
   
    public App(BMIResultRepository repo)
	{
		InitializeComponent();


		MainPage = new AppShell();

        // TODO Add the BMIResultRepository as a property and iniƟalize it inside the constructor. 
        repository = repo;

    }
}

