using System.ComponentModel;
using System.Windows;
using AngelSix.SolidDna;

namespace SolidWorks_api_events_example.Addin
{
    public class ViewModel
    {
        public ViewModel()
        {
            if (DesignerProperties.GetIsInDesignMode(new DependencyObject()))
                return;

            SolidWorksEnvironment.Application.ActiveModelInformationChanged += Application_ActiveModelInformationChanged;
        }

        private void Application_ActiveModelInformationChanged(Model model)
        {
            MessageBox.Show("Active model info changed");
        }

        public string WelcomeText => "Hi there";
    }
}
