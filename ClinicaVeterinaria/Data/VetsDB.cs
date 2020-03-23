using ClinicaVeterinaria.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicaVeterinaria.Data
{
    public class VetsDB : DbContext
    {
        public VetsDB(DbContextOptions<VetsDB> options) : base(options) { }
        //adicionar tabelas
        public DbSet<Animais> Animais { get; set; }
        public DbSet<Donos> Donos { get; set; }
        public DbSet<Veterinarios> Veterinarios { get; set; }
        public DbSet<Consultas> Consultas { get; set; }

    }
}
