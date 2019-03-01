using Senai.Senatur.WebApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Senatur.WebApi.Interfaces
{
    public interface IPacoteRepository
    {
        List<Pacotes> Listar();
        void Cadastrar(Pacotes pacotes);
        void Alterar(Pacotes pacotes);
        Pacotes Buscar(int id);
    }
}
