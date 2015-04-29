using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Chat
{
    /// <summary>
    /// Descripción breve de ServicioChat
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class ServicioChat : System.Web.Services.WebService
    {

        [WebMethod]
        public string chatiar(string Mensaje)
        {
            switch (Mensaje)
            {
                case "Hola bb":  return"ke onda";
                case "De donde eres": return "Guadalajara";
                case "Como estas": return "bien aki andamos";
                case "Como te llamas": return "felix";
                case "Tienes cel": return "solo uso telefono publico";
                case "Tienes web cam": return "no mija muy apenas tengo pal civer";
                case "Quieres mostrarme": return "pos 2 trenzas y un chongo";
                case "Que buscas realmente": return "solo busco mi ubicacion en gps";
                case "Osea ke te gusta experimentar cosas nuevas": return "solo tomar lloga y seguir tus pasos";
                case "Que tal si empezamos a subir la temperatura": return "pos no soy el meterologo para calcular tu temperatura";
                case "Hasta donde quieres llegar": return "pos no se tuu jaja";
                case "Cuantos años tienes": return "pos los suficientes paa andar aki";
                case "Que te gusta hacer": return "pos lo ke sea es bueno jaja";
                case "Y lo...": return "paso un borrego Lol lml";
                case "Ahorita llego a tu casa": return "nel porque esta ocupada mi casa";
                default: return "Favor de Contestar";
                    
            }
        }
    }
}
