using HarmonyLib;
using System;
using System.Collections.Generic;
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
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=w2KWMPny}Why are you here?");
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
                throw new ArgumentException("Cannot find ldstr 'I will return!' in EonirFavorEnvoyTownBehavior.AddEmpireEnvoyDialogLines");
        }
    }
}
