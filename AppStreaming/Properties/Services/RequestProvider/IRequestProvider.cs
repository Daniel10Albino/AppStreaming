using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppStreaming.Properties.Services.RequestProvider
{
    public interface IRequestProvider
    {
        Task PostAsync<Tsend>(string uri, Tsend data, string token = "");
    }
}
