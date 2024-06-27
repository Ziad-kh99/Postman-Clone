namespace PostmanCloneUI;

public partial class Dashboard : Form
{
    public Dashboard()
    {
        InitializeComponent();
    }

    private void Dashboard_Load(object sender, EventArgs e)
    {

    }

    private async void apiCallBtn_Click(object sender, EventArgs e)
    {
        // TODO: Validate API URL.


        try
        {
            systemStatus.Text = "Calling API...";

            // Sample code will be replaced the actual api call.
            await Task.Delay(2000);

            systemStatus.Text = "Ready";
        }
        catch(Exception ex) 
        {
            apiResponseText.Text = $"Error: {ex.Message}";
            systemStatus.Text = "Error";
        }

    }
}
