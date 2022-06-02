using Portafolio.Models;

namespace Portafolio.Servicios
{
    public interface IRepositorioProyectos
    {
        List<Proyecto> ObtenerProyectos();
    }
    public class RepositorioProyectos : IRepositorioProyectos
    {
       
        public List<Proyecto> ObtenerProyectos() 
        {
            return new List<Proyecto>()
            {
                new Proyecto
                {
                    Titulo =  "Critika",
                    Descripcion = "Application Android pour faire des commentaire et des notes aux jeux vidéos",
                    Link = "https://git.dti.crosemont.quebec/critika/clientandroid",
                    ImageURL = "/imagenes/logoCritika.png"
                },
                new Proyecto
                {
                    Titulo =  "L'ombre des Purges",
                    Descripcion = "Application Android d'une jeu de choix de rol avec plusieur choix à faire",
                    Link = "https://git.dti.crosemont.quebec/yshmygun/app-dont-vous-etes-le-heros/-/tree/Livrable-TP3",
                    ImageURL = "/imagenes/ombrePurges.png"
                },
                new Proyecto
                {
                    Titulo =  "Casino",
                    Descripcion = "Application Android de simulation d'un casino",
                    Link = "https://git.dti.crosemont.quebec/whernandez/casino/-/tree/TP3",
                    ImageURL = "/imagenes/desCasino.png"
                },
            };
        }

    }
}
