using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Songs.Server.Model
{
    public class Song
    {
        public int SongId { get; set; }

        public string Name { get; set; }

        public double Length { get; set; }

        //Foreign Keys

        public int InterpreterId { get; set; }

        public Interpreter Interpreter { get; set; }
    }
}
