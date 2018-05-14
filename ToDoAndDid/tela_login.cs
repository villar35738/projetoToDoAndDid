namespace ToDoAndDid
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tela_login
    {
        [Key]
        public int id_user { get; set; }

        [Required]
        [StringLength(255)]
        public string nome_user { get; set; }

        [Required]
        [StringLength(255)]
        public string senha { get; set; }
    }
}
