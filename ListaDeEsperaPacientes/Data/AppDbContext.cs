using ListaDeEsperaPacientes.Models;

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeEsperaPacientes.Data
{
    public class AppDbContext : DbContext
    {
        
        public AppDbContext(): base(@"Data Source=KAUE\SQLEXPRESS;Initial Catalog=ListadeEspera;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
        
        { }

        public DbSet<Paciente> Paciente { get; set; }   
    }
}
