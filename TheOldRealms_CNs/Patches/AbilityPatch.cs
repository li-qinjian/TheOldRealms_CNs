using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;
using TaleWorlds.Localization;
using TOR_Core.AbilitySystem;
using TOR_Core.AbilitySystem.Spells;

namespace TheOldRealms_CNs.Patches
{
    [HarmonyPatch]
    internal class AbilityPatch
    {
        [HarmonyTranspiler]
        [HarmonyPatch(typeof(Ability), "IsDisabled")]
        public static IEnumerable<CodeInstruction> TranspilerAbilityIsDisabled(IEnumerable<CodeInstruction> instructions, ILGenerator generator)
        {
            var found = false;
            foreach (var instruction in instructions)
            {
                if (instruction.opcode == OpCodes.Ldstr)
                {
                    var stringOperand = instruction.operand.ToString();
                    switch (stringOperand)
                    {
                        case "{=!}Enabled":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=6xAo3L4Q}{=!}Enabled");
                            found = true;
                            break;
                        case "{=!}On cooldown":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=TpQT1Vm0}{=!}On cooldown");
                            found = true;
                            break;
                        case "{=!}Mission is over":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=G1p7qx2u}{=!}Mission is over");
                            found = true;
                            break;
                        case "{=!}Casting":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=Fj0owOnJ}{=!}Casting");
                            found = true;
                            break;
                        case "{=!}In Mistform":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=bmmSvu7S}{=!}In Mistform");
                            found = true;
                            break;
                        default:
                            yield return instruction;
                            break;
                    }
                }
                else
                {
                    yield return instruction;
                }
            }
            if (found is false)
                throw new ArgumentException("Cannot find ldstr '{=!}Enabled' in Ability.IsDisabled");
        }

        [HarmonyTranspiler]
        [HarmonyPatch(typeof(Ability), "CanCast")]
        public static IEnumerable<CodeInstruction> TranspilerAbilityCanCast(IEnumerable<CodeInstruction> instructions, ILGenerator generator)
        {
            var found = false;
            foreach (var instruction in instructions)
            {
                if (instruction.opcode == OpCodes.Ldstr)
                {
                    var stringOperand = instruction.operand.ToString();
                    switch (stringOperand)
                    {
                        case "Can only cast in a frontal cone":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=xYxWbi2Y}Can only cast in a frontal cone");
                            found = true;
                            break;
                        case "Caster is dead or routed":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=VvDbhtSJ}Caster is dead or routed");
                            found = true;
                            break;
                        default:
                            yield return instruction;
                            break;
                    }
                }
                else
                {
                    yield return instruction;
                }
            }
            if (found is false)
                throw new ArgumentException("Cannot find ldstr 'Can only cast in a frontal cone' in Ability.CanCast");
        }

        [HarmonyTranspiler]
        [HarmonyPatch(typeof(Spell), "IsDisabled")]
        public static IEnumerable<CodeInstruction> TranspilerSpellIsDisabled(IEnumerable<CodeInstruction> instructions, ILGenerator generator)
        {
            var found = false;
            foreach (var instruction in instructions)
            {
                if (instruction.opcode == OpCodes.Ldstr && instruction.operand.ToString() == "{=!}Not enough winds of magic")
                {
                    yield return new CodeInstruction(OpCodes.Ldstr, "{=UQcdzMRW}Not enough winds of magic");

                    found = true;
                }
                else
                {
                    yield return instruction;
                }
            }
            if (found is false)
                throw new ArgumentException("Cannot find ldstr '{=!}Not enough winds of magic' in Spell.IsDisabled");
        }

        [HarmonyTranspiler]
        [HarmonyPatch(typeof(CareerAbility), "CanCast")]
        public static IEnumerable<CodeInstruction> TranspilerCareerAbilityCanCast(IEnumerable<CodeInstruction> instructions, ILGenerator generator)
        {
            var found = false;
            foreach (var instruction in instructions)
            {
                if (instruction.opcode == OpCodes.Ldstr)
                {
                    var stringOperand = instruction.operand.ToString();
                    switch (stringOperand)
                    {
                        case "Not enough Usages (maximum {0})":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=Yu5UeOJa}Not enough Usages (maximum {0})");
                            found = true;
                            break;
                        case "No target locked":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=Ed1Lh5qB}No target locked");
                            found = true;
                            break;
                        case "Caster is not player controlled":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=vYChLbgr}Caster is not player controlled");
                            found = true;
                            break;
                        default:
                            yield return instruction;
                            break;
                    }
                }
                else
                {
                    yield return instruction;
                }
            }
            if (found is false)
                throw new ArgumentException("Cannot find ldstr '{=!}Enabled' in CareerAbility.CanCast");
        }

        [HarmonyTranspiler]
        [HarmonyPatch(typeof(CareerAbility), "IsDisabled")]
        public static IEnumerable<CodeInstruction> TranspilerCareerAbilityIsDisabled(IEnumerable<CodeInstruction> instructions, ILGenerator generator)
        {
            var found = false;
            foreach (var instruction in instructions)
            {
                if (instruction.opcode == OpCodes.Ldstr)
                {
                    var stringOperand = instruction.operand.ToString();
                    switch (stringOperand)
                    {
                        case "{=!}Ability not charged":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=HyIIrFYD}{=!}Ability not charged");
                            found = true;
                            break;
                        case "{=!}Not usable mounted":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=RVZ3wwGo}{=!}Not usable mounted");
                            found = true;
                            break;
                        default:
                            yield return instruction;
                            break;
                    }
                }
                else
                {
                    yield return instruction;
                }
            }
            if (found is false)
                throw new ArgumentException("Cannot find ldstr '{=!}Enabled' in CareerAbility.IsDisabled");
        }

        [HarmonyTranspiler]
        [HarmonyPatch(typeof(ItemBoundAbility), "IsDisabled")]
        public static IEnumerable<CodeInstruction> TranspilerItemBoundAbilityIsDisabled(IEnumerable<CodeInstruction> instructions, ILGenerator generator)
        {
            var found = false;
            foreach (var instruction in instructions)
            {
                if (instruction.opcode == OpCodes.Ldstr)
                {
                    var stringOperand = instruction.operand.ToString();
                    switch (stringOperand)
                    {
                        case "{=!}No more artillery pieces in inventory":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=wOMpKWnP}No more artillery pieces in inventory");
                            found = true;
                            break;
                        case "{=!}Party cannot field more artillery pieces":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=8OUxMh2O}Party cannot field more artillery pieces");
                            found = true;
                            break;
                        default:
                            yield return instruction;
                            break;
                    }
                }
                else
                {
                    yield return instruction;
                }
            }
            if (found is false)
                throw new ArgumentException("Cannot find ldstr '{=!}No more artillery pieces in inventory' in ItemBoundAbility.IsDisabled");
        }
    }
}
