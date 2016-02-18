using Nancy;


namespace Polymer.Spike
{
	public class HomeModule : NancyModule
	{
		public HomeModule()
		{
			Get["/"] = _ => View["index"];
		}
	}
}