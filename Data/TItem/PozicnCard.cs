using Microsoft.AspNetCore.Components;

namespace BlazorASG.Data.New
{
	public class CardIconm
	{
		public string? Src { set; get; }

		public string? ClassContanier { set; get; } = "wk2  ";

		public string? ClassIcon { set; get; } = "";

		public string? ClassImg { set; get; } = "wave-image";
	}



	public class CardIconServicsm : CardIconm
	{
		public new string? ClassContanier { set; get; } = "list-inline-item me-0";
	}



	public class CardIconItemsm
	{
		public List<CardIconServicsm>? CardIconServics { set; get; }

		public static readonly string INEERCLASS = "list-inline d-flex justify-content-center flex-wrap gap-4 my-5 my-lg-6";

		public string? ClassItems { set; get; } = "wk1";


		public bool IsUseStyleIneerItems { set; get; } = true;

		public string Name { set; get; } = "Lahja";
		public bool IsName { set; get; } = true;



		public string ClassContainer { set; get; } = "animated-text divtextheaderH";

		public string NameFoter { set; get; } = " Get  started";
		public bool INameFoter { set; get; } = true;





	}



	public class CardTextAndIconm
	{

		public static readonly string INEERCLASS = "hover-item d-flex align-items-center border-bottom position-relative py-4";
		public bool IsUseStyleIneerItems { set; get; } = true;
		public string? ClassItems { set; get; } = "";
		public CardIconm? Icon { set; get; }
		public string? Name { set; get; } = "";
		public bool IsName { set; get; }

	}
}
