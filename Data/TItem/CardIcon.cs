using BlazorASG.Data.TItem;
using Microsoft.AspNetCore.Components;

namespace BlazorASG.Data.TItem
{
   public  class CardIcon
    {
        public string? Src { set; get; }

        public string? ClassContanier { set; get; } = "list-inline-item";

        public string? ClassIcon { set; get; } = "icon-xl btn-transition bg-white border border-white border-opacity-10 d-flex justify-content-center align-items-center rounded-2";


        public string? ClassImg { set; get; } = "h-40px";
    }



    public  class CardIconServics : CardIcon
    {
        public new string? ClassContanier { set; get; } = "list-inline-item me-0";
    }



    public  class CardIconItems
    {
        public List<CardIconServics>? CardIconServics { set; get; }

        public static readonly string INEERCLASS = "list-inline d-flex justify-content-center flex-wrap gap-4 my-5 my-lg-6";
       
        public string? ClassItems { set; get; } = "";

     
        public bool IsUseStyleIneerItems { set; get; } = true;

        public string Name { set; get; } = "Name";
        public bool IsName { set; get; } = true;



        public string ClassContainer { set; get; } = "inner-container text-center mt-8";

        public string NameFoter { set; get; } = " Uncover our AI capabilities";
        public bool INameFoter { set; get; } = true;





    }



    public class CardTextAndIcon
    {

        public static readonly string INEERCLASS = "hover-item d-flex align-items-center border-bottom position-relative py-4";
        public bool IsUseStyleIneerItems { set; get; } = true;

        public string? ClassItems { set; get; } = "";
        public CardIcon? Icon { set; get; }
        public string? Name { set; get; } = "AI consulting and strategy";
        public bool IsName { set; get; } = true;
        public string? Description { set; get; } = "";
        public bool IsDescription { set; get; } = true;
		public string ButtonLink { get; set; } = "";
		public bool IsButtonLink { get; set; } = true;

	}

   public class CaerdSevicisIcon
{

    public static readonly string INEERCLASS = "list-inline d-flex justify-content-center flex-wrap gap-2 gap-md-4 mb-0 mt-4 mt-xl-5";
    public bool IsUseStyleIneerItems { set; get; } = true;

    public string? ClassItems { set; get; } = "";
    public CardIcon? Icon { set; get; }
    public string? Name { set; get; } = "";
    public bool IsName { set; get; } = true;
    public string? Description { set; get; } = "";
    public bool IsDescription { set; get; } = true;
	public string ButtonLink { get; set; } = "";
	public bool IsButtonLink { get; set; } = true;

	}

	public class PricingPlanModel
    {
        public static readonly string INEERCLASS = "";
        public bool IsUseStyleIneerItems { get; set; } = true;
        public string ClassItems { get; set; } = string.Empty;
        public List<PricingCardModel>? CardIconServicsModel { get; set; }
    }

    public class PricingCardModel 
    {
        public string Choose { get; set; } = "";
        public string Title { get; set; } = "";
        public string PriceDisplay { get; set; } = "";
        public string ButtonText { get; set; } = "";
        public string ButtonLink { get; set; } = "";
        public string Details { get; set; } = "";
        public string CardClass { get; set; } = "";
        public string ButtonClass { get; set; } = "";
        public string? CardTheme { get; set; } = null;
    }
    public class Testimonial
    {
        public string Name { get; set; }
        public string Role { get; set; }
        public string Message { get; set; }
        public string ImageUrl { get; set; }
    }
}
