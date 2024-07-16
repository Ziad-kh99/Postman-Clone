using PostmanCloneLibrary;

namespace PostmanCloneUI;

public partial class Dashboard : Form
{
    private readonly IApiAccess api = new ApiAccess();
    public Dashboard()
    {
        InitializeComponent();
        //httpVerbSelection.SelectedIndex = 0;
        httpVerbSelection.SelectedItem = "GET";
    }

    private void Dashboard_Load(object sender, EventArgs e)
    {

    }

    private async void apiCallBtn_Click(object sender, EventArgs e)
    {
        systemStatus.Text = "Calling API...";
        apiResponseText.Text = string.Empty;

        // TODO: Validate API URL.
        if (api.IsValidUrl(apiURLText.Text) == false)
        {
            systemStatus.Text = "Invalid URL";
            return;
        }


        try
        {   
            callData.SelectedTab = responseTab;
            string response = await api.CallApiAsync(apiURLText.Text);

            apiResponseText.Text = response;

            systemStatus.Text = "Ready";
        }
        catch (Exception ex)
        {
            apiResponseText.Text = $"Error: {ex.Message}";
            systemStatus.Text = "Error";
        }

    }

}
