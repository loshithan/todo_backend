using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using todo_backend.DependencyInjections;
using todo_backend.Models;

namespace todo_backend.Controllers
{
    public class TodoController : ApiController
    {
        IBusinessLayer _businessLayer;
        HttpResponseMessage _response;

        public TodoController(IBusinessLayer businessLayer, HttpResponseMessage response)
        {
            _businessLayer = businessLayer;
            _response = response;
        }
        public TodoController()
        {

        }
        // GET api/values
        public IHttpActionResult Get()
        {

            try
            {
                return Ok(_businessLayer.GetAllTodo());
            }
            catch (Exception ex)
            {
                 _response = Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);

                return ResponseMessage(_response);
            }
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public IHttpActionResult Post([FromBody] Todo value)
        {
            try
            {
                _businessLayer.AddTodo(value);
                return Ok();
            }
            catch (Exception ex)
            {
                _response = Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);

                return ResponseMessage(_response);
            }

        }

        // PUT api/values/5
        public IHttpActionResult Put(int id, [FromBody] Todo value)
        {
            try
            {
                _businessLayer.EditTodo(id, value);
                return Ok();
            }
            catch (Exception ex)
            {
                _response = Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);

                return ResponseMessage(_response);
            }
        }

        // DELETE api/values/5
        public IHttpActionResult Delete(int id)
        {
            try
            {
                _businessLayer?.RemoveTodo(id);
                return Ok();
            }
            catch (Exception ex)
            {
                _response = Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);

                return ResponseMessage(_response);
            }
        }
    }
}
