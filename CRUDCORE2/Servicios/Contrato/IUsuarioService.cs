using Microsoft.EntityFrameworkCore;
using CRUDCORE2.Models;

namespace CRUDCORE2.Servicios.Contrato
{
    public interface IUsuarioService
    {
        Task<Usuario> GetUsuarios(string correo, string clave);
        Task<Usuario> SaveUsuario(Usuario modelo);
    }
}
