using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Entidades
{
    /*AlumnoEgresado (promedio: float; promocion: Short) - ToString():string (polimorfismo; reutilizar código) 
    */
    public class AlumnoEgresado : Alumno, ISerializar, IDeserializar
    {
        private float promedio;
        private short promocion;

        public float Promedio { get => promedio; set => promedio = value; }
        public short Promocion { get => promocion; set => promocion = value; }

        public AlumnoEgresado() : base(new Persona("pepe", "pepe", EIdioma.Español, 2), 0, ENivelDeEstudio.Universitaria)
        { }

        public AlumnoEgresado(Alumno a, float promedio, short promicion) : this()
        {
            this.promedio = promedio;
            this.promocion = promicion;
        }
        public override string ToString()
        {
            return base.ToString() + $"promedio:{this.promedio}-promocion:{this.promocion}";
        }

        public bool Xml(string path)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(AlumnoEgresado));

                using (FileStream fileStream = new FileStream(path, FileMode.Create))
                {
                    serializer.Serialize(fileStream, this);
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al serializar en XML: " + ex.Message);
                return false;
            }
        }

        bool IDeserializar.Xml(string path, out AlumnoEgresado alumnoEgresado)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(AlumnoEgresado));

                using (FileStream fileStream = new FileStream(path, FileMode.Open))
                {
                    alumnoEgresado = (AlumnoEgresado)serializer.Deserialize(fileStream);
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al deserializar en XML: " + ex.Message);
                alumnoEgresado = null;
                return false;
            }
        }
    }

}
