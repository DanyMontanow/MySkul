﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Entities;

namespace App.DAL
{
    public class EnteradoRepo
    {
        private AppDBContext _contexto;

        public EnteradoRepo()
        {
            _contexto = new AppDBContext();
        }
        /// <summary>
        /// Agregar Alumno
        /// </summary>
        /// <param name="alumno"></param>
        public void Agregar(Enterado enterado)
        {
            _contexto.Enterado.Add(enterado);
            _contexto.SaveChanges();
        }
        /// <summary>
        /// Borrar alumno
        /// </summary>
        /// <param name="alumno"></param>
        public void Borrar(Enterado enterado)
        {
            _contexto.Enterado.Remove(enterado);
            _contexto.SaveChanges();
        }
        /// <summary>
        /// muestra registros deseados
        /// </summary>
        /// <returns></returns>
        public List<Enterado> TraerTodo()
        {
            return _contexto.Enterado.OrderBy(x => x.Id).ToList();
        }
        public Enterado TraerId(int Id)
        {
            return _contexto.Enterado.FirstOrDefault(x => x.Id == Id);
        }

    }
}
