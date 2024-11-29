﻿using Services.Context;
using Services.DAL.FactoryServices;
using Services.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Logic
{
    /// <summary>
    /// Clase de lógica para el manejo de registros (logs) utilizando diferentes estrategias de logging.
    /// </summary>
    public static class LoggerLogic
    {
        private static LoggerContext _loggerContext = new LoggerContext();

        /// <summary>
        /// Constructor estático que inicializa la estrategia de logging por defecto.
        /// </summary>
        static LoggerLogic()
        {
            _loggerContext.SetLoggerStrategy(LoggerFactory.CreateLogger());
        }
        /// <summary>
        /// Escribe un registro (log) en el sistema utilizando la estrategia configurada.
        /// En caso de error crítico, notifica al administrador.
        /// </summary>
        /// <param name="log">Objeto <see cref="Log"/> que contiene la información del registro.</param>
        /// <param name="ex">Excepción opcional asociada con el log.</param>
        public static void WriteLog(Log log, Exception ex = null)
        {
            // Si es un error crítico, voy a tratar de implementar notificacion por correo
            if (log.TraceLevel == System.Diagnostics.TraceLevel.Error)
            {
                // Por ejemplo, enviar un correo al equipo de soporte en caso de error crítico
                NotifyAdmin(log, ex);
            }

            // Escribir el log utilizando la estrategia configurada
            _loggerContext.WriteLog(log, ex);
        }
        /// <summary>
        /// Notifica al equipo de soporte en caso de error crítico, como enviando un correo electrónico.
        /// </summary>
        /// <param name="log">Objeto <see cref="Log"/> que contiene la información del registro.</param>
        /// <param name="ex">Excepción opcional asociada con el log.</param>
        private static void NotifyAdmin(Log log, Exception ex)
        {
            // VOY A TRARTAR DE IMPLEMENTAR UNA NOTIFICACIÓN POR CORREO ELECTRÓNICO
            // 



        }
    }
}
