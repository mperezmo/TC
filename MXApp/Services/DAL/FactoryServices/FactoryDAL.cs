﻿using Services.DAL.Contracts;
using Services.DAL.Implementations.SQLServer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.DAL.FactoryServices
{
    /// <summary>
    /// Clase de fábrica para proporcionar instancias de repositorios de datos de acuerdo con el tipo de backend configurado.
    /// </summary>
    internal class FactoryDAL
    {
        private static IUsuarioDAL _UsuarioRepository;
        private static readonly int backendType;
        private static readonly object _lock = new object();
        /// <summary>
        /// Constructor estático que inicializa el tipo de backend desde la configuración de la aplicación.
        /// </summary>
        static FactoryDAL()
        {
            backendType = int.Parse(ConfigurationManager.AppSettings["BackendType"]);
        }
        /// <summary>
        /// Obtiene una instancia del repositorio de usuario según el backend configurado.
        /// Implementa un patrón singleton y garantiza que solo se cree una instancia.
        /// </summary>
        public static IUsuarioDAL UsuarioRepository
        {
            get
            {
                if (_UsuarioRepository == null)
                {
                    lock (_lock)
                    {
                        if (_UsuarioRepository == null)
                        {
                            switch ((BackendType)backendType)
                            {
                                case BackendType.SqlServer:
                                    _UsuarioRepository = new UsuarioRepository();
                                    break;
                                default:
                                    throw new NotSupportedException("Backend no soportado.");
                            }
                        }
                    }
                }
                return _UsuarioRepository;
            }
        }
    }
    /// <summary>
    /// Enumeración que define los tipos de backend compatibles para la fábrica.
    /// </summary>
    internal enum BackendType
    {
        /// <summary>
        /// Backend de base de datos SQL Server.
        /// </summary>
        SqlServer = 1

    }
}
