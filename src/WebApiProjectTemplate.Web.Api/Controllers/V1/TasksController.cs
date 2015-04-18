using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiProjectTemplate.Web.Api.Models;
using WebApiProjectTemplate.Web.Common.Routing;

namespace WebApiProjectTemplate.Web.Api.Controllers.V1
{
    //[RoutePrefix("api/{apiVersion:apiVersionConstraint(v1)}/tasks")]
    [ApiVersion1RoutePrefix("tasks")]
    public class TasksController : ApiController
    {
        [Route("", Name = "AddTaskRoute")]
        [HttpPost]
        public Task AddTask(HttpRequestMessage requestMessage, Task newTask)
        {
            return new Task
            {
                Subject = "In v1, newTask.Subject = " + newTask.Subject
            };
        }
    }
}
