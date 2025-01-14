//Global story tags
# title: 交通事故
# frequency: Common
# development: false
# illustration: cart_accident

INCLUDE include.ink

        VAR InjuryDifficulty = 2
            {InjuryRoll:
                -1: 
                    ~InjuryDifficulty = 100
                -2: 
                    ~InjuryDifficulty = 250
            }
        
        VAR Settlement = ""
            ~ Settlement = GetNearestSettlement("town")
                
        VAR Notable = ""
            ~ Notable = GetRandomNotableFromSpecificSettlement(Settlement)
                
        VAR NotableChange = false
                
        VAR PartyCanRaiseDead = false
            ~ PartyCanRaiseDead = PartyHasNecromancer(false)
                
        VAR RaiseDeadSkillCheckText = ""
            ~ RaiseDeadSkillCheckText = print_party_skill_chance("Spellcraft", 25)
                
        VAR RaiseDeadSkillCheckTest = false
            ~ RaiseDeadSkillCheckTest = perform_party_skill_check("Spellcraft", 25)
                
        VAR MedicineSkillCheckText = ""
            ~ MedicineSkillCheckText = print_party_skill_chance("Medicine", InjuryDifficulty)
                
        VAR MedicineSkillCheckTest = false
            ~ MedicineSkillCheckTest = perform_party_skill_check("Medicine", InjuryDifficulty)
                
        VAR SpellcraftSkillCheckText = ""
            ~ SpellcraftSkillCheckText = print_party_skill_chance("Spellcraft", InjuryDifficulty)
                
        VAR SpellcraftSkillCheckTest = false
            ~ SpellcraftSkillCheckTest = perform_party_skill_check("Spellcraft", InjuryDifficulty)
                
        VAR LoreOfLifeInParty = false
                ~ LoreOfLifeInParty = DoesPartyKnowSchoolOfMagic(false, "LoreOfLife")

        VAR InjuryRoll = 2
            ~ InjuryRoll = RANDOM(0,2)
            
        VAR InjuryText1 = ""
            {InjuryRoll:
                -0: 
                    ~InjuryText1 = "毫发无损"
                -1: 
                    ~InjuryText1 = "轻微受伤"
                -2: 
                    ~InjuryText1 = "严重受伤"
            }
        
        VAR InjuryText2 = ""
            {InjuryRoll:
                -0: 
                    ~InjuryText2 = "要求"
                -1: 
                    ~InjuryText2 = "乞求"
                -2: 
                    ~InjuryText2 = "喘着粗气"
            }
        
        VAR InjuryText3 = ""
            {InjuryRoll:
                -0: 
                    ~InjuryText3 = "站了起来"
                -1: 
                    ~InjuryText3 = "勉强站起"
                -2: 
                    ~InjuryText3 = "躺在那里挣扎"
            }
            
        VAR InjuryText4 = ""
            {InjuryRoll:
                -0: 
                    ~InjuryText4 = ""
                -1: 
                    ~InjuryText4 = "少有一段时间保持残废，他感到有些沮丧"
                -2: 
                    ~InjuryText4 = "死了"
            }
    
        VAR HorsesAround = 0
            ~HorsesAround = RANDOM(0,1)

        //Ask for info
        VAR HasAsked = false
        
        //Profession of the stuck man
        VAR ProfessionRoll = 0
            ~ ProfessionRoll = RANDOM(0,2)
            
        VAR Profession = ""
            {ProfessionRoll:
                -0: 
                    ~Profession = "商人"
                -1: 
                    ~Profession = "农民"
                -2: 
                    ~Profession = "铁匠"
            }
        
        VAR RewardText = ""
            {ProfessionRoll:
                -0: 
                    ~RewardText = "500 第纳尔"
                -1: 
                    ~RewardText = "5 谷物"
                -2: 
                    ~RewardText = "2 钢锭"
            }

        VAR HasExtorted = false
        
        //Bonus Reward
        VAR BonusRoll = 0

        VAR ManAlive = true
        
         ~ SetTextVariable("HorsesAround",HorsesAround)
        ~ SetTextVariable("InjuryText1",InjuryText1)
        ~ SetTextVariable("InjuryText2",InjuryText2)
        ~ SetTextVariable("InjuryText3",InjuryText3)
        ~ SetTextVariable("InjuryText4",InjuryText4)
        
        ~ SetTextVariable("Profession",Profession)
        ~ SetTextVariable("Settlemente",Settlement)
        ~ SetTextVariable("Notable",Notable)
        ~ SetTextVariable("RewardText",RewardText)
        
        ~ SetTextVariable("RaiseDeadSkillCheckText",RaiseDeadSkillCheckText)
         
        ~ SetTextVariable("HasExtorted1",HasExtorted)
        ~ SetTextVariable("HasExtorted2",HasExtorted)
        

