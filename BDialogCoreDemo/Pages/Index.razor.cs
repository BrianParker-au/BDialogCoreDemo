using BJSInteroptCore.Services;
using Microsoft.AspNetCore.Components;

namespace BDialogCoreDemo.Pages
{
    public partial class Index : ComponentBase, IDisposable
    {

        private bool isResizing = false;
        private int resizeCount = 0;
        private int resizingCount = 0;

        [Inject]
        private IJSInteropCoreService? JSInteropCoreService { get; set; }

        protected override void OnInitialized()
        {
            JSInteropCoreService!.OnResize += Index_OnResize;
            JSInteropCoreService!.OnResizing += Index_OnResizing;
            base.OnInitialized();
        }       

        private void Index_OnResizing(bool isResizing)
        {
            this.isResizing = isResizing;
            resizingCount++;
            InvokeAsync(StateHasChanged);
        }
        private void Index_OnResize()
        {
            resizeCount++;
            InvokeAsync(StateHasChanged);
        }

        private ElementReference aButton;
        private ElementReference anInput;

        private void ButtonClicked()
        {

        }
        private void Onfocusout()
        {

        }
        private void Onfocusin()
        {

        }
        public void Dispose()
        {
            JSInteropCoreService!.OnResize -= Index_OnResize;
            JSInteropCoreService!.OnResizing -= Index_OnResizing;

        }
    }
}