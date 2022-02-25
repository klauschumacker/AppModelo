using DevT800.UI.Site.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevT800.UI.Site.Repository
{
    public interface IContatoRepository
    {
        ContatoModel ListarPorId(int id);

        List<ContatoModel> BuscarTodos();

        ContatoModel Adicionar(ContatoModel contato);

        ContatoModel Atualizar(ContatoModel contato);

        bool Excluir(int id);
    }
}