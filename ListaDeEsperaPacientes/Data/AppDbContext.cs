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
        
        public AppDbContext(): base(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=WindowsFormsListaEspera;Integrated Security=True")
        
        { }

        public DbSet<Paciente> Paciente { get; set; }   
    }
}
//Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ListadeEspera;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False