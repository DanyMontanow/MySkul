namespace App.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Alumno",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        ApellidoPaterno = c.String(),
                        ApellidoMaterno = c.String(),
                        NoControl = c.Int(nullable: false),
                        FechaDeNamiento = c.DateTime(nullable: false),
                        Foto = c.String(),
                        Jefe = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Alumnos_Clase",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdAlumno = c.Int(nullable: false),
                        IdClase = c.Int(nullable: false),
                        IdDocente = c.Int(nullable: false),
                        Alumno_Id = c.Int(),
                        Clase_Id = c.Int(),
                        Docente_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Alumno", t => t.Alumno_Id)
                .ForeignKey("dbo.Clase", t => t.Clase_Id)
                .ForeignKey("dbo.Docente", t => t.Docente_Id)
                .Index(t => t.Alumno_Id)
                .Index(t => t.Clase_Id)
                .Index(t => t.Docente_Id);
            
            CreateTable(
                "dbo.Clase",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdMateria = c.Int(nullable: false),
                        Materia_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Materia", t => t.Materia_Id)
                .Index(t => t.Materia_Id);
            
            CreateTable(
                "dbo.Materia",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Docente",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        ApellidoPaterno = c.String(),
                        ApellidoMaterno = c.String(),
                        Foto = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Comentario",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdAlumno = c.Int(nullable: false),
                        IdAviso = c.Int(nullable: false),
                        Alumno_Id = c.Int(),
                        Aviso_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Alumno", t => t.Alumno_Id)
                .ForeignKey("dbo.Aviso", t => t.Aviso_Id)
                .Index(t => t.Alumno_Id)
                .Index(t => t.Aviso_Id);
            
            CreateTable(
                "dbo.Aviso",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Titulo = c.String(),
                        Descripcion = c.String(),
                        FechaHora = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Enterado",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdAlumno = c.Int(nullable: false),
                        IdAviso = c.Int(nullable: false),
                        Alumno_Id = c.Int(),
                        Aviso_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Alumno", t => t.Alumno_Id)
                .ForeignKey("dbo.Aviso", t => t.Aviso_Id)
                .Index(t => t.Alumno_Id)
                .Index(t => t.Aviso_Id);
            
            CreateTable(
                "dbo.Publicacion",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdDocente = c.Int(nullable: false),
                        Titulo = c.String(),
                        Descripcion = c.String(),
                        FechaHora = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Enterado", "Aviso_Id", "dbo.Aviso");
            DropForeignKey("dbo.Enterado", "Alumno_Id", "dbo.Alumno");
            DropForeignKey("dbo.Comentario", "Aviso_Id", "dbo.Aviso");
            DropForeignKey("dbo.Comentario", "Alumno_Id", "dbo.Alumno");
            DropForeignKey("dbo.Alumnos_Clase", "Docente_Id", "dbo.Docente");
            DropForeignKey("dbo.Alumnos_Clase", "Clase_Id", "dbo.Clase");
            DropForeignKey("dbo.Clase", "Materia_Id", "dbo.Materia");
            DropForeignKey("dbo.Alumnos_Clase", "Alumno_Id", "dbo.Alumno");
            DropIndex("dbo.Enterado", new[] { "Aviso_Id" });
            DropIndex("dbo.Enterado", new[] { "Alumno_Id" });
            DropIndex("dbo.Comentario", new[] { "Aviso_Id" });
            DropIndex("dbo.Comentario", new[] { "Alumno_Id" });
            DropIndex("dbo.Clase", new[] { "Materia_Id" });
            DropIndex("dbo.Alumnos_Clase", new[] { "Docente_Id" });
            DropIndex("dbo.Alumnos_Clase", new[] { "Clase_Id" });
            DropIndex("dbo.Alumnos_Clase", new[] { "Alumno_Id" });
            DropTable("dbo.Publicacion");
            DropTable("dbo.Enterado");
            DropTable("dbo.Aviso");
            DropTable("dbo.Comentario");
            DropTable("dbo.Docente");
            DropTable("dbo.Materia");
            DropTable("dbo.Clase");
            DropTable("dbo.Alumnos_Clase");
            DropTable("dbo.Alumno");
        }
    }
}
