using Coypu;

namespace Roboweb
{
    public class RoboBrowser
    {
        public BrowserSession browserSession { get; set; }
        public Scope SessionScope;
        public RoboBrowser()
        {

        }
        public RoboBrowser(Scope scope)
        {
            this.SessionScope = scope;
        }


    }
}