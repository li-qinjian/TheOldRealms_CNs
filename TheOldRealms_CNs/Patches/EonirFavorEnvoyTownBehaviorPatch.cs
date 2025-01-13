using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using TaleWorlds.Localization;
using TOR_Core.CampaignMechanics.CustomEncounterDialogs;
using TOR_Core.CampaignMechanics.Menagery;

namespace TheOldRealms_CNs.Patches
{
    [HarmonyPatch]
    internal class EonirFavorEnvoyTownBehaviorPatch
    {
        [HarmonyTranspiler]
        [HarmonyPatch(typeof(EonirFavorEnvoyTownBehavior), "AddSpellsingerEnvoyDialogLines")]
        public static IEnumerable<CodeInstruction> TranspilerAddSpellsingerEnvoyDialogLines(IEnumerable<CodeInstruction> instructions /*, ILGenerator generator*/)
        {
            var found = false;
            foreach (var instruction in instructions)
            {
                if (instruction.opcode == OpCodes.Ldstr)
                {
                    var stringOperand = instruction.operand.ToString();
                    switch (stringOperand)
                    {
                        case "You are not part of these people, begone.":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=7YBSPfkG}You are not part of these people, begone.");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "The forest told of me your coming, yet not why. What have you come to ask of me?":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=W4Lnh13u}The forest told of me your coming, yet not why. What have you come to ask of me?");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "I want to travel along the roots of the Asrai, can you be my guide?":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=5HANLbwJ}I want to travel along the roots of the Asrai, can you be my guide?");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "We need the Forestborn, are there any who can come to our aid?":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=DjqBTp5p}We need the Forestborn, are there any who can come to our aid?");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "{=tor_spelltrainer_eonir_open_book_str}I seek to further my knowledge of the Winds of Magic, can you help me achieve this?":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=C5Xhxk0O}I seek to further my knowledge of the Winds of Magic, can you help me achieve this?");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "{=tor_spelltrainer_eonir_open_book_str}I think i am ready to learn a new facet of the winds of magic.":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=kLRbSfmj}I think i am ready to learn a new facet of the winds of magic.");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "Why are you here?":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=X3aGZ7dk}Why are you here?");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "That's all thank you.":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=eAHu0CbA}That's all thank you.");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "I can, but for a price. Help our people, they need more power and then I will allow you to travel the worldroot.":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=apZ5VFit}I can, but for a price. Help our people, they need more power and then I will allow you to travel the worldroot.");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "Of course, I am willing to help. Now as my guide, please tell me how I can travel along these ancient pathways?":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=nFyQLVmU}Of course, I am willing to help. Now as my guide, please tell me how I can travel along these ancient pathways?");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "There is an entranceway to the Worldroots here in Laurelorn, first you must find it. Once there, a Spellsinger will help you travel across it but only to Maisontaal in the distant lands of Bretonnia.\n\nWe can go no further, as I am not willing to offend the Asrai. The roots are sacred, it is rare enough for non-Asrai to cross them.":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=Q5gUUjUP}There is an entranceway to the Worldroots here in Laurelorn, first you must find it. Once there, a Spellsinger will help you travel across it but only to Maisontaal in the distant lands of Bretonnia.\n\nWe can go no further, as I am not willing to offend the Asrai. The roots are sacred, it is rare enough for non-Asrai to cross them.");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "There are many who live as nomads, far from our villages and deep within the woods. It will take time for any messages to reach them but it can be done. Is this what you desire?":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=HOkMIv92}There are many who live as nomads, far from our villages and deep within the woods. It will take time for any messages to reach them but it can be done. Is this what you desire?");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "We recently called for the forestborn's aid. We should wait longer for another call":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=nUdVVGNT}We recently called for the forestborn's aid. We should wait longer for another call");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "Understood.":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=mPIYTfVu}Understood.");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "That would be kind. I am sure we will be able to pay that favor back one day. I will decide in favor of the forestborn":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=UM98PBvD}That would be kind. I am sure we will be able to pay that favor back one day. I will decide in favor of the forestborn");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "I need to think about this.":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=iI5lXnvc}I need to think about this.");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "I will see what I can do.":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=1Lukob2K}I will see what I can do.");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "I can teach you, but as much as you are ready to do so, I need your word in the Council (500{EONIR_FAVOR})?":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=NKzKcUtJ}I can teach you, but as much as you are ready to do so, I need your word in the Council (500{EONIR_FAVOR})?");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "It shouldn't be for your disadvantage":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=6F5IsL52}It shouldn't be for your disadvantage");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "I am representing a coven of Spellsingers dedicated to the defense of Laurelorn. While the Council is busy with politics, the Faniour, the forest born elves, are endagered by all the threads of the forest.":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=hA7PIb2W}I am representing a coven of Spellsingers dedicated to the defense of Laurelorn. While the Council is busy with politics, the Faniour, the forest born elves, are endagered by all the threads of the forest.");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "The forest is beset by destructive beasts and men alike, what then, are you protecting?":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=0sj3fF9W}The forest is beset by destructive beasts and men alike, what then, are you protecting?");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "What matters can the Council solve for you? What can you give me in turn?":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=P4xmNuDj}What matters can the Council solve for you? What can you give me in turn?");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "The Faniour aswell as the Touriour follow the same people. Your matters, are my matters.":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=6PN0HtCf}The Faniour aswell as the Touriour follow the same people. Your matters, are my matters.");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "I am not a man of politics. I am here to stand our case. I know that seemingly the Council, sometimes forgets about us. Thats why I am here, and standing for the forest people. I know that nothing works here, without giving something in return.":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=ybgm361Y}I am not a man of politics. I am here to stand our case. I know that seemingly the Council, sometimes forgets about us. Thats why I am here, and standing for the forest people. I know that nothing works here, without giving something in return.");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "Help us with your political power, and I will try to make it worth. I can assist you with some magic, like using the world roots of the Asrai, or can make your influence provide you power over the council. Apart, I can see what i can do for teaching you some magic":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=HRrZVKFq}Help us with your political power, and I will try to make it worth. I can assist you with some magic, like using the world roots of the Asrai, or can make your influence provide you power over the council. Apart, I can see what i can do for teaching you some magic");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "Is there something else I could do for you?":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=gsyVDcXQ}Is there something else I could do for you?");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        default:
                            yield return instruction;
                            break;
                    }
                    found = true;
                }
                else
                {
                    yield return instruction;
                }
            }
            if (found is false)
                throw new ArgumentException("Cannot find ldstr 'You are not part of these people, begone.' in EonirFavorEnvoyTownBehavior.AddSpellsingerEnvoyDialogLines");
        }

        [HarmonyTranspiler]
        [HarmonyPatch(typeof(EonirFavorEnvoyTownBehavior), "AddEmpireEnvoyDialogLines")]
        public static IEnumerable<CodeInstruction> TranspilerAddEmpireEnvoyDialogLines(IEnumerable<CodeInstruction> instructions /*, ILGenerator generator*/)
        {
            var found = false;
            foreach (var instruction in instructions)
            {
                if (instruction.opcode == OpCodes.Ldstr)
                {
                    var stringOperand = instruction.operand.ToString();
                    switch (stringOperand)
                    {
                        case "You are not part of these people, begone.":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=7YBSPfkG}You are not part of these people, begone.");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "You do not have the privilege to serve the council. You are of no use. (Low Renown).":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=FGwwD1aC}You do not have the privilege to serve the council. You are of no use. (Low Renown).");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "Is there some way I can be of assistance?":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=tzymiZRk}Is there some way I can be of assistance?");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "I bring quality goods to trade and wish to build my reputation amongst the High Council. Are you interested?":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=fyQNpQvr}I bring quality goods to trade and wish to build my reputation amongst the High Council. Are you interested?");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "I find myself in need of quality goods to trade amongst the nobles of the Empire. Can you supply them?":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=MpCfcjmn}I find myself in need of quality goods to trade amongst the nobles of the Empire. Can you supply them?");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "Our people need to make peace. What does it take to stop the war?":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=kDY99VXI}Our people need to make peace. What does it take to stop the war?");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "Why are you here?":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=X3aGZ7dk}Why are you here?");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "That's all thank you.":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=eAHu0CbA}That's all thank you.");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "The Empire and the Council should make peace. Your people, neither ours will do this without hesitantion ({PEACE_COSTS}{EONIR_FAVOR})":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=PQY5EdTE}The Empire and the Council should make peace. Your people, neither ours will do this without hesitantion ({PEACE_COSTS}{EONIR_FAVOR})");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "My political power is limited. We became too demanding, you should ask another time":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=cO6n5WfZ}My political power is limited. We became too demanding, you should ask another time");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "Understood.":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=mPIYTfVu}Understood.");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "Let's do this.":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=Ulszxwuw}Let's do this.");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "I need to think about this.":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=iI5lXnvc}I need to think about this.");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "We will see what we can do.":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=GNNXg5Rh}We will see what we can do.");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "Obviously your offering the empire can benefit the Council.(Exchange {ORIGINAL_PRESTIGE} to {RETURN_FAVOR}{EONIR_FAVOR}) ":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=WCXQdbG1}Obviously your offering the empire can benefit the Council.(Exchange {ORIGINAL_PRESTIGE} to {RETURN_FAVOR}{EONIR_FAVOR}) ");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "I am glad to make businesses with you(Exchanged {ORIGINAL_PRESTIGE} Prestige to {RETURN_FAVOR}{EONIR_FAVOR})":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=49mLC4TQ}I am glad to make businesses with you(Exchanged {ORIGINAL_PRESTIGE} Prestige to {RETURN_FAVOR}{EONIR_FAVOR})");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "The Empires ambitions need to way in the Council. (gain for 50 Council Favour 30 Prestige)":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=qJGJQORn}The Empires ambitions need to way in the Council. (gain for 50 Council Favour 30 Prestige)");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "I am glad to make businesses with you.":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=Gd0FPuZ6}I am glad to make businesses with you.");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "As an envoy of Graf Boris Todbringer I represent the interests of Middenland, and to a minor extent that of the Empire as a whole. We wish to maintain peaceful relations with Eonir, built on trust, trade and mutual respect so that we may all benefit.":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=apxKtpxU}As an envoy of Graf Boris Todbringer I represent the interests of Middenland, and to a minor extent that of the Empire as a whole. We wish to maintain peaceful relations with Eonir, built on trust, trade and mutual respect so that we may all benefit.");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "You encroach upon our lands without heeding what is sacred, yet talk to us about respect? You do not belong here.":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=64oLGj0y}You encroach upon our lands without heeding what is sacred, yet talk to us about respect? You do not belong here.");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "It benefits neither of us to make enemies when they aren't needed, trade and peace can only benefit both our peoples.":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=RGjuJ1YZ}It benefits neither of us to make enemies when they aren't needed, trade and peace can only benefit both our peoples.");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "The problems of the empire are shared with the Eonir. We need to fight together side on side, all of our common enemies.":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=Ge8ealF5}The problems of the empire are shared with the Eonir. We need to fight together side on side, all of our common enemies.");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "We seek only to cooperate, to the mutual benefit of all involved. Conflict between our peoples serves to aid none but our enemies, surely you can agree with me on this.":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=nnBw7olg}We seek only to cooperate, to the mutual benefit of all involved. Conflict between our peoples serves to aid none but our enemies, surely you can agree with me on this.");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "My word carries weight, as does that of our Graf. I can ensure a state of peace and profitable trade between our nations, we may even be able to provide mercenaries should your lands ever be threatened. ...Think on it, we both have much to gain.":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=4RiY4mbm}My word carries weight, as does that of our Graf. I can ensure a state of peace and profitable trade between our nations, we may even be able to provide mercenaries should your lands ever be threatened. ...Think on it, we both have much to gain.");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "Is there another way I can be of service?":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=radDVKcA}Is there another way I can be of service?");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        default:
                            yield return instruction;
                            break;
                    }
                    found = true;
                }
                else
                {
                    yield return instruction;
                }
            }
            if (found is false)
                throw new ArgumentException("Cannot find ldstr 'You are not part of these people, begone.' in EonirFavorEnvoyTownBehavior.AddEmpireEnvoyDialogLines");
        }

        [HarmonyTranspiler]
        [HarmonyPatch(typeof(EonirFavorEnvoyTownBehavior), "AddDruchiiEnvoyDialogLines")]
        public static IEnumerable<CodeInstruction> TranspilerAddDruchiiEnvoyDialogLines(IEnumerable<CodeInstruction> instructions /*, ILGenerator generator*/)
        {
            var found = false;
            foreach (var instruction in instructions)
            {
                if (instruction.opcode == OpCodes.Ldstr)
                {
                    var stringOperand = instruction.operand.ToString();
                    switch (stringOperand)
                    {
                        case "You are not part of these people, begone.":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=7YBSPfkG}You are not part of these people, begone.");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "You do not have the previleg to serve the council. You are of no use. (Low Renown).":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=FGwwD1aC}You do not have the previleg to serve the council. You are of no use. (Low Renown).");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "I am a servant of the Witchking, what can I do for you?":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=uIvDWosG}I am a servant of the Witchking, what can I do for you?");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "We are surrounded by enemies, we seek your aid to sow chaos within their ranks to weaken them.":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=JrdC1oeb}We are surrounded by enemies, we seek your aid to sow chaos within their ranks to weaken them.");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "I have a fine stock of prisoners to sell, should you be interested.":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=o1lB63N5}I have a fine stock of prisoners to sell, should you be interested.");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "I have some lucrative raiding targets for you.":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=3n5Cnyml}I have some lucrative raiding targets for you.");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "Why are you here?":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=X3aGZ7dk}Why are you here?");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "That's all thank you.":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=eAHu0CbA}That's all thank you.");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "A Khainite dagger can make all the difference, if it finds the right throat at the wrong time. Wars have started over less. Upon whose throat should our daggers fall? (Declare war between 2 factions ({FORCEWAR_PRICE}{EONIR_FAVOR})":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=NGCceVrl}A Khainite dagger can make all the difference, if it finds the right throat at the wrong time. Wars have started over less. Upon whose throat should our daggers fall? (Declare war between 2 factions ({FORCEWAR_PRICE}{EONIR_FAVOR})");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "The Witchking would not allow that. We should wait longer with such a request.":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=UZo3nYU8}The Witchking would not allow that. We should wait longer with such a request.");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "Understood.":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=mPIYTfVu}Understood.");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "Let's do this.":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=Ulszxwuw}Let's do this.");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "I need to think about this.":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=iI5lXnvc}I need to think about this.");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "We will see what we can do.":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=GNNXg5Rh}We will see what we can do.");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "What a promising trade. This will be credited for your next negotiation with the Witch king I believe the Council will like this.":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=HHiiCtsY}What a promising trade. This will be credited for your next negotiation with the Witch king I believe the Council will like this.");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "...This will cost you influence with the council, but we are always in need of more slaves. where do you suggest our Black Arks to anchor?({SLAVERTIDE_PRICE}{EONIR_FAVOR})":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=UTriM8Hk}...This will cost you influence with the council, but we are always in need of more slaves. where do you suggest our Black Arks to anchor?({SLAVERTIDE_PRICE}{EONIR_FAVOR})");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "Let's do this({SLAVERTIDE_PRICE}{EONIR_FAVOR}).":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=fCQJqSAa}Let's do this({SLAVERTIDE_PRICE}{EONIR_FAVOR}).");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "I could see what I can do.":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=tRsO1ecP}I could see what I can do.");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "I speak as an envoy of the rightful ruler of the Asur, and the Black Council. We may not always be aligned in our views but we believe both the Druchii and Eonir have much in common, and much to gain from one another.":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=TxOHUiK0}I speak as an envoy of the rightful ruler of the Asur, and the Black Council. We may not always be aligned in our views but we believe both the Druchii and Eonir have much in common, and much to gain from one another.");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "You raid our coasts, enslave our people and yet have the audacity to stand before us, acting as if none of this has taken place!":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=E3hCoPqP}You raid our coasts, enslave our people and yet have the audacity to stand before us, acting as if none of this has taken place!");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "I am skeptical, you come here with your own ambitions but to what end? How would hearing you speak now, benefit the Eonir?":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=nZWxdrZl}I am skeptical, you come here with your own ambitions but to what end? How would hearing you speak now, benefit the Eonir?");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "The Asur betrayed us and left us to die, I might not share your every sentiment Druchii, but I know you too suffer from our cousin's boundless arrogance.":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=Rh4DAYCW}The Asur betrayed us and left us to die, I might not share your every sentiment Druchii, but I know you too suffer from our cousin's boundless arrogance.");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "We are not your enemy, the opposite is true. Few share our bond of suffering at the hands of the Asur, few can understand our mutual plight. There are many ways we can coexist and thrive, together. - Join us, we have been scorned by our kin for far too long and this is the best path for our futures combined.":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=v7OhAG4w}We are not your enemy, the opposite is true. Few share our bond of suffering at the hands of the Asur, few can understand our mutual plight. There are many ways we can coexist and thrive, together. - Join us, we have been scorned by our kin for far too long and this is the best path for our futures combined.");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "Your seas will be safe from raids and protected from any foe, the darkest desires of your people will be free of judgement and all we seek is influence over your council. - We merely wish to lessen the gap between our peoples so that we may stand against the Asur together, a sure and just cause, do you not agree?":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=11Za94Wp}Your seas will be safe from raids and protected from any foe, the darkest desires of your people will be free of judgement and all we seek is influence over your council. - We merely wish to lessen the gap between our peoples so that we may stand against the Asur together, a sure and just cause, do you not agree?");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "Is there something else you require of me?":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=YYWcCASK}Is there something else you require of me?");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "Is there something else the Witch king could do for you?":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=rr9OOSKH}Is there something else the Witch king could do for you?");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        default:
                            yield return instruction;
                            break;
                    }
                    found = true;
                }
                else
                {
                    yield return instruction;
                }
            }
            if (found is false)
                throw new ArgumentException("Cannot find ldstr 'You are not part of these people, begone.' in EonirFavorEnvoyTownBehavior.AddDruchiiEnvoyDialogLines");
        }

        [HarmonyTranspiler]
        [HarmonyPatch(typeof(EonirFavorEnvoyTownBehavior), "AddAsurEnvoyDialogLines")]
        public static IEnumerable<CodeInstruction> TranspilerAddAsurEnvoyDialogLines(IEnumerable<CodeInstruction> instructions /*, ILGenerator generator*/)
        {
            var found = false;
            foreach (var instruction in instructions)
            {
                if (instruction.opcode == OpCodes.Ldstr)
                {
                    var stringOperand = instruction.operand.ToString();
                    switch (stringOperand)
                    {
                        case "You are not part of these people, begone.":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=7YBSPfkG}You are not part of these people, begone.");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "You do not have the previleg to serve the council. You are of no use. (Low Renown).":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=FGwwD1aC}You do not have the previleg to serve the council. You are of no use. (Low Renown).");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "Kneel before the envoy of the Asur and representative of the illustrious Pheonix King, Finubar the Seafarer. Speak and do so quickly.":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=AFWTrARL}Kneel before the envoy of the Asur and representative of the illustrious Pheonix King, Finubar the Seafarer. Speak and do so quickly.");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "We desire to expand our trade networks, but lack the funding. Would Ulthuan be willing to invest in this endeavour?":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=6YKVAKYp}We desire to expand our trade networks, but lack the funding. Would Ulthuan be willing to invest in this endeavour?");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "Eonir is threatened, we need soldiers to defend our homes and people, can you aid us?":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=cEiP7pbA}Eonir is threatened, we need soldiers to defend our homes and people, can you aid us?");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "We seek the aid of your diplomats, tensions between the kingdoms of man is at a high and we seek to reverse this.":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=A62ouYQ4}We seek the aid of your diplomats, tensions between the kingdoms of man is at a high and we seek to reverse this.");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "Why are you here?":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=X3aGZ7dk}Why are you here?");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "That's all thank you.":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=eAHu0CbA}That's all thank you.");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "With ease, how much is needed?":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=phHVZA26}With ease, how much is needed?");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "We wait for another shipment of the tressure fleet, this might take a few days. Come back":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=IQyM2Ygt}We wait for another shipment of the tressure fleet, this might take a few days. Come back");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "Understood.":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=mPIYTfVu}Understood.");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "{ASUR_MONEYRETURN1}{GOLD_ICON} for {ASUR_FAVORCOST_MONEY1}{EONIR_FAVOR}":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=rVLwBWyI}{ASUR_MONEYRETURN1}{GOLD_ICON} for {ASUR_FAVORCOST_MONEY1}{EONIR_FAVOR}");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "{ASUR_MONEYRETURN2}{GOLD_ICON} for {ASUR_FAVORCOST_MONEY2}{EONIR_FAVOR}":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=MxYxCfQy}{ASUR_MONEYRETURN2}{GOLD_ICON} for {ASUR_FAVORCOST_MONEY2}{EONIR_FAVOR}");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "{ASUR_MONEYRETURN3}{GOLD_ICON} for {ASUR_FAVORCOST_MONEY3}{EONIR_FAVOR}":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=mtsbvc69}{ASUR_MONEYRETURN3}{GOLD_ICON} for {ASUR_FAVORCOST_MONEY3}{EONIR_FAVOR}");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "I need to think about this.":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=iI5lXnvc}I need to think about this.");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "There may be some amongst the Asur willing to fight, even if it is for our less civlised kin.":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=ygGEZPSp}There may be some amongst the Asur willing to fight, even if it is for our less civlised kin.");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "Sure I accept (150 {EONIR_FAVOR}).":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=CUOaO4iM}Sure I accept (150 {EONIR_FAVOR}).");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "We can put in a good word for you from one of our many embassies, the word of an Asur has much worth amongst men. With whom do you seek better relations?":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=ZSGigdWT}We can put in a good word for you from one of our many embassies, the word of an Asur has much worth amongst men. With whom do you seek better relations?");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "You should wait a bit, good diplomacy requires patience":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=wmKmGU2e}You should wait a bit, good diplomacy requires patience");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "Sure I accept (400 {EONIR_FAVOR}).":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=SfhXhq7W}Sure I accept (400 {EONIR_FAVOR}).");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "I am here as a representative of Ulthuan, and to stand as a reminder that the freedom and independence you enjoy is a most gracious gift given by the Pheonix King. A gift that can be rescinded at his discretion.":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=RX1nYik1}I am here as a representative of Ulthuan, and to stand as a reminder that the freedom and independence you enjoy is a most gracious gift given by the Pheonix King. A gift that can be rescinded at his discretion.");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "You abandoned us to die, then tried to take our lands by force. We have survived without Ulthuan until now and will continue to do so. Begone, 'kin'.":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=gEtj3avH}You abandoned us to die, then tried to take our lands by force. We have survived without Ulthuan until now and will continue to do so. Begone, 'kin'.");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "Be mindful, our willingess to negotiate is not a sign that we have forgotten your transgressions, what do you come here to offer us?":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=Bs6Et84t}Be mindful, our willingess to negotiate is not a sign that we have forgotten your transgressions, what do you come here to offer us?");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "We are kin and have been apart for far too long, we seek the help of the Asur and appreciate any that can be offered.":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=3H7K7tnR}We are kin and have been apart for far too long, we seek the help of the Asur and appreciate any that can be offered.");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "We are willing to offer aid in many forms, as long as it increases our influence within the council.":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=8HSzi1pr}We are willing to offer aid in many forms, as long as it increases our influence within the council.");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "Ulthuan has connections across the Old World, should finances, a good word with an enemy or soldiers to defend your forest be needed, we can provide it. For the agreed price, of course.":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=1uowtL5k}Ulthuan has connections across the Old World, should finances, a good word with an enemy or soldiers to defend your forest be needed, we can provide it. For the agreed price, of course.");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "Is there something else I could do for you?":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=gsyVDcXQ}Is there something else I could do for you?");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        default:
                            yield return instruction;
                            break;
                    }
                    found = true;
                }
                else
                {
                    yield return instruction;
                }
            }
            if (found is false)
                throw new ArgumentException("Cannot find ldstr 'You are not part of these people, begone.' in EonirFavorEnvoyTownBehavior.AddAsurEnvoyDialogLines");
        }

        [HarmonyTranspiler]
        [HarmonyPatch(typeof(EonirFavorEnvoyTownBehavior), "CreateEnvoys")]
        public static IEnumerable<CodeInstruction> TranspilerCreateEnvoys(IEnumerable<CodeInstruction> instructions /*, ILGenerator generator*/)
        {
            var found = false;
            foreach (var instruction in instructions)
            {
                if (instruction.opcode == OpCodes.Ldstr)
                {
                    var stringOperand = instruction.operand.ToString();
                    switch (stringOperand)
                    {
                        case "{=tor_eonir_envoy_asur}Envoy of the Witch King":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=5GLwmlZC}Envoy of the Witch King");
                            found = true;
                            break;
                        case "{=tor_eonir_envoy_asur}Envoy of the Phoenix King":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=6WtgDRJ7}Envoy of the Phoenix King");
                            found = true;
                            break;
                        case "{=tor_eonir_envoy_asur}Envoy of the Empire":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=H1vQ0Rvv}Envoy of the Empire");
                            found = true;
                            break;
                        case "{=tor_eonir_envoy_asur}Spellsinger of the Faniour":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=CHngGIAB}Spellsinger of the Faniour");
                            found = true;
                            break;
                        default:
                            yield return instruction;
                            break;
                    }
                    found = true;
                }
                else
                {
                    yield return instruction;
                }
            }
            if (found is false)
                throw new ArgumentException("Cannot find ldstr 'You are not part of these people, begone.' in EonirFavorEnvoyTownBehavior.CreateEnvoys");
        }

        //[HarmonyTranspiler]
        //[HarmonyPatch(typeof(EonirFavorEnvoyTownBehavior), AccessTools.FirstMethod(typeof(EonirFavorEnvoyTownBehavior), methodInfo => methodInfo.Name.Contains("LearnNewLoresPrompt")).Name)]
        //public static IEnumerable<CodeInstruction> TranspilerLearnNewLoresPrompt(IEnumerable<CodeInstruction> instructions /*, ILGenerator generator*/)
        //{
        //    var found = false;
        //    foreach (var instruction in instructions)
        //    {
        //        if (instruction.opcode == OpCodes.Ldstr)
        //        {
        //            var stringOperand = instruction.operand.ToString();
        //            switch (stringOperand)
        //            {
        //                case "Learn new lore":
        //                    yield return new CodeInstruction(OpCodes.Ldstr, "{=fVABwOgl}Learn new lore");
        //                    yield return new CodeInstruction(OpCodes.Ldnull);
        //                    yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
        //                    yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
        //                    found = true;
        //                    break;
        //                case "Force Peace":
        //                    yield return new CodeInstruction(OpCodes.Ldstr, "{=WDLtnx3B}Force Peace");
        //                    found = true;
        //                    break;
        //                case "Select a new lore to learn ( maximum 3)":
        //                    yield return new CodeInstruction(OpCodes.Ldstr, "{=M7rmSbLs}Select a new lore to learn ( maximum 3)");
        //                    found = true;
        //                    break;
        //                default:
        //                    yield return instruction;
        //                    break;
        //            }
        //            found = true;
        //        }
        //        else
        //        {
        //            yield return instruction;
        //        }
        //    }
        //    if (found is false)
        //        throw new ArgumentException("Cannot find ldstr 'Learn new lore' in EonirFavorEnvoyTownBehavior.LearnNewLoresPrompt");
        //}
    }
}
