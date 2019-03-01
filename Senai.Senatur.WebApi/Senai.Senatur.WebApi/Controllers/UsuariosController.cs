using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Senai.Senatur.WebApi.Interfaces;
using Senai.Senatur.WebApi.Repositories;

namespace Senai.Senatur.WebApi.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private IUsuarioRepository UsuarioRepository;

        public UsuariosController()
        {
            UsuarioRepository = new UsuarioRepository(); 
        }
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(UsuarioRepository.Listar());
            }
            catch (Exception ex)
            {

                return BadRequest();
            }
        }
    }
}