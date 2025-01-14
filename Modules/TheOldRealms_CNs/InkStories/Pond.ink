//Global story tags
# title: 池塘
# frequency: Common
# development: false
# illustration: pond

//Important Irregular Characters
    //| (Vertical Bar)

//Scenarios notes
    //Rarity: COMMON
    //Repeatable: YES
    
    //Restrictions
        //Terrain: Not dessert,
    
    //Triggers:
        //While travelling on campaign map
    
    //Scenario Explanation (explain the main scenario and any major variations that you are planning to build in. If a variation is different enough consider making it its own file.)
    
        //Main: You are travelling and come across a pond.

        //Alts:
            //If encountered while in a chaos area it gets weird.
            //Something comes out of the water and attacks. (River troll or River troll hag for a mini boss fight)
        
        
    //Future Options/Additions
        //Make it so the player does not have to click through each time they do a loop.
        //More options
            //Search for animals (capture geese)
            //Spend some time training
        //Add choices/effects for nature gods
            //Fishing success chance improved by Priest of Manaan
            //Healing success chance improved by Pries of Rhya or Shallya
            //Foraging success chance improved by Priest of Rhya
        //Add choices/effects for wizards (Lore of Life, Lore of Beasts, ...)
            //Lore of Beast for fishing Bonus?
        //Add randomness to the amount of plant and animal life as well as the difficulty of success
            //Randomize elements of Foraging
            //Randomize elements of Fishing
        //Add scavenging option
            //can find jewerly that was lost in the pond
        
//Data Import/Export Section
    //Make sure you include this in all ink files to get access to integration functions
        INCLUDE include.ink
        
    //List of Data Being Imported (use this to help keep track of what data you are importing; will help with troubleshooting and testing.)
    
        //Scouting Highest In party
            //Used in Fishing skill check
                VAR PartyScoutingCheckText = 0
                    //~ PartyScoutingCheckText = print_party_skill_chance("Scouting", FishDifficulty) [Variable Update]
                
                VAR PartyScoutingCheckTest = 0
                    //~ PartyScoutingCheckTest = perform_party_skill_check("Scouting", FishDifficulty) [Variable Update]
        //Medicine (Highest in Party)
            //Used in party recovery skill check
                VAR WoundedCount = 1
                    ~ WoundedCount = GetTotalPartyWoundedCount() + 1

                VAR MedicineDifficulty = 1
                    ~ MedicineDifficulty = 3*WoundedCount
                    
                    
                VAR PartyMedicineCheckText = 2
                    ~ PartyMedicineCheckText = print_party_skill_chance("Medicine", MedicineDifficulty)
                
                VAR PartyMedicineCheckTest = 2
                    ~ PartyMedicineCheckTest = perform_party_skill_check("Medicine", MedicineDifficulty)
                    
        //Ranged Weapon Skill Highest In the party
            //Bows, Crossbows, Throwing, Gunnery
                //Bow
                    VAR BowHighestInParty = 0
                        ~ BowHighestInParty = GetPartySkillValue("Bow")

                //Crossbow
                    VAR CrossbowHighestInParty = 0
                        ~ CrossbowHighestInParty = GetPartySkillValue("Crossbow")

                //Bow
                    VAR ThrowingHighestInParty = 0
                        ~ ThrowingHighestInParty = GetPartySkillValue("Throwing")
                //Bow
                    VAR GunpowderHighestInParty = 0
                        ~ GunpowderHighestInParty = GetPartySkillValue("Gunpowder")
                        
            //Comparison
                VAR SkillText1 = ""
                VAR SkillText2 = ""
                VAR SkillTextFinal = ""
                
                VAR BowVsCrossbow = 0
                    {
                        - BowHighestInParty >= CrossbowHighestInParty:
                            ~ BowVsCrossbow = BowHighestInParty
                            ~ SkillText1 = "Bow"
                        - else:
                            ~ BowVsCrossbow = CrossbowHighestInParty
                            ~ SkillText1 = "Crossbow"
                    }
                    
                VAR ThrowingVsGunpowder = 0
                    {
                        - ThrowingHighestInParty >= GunpowderHighestInParty:
                            ~ ThrowingVsGunpowder = ThrowingHighestInParty
                            ~ SkillText2 = "Throwing"
                        - else:
                            ~ ThrowingVsGunpowder = GunpowderHighestInParty
                            ~ SkillText2 = "Gunpowder"
                    }
                    
                VAR FinalComparison = 0
                    {
                        - BowVsCrossbow >= ThrowingVsGunpowder:
                            ~ FinalComparison = BowVsCrossbow
                            ~ SkillTextFinal = SkillText1
                        - else:
                            ~ FinalComparison = ThrowingVsGunpowder
                            ~ SkillTextFinal = SkillText2
                    }
 
            //RangedSkillCheck
                VAR PartyRangedSkillCheckText = 1
                    //~ PartyRangedSkillCheckText = print_party_skill_chance(SkillTextFinal, 200) [Variable Update]
                    
            //Wizards in party
                //Lore of life
                    VAR LoreOfLifeInParty = false
                        ~ LoreOfLifeInParty = DoesPartyKnowSchoolOfMagic(false, "LoreOfLife")
                //Lore of life
                    VAR LoreOfBeastsInParty = false
                        ~ LoreOfBeastsInParty = DoesPartyKnowSchoolOfMagic(false, "LoreOfBeasts")
                        
    //Data Exported (use this to help keep track of what data you are exporting; will help with troubleshooting and testing.)
        //Give Items
            
        
