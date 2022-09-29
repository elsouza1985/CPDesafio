using CPDesafio.Modelos.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;

using System.Text;

namespace CPDesafio.Repositorios.Contexto
{
    public class CPDesafioContexto : DbContext
    {
        private readonly string _connectionString;
        
        public CPDesafioContexto(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("conn1");
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .EnableSensitiveDataLogging()
                .UseSqlServer(_connectionString);
        }

        public DbSet<Pessoa> pessoas{get;set;}
        
        public DbSet<Tecnologia> tecnologia{get;set;}

        public DbSet<PessoaTecnologia> pessoaTecnologias{get;set;}


    }
}
