using lguamanS5.modelos;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace lguamanS5.Repositories
{
    public class personaRepositorie
    {
        string _dbpath;
        private SQLiteConnection _connection;
        public string status { get; set; }
        private void init() {
            if(_connection is not null)
                return;
             _connection = new(_dbpath);
             _connection.CreateTable<persona>();
        }

        public personaRepositorie(string dbpath)
        {
            _dbpath = dbpath;
        }

        public void AddPerson(string name)
        {
            int result = 0;
            try
            {
                init();

                if (string.IsNullOrEmpty(name))
                    throw new Exception("El nombre es requerido");

                persona person = new() { Name = name };

                result = _connection.Insert(person);
                status = string.Format("Dato ingresado", result, name);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<persona> GetPersonList(){
            try
            {
                init();
                return _connection.Table<persona>().ToList();
            }
            catch (Exception ex)
            {

                status = string.Format("error", ex.Message);
            }

            return new List<persona>();
        
        }
    }

}
