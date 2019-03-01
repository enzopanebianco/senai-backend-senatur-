using Senai.Senatur.WebApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Senatur.WebApi.Interfaces
{
    public interface IUsuarioRepository
    {
        List<Usuarios> Listar();
        Usuarios Buscar(string email, string senha);
    }
}
