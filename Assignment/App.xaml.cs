using Assignment.Respositories;

namespace Assignment;

public partial class App : Application
{
	public static CarsRespository _carRepo { get; set;}
	public App(CarsRespository carsRepo)
	{
		InitializeComponent();

		_carRepo = carsRepo;

		
		MainPage = new Assignment12();
	}
}
