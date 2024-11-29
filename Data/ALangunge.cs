namespace BlazorASG.Data
{
    // PricingPlan.cs
    public class PricingPla
    {
        public string Title { get; set; }
        public string Price { get; set; }
        public string PricePeriod { get; set; }
        public string Users { get; set; }
        public string Storage { get; set; }
        public string Support { get; set; }
        public string Access { get; set; }
        public string ButtonText { get; set; }
        public string ButtonStyle { get; set; }
        public bool IsFeatured { get; set; }
    }
    public class PricingPlan
        {
            public string Title { get; set; }
            public string Price { get; set; }
            public string PricePeriod { get; set; }
            public string Users { get; set; }
            public string Storage { get; set; }
            public string Support { get; set; }
            public string Access { get; set; }
            public string ButtonText { get; set; }
            public string ButtonStyle { get; set; }
            public bool IsFeatured { get; set; }
        }
    

    public class ALangunge
    {
        public   string[] EN { set; get; }
        public   string[] AR { set; get; }
       
    }

    public class LGD
    {
        public static Dictionary<string, Dictionary<TypeChat, Dictionary<TypeLabeLLG, string>>> Values=new Dictionary<string, Dictionary<TypeChat, Dictionary<TypeLabeLLG, string>>>()
        {
            
           

        };

        public LGD()
        {

           
        }


        public static void Run()
        {
            Dictionary<TypeChat, Dictionary<TypeLabeLLG, string>> En = new Dictionary<TypeChat, Dictionary<TypeLabeLLG, string>>();

            

            Values.Add("en",En);
        }

        public static void Genrallp(Dictionary<TypeChat, Dictionary<TypeLabeLLG, string>> en)
        {

        }
    }
    public  enum TypeLabeLLG
    {

    }
   
}
