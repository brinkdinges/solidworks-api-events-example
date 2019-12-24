using System.ComponentModel;
using System.Windows;
using AngelSix.SolidDna;

namespace SolidWorks_api_events_example.Addin
{
    public class ViewModel
    {
        private static ViewModel _instance;

        public ViewModel()
        {
            _instance = this;
            if (DesignerProperties.GetIsInDesignMode(new DependencyObject()))
                return;

            SolidWorksEnvironment.Application.ActiveModelInformationChanged += Application_ActiveModelInformationChanged;
        }

        public static void ShutDown()
        {
            _instance?.ShutDownInstance();
        }

        private void ShutDownInstance()
        {
            SolidWorksEnvironment.Application.ActiveModelInformationChanged -= Application_ActiveModelInformationChanged;
        }

        private void Application_ActiveModelInformationChanged(Model model)
        {
            MessageBox.Show("Active model info changed");
        }

        public string WelcomeText => "Hi there";
    }
}
