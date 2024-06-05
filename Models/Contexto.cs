﻿using Microsoft.EntityFrameworkCore;

namespace FindForYou.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {

        }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Objeto> Objeto { get; set; }
        public DbSet<Observacoes> Observacoes { get; set; }
    }
}