-> Start

===Start===
    你的部队行军时，你看到远处有一辆马车。
    当你靠近时，你发现它已经破损了。
    {HorsesAround: 你还可以看到一些马在附近的草地上吃草，你估摸这些马在事发之前正在拉车。}

    *[靠近马车]->Approach
    *[不管它] 您决定不理会翻倒的马车，继续前行。 ->END

===Approach===

    你靠近马车周围，发现一个人被卡在下面。当他看到你在靠近时，变向你大声呼救。
    您注意到被困在马车下的人是{InjuryText1}。
    你走到他身前，他向你{InjuryText2}“帮帮我！”。
    你会怎么做？
    ->choices
    
    =choices
        *[天下可没有免费的午餐]
            你问他有什么回报。
            那人回答说："我只是一个来自{Settlement}的普通{Profession}，家境贫寒，只能言谢。
            顿了一会，他说“我是{Notable}的朋友，我能帮你说说好话。”
            在与他对话的同时，你注意到车上似乎还有一些货物。
            ~HasAsked = true
            ->choices
        
            *{not HasAsked}[直接帮他（仁慈++）]
                你决定拉他一把。
                ~ AddTraitInfluence("Mercy", 40)
                ->AfterLift
                
            *{HasAsked}[帮他（+{Notable}好感，仁慈+）]
                你决定拉他一把。
                ~ AddTraitInfluence("Mercy", 20)
                ~ NotableChange = true
                ->AfterLift
        
            *{HasAsked}[敲诈一笔（仁慈-）]
                他告诉{Profession}：不如此谦虚。他显然有一定经济实力，很容易就能拿出{RewardText}作为援助的补偿。
                他别无选择，无奈同意了。
                ~ AddTraitInfluence("Mercy", -20)
                ~ HasExtorted = true
                ->AfterLift
            
            *{HasAsked && HorsesAround}[索要一匹马（仁慈-）]
                显然一个人无法控制两匹马，因此给你一匹马作为报酬也是合情合理的吧？
                他别无选择，无奈同意了。
                ~ AddTraitInfluence("Mercy", -20)
                ~ HasExtorted = true
                ~ SetTextVariable("HasExtorted1",HasExtorted)
                ~ SetTextVariable("HasExtorted2",HasExtorted)
                ->AfterLift
        
            *{HorsesAround}[抢走马离开（仁慈-）]
                与其帮助这人，不如去驯服这两匹马。它们难道不是野马吗？周围又没主人认领，这样做完全合法。
                在你驯服了马匹并准备离开时，你听到被困者乞求你回来帮忙的哭喊声。然而哭喊声也渐渐消失在远方。
                ~ AddTraitInfluence("Mercy", -40)
                ~ GiveItem("old_horse",2)
                ->END
                
        //Necromancer option
            *{PartyCanRaiseDead}[杀掉这人，把他做成骷髅，{HorsesAround: take the horses,}抢走他的马车（仁慈---）{print_party_skill_chance("Spellcraft", 25)}]
                一个绝妙的主意出现在你的脑海中。既然这个人作为车夫毫无价值，也许他可以通过成为你的亡灵奴仆来证明自己的价值。
                你迅速地杀死了这个人，并把他变成骷髅。你的队伍努力之后{RaiseDeadSkillCheckTest: succeeds| fails}。
                {RaiseDeadSkillCheckTest: -> raiseSucceed | -> raiseFail}
    
    =raiseSucceed
    成功将他“起死回生”。你决定拿走这个人的所有财产来庆祝。
        {ProfessionRoll:
            -0: 
                ~GiveGold(500)
            -1: 
                ~GiveItem("grain", 5)
            -2: 
                ~GiveItem("ironIngot4", 2)
        }
        {HorsesAround: {GiveItem("old_horse",2)}}
        ~ ChangePartyTroopCount("tor_vc_skeleton",1)
        -> END
    
    =raiseFail
    失败了。你决定拿走死者的所有财产，作为对浪费你时间的补偿。
        {ProfessionRoll:
            -0: 
                ~GiveGold(500)
            -1: 
                ~GiveItem("grain", 5)
            -2: 
                ~GiveItem("ironIngot4", 2)
        }
        {HorsesAround: {GiveItem("old_horse",2)}}
        -> END

