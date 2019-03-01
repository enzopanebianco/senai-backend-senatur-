using Senai.Senatur.WebApi.Domains;
using Senai.Senatur.WebApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Senatur.WebApi.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        public Usuarios Buscar(string email, string senha)
        {
            using (SenatourContext ctx = new SenatourContext())
            {
                return ctx.Usuarios.FirstOrDefault(user => user.Email == email && user.Senha == senha);
            }
        }

        public List<Usuarios> Listar()
        {
            using (SenatourContext ctx = new SenatourContext())
            {
                return ctx.Usuarios.ToList();
            }
        }
    }
}
