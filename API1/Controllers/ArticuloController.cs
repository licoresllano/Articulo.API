using BLL;
using System;
using System.Net;
using System.Web.Http;


namespace APILicores.Controllers
{
    [RoutePrefix("API/Licores")]
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class ArticuloController : ApiController
    {
        // GET: Articulo

        [HttpGet]
        [Route("ObtenerArticulos")]
        public IHttpActionResult ObtenerArticulos() 
        {
            try
            {
                ArticuloBLL Articulo = new ArticuloBLL();
                return Content(HttpStatusCode.OK, Articulo.obtenerArticulos());
            }
            catch (Exception)
            {

                throw;
            }
        }



    }

    internal class EnableCorsAttribute : Attribute
    {
        private string origins;
        private string headers;
        private string methods;

        public EnableCorsAttribute(string origins, string headers, string methods)
        {
            this.origins = origins;
            this.headers = headers;
            this.methods = methods;
        }
    }
}