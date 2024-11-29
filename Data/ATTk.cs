using System.Net.Http.Headers;
namespace BlazorASG.Data
{

    public class ATTK
    {
        public readonly static List<Tactic> Tactics = new List<Tactic>();

        public static async Task<OutputModel> getResponse(string pk) {

            try
            {
                var client = new HttpClient();
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri("https://asgmodelai.pythonanywhere.com/api/tecbytac/" + pk),


                };


                using (var response = await client.SendAsync(request))
                {
                    response.EnsureSuccessStatusCode();

                    var Output = (await response.Content.ReadFromJsonAsync<OutputModel>());

                    return Output;
                }
            }
            catch {
                return null;
            }
            return null;
        }

    
        public static async Task Load()
        {

            var tactics = await getResponse("kk");

            if (tactics != null)
            {

                string[] txt = tactics.description.Split("@@");
                for (int i = 1; i < txt.Length; i++)
                {
                    Tactics.Add(new Tactic(txt[i]));
                }


                for (int i = 0; i < Tactics.Count; i++)
                {

                    var tecs = await getResponse(i.ToString());
                    if (tecs != null)
                    {

                        string[] ts = tecs.description.Split("@@");
                        for (int j = 1; j < ts.Length; j++)
                        {
                            Tactics[i].Techniques.Add(new(ts[j]));
                        }
                    }
                }



            }





         }
    }
}