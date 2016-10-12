using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using App.Entities;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace App.DAL
{
    public class AppDBContext : DbContext 
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }
        public AppDBContext() : base("AppDBContext")
        {
            this.Configuration.ValidateOnSaveEnabled = false;
        }
        static AppDBContext()
        {
           DbConfiguration.SetConfiguration(new MySql.Data.Entity.MySqlEFConfiguration());
        }

       public DbSet<Alumno> Alumno { get; set; }
       public DbSet<Alumnos_Clase> Alumno_Clase { get; set; }
       public DbSet<Aviso> Aviso { get; set; }
       public DbSet<Clase> Clase { get; set; }
       public DbSet<Comentario> Comentario { get; set; }
       public DbSet<Docente> Docente { get; set; }
       public DbSet<Enterado> Enterado { get; set; }
       public DbSet<Materia> Materia { get; set; }
       public DbSet<Publicacion> Publicacion { get; set; }
    }
}
