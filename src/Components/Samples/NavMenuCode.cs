using Microsoft.AspNetCore.Components;

namespace Gwergilius.Calculator.Components.Samples
{
    public class NavMenuCode : ComponentBase
    {
        private bool collapseNavMenu = true;

        [Parameter]
        public string Brand { get; set; }

        protected string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

        protected void ToggleNavMenu()
        {
            collapseNavMenu = !collapseNavMenu;
        }
    }
}