===AfterLift===
    你的队伍从那人身上抬起马车，他{InjuryText3}。

    //Is Injured?
        {InjuryRoll:
            -0:     ->Reward
            -else:  ->Injury
        }

        =Injury
            如何治疗他的伤势？
                *[药物治疗 {MedicineSkillCheckText}]
                    你最好的医生开始治疗，试图把他医好。
                        {MedicineSkillCheckTest: ->Success | ->Fail}
                        
                *{LoreOfLifeInParty}[魔法治疗 {SpellcraftSkillCheckText}]
                    你的法师唤起纪伦之风，治疗他的伤口。
                        {SpellcraftSkillCheckTest: ->Success | ->Fail}
                    
        =Success
            你的治疗成功了，他现在健康如初。
                ~ BonusRoll = RANDOM(0,100)
                ->Reward
            
        =Fail
            你的治疗失败了，而那个人{InjuryText4}。
                {InjuryRoll:
                    -2:
                        ~ ManAlive = false
                }
            ->Reward
            
===Reward===

    {ManAlive:->LiveReward|->DeadReward}

    =LiveReward
        得救后，这个人{HasExtorted: 勉为其难的}感谢你的帮助{HasExtorted: 并给你许诺的奖赏}。
        {NotableChange: 他整理自己的行李并说：“我一旦回家就会立马告诉{Notable}你的要求”}
        {HasExtorted == false && BonusRoll >=50: 男子顿了一会儿说：“我知道我没有多少钱，但请收下这个。”}
        
        {HasExtorted || (not HasExtorted && BonusRoll >=50):
            -true:
                {ProfessionRoll:
                    -0: 
                        ~GiveGold(500)
                    -1: 
                        ~GiveItem("grain", 5)
                    -2: 
                        ~GiveItem("ironIngot4", 2)
                }
        }
        {NotableChange: {ChangeRelations(Notable, 5)}}
        ->END
        
    =DeadReward
        你接下来会做什么？
            *[安葬这个男人（仁慈+）]
                你决定安葬他，希望他能安息。
                {AddTraitInfluence("Mercy", 40)}
                ->DeadReward
            *[洗劫马车{HorsesAround: and take the horses} ({RewardText}{HorsesAround:, +2 tier 0 horses})]
                他已经去世，显然他不再需要这些物品了。
                {ProfessionRoll:
                    -0: 
                        ~GiveGold(500)
                    -1: 
                        ~GiveItem("grain", 5)
                    -2: 
                        ~GiveItem("ironIngot4", 2)
                }
                {HorsesAround: {GiveItem("old_horse",2)}}
                ->DeadReward
            *{PartyCanRaiseDead}[复活他为骷髅 （+1 骷髅）{RaiseDeadSkillCheckText}]
                既然尸体没有利用价值，为何不如复活成骷髅？
                你的队伍努力之后{RaiseDeadSkillCheckTest: succeeds| fails}.
                
                {RaiseDeadSkillCheckTest:
                    -true: 那人的尸体站了起来，摇摇晃晃地加入了你的军队。
                        ~ ChangePartyTroopCount("tor_vc_skeleton",1)
                }
                ->DeadReward
            *[继续前进（离开）]
                你决定是时候继续前进了。
                ->END
