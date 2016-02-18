using Nancy;
using Nancy.Conventions;


namespace Polymer.Spike
{
	public class Bootstrapper : DefaultNancyBootstrapper
	{
		protected override void ConfigureConventions(NancyConventions nancyConventions)
		{
			base.ConfigureConventions(nancyConventions);
			nancyConventions.StaticContentsConventions.Add(StaticContentConventionBuilder.AddDirectory("bower", @"bower_components"));
		}
	}
}