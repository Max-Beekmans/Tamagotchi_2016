using System;
using System.Collections.Generic;
using System.Linq;
using Ninject.Modules;
using Tamagotchi_prog.Repository;

namespace Tamagotchi_prog.Models.GameRules
{
    public class GameRuleModule : NinjectModule
    {

        public override void Load()
        {
            //var settingsDictonary = GetGameRule();

            //if (settingsDictonary["Fatigue"])
            //{
            //    Bind<IGameRule>().To<FatigueRule>();
            //}

            //if (settingsDictonary["Hunger"])
            //{
            //    Bind<IGameRule>().To<HungerRule>();
            //}

            //if (settingsDictonary["Boredom"])
            //{
            //    Bind<IGameRule>().To<BoredomRule>();
            //}

            //if (settingsDictonary["Isolation"])
            //{
            //    Bind<IGameRule>().To<IsolationRule>();
            //}

            var myContext = new MyContext();
            var r = myContext.RuleSettings.First();
            if (r.Fatigue)
            {
                Bind<IGameRule>().To<FatigueRule>();
            }

            if (r.Hunger)
            {
                Bind<IGameRule>().To<HungerRule>();
            }

            if (r.Boredom)
            {
                Bind<IGameRule>().To<BoredomRule>();
            }

            if (r.Isolation)
            {
                Bind<IGameRule>().To<IsolationRule>();
            }

        }

        //private Dictionary<String, bool> GetGameRule()
        //{
        //    //var EnabledRules = new Dictionary<String, bool>
        //    //{
        //    //    {"Boredom", true},
        //    //    {"Hunger", true},
        //    //    {"Fatigue", true},
        //    //    {"Isolation", true}
        //    //};
        //    //MyContext Context = new MyContext();
        //    //return Context.RuleSettings.First().;
        //    //return EnabledRules;
        //}
       
    }
}