namespace ServiceStack.Web
{
	public class HelloService : ServiceStack.ServiceInterface.Service
	{
		public object Any (Hello request)
		{
			return new HelloResponse { Result = "Hello, " + request.Name };
		}
	} 
}