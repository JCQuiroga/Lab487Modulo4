using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Lab487Modulo4.Utilities;

namespace Lab487Modulo4.Extensions
{
    public class LogHandler : DelegatingHandler
    {
        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            Utils.WriteLog("Peticion -> " + request.ToString());
            var reponse = await base.SendAsync(request, cancellationToken);

            Utils.WriteLog("Respuesta -> " + reponse.ToString());

            return reponse;
        }
    }
}