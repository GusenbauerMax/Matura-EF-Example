using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Text;

namespace Songs.Shared.Model
{
    public class Interpreter
    {
        [Required]
        public int InterpreterId { get; set; }

        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(40)]
        public string LastName { get; set; }

        public DateTime Birth { get; set; }

        //Foreign Keys

        public ICollection<Song> Songs { get; set; }
    }
}
