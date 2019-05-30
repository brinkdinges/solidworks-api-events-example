using AngelSix.SolidDna;

namespace SolidWorks_api_events_example.Addin
{
    public class ExamplePlugin : SolidPlugIn    
    {
        public override void ConnectedToSolidWorks()
        {
            var taskPane = new TaskpaneIntegration<TaskPaneWindowHost>
            {
                WpfControl = new TaskPaneUserControl()
            };

            taskPane.AddToTaskpaneAsync();
        }

        public override void DisconnectedFromSolidWorks()
        {
            
        }

        public override string AddInTitle => "Example plugin";

        public override string AddInDescription => "Showing that events remain hooked after add-in is unloaded";
    }
}
