using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;
using TaleWorlds.Localization;
using TOR_Core.CampaignMechanics.RaiseDead;
using TOR_Core.CampaignMechanics.ServeAsAHireling;

namespace TheOldRealms_CNs.Patches
{
    [HarmonyPatch]
    internal class ServeAsAHirelingCampaignBehaviorPatch
    {
        [HarmonyTranspiler]
        [HarmonyPatch(typeof(ServeAsAHirelingCampaignBehavior), "LeaveEnlistingParty")]
        public static IEnumerable<CodeInstruction> LeaveEnlistingPartyTranspiler(IEnumerable<CodeInstruction> instructions, ILGenerator generator)
        {
            var found = false;
            foreach (var instruction in instructions)
            {
                if (instruction.opcode == OpCodes.Ldstr)
                {
                    var stringOperand = instruction.operand.ToString();
                    switch (stringOperand)
                    {
                        case "This will harm your relations with the entire faction.":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=6lwXDEoY}This will harm your relations with the entire faction.");
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
                throw new ArgumentException("Cannot find ldstr 'This will harm your relations with the entire faction.' in ServeAsAHirelingCampaignBehavior.LeaveEnlistingParty");
        }

        [HarmonyTranspiler]
        [HarmonyPatch(typeof(ServeAsAHirelingCampaignBehavior), "InitializeDialogs")]
        public static IEnumerable<CodeInstruction> InitializeDialogsTranspiler(IEnumerable<CodeInstruction> instructions, ILGenerator generator)
        {
            var found = false;
            foreach (var instruction in instructions)
            {
                if (instruction.opcode == OpCodes.Ldstr)
                {
                    var stringOperand = instruction.operand.ToString();
                    switch (stringOperand)
                    {
                        case "I would like to quit my service.":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=I7JC76vt}I would like to quit my service.");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "Are you sure?":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=rX4KbXwM}Are you sure?");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "Yes i want to leave":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=mQLnMJtM}Yes i want to leave");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "I have to think about this.":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=4iDBIgCE}I have to think about this.");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "I am hereby offering my sword.":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=VXmPSt7I}I am hereby offering my sword.");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "I accept my Lord.":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=ZjE3WFik}I accept my Lord.");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "I need to think about this":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=lwLNcA9b}I need to think about this");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
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
                throw new ArgumentException("Cannot find ldstr 'I would like to quit my service.' in ServeAsAHirelingCampaignBehavior.InitializeDialogs");
        }

        [HarmonyTranspiler]
        [HarmonyPatch(typeof(ServeAsAHirelingCampaignBehavior), "SetupHirelingMenu")]
        public static IEnumerable<CodeInstruction> SetupHirelingMenuTranspiler(IEnumerable<CodeInstruction> instructions, ILGenerator generator)
        {
            var found = false;
            foreach (var instruction in instructions)
            {
                if (instruction.opcode == OpCodes.Ldstr)
                {
                    var stringOperand = instruction.operand.ToString();
                    switch (stringOperand)
                    {
                        case "Back":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=2Pn37PsW}Back");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "Enter the settlement":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=F7ZMXkmY}Enter the settlement");
                            found = true;
                            break;
                        case "off":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=8Jncw6Am}off");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "Desert":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=2vbvuFjg}Desert");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
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
                throw new ArgumentException("Cannot find ldstr 'Back' in ServeAsAHirelingCampaignBehavior.SetupHirelingMenu");
        }

        [HarmonyTranspiler]
        [HarmonyPatch(typeof(ServeAsAHirelingCampaignBehavior), "SetupBattleMenu")]
        public static IEnumerable<CodeInstruction> SetupBattleMenuTranspiler(IEnumerable<CodeInstruction> instructions, ILGenerator generator)
        {
            var found = false;
            foreach (var instruction in instructions)
            {
                if (instruction.opcode == OpCodes.Ldstr)
                {
                    var stringOperand = instruction.operand.ToString();
                    switch (stringOperand)
                    {
                        case "Your Lord engages in a battle.":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=GFBZqDjw}Your Lord engages in a battle.");
                            found = true;
                            break;
                        case "Join battle":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=DpY9C2a8}Join battle");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "Avoid Combat":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=ySQjGSpm}Avoid Combat");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "Flee":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=zNL6CZbo}Flee");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
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
                throw new ArgumentException("Cannot find ldstr 'Back' in ServeAsAHirelingCampaignBehavior.SetupBattleMenu");
        }

        [HarmonyTranspiler]
        [HarmonyPatch(typeof(ServeAsAHirelingCampaignBehavior), "PauseModeToggle")]
        public static IEnumerable<CodeInstruction> PauseModeToggleTranspiler(IEnumerable<CodeInstruction> instructions, ILGenerator generator)
        {
            var found = false;
            foreach (var instruction in instructions)
            {
                if (instruction.opcode == OpCodes.Ldstr)
                {
                    var stringOperand = instruction.operand.ToString();
                    switch (stringOperand)
                    {
                        case "Off":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=8Jncw6Am}Off");
                            found = true;
                            break;
                        case "On":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=L8hcF1Rg}On");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
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
                throw new ArgumentException("Cannot find ldstr 'Back' in ServeAsAHirelingCampaignBehavior.PauseModeToggle");
        }

        [HarmonyTranspiler]
        [HarmonyPatch(typeof(ServeAsAHirelingCampaignBehavior), "SetActivities")]
        public static IEnumerable<CodeInstruction> SetActivitiesTranspiler(IEnumerable<CodeInstruction> instructions, ILGenerator generator)
        {
            var found = false;
            foreach (var instruction in instructions)
            {
                if (instruction.opcode == OpCodes.Ldfld && instruction.operand == (object)AccessTools.Field(typeof(TextObject), "Value"))
                {
                    yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(TextObject), nameof(TextObject.ToString)));
                    found = true;
                }
                else
                {
                    yield return instruction;
                }
            }
            if (found is false)
                throw new ArgumentException("Cannot find ldfld [TaleWorlds.Localization]TaleWorlds.Localization.TextObject::Value in ServeAsAHirelingCampaignBehavior.SetActivities");
        }
    }
}
