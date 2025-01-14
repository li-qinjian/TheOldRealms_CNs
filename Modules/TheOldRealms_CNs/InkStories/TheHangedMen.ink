//Global story tags
# title: 被吊死的人
# frequency: Common
# development: false
# illustration: hangedman

//Important Irregular Characters
    //| (Vertical Bar)

//Scenarios notes
    //Rarity: COMMON
    //Repeatable: YES
    
    //Triggers:
        //While Travelling on Campaign map
    
    //Scenario Explanation (explain the main scenario and any major variations that you are planning to build in. If a variation is different enough consider making it its own file.)
    
        //Main: You come across a bunch of hanged men with a sword in the ground underneath them. There is a body buried under the sword.

        //Alt:
        
    //Future Options/Additions
        //Add ability to gain relations or gain faith skill for people who have a death god (ex. Morr)
        //Remove certain choices if the player is not Order (Undead, Chaos, Greenskin)
        //Make sure the spellcraft skill used for raise dead comes from a necromancer in the party
        //Add in a murder mystery available by speaking to the dead
            //Necro can make Spirit hosts instead of zombies
        //Take skulls option for chaos
        //Change skeleton to zombie
        //Defile corpses

INCLUDE include.ink

//Variables setup

    //Party can raise departed
        VAR PartyCanRaiseDead = false
            ~ PartyCanRaiseDead = PartyHasNecromancer(false)
                
    //Spellcraft (Highest In Party)
        VAR PartySpellcraftCheckText = 0 //Not important initial value
            ~ PartySpellcraftCheckText = print_party_skill_chance("Spellcraft", RaiseDeadDifficulty)
                
        VAR PartySpellcraftCheckTest = 0 //Not important initial value
            ~ PartySpellcraftCheckTest = perform_party_skill_check("Spellcraft", RaiseDeadDifficulty)
                
    //Give Items
        VAR HaveSword = false
        VAR TookSword = false
        VAR LootedBody = false

    //Raise Dead
        VAR RaiseDeadDifficulty = 50
        VAR SkeletonSuccess = false

    //Grave Interaction
        VAR DugUpGrave = false
        VAR CryptGuardSuccess = false


-> Start

===Start===
    你惊讶的发现一颗树上吊着三个人，地上还插着一把剑。走近一看，你发现树上刻着“叛徒”二字，而这把剑是用来标记坟墓的。 ->choice1

    //What to do with the hanging bodies
    =choice1
        你要如何处理尸体？
        
            *[什么也不做]
                你决定不处理尸体。
                ->Grave
        
            *[安葬尸体（仁慈+）]
                你砍下绳子，让他们安息。
                ~ AddTraitInfluence("Mercy", 20)
                ->Grave
        
            *[抢劫尸体（仁慈-）]
                你砍倒尸体，掠夺财物，还拿走他们被处死时穿的破布。
                ~ AddTraitInfluence("Mercy", -20)
                ~ GiveItem("wrapped_headcloth",3)
                ~ GiveItem("ragged_robes",3)
                ~ GiveItem("leather_shoes",3)
                ->Grave
            
        //Raise the hanging bodies as skeletons
            *{PartyCanRaiseDead}[将吊死的尸体复活为骷髅（仁慈-） {print_party_skill_chance("Spellcraft", RaiseDeadDifficulty)}]
                ~ AddTraitInfluence("Mercy", -50)
                {perform_party_skill_check("Spellcraft", RaiseDeadDifficulty):
                    -true:
                        ~ ChangePartyTroopCount("tor_vc_skeleton",3)
                        ~ SkeletonSuccess = true
                }
                你的部队试图将尸体复活为骷髅 {SkeletonSuccess: and succeeds. ->Grave | and fails.->choice1}


===Grave===
    //Needed for intermission text 
        讨论完如何处理尸体后，你将注意力转移到剑上标记的坟墓上。
        ->choice2
        
    //如何处理被掩埋的尸体。
    =choice2
        
        //Variable Update
        ~ RaiseDeadDifficulty = 100
        What will you do with the grave?
        *[离开此地（离开）]
            ->Leave
            
        *[超度亡魂（仁慈+）]
            你为逝者祈祷，希望他们能够安息。
            ~ AddTraitInfluence("Mercy", 20)
            ->Leave


        *[拿走剑（一把3阶剑）（仁慈-）]
            你把剑拿在手上。
            ~ AddTraitInfluence("Mercy", -20)
            ~ HaveSword = true
            ~ TookSword = true
            ->choice2
            
        *[挖掘坟墓（仁慈-）]
            你挖开坟墓，发现一名战士被埋在一些盔甲里。你可以看到这些盔甲已经损坏，很可能是“叛徒”的。
            ~ AddTraitInfluence("Mercy", -20)
            ~ DugUpGrave = true
            ->choice2
        
        *{DugUpGrave == true}[掠夺被掩埋的尸体（两个3阶护甲）]
            你要剥去身上所有完好的盔甲。
            ~LootedBody = true
            ~AddTraitInfluence("Mercy", -20)
            
                //Loot Rolls
                    {RANDOM(0,1):
                        -0: 
                            ~GiveItem("roundkettle_over_imperial_leather",1)
                        -1: 
                            ~GiveItem("imperial_padded_cloth",1)
                    }
                    {RANDOM(0,1):
                        -0: 
                            ~GiveItem("mail_mitten",1)
                        -1: 
                            ~GiveItem("mail_chausses",1)
                    }

            ->choice2
            
        *{DugUpGrave && PartyCanRaiseDead && not LootedBody}[将埋葬的尸体复活为尸妖（+1地穴守卫，仁慈--） {print_party_skill_chance("Spellcraft", RaiseDeadDifficulty)}]
            ~AddTraitInfluence("Mercy", -50)
                
                //Raise Dead
                    {perform_party_skill_check("Spellcraft", RaiseDeadDifficulty):
                        -true:
                            ~ ChangePartyTroopCount("tor_vc_crypt_guard",1)
                            ~ CryptGuardSuccess = true
                            ~ HaveSword = false
                        -false:
                    }

                您的部队试图将尸体复活为尸妖 {CryptGuardSuccess: and succeed. The wight stands up {TookSword: and holds out its hand as if to ask for its sword back. You give back the weapon} then it marches off to join the rest of your forces. ->Leave | and fail.->choice2}
            ->Leave

===Leave===
    做出决定后，继续你的行程。
    {HaveSword: 
        ~GiveItem("vlandia_sword_1_t2",1)
    }
-> END















