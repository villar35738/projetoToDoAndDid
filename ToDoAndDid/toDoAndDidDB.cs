namespace ToDoAndDid
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class toDoAndDidDB : DbContext
    {
        public toDoAndDidDB()
            : base("name=toDoAndDidDB")
        {
        }

        public virtual DbSet<tasks> tasks { get; set; }
        public virtual DbSet<tela_login> tela_login { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tasks>()
                .Property(e => e.titulo_task)
                .IsUnicode(false);

            modelBuilder.Entity<tela_login>()
                .Property(e => e.nome_user)
                .IsUnicode(false);

            modelBuilder.Entity<tela_login>()
                .Property(e => e.senha)
                .IsUnicode(false);
        }
    }
}
