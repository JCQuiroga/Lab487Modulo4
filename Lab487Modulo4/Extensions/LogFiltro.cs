using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;
using Lab487Modulo4.Utilities;

namespace Lab487Modulo4.Extensions
{
    public class LogFiltro : Attribute, IActionFilter
    {
        public bool AllowMultiple => true;

        public async Task<HttpResponseMessage> ExecuteActionFilterAsync(HttpActionContext actionContext, CancellationToken cancellationToken, Func<Task<HttpResponseMessage>> continuation)
        {
            Utils.WriteLog("Empieza el filtro");

            foreach (var item in actionContext.ActionArguments.Keys) Utils.WriteLog(string.Format("{0}: {1}", item, actionContext.ActionArguments[item]));

            var reponse = await continuation();

            Utils.WriteLog(string.Format("Respuesta : {0}", reponse));
            return reponse;
        }
    }
}