﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tamagotchi_prog.Models.GameActions
{
    public class Eat : GameAction
    {
        public Eat()
        {
            this.Action = Actions.Eat;
        }

        public override int ExecuteGameAction(Tamagotchi tamagotchi, Dictionary<String, double> actionTimeSpan)
        {
            if (CheckDeath(tamagotchi))
            {
                tamagotchi.IsDead = true;
                return 0;
            }

            if (tamagotchi.CooldownTime <= 0)
            {
                tamagotchi.CooldownTime = actionTimeSpan["eat"];
                tamagotchi.StartActionTime = DateTime.Now;
                tamagotchi.LastAction = Actions.Eat;
                return 1;
            }

            return 0;
        }

        public override int StopAction(Tamagotchi tamagotchi, Dictionary<string, double> actionMultipliers, double passedTime)
        {
            if (tamagotchi.CooldownTime <= passedTime)
            {
                tamagotchi.Hunger = (tamagotchi.Hunger - actionMultipliers["eat"]);
                tamagotchi.LastAction = Actions.None;
                tamagotchi.CooldownTime = 0;
                return 1;
            }
            return 0;
        }
    }
}