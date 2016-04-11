using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Tamagotchi_prog.Models.GameActions;

namespace Tamagotchi_prog.Models
{
    [Table("Tamagotchi")]
    public class Tamagotchi
    {
        [Key]
        public String Name { get; set; }

        public DateTime LastAccessTime { get; set; }
        //TimeRemaining to achieve munchies
        public double MunchieTime { get; set; }
        //ActionCooldown time in minutes
        public double CooldownTime { get; set; }

        public DateTime StartActionTime { get; set; }

        public Actions LastAction { get; set; }

        public double Hunger { get; set; }

        public double Sleep { get; set; }

        public double Boredom { get; set; }

        public double Health { get; set; }

        public String ImageURL { get; set; }

        public int StatusEffectId { get; set; }

        public virtual StatusEffect StatusEffects { get; set; }

        public Boolean IsDead { get; set; }
    }
}