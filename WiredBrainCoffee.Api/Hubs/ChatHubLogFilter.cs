using Microsoft.AspNetCore.SignalR;
using Newtonsoft.Json;
using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace WiredBrainCoffee.Api.Hubs
{
    public class ChatHubLogFilter : IHubFilter
    {
		public async ValueTask<object> InvokeMethodAsync(HubInvocationContext
		invocationContext, Func<HubInvocationContext, ValueTask<object>> next)
		{
			var messageText = JsonConvert.SerializeObject(invocationContext.HubMethodArguments);
			Debug.WriteLine($"Conversation Log: '{messageText}'");

			Debug.WriteLine("Before hub execution");

			var nextRun = await next(invocationContext);

			Debug.WriteLine("After hub exection");

			return nextRun;
		}
	}
}
