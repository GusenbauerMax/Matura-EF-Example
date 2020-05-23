using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Songs.Shared.Model
{
    public class Song
    {
        [Required]
        public int SongId { get; set; }

        [Required]
        [MaxLength(50)]
        [MinLength(1)]
        public string Name { get; set; }

        [Range(0.0, 30)]
        public double Length { get; set; }

        //Foreign Keys

        [Required]
        public int InterpreterId { get; set; }

        public Interpreter Interpreter { get; set; }
    }
}
