using static System.Net.Mime.MediaTypeNames;

namespace MPG_Comparison;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void SubmitValues(object sender, EventArgs e)
	{
       
        // collecting the entered values from the user into variables
        float tripMiles = float.Parse(entTripMiles.Text);
        float gallonsFilled = float.Parse(entGallonsFilled.Text);
        float reportedFuelEconomy = float.Parse(entReportedFuelEconomy.Text);

        // calculating the actual mpg and percent error. Putting values into strings 
        float actualFuelEconomy = tripMiles / gallonsFilled;
        float percentError =
        ((reportedFuelEconomy - actualFuelEconomy)
        / (actualFuelEconomy)) * 100;


        lblActualFuelEconomy.Text = 
            $"Actual fuel economy since you last refill: {actualFuelEconomy:0.0} MPG";
        lblPercentError.Text =
            $"Percent error of your vehicle's reported mileage: {percentError:0.0}%";

    }

    void OnEntryTextChanged(object sender, TextChangedEventArgs e)
    {
       string oldText = e.OldTextValue;
       string newText = e.NewTextValue;
    }

    void OnEntryCompleted(object sender, EventArgs e)
    {
       string text = ((Entry)sender).Text;
    }

    // DisplayAlert("title", "message", "button1", "button2");

}

