using TP4.Models;

namespace TP4.Models
{
    public static class Equipos
    {
        public static List<string> ListaEquipos{get; private set;} = new List<string> {"Boca", "River", "Independiente", "Racing", "Estudiantes"};
        public static List<string> ListaMedias{get; private set;} = new List<string> {"Medias_Boca.png", "Medias_River.png", "Medias_Independiente.png", "Medias_Racing.png", "Medias_Estudiantes.png"};
        public static List<string> ListaPantalones{get; private set;} = new List<string> {"Pantalon_Boca.png", "Pantalon_River.png", "Pantalon_Independiente.png", "Pantalon_Racing.png", "Pantalon_Estudiantes.png"};
        public static List<string> ListaRemeras{get; private set;} = new List<string> {"Remera_Boca.png", "Remera_River.png", "Remera_Independiente.png", "Remera_Racing.png", "Remera_Estudiantes.png"};
        public static Dictionary<string, Indumentaria> EquiposIndumentaria{get; private set;} = new Dictionary<string, Indumentaria>();

        public static bool IngresarIndumentaria(string EquipoSeleccionado, Indumentaria item)
        {
            if (EquiposIndumentaria.ContainsKey(EquipoSeleccionado)) return false;
            else
            {
                EquiposIndumentaria.Add(EquipoSeleccionado, item);
                return true;
            }
        }
    }
}