using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ServicoWebApi.Models;

namespace ServicoWebApi.Controllers
{
    public class ClienteController : ApiController
    {
        Cliente[] clientes = new Cliente[]
        {
            new Cliente() { Id = 1, Nome = "Teste1", Email = "teste1@gmail.com" },
            new Cliente() { Id = 2, Nome = "Teste2", Email = "teste2@gmail.com" },
            new Cliente() { Id = 3, Nome = "Teste3", Email = "teste3@gmail.com" }
        };

        public IEnumerable<Cliente> GetClientes()
        {
            return clientes;
        }

        public IHttpActionResult GetCliente(int id)
        {
            var cli = clientes.FirstOrDefault((c) => c.Id == id);
            return Ok(cli);
        }
    }
}
