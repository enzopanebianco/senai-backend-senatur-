using Senai.Senatur.WebApi.Domains;
using Senai.Senatur.WebApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Microsoft.AspNetCore.Hosting.Internal.HostingApplication;

namespace Senai.Senatur.WebApi.Repositories
{
    public class PacoteRepository : IPacoteRepository
    {
        public void Alterar(Pacotes pacotes)
        {
            using (SenatourContext ctx = new SenatourContext())
            {
                ctx.Pacotes.Update(pacotes);
                ctx.SaveChanges();
            }
        }

        public Pacotes Buscar(int id)
        {
            using (SenatourContext ctx = new SenatourContext())
            {
                return ctx.Pacotes.Find(id);
            }
        }

        public void Cadastrar(Pacotes pacotes)
        {
            using (SenatourContext ctx = new SenatourContext())
            {
                ctx.Pacotes.Add(pacotes);
                ctx.SaveChanges();
            }
        }

        public List<Pacotes> Listar()
        {
            using (SenatourContext ctx = new SenatourContext())
            {
                return ctx.Pacotes.ToList();
            }
        }
    }
}