//Variables setup
    //IMPORTANT! Initial values are mandatory, but they can only be primitives (number, string, boolean). If we want to assign the return value of a function to the variable, we must do it on a separate line, see one line below

    //Seed
        //~ SEED_RANDOM(100) //Uncomment to lock an RNG testing seed for the randomness. Change number inside () for different seed
        
    //Fish
        VAR FishDifficulty = 50
            
        VAR FishLoops = 3
        
        VAR HideSuccessful = false
        
    //Forage
        VAR ForageDifficulty = 75
        
        VAR ForageLoops = 5
        
    //Was X attempt successful
        VAR AttemptSuccessful = false
        
    //Reward Roll
        VAR RewardRoll = 0
        

//Variable Update (Update any variables here)
    ~ PartyScoutingCheckText = print_party_skill_chance("Scouting", FishDifficulty)
                
    //~ PartyScoutingCheckTest = perform_party_skill_check("Scouting", FishDifficulty) Needs to be done each loop

    ~ PartyRangedSkillCheckText = print_party_skill_chance(SkillTextFinal, FishDifficulty*2)
    
//Variable Check (Use for sanity check. Uncomment variables to see what they are)

-> Start

===Start===

    你的部队在行军途中遇到一片安宁祥和的景色，美的让人忘却呼吸。幽暗的池塘如同一颗闪闪的宝石。池水平静清澈，倒映着蔚蓝的天空。郁郁葱葱的植被环绕着池塘，提供了一处宁静的避难所。
    {IsNight(): Silver moonlight | Golden sunlight} 透过树丛，洒下一片霞光。空气中弥漫着柔和的大自然气息，为你疲惫的身心带来抚慰。莺声呖呖娓娓动听，氛围如此宁静。

    你站在那里，被眼前的景象所吸引时，你的部下追了上来。他们疲惫不堪的脸上露出惊奇和欣慰的笑容。就连不苟言笑的士兵也露出了一丝微笑。
    
    你的二把手搭在你的肩膀上，声音难得的轻松：“我们在池边休息片刻？”
        ->choice1
        
    =choice1
        What will you have your party do?
            *[采集 (Multiple attempts at {LoreOfLifeInParty: 50% chance (Improved by Lore of Life)| 25% chance} to succeed at harvesting various wild plants)] 
                
                你让你的士兵去采集野生植物。
            
                //Lore of Life in Party Increases success chance
                    {LoreOfLifeInParty:
                        -true: 
                            你命令你的士兵召唤吉兰之风才辅助采集。
                            ~ ForageDifficulty = ForageDifficulty - 25
                        -false:
                        -else: ERROR
                    }
                    
                ->ForageLoop

            *[钓鱼 (Multiple chances to get Fish (50% success chance))] 
            
            你让你的士兵去钓鱼。
                
                ->FishLoop
                
            *[休息（所有同伴痊愈，所有伤兵康复 {PartyMedicineCheckText}）]
                
                你试着让你的士兵休息一下，希望短暂的喘息能让他们好起来。
                
                {PartyMedicineCheckTest:
                    -true: 
                        你的部队休息了一段时间，同时治疗受伤的士兵。
                        ~ HealPartyToFull()
                    -false:
                    就在大家开始照顾伤员时，大地突然震动起来，空气弥漫着轰鸣声。岸边山体滑坡，泥土岩石倾泻而下，砸进池塘。水流汹涌，吞没了一部分被长期侵蚀的土地。
                    -else: "ERROR"
                }
                
                
                ->Leave
                
            *[离开] 没有时间去休息了，立马出发。->END

    =ForageLoop
        //Decrease number of loops remaining
            ~ ForageLoops = ForageLoops - 1
        
        //Was attempt successful
            {RANDOM(0,100)>=ForageDifficulty:
                -true:
                    ~ AttemptSuccessful = true
                -false:
                    ~ AttemptSuccessful = false
                -else: ERROR
            }

        //Reward if successful
            {AttemptSuccessful:
                -true:
                    ~ RewardRoll = 1
                -false:
                    ~ RewardRoll = 0
            }
            
            {RewardRoll:
                -0:
                    觅食无果，你的手下空手而归。
                -1:
                    你的士兵找到了谷物 （+1 谷物）
                    ~ GiveItem("grain",1)
            }
            
        //End of Loop
            {ForageLoops > 0 : ->ForageLoop | ->Leave}
        
    ->END
    
    =FishLoop
        //Decrease number of loops remaining
            ~ FishLoops = FishLoops - 1
        
        //Was attempt successful
            {RANDOM(0,100)>=ForageDifficulty:
                -true:
                    ~ AttemptSuccessful = true
                -false:
                    ~ AttemptSuccessful = false
                -else: ERROR
            }

        //Reward
            {
                - AttemptSuccessful == true:
                    你的士兵钓到一些鱼 （+1 鱼）
                    ~ GiveItem("fish",1)
                - AttemptSuccessful == false:
                     空军……
                -else: ERROR
            }
                    
        //End of Loop
            {FishLoops > 0 : ->FishLoop | ->Leave}
        
    ->END
    
===Leave===
    在池塘边度过美好时光后，您决定离开。

    ~ MakePartyDisorganized()
    
-> END
