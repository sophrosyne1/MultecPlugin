using System.Text;
using System.Threading.Tasks;
using RepetierHostExtender.interfaces;

namespace MultecPlugin
{
    public class MultecPlugin : IHostPlugin
    {

        IHost host;
        /// <summary>
        /// Called first to allow filling some lists. Host is not fully set up at that moment.
        /// </summary>
        /// <param name="host"></param>
        public void PreInitalize(IHost _host)
        {
            host = _host;
        }

    
        /// <summary>
        /// Called after everything is initalized to finish parts, that rely on other initializations.
        /// Here you must create and register new Controls and Windows.
        /// </summary>
        public void PostInitialize()
        {
            // Add the Multec Control to the right tab
            MultecTouchpanel TouchControl = new MultecTouchpanel();
            TouchControl.Connect(host);
            host.RegisterHostComponent(TouchControl);

            // Add some text in the about dialog
            host.AboutDialog.RegisterThirdParty("MultecPlugin", "\r\n\r\nMultecPlugin written by Multec GmbH\r\n3D Druck 4.0");
        }
        /// <summary>
        /// Last round of plugin calls. All controls exist, so now you may modify them to your wishes.
        /// </summary>
        public void FinializeInitialize()
        {
        }
    }
}
