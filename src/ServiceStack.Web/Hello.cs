using System;
using ServiceStack.ServiceHost;

namespace ServiceStack.Web
{
	[Route("/hello")]
	[Route("/hello/{Name}")]
	public class Hello
	{
		public string Name { get; set; }
	}
}