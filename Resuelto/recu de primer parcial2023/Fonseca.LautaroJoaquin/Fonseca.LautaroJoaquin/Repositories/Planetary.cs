using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Entities.Repositories
{
    public class Planetary
    {
        private int capacity;
        private List<AstralBody> astralBodiesList;

        public Planetary(int capacity)
        {
            this.capacity = capacity;
            this.astralBodiesList = this.Deserialize();
        }

        public Planetary() : this(100)
        {

        }

        protected string PlanetFilepath => Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
            "Planets.json"
        );

        protected string StarFilepath => Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
            "Stars.json"
        );

        protected bool DoesFileExist() => File.Exists(PlanetFilepath) && new FileInfo(PlanetFilepath).Length != 0;

        public string GetAll()
        {
            StringBuilder sb = new();
            foreach (AstralBody astralBody in this.astralBodiesList)
            {
                sb.AppendLine(astralBody.ToString());
            }
            return sb.ToString();
        }

        public List<AstralBody> GetElements()
        {
            return this.astralBodiesList;
        }

        public int GetNextId()
        {
            int maxId = this.astralBodiesList.Count > 0 ? this.astralBodiesList.Max(it => it.Id): 0;
            return maxId > 0 ? maxId + 1 : 1;
        }

        public List<AstralBody> Deserialize()
        {
            List<AstralBody> list = new();
            try
            {
                if (File.Exists(PlanetFilepath))
                {
                    using TextReader planetReader = new StreamReader(PlanetFilepath);
                    list.AddRange(JsonSerializer.Deserialize<List<Planet>>(planetReader.ReadToEnd()) ?? new List<Planet>());
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine($"Ha ocurrido un error al Cargar elementos: {exception.Message}\n{exception.StackTrace}");
                throw;
            }

            try
            {
                if (File.Exists(StarFilepath))
                {
                    using TextReader starReader = new StreamReader(StarFilepath);
                    list.AddRange(JsonSerializer.Deserialize<List<Star>>(starReader.ReadToEnd()) ?? new List<Star>());
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine($"Ha ocurrido un error al Cargar elementos: {exception.Message}\n{exception.StackTrace}");
                throw;
            }
            return list;
        }

        public bool Flush()
        {
            try
            {
                using TextWriter writer = new StreamWriter(PlanetFilepath);

                writer.Write(JsonSerializer.Serialize(this.astralBodiesList.FindAll(it => it is Planet)));
            }
            catch (Exception exception)
            {
                Console.WriteLine($"Ha ocurrido un error al Guardar elementos: {exception.Message}\n{exception.StackTrace}");
                return false;
            }
            try
            {
                using TextWriter writer = new StreamWriter(StarFilepath);

                writer.Write(JsonSerializer.Serialize(this.astralBodiesList.FindAll(it => it is Star)));
            }
            catch (Exception exception)
            {
                Console.WriteLine($"Ha ocurrido un error al Guardar elementos: {exception.Message}\n{exception.StackTrace}");
                return false;
            }
            return true;
        }

        public bool Save(AstralBody entity)
        {
            if (this.astralBodiesList.Count + 1 > capacity)
            {
                return false;
            }

            if (entity.Id == 0)
            {
                entity.Id = GetNextId();
            }

            this.astralBodiesList.Add(entity);

            return Flush();
        }

        public virtual bool Delete(List<AstralBody> collection)
        {
            bool deleted = astralBodiesList.RemoveAll(collection.Contains) > 0;

            if (deleted)
            {
                Flush();
            }

            return deleted;
        }

        public virtual bool Delete(AstralBody entity)
        {
            bool deleted = astralBodiesList.Remove(entity);

            if (deleted)
            {
                Flush();
            }

            return deleted;
        }
    }
}
