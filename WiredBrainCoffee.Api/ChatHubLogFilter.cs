using Microsoft.AspNetCore.SignalR;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace WiredBrainCoffee.Api
{
    public class ChatHubLogFilter : IHubFilter
    {
        public async ValueTask<object> InvokeMethodAsync(
        HubInvocationContext invocationContext, Func<HubInvocationContext, ValueTask<object>> next)
        {
            Debug.WriteLine($"Conversation Log: '{JsonConvert.SerializeObject(invocationContext.HubMethodArguments)}'");

            Debug.WriteLine("Before hub execution");
                
            var nextRun = await next(invocationContext);

            Debug.WriteLine("After hub exection");

            return nextRun;
        }
    }
}
