

using Agencia.Controllers;

namespace Agencia.Models.interfaces ;
{
    public interface destinoUsuario
{
    Teste<List<DestinoModel>> BuscarDestino();
    
    Teste<DestinoModel> Atualizar(DestinoModel destino);

    Teste<DestinoModel> Adicionar(DestinoModel destino, int id);
    Teste<bool> Apagar(int id);
}


}

