using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Senai.Senatur.WebApi.Domains;
using Senai.Senatur.WebApi.Interfaces;
using Senai.Senatur.WebApi.Repositories;

namespace Senai.Senatur.WebApi.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class PacotesController : ControllerBase
    {
        private IPacoteRepository PacoteRepository;

        public PacotesController()
        {
            PacoteRepository = new PacoteRepository();
        }

       
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(PacoteRepository.Listar());
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }
        [Authorize(Roles="ADMINISTRADOR")]
        [HttpPost]
        public IActionResult Post(Pacotes pacotes)
        {
            try
            {
                PacoteRepository.Cadastrar(pacotes);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }
        [HttpPut]
        public IActionResult Put(Pacotes pacotes)
        {
            try
            {
                PacoteRepository.Alterar(pacotes);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id )
        {
            try
            {
                Pacotes pacotes = PacoteRepository.Buscar(id);
                if (pacotes==null)
                {
                    return NotFound();
                }

                return Ok(pacotes);
            }
            catch (Exception ex)
            {

                return BadRequest();
            }
        }
    }
}