using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace CRUDCORE.Datos
{
    public class Conexion
    {
        private string cadenaSQL = string.Empty;

        public Conexion() {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();
            cadenaSQL = builder.GetSection("ConnectionStrings:CadenaSQL").Value;
        }

        public string getCadenaSQL() {
            return cadenaSQL;
        }
    }
}
