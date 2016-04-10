using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Tamagotchi_prog.Models;
using Tamagotchi_prog.Models.GameActions;

namespace Tamagotchi_prog.Repository
{
    public class MyContextInitializer : DropCreateDatabaseAlways<MyContext>
    {

        protected override void Seed(MyContext context)
        {
            base.Seed(context);

            context.Tamagotchis.Add(new Tamagotchi()
            {
                Name = "Madonna",
                Boredom = 60,
                Health = 50,
                Hunger = 40,
                Sleep = 30,
                IsDead = false,
                LastAccessTime = DateTime.Now,
                LastAction = Actions.None,
                StartActionTime = DateTime.Now,
                StatusEffects = new StatusEffect()
                {
                    Athlete = false,
                    Crazy = false,
                    Munchies = false
                }
            });

            context.Tamagotchis.Add(new Tamagotchi()
            {
                Name = "Rick Astley",
                Boredom = 0,
                Health = 30,
                Hunger = 80,
                Sleep = 80,
                IsDead = false,
                LastAccessTime = DateTime.Now,
                LastAction = Actions.None,
                StartActionTime = DateTime.Now,
                StatusEffects = new StatusEffect()
                {
                    Athlete = false,
                    Crazy = false,
                    Munchies = false
                }
            });

            context.Tamagotchis.Add(new Tamagotchi()
            {
                Name = "Whitney Houston",
                Boredom = 100,
                Health = 0,
                Hunger = 0,
                Sleep = 80,
                IsDead = true,
                LastAccessTime = DateTime.Now,
                LastAction = Actions.None,
                StartActionTime = DateTime.Now,
                StatusEffects = new StatusEffect()
                {
                    Athlete = false,
                    Crazy = false,
                    Munchies = false
                }
            });

            context.RuleSettings.Add(new RuleSettings()
            {
                Boredom = true,
                Hunger = true,
                Fatigue = true,
                Isolation = true
            });

            context.SaveChanges();
        }
    }
}
