namespace ToDoAndDid
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tasks
    {
        [Key]
        public int id_task { get; set; }

        [Required]
        [StringLength(255)]
        public string titulo_task { get; set; }

        [Column(TypeName = "date")]
        public DateTime data_abertura { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data_encerramento { get; set; }
    }
}
