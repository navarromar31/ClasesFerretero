using Ferretero11D.Models;/*Referencia nustro modelo categoria*/
using Microsoft.EntityFrameworkCore;

namespace Ferretero11D.Datos
{
    public class AplicationDbContext : DbContext
    {
        //Metodo constructor para generar la instancia 
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options) : base(options)/*Recibe parametros para poder generar la instancia*/
        {

        }

        //Respectivas tablas de la BD basadas en el modelo 
        public DbSet<Categoria> categorias{get;set;}/*Toma el modelo de referencia para generar la ttabla respectiva en la BD*/





    }
}
