﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Domain
{///////////////////////////////////////////////////////////
    //  Component.cs
    //  Implementation of the Class Component
    //  Generated by Enterprise Architect
    //  Created on:      02-may.-2024 21:18:24
    //  Original author: gaston
    ///////////////////////////////////////////////////////////

    /// <summary>
    /// Clase abstracta que representa un acceso en el sistema.
    /// </summary>
    public abstract class Acceso
    {
        /// <summary>
        /// Identificador único del acceso.
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// Nombre del acceso.
        /// </summary>
        public string Nombre { get; set; }
        /// <summary>
        /// Constructor por defecto de la clase Acceso.
        /// </summary>
        public Acceso()
        {

        }


        /// <summary>
        /// Agrega un componente de acceso al acceso actual.
        /// </summary>
        /// <param name="component">El componente de acceso a agregar.</param>
        public abstract void Add(Acceso component);

        /// <summary>
        /// Elimina un componente de acceso del acceso actual.
        /// </summary>
        /// <param name="component">El componente de acceso a eliminar.</param>
        public abstract void Remove(Acceso component);
        /// <summary>
        /// Obtiene el número de componentes de acceso contenidos en el acceso actual.
        /// </summary>
        /// <returns>Número de componentes de acceso.</returns>
        public abstract int GetCount();

    }
}
