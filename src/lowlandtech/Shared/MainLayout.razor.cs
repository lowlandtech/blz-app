using Blazor.AdminLte;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.JSInterop;
using System;

namespace LowlandTech.Shared
{
    public partial class MainLayout
    {
        [Inject] public NavigationManager NavigationManager { get; set; }
        [Inject] public IJSRuntime Js { get; set; }
        [Inject] public ILayoutManager LayoutManager { get; set; }
        [Inject] public NavBarLeftInjectableMenu NavBarLeftInjectableMenu { get; set; }

        protected override void OnParametersSet()
        {
            // content = null; for refreshing custom menu injectables per page.
            // no override; reset default to show parent menu content items.
            NavBarLeftInjectableMenu.SetContent(null, false);
        }

        private readonly DateTime _dt = DateTime.Now;

        private void SeeAllMessages(Tuple<IDropdownFooter, MouseEventArgs> args)
        {
            NavigationManager.NavigateTo("messages/see-all-messages");
        }

        private void HandleContent(Tuple<INavBarMenuItem, MouseEventArgs> args)
        {
            NavigationManager.NavigateTo("messages/see-all-messages");
        }

        private void SeeAllNotifications(Tuple<IDropdownFooter, MouseEventArgs> args)
        {
            NavigationManager.NavigateTo("messages/see-all-notifications");
        }

        protected override void OnAfterRender(bool isFirstRender)
        {
            LayoutManager.IsFooterFixed = true;
            LayoutManager.IsNavBarFixed = true;
            LayoutManager.IsSideBarFixed = true;
            base.OnAfterRender(isFirstRender);
        }
    }
}
