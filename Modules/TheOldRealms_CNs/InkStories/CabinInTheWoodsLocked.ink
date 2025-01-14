//Global story tags
# title: 林中小屋
# frequency: Common
# development: false
# illustration: roadpoint2


//Important Irregular Characters
    //| (Vertical Bar)

//Scenarios notes
    //Rarity: COMMON
    //Repeatable: YES
    
    //Restrictions
    
    //Triggers:
        //While Travelling on the campaign map
        //After clearing a random bandit camp
        //Quests:
            //Bandit Bounty quest
    
    //Scenario Explanation (explain the main scenario and any major variations that you are planning to build in. If a variation is different enough consider making it its own file.)
    
        //Main: Party comes across a locked cabin. They must find a way in.

        //Alt1: Ambush by hostile party [Not Implemented]
        //Alt2: Dungeon hidden inside [Not Implemented]
        
        
    //Future Options/Additions
        //Faith check if party has a priest of Ranald
        //Someone answers when you knock on the door
        //Burn down the cabin
        //Hidden items in the cabin
            //Different ways item can be hidden (ex magically hidden, trap door)

INCLUDE include.ink

//Variables setup
            
        VAR PartyRogueryCheckText = 0
        VAR PartyRogueryCheckTest = 0
        VAR PartySpellcraftCheckText = 0
        VAR PartySpellcraftCheckTest = 0
        VAR PartyEngineeringCheckText = 0
        VAR PartyEngineeringCheckTest = 0
        VAR PartyCanCastSpell = false
        VAR PartyVigorCheckText = ""
        VAR PartyVigorCheckTest = 0
        
    VAR LockQuality = 0
        ~ LockQuality = RANDOM(1,3)
            
    VAR LockDifficulty = 0
        ~ LockDifficulty = LockQuality * 50
            
    VAR LockText = ""
        {
            - LockQuality == 1:
                ~ LockText = "薄弱的"
            - LockQuality == 2:
                ~ LockText = "普通的"
            - LockQuality == 3:
                ~ LockText = "强大的"
        }
            
    ~ SetTextVariable("LockText",LockQuality)
            
    VAR DoorQuality = 0
        ~ DoorQuality = RANDOM(1,3)
            
    VAR DoorDifficulty = 0
        ~ DoorDifficulty = DoorQuality * 50

    VAR DoorText = ""
        {
            - DoorQuality == 1:
                ~ DoorText = "薄弱的"
            - DoorQuality == 2:
                ~ DoorText = "普通的"
            - DoorQuality == 3:
                ~ DoorText = "强大的"
        }

    ~ SetTextVariable("DoorText",DoorQuality)
    //Reward
        VAR RewardRoll = 0
           ~ RewardRoll = RANDOM(0,2)
           
        VAR RewardText = ""
            {
                - RewardRoll == 0:
                    ~ RewardText = "5 谷物"
                - RewardRoll == 1:
                    ~ RewardText = "2 钢锭"
                - RewardRoll == 2:
                    ~ RewardText = "500 第纳尔"
            }
            
    ~ SetTextVariable("RewardText",RewardRoll)
            
 //Variable Update: Update any variables before story start
    ~ PartyRogueryCheckText = print_party_skill_chance("Roguery", LockDifficulty)
    ~ PartyRogueryCheckTest = perform_party_skill_check("Roguery", LockDifficulty)
    
    ~ PartySpellcraftCheckText = print_party_skill_chance("Spellcraft", DoorDifficulty)
    ~ PartySpellcraftCheckTest = perform_party_skill_check("Spellcraft", DoorDifficulty)           

    ~ PartyEngineeringCheckText = print_party_skill_chance("Engineering", LockDifficulty)
    ~ PartyEngineeringCheckTest = perform_party_skill_check("Engineering", LockDifficulty)

    ~ PartyVigorCheckText = print_party_attribute_chance("Vigor", DoorDifficulty / 30)
    ~ PartyVigorCheckTest = perform_party_attribute_check("Vigor", DoorDifficulty / 30)


-> Start

===Start===
    当你的队伍前行时，你们发现了森林中的一间小屋。
    
    *[走近小屋]->Approach
    *[继续前行 (离开)]You decide it is better to move on for now.->END
    
===Approach===

当你走近小屋时，你可以看到它被严密地用木板封住。小屋上唯一的门似乎被紧紧锁住。当你仔细检查门时，你发现门是{DoorText}的，上面的锁是{LockText}的。->choice1

    =choice1
    你的队伍将怎么做？
    *[敲门]你试着敲了敲门，但没有人回应。->Approach.choice1
    
    //Pick the lock (Roguery)
        *[撬开门上的锁{PartyRogueryCheckText}]
            你的队伍中最擅长盗贼技能的人试图撬开锁。
            {PartyRogueryCheckTest:你的队伍成功打开了锁。->Inside | 你的队伍未能撬开锁。 ->Approach.choice1}
        
    //Disassemble the Lock (Engineering)
        *[拆解锁{PartyEngineeringCheckText}]
            你的队伍中最擅长工程技能的人试图拆解锁。
            {PartyEngineeringCheckTest: 你的工程师运用各种精良的工具，包括螺丝刀、凿子和大锤，巧妙地拆解了锁，拆解得如此彻底，以至于锁再也无法重新组装。->Inside | 你的队伍未能拆解锁。 ->Approach.choice1}
    
    //Blow up the door (Spellcraft)
        *{PartyCanCastSpell == true}[炸毁门{PartySpellcraftCheckText}]
            你的队伍中最擅长魔法技能的法师试图用魔法炸毁门。
            {PartySpellcraftCheckTest: 你的队伍用魔法将门炸得粉碎。 ->Inside | 你的队伍未能炸毁门。 ->Approach.choice1}
            
    //Break down the door (Vigor)
        *[撞破门{PartyVigorCheckText}]
            你的队伍中最强壮的成员试图破门而入。
            {PartyVigorCheckTest: 你的队伍用力一撞，门被撞破。 ->Inside | 你的队伍未能破门而入。 ->Approach.choice1}

    *[继续前行 (离开)]你决定现在最好继续前行。 ->END

===Inside===

你的队伍进入小屋，发现有人或某种东西在这里储存了一些物资。->choice2

    =choice2
        *[拿走物资({RewardText})]
            你拿走了{RewardText}将其添加到你的物资中，然后继续前行。
            {RewardRoll:
                -0: 
                    ~ GiveItem("grain",5)
                -1: 
                    ~ GiveItem("ironIngot4", 2)
                -2: 
                    ~ GiveGold(500)
            }
            ->END
        
        *[离开]你决定不拿走这些物资，继续前行。->END
