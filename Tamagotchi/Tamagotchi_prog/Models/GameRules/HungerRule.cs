﻿using System;
using System.Collections.Generic;

namespace Tamagotchi_prog.Models.GameRules
{
    public class HungerRule : IGameRule
    {
        public Tamagotchi ExecuteRule(Tamagotchi tamagotchi, double timePassed, Dictionary<string, double> multipliers)
        {
            if (tamagotchi.MunchieTime == 0)
            {
                tamagotchi.MunchieTime = (80 - tamagotchi.Boredom) / multipliers["boredom"];
            }

            if (tamagotchi.MunchieTime < timePassed && tamagotchi.MunchieTime > 0)
            {
                tamagotchi.Hunger += ((timePassed - tamagotchi.MunchieTime)*(multipliers["hunger"]*2));
                tamagotchi.Hunger += (tamagotchi.MunchieTime*multipliers["hunger"]);
            }
            else
            {
                if (tamagotchi.StatusEffects.Munchies)
                {
                    tamagotchi.Hunger += (timePassed*(multipliers["hunger"]*2));
                }
                else
                {
                    tamagotchi.Hunger += (timePassed * multipliers["hunger"]);
                }
            }

            if (tamagotchi.Hunger >= 100 && !tamagotchi.StatusEffects.Athlete)
            {
                tamagotchi.IsDead = true;
            }

            tamagotchi.MunchieTime = 0;

            return tamagotchi;
        }
    }
}