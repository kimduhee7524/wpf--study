using CustomControl.UI.Views;
using System.Windows;

namespace CustomControl
{
    internal class App: Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            PracticeWindow window = new ();
            window.ShowDialog();
        }
    }
}