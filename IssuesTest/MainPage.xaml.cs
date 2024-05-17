using System.Collections.ObjectModel;
using System.Diagnostics;

namespace IssuesTest;

public partial class MainPage : ContentPage
{
    ObservableCollection<State> states = new ObservableCollection<State>();
    public MainPage()
	{
		InitializeComponent();
        var state = new State() { Code = "NY", Name = "New York" };
        states.Add(state);

        var state2 = new State() { Code = "FL", Name = "Florida" };
        states.Add(state2);

        list.ItemsSource = states;        
    }

    string initCode = "";
    private void tbCode_Focused(object sender, FocusEventArgs e)
    {
        var textBox = (Entry)sender;
        initCode = textBox.Text;
    }

    
    private void tbCode_Unfocused(object sender, FocusEventArgs e)
    {
        var textBox = (Entry)sender;
        //lHey.Text = textBox.Text;
        if (initCode != textBox.Text)
            testTitle.Text = textBox.Text;
        //Debug.WriteLine(textBox.Text);
    }

    string initName = "";
    private void tbName_Focused(object sender, FocusEventArgs e)
    {
        var textBox = (Entry)sender;
        initName = textBox.Text;
    }

    private void tbName_Unfocused(object sender, FocusEventArgs e)
    {
        var textBox = (Entry)sender;
        if (initName != textBox.Text)
            testTitle.Text = textBox.Text;
            //Debug.WriteLine(textBox.Text);
    }

    private void btnAdd_Clicked(object sender, EventArgs e)
    {
        var state = new State() { Code = "CT", Name = "Connecticut" };
        states.Add(state);
    }

    private void tbName_Completed(object sender, EventArgs e)
    {
        testTitle.Text = "Completed";
    }
}

public class State
{
    public string Code { get; set; }
    public string Name { get; set; }
}
