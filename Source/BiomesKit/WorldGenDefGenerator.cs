﻿using HarmonyLib;
using RimWorld;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using Verse;

namespace BiomesKit
{

    [StaticConstructorOnStartup]
    static class WorldGenStepConstructor
    {
        static WorldGenStepConstructor()
        {
            WorldGenStepDef def = new WorldGenStepDef
            {
                defName = "BiomesKitWorldGenStep",
                order = 211,
                worldGenStep = new BiomesKit.LateBiomeWorker()

            };
            DefDatabase<Verse.WorldGenStepDef>.Add(def);
        }
    }
}
