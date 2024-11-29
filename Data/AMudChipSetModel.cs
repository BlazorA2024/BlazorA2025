using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using Microsoft.AspNetCore.DataProtection.KeyManagement;
using MudBlazor;

namespace BlazorASG.Data
{
  public class AMudChipSetModel
    {
      public   MudChip[] Selected { set; get; }
        public bool Filter { set; get; } = true;

        public string Title { set; get; } = "";

        public string[] Items { set; get; }
    }
}