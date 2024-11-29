using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using Microsoft.AspNetCore.DataProtection.KeyManagement;

namespace BlazorASG.Data
{

    public class LoginForm
    {

    }
  public class Auth:ComponentBase
    {
        [Inject] ProtectedSessionStorage Pss { set; get; }
        public Task<string> IDSesion   => getSesion();

       
        private async Task<string> getSesion() {

            try
            {
                string? vs = (await Pss.GetAsync<string?>(KEY)).Value;

                if (vs != null)
                {
                    return vs;
                    

                }
                else
                {
                    var id = Guid.NewGuid().ToString();
                    await Pss.SetAsync(KEY, id);

                    return id;

                }
            }
            catch
            {

            }
            return "";
        }
            


private static readonly string KEY = "__IDSesion__";
        public  Auth()
        {

           
        }
    }
}