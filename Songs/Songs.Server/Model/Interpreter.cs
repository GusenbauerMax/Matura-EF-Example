using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Text;

namespace Songs.Server.Model
{
    public class Interpreter
    {
        public int InterpreterId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime Birth { get; set; }

        //Foreign Keys

        public ICollection<Song> Songs { get; set; }
    }
}
