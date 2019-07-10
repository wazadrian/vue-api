using Api.Db;
using Api.Models;
using System.Web.Http;
using System.Web.Http.Results;

namespace Api.Controllers
{
    public class DragonsController : ApiController
    {
        // GET api/<controller>
        public JsonResult<Dragon[]> GetAll()
        {
            return Json(DragonsRepository.GetAll());
        }

        // GET api/<controller>/5
        public JsonResult<Dragon> Get(int id)
        {
            return Json(DragonsRepository.GetById(id));
        }
    }
}