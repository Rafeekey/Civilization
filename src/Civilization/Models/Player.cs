﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Civilization.Models
{
    [Table("Players")]
    public class Player
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int AvailableBase { get; set; }
        public int AvailableMoves { get; set; }
        public int Wood { get; set; }
        public int Metal { get; set; }
        public int Stone { get; set; }
        public int Gold { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<PlayerGamePiece> PlayerGamePieces { get; set; }

        public Player()
        {
            AvailableBase = 1;
            AvailableMoves = 5;
            Wood = 10;
            Stone = 2;
            Metal = 0;
            Gold = 0;
        }
    }
}
