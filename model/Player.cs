using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace core_mvc_git_exercise.model
{
    [Table("Player")]
    public class Player
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Team { get; set; }

    }
}
