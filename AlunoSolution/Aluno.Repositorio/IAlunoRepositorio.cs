using Aluno.Dominio;

namespace Aluno.Repositorio
{
    public interface IAlunoRepositorio
    {
        void Adicionar();
        List<int> Listar();
    }
}