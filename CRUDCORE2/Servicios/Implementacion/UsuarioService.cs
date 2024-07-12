using Microsoft.EntityFrameworkCore;
using CRUDCORE2.Models;
using CRUDCORE2.Servicios.Contrato;

namespace CRUDCORE2.Servicios.Implementacion
{
    public class UsuarioService : IUsuarioService
    {
        private readonly DbpruebaContext _dbContext;
        public UsuarioService(DbpruebaContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<Usuario> GetUsuarios(string correo, string clave)
        {
           Usuario usuario_encontrado = await _dbContext.Usuarios.Where(u=>u.Correo==correo && u.Clave==clave)
                .FirstOrDefaultAsync();

            return usuario_encontrado;
        }

        public async Task<Usuario> SaveUsuario(Usuario modelo)
        {
            _dbContext.Usuarios.Add(modelo);
            await _dbContext.SaveChangesAsync();
            return modelo;
        }
    }
}
