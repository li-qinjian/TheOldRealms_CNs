//Global story tags
# title: 营地故事
# frequency: Special
# development: false
# illustration: campfirenight

//Important Irregular Characters
    //| (Vertical Bar)

//Scenarios notes
    //Rarity: COMMON
    //Repeatable: YES
    
    //Triggers:
        //While traveling on the campaign map
    
    //Scenario Explanation (explain the main scenario and any major variations that you are planning to build in. If a variation is different enough consider making it its own file.)
    
        //Main: You are around a campfire and can listen to a story to gain xp or tell your men to rest.

        //Alt: You can get ambushed
        
    //Future Options/Additions
        //More possible variants in groupings
        //Magic and Faith XP options when proper restictions are in place
        
//Data Import/Export Section
    //Make sure you include this in all ink files to get access to integration functions
        INCLUDE include.ink
        
    //List of Data Being Imported (use this to help keep track of what data you are importing; will help with troubleshooting and testing.)
    
        //
        
    //Data Exported (use this to help keep track of what data you are exporting; will help with troubleshooting and testing.)
        
        //Skill XP
        
//Variables setup
    //IMPORTANT! Initial values are mandatory, but they can only be primitives (number, string, boolean). If we want to assign the return value of a function to the variable, we must do it on a separate line, see one line below

    //Seed
        //~ SEED_RANDOM(100) //Uncomment to lock an RNG testing seed for the randomness. Change number inside () for different seed
        
    //Learning sets (The groupings of exp by campfire story category)
        //Each option gives 3000 Xp total. So if a story has 2 skills attached they each get 1500 Xp. For 3 it is 1000 for each.
        //Grouping 1: War stories
            //1. The Hunt (Scouting, Random ranged weapon skill, Tactics)
            //2. The Ambush (Leadership, Tactics, Roguery)
            //3. The Charge (Riding, Polearm, Leadership)
            //4. Holding the Line (Random Melee skill, Leadership, Tactics)
            //5. The Brawl (All melee skills)
            //6. The Shootout (All ranged weapon skills)
        //Grouping 2: Talk about
            //1. Great Rulers (Steward, Leadership, Charm)
            //2. Craftsman (Smithing and Engineering)
            //3. Negotiation (Charm, Trade, Roguery)
            //4. Traveling (Riding and Athletics)
            //5. Survival (Medicine, Scouting, Athletics)
            
    //Random Selections
        //Melee Weapon
            VAR MeleeWeaponRandom = 0
                ~ MeleeWeaponRandom = RANDOM(1,3)
            VAR MeleeWeaponText = ""
                
                {MeleeWeaponRandom:
                    -1:
                        ~ MeleeWeaponText = "单手武器"
                    -2:
                        ~ MeleeWeaponText = "双手武器"
                    -3:
                        ~ MeleeWeaponText = "长杆武器"
                }

        //Ranged
            VAR RangedWeaponRandom = 0
                ~ RangedWeaponRandom = RANDOM(1,4)
            VAR RangedWeaponText = ""
                
                {RangedWeaponRandom:
                    -1:
                        ~ RangedWeaponText = "弓"
                    -2:
                        ~ RangedWeaponText = "弩"
                    -3:
                        ~ RangedWeaponText = "投掷"
                    -4:
                        ~ RangedWeaponText = "火枪"
                }
    
    //Group 1
        VAR StoryName = ""
        VAR StoryBranch = ""
        VAR StoryXpText = ""
        
        VAR StorySelect = 0
            ~ StorySelect = RANDOM(1,6)
            
            {StorySelect:
                -0: ERROR
                -1:
                    ~ StoryName = "狩猎"
                    ~ StoryBranch = ->TheHunt
                    ~ StoryXpText = "(+1000 XP——侦查、{RangedWeaponText}、战术)"
                -2:
                    ~ StoryName = "埋伏"
                    ~ StoryBranch = ->TheAmbush
                    ~ StoryXpText = "(+1000 XP——统御、战术、流氓习气)"
                -3:
                    ~ StoryName = "进攻"
                    ~ StoryBranch = ->TheCharge
                    ~ StoryXpText = "(+1000 XP——骑术、长杆武器、统御)"
                -4:
                    ~ StoryName = "坚守阵地"
                    ~ StoryBranch = ->HoldingTheLine
                    ~ StoryXpText = "(+1000 XP——{MeleeWeaponText}、统御、战术)"
                -5:
                    ~ StoryName = "斗殴"
                    ~ StoryBranch = ->TheBrawl
                    ~ StoryXpText = "(+1000 XP——所有近战武器技能)"
                -6:
                    ~ StoryName = "枪林弹雨"
                    ~ StoryBranch = ->TheShootout
                    ~ StoryXpText = "(+750 XP——所有远程武器技能)"
            }
    
    //Group 2
        VAR DiscussionName = ""
        VAR DiscussionBranch = ""
        VAR DiscussionXpText = ""
        
        VAR DiscussionSelect = 0
            ~ DiscussionSelect = RANDOM(1,5)
            
            {DiscussionSelect:
                -0: ERROR
                -1:
                    ~ DiscussionName = "伟大领袖"
                    ~ DiscussionBranch = ->GreatRulers
                    ~ DiscussionXpText = "(+1000 XP——管理、统御、魅力)"
                -2:
                    ~ DiscussionName = "工匠"
                    ~ DiscussionBranch = ->Craftsman
                    ~ DiscussionXpText = "(+1500 XP——锻造、工程)"
                -3:
                    ~ DiscussionName = "磋商"
                    ~ DiscussionBranch = ->Negotiation
                    ~ DiscussionXpText = "(+1000 XP——魅力、贸易、流氓习气)"
                -4:
                    ~ DiscussionName = "旅行"
                    ~ DiscussionBranch = ->Traveling
                    ~ DiscussionXpText = "(+1500 XP——骑术、跑动)"
                -5:
                    ~ DiscussionName = "生存"
                    ~ DiscussionBranch = ->Survival
                    ~ DiscussionXpText = "(+1000 XP——医术、侦察、跑动)"
            }
            
            
            
        
//Variable Check (Use for sanity check. Uncomment variables to see what they are)
//{GiveSkillExperience("Throwing", 1000)}

-> Start

===Start===

夜幕降临，你和你的部下安营扎寨。你看到你的部下分成了两组，一组似乎在讲战争故事，而另一组只是在聊天。 -> choice1

    =choice1
        你会怎么做？ //{MeleeWeaponRandom} {RangedWeaponRandom} //Uncomment for bug testing
            *[聆听战争故事——{StoryName} {StoryXpText}]
                ->StoryBranch
            *[加入讨论关于{DiscussionName} {DiscussionXpText}]
                ->DiscussionBranch
				*[告诉你的部下好好休息（所有同伴痊愈，所有伤员康复）]
                你要告诉你的士兵要早睡早起，尽可能多休息。
                ~ HealPartyToFull()
                ->END

===TheHunt===
  在噼噼啪啪的篝火声中，一个灰头土脸的士兵声情并茂地讲述着伪装和捕猎的故事。闪烁的火焰如同士兵们期待的目光。

  “听好了，小伙子小姑娘们，”士兵开始说，“让我给你们讲讲我们上次狩猎的故事。那是一个月黑风高的夜晚，我们跟随猎物移动的影子和沙沙作响的树叶。斥候在灌木丛中不停穿梭，目光锐利，感觉敏锐。突然，他停了下来，我们也感觉到了一个与众不同的猎物——牛头人……”

  随着故事的展开，士兵们被故事情节所吸引，体验到了追逐的快感和空气中弥漫的紧张气氛。讲述者生动地描绘了狡猾与智慧共存的故事，故事结束时，士兵们对侦察和狩猎的艺术有了新的认识。
    
    //Give Xp
        ~ GiveSkillExperience("Scouting",1000)
        ~ GiveSkillExperience("Tactics",1000)
        
        {RangedWeaponRandom:
                    -1:
                        ~ GiveSkillExperience("Bow" ,1000)
                    -2:
                        ~ GiveSkillExperience("Crossbow" ,1000)
                    -3:
                        ~ GiveSkillExperience("Throwing" ,1000)
                    -4:
                        ~ GiveSkillExperience("Gunpowder" ,1000)
                }
    -> END

===TheAmbush===
  余烬噼啪作响，一名士兵的声音响起，眼中闪过一丝调皮。篝火温暖的光芒照亮了他战友们渴望听故事的脸庞。

  “来，过来吧——”士兵笑着说，“让我给你们讲讲我们的伏击故事。想象一下——曼恩斯利布的夜晚，野兽人在毫无察觉的情况下前进。同时我们的计划很明智，行动很迅速。我们出其不意，凶猛出击，扭转了不利局面……”

  士兵们被带入了一个精心策划和执行迅速的场景。故事结束后，士兵们笑声不断，点头称赞，对战术和精心实施伏击的威力有了更深刻的理解。
    
        //Give Xp
            ~ GiveSkillExperience("Leadership",1000)
            ~ GiveSkillExperience("Tactics",1000)
            ~ GiveSkillExperience("Roguery",1000)
    -> END

===TheCharge===
  温暖的火堆怀抱着围过来的士兵，在他们的脸上投下舞动的阴影。这时，一个身经百战的老兵开始滔滔不绝，他们听得全神贯注。

  “听好了，我的朋友们，”这位战士讲述上一次的战斗：“那天，我们沐浴在夕阳余辉中，战马迫不及待，蹄子刨着大地。随着一声雷鸣般的呐喊，我们发起了冲锋……”

  士兵们几乎可以感受到迎面而来的狂风和脚下隆隆不绝的马蹄声。这个故事生动地描绘了一幅团结和勇气的画面，让士兵们对骑术、武器使用以及协调冲锋的力量有了更深刻的理解。
    
    //Give Xp
        ~ GiveSkillExperience("Riding",1000)
        ~ GiveSkillExperience("Polearm",1000)
        ~ GiveSkillExperience("Leadership",1000)
    -> END 

===HoldingTheLine===
  篝火轻微噼啪，一名士兵的声音充满了决心。火焰的光芒也映照着听众们的决心。

  “仔细听，朋友们，”士兵坚定不移地说道，“我必须说说我们背水一战的故事。当时情况十分危急，亡灵大军大军压境，稳步推进。我们坚守阵地，紧握盾牌，顽强防守……”

  士兵们感受到了一种团结的力量，仿佛他们与故事中的勇士并肩而立。讲述者的话强调了统御和战术的重要性，让士兵们对防御有了更深的体会。
    
    //Give Xp
            ~ GiveSkillExperience("Scouting",1000)
            
            ~ GiveSkillExperience("Tactics",1000)
            
            {MeleeWeaponRandom:
                    -1:
                        ~ GiveSkillExperience("OneHanded",1000)
                    -2:
                        ~ GiveSkillExperience("TwoHanded",1000)
                    -3:
                        ~ GiveSkillExperience("Polearm",1000)
                }
    -> END

===TheBrawl===
  篝火闪烁，一个士兵大声讲述友情和竞争的故事。笑声与火焰的噼啪声交织在一起，士兵们凑了过来，急切地想听他讲故事。

  “啊，我的战友们，”士兵笑着说，“让我来给你们讲讲上次训练时发生的事情吧！那是一个欢乐的夜晚，也是一场激烈的较量。我们玩命地测试自己的能力，每一次出击和招架都是一次技巧的舞蹈……”

  士兵们投来了会心的一瞥，脑海中浮现出他们对训练的回忆。讲述者强调了友情的力量和近战技巧的教训，给士兵们留下了宝贵的经验。
    
    //Give Xp
            ~ GiveSkillExperience("OneHanded",1000)
            ~ GiveSkillExperience("TwoHanded",1000)
            ~ GiveSkillExperience("Polearm",1000)
    -> END

===TheShootout===
  篝火温暖的怀抱中，一个士兵的声音里充满期待。他的同伴们静下心来聆听时，他们的眼中闪烁着火焰。

  “朋友们，听好了。”士兵开始讲述，“想象一下，乌云密布，野兽人浩浩荡荡，我们的军团万箭齐发，为战场搭建好了舞台。弓箭、弩箭、投掷标枪和火炮占据舞台的中央……”

  士兵们交头接耳，脑海中生动地描绘着箭矢和弹丸在空中翱翔的场景。讲述者强调了远程战斗的复杂性，让士兵们对各种远程武器技能有了更深刻的理解。
    
    //Give Xp
            ~ GiveSkillExperience("Bow",750)
            ~ GiveSkillExperience("Crossbow",750)
            ~ GiveSkillExperience("Throwing",750)
            ~ GiveSkillExperience("Gunpowder",750)
    -> END

===GreatRulers===
  在篝火的温暖光辉中，一群士兵就旧世界的伟大统治者展开了热烈的讨论。他们的声音中带着钦佩和尊敬，他们的故事中交织着领导才能和治国之道。

  一位士兵首先发言，他的声音充满了崇敬：“让我们来谈谈塑造了我们这片土地的传奇统治者。上次我听说，伟大的皇帝卡尔·弗朗茨很好地维护了他的声誉，因为治理国家需要付出很多……”

  随着时间流逝，士兵们思考着这些统治者的卓越品质——他们善于管理，精与统治以及有团结臣民的魅力。他们对管理、统御和魅力的重要性深信不疑，让他们对权力带来的责任有了更深刻的理解。
    
    //Give Xp
            ~ GiveSkillExperience("Steward",1000)
            ~ GiveSkillExperience("Leadership",1000)
            ~ GiveSkillExperience("Charm",1000)
    -> END

===Craftsman===
  篝火周围，气氛甚是热烈，一群士兵交流着手工艺术和工程奇迹的故事。在讲述细致入微的工匠大师和巧夺天工的工程师的壮举时，他们的声音中充满了敬畏和钦佩。

  “听仔细了，同志们，”一名士兵催促道，“知道这个的人不多，但我有幸从一个矮人那里学到了工程学。矮人城堡是工程艺术的结晶……”

  随着故事的展开，士兵们惊叹于复杂的设计和推动这些壮举的纯粹智慧。他们的讨论深入到了铁匠、工程师们的奇思妙想所带来的的奇迹，让他们对这些重要的行业有了新的认识。
    
    //Give Xp
            ~ GiveSkillExperience("Smithing",1500)
            ~ GiveSkillExperience("Engineering",1500)
    -> END

===Negotiation===
  火光闪烁，一群士兵相互倾诉交涉和贸易的故事。当他们分享成功的谈判和有趣的意外时，笑声如潮。

  “啊，我的同志们，”一位士兵笑着说，“让我来分享一下交涉的艺术和贸易的技巧。从与狡猾的半身人讨价还价，到面对精明的马丽恩堡商人，公平交易的道路上充满了智慧和欺骗……”

  士兵们听得津津有味，他们被旧大陆熙熙攘攘的市场，和集市上发生或机智或戏谑的故事所吸引。他们思考着魅力、贸易和偶尔失误之间的微妙平衡，对谈判的艺术有了更深的理解。
    
    //Give Xp
            ~ GiveSkillExperience("Charm",1000)
            ~ GiveSkillExperience("Trade",1000)
            ~ GiveSkillExperience("Roguery",1000)
    -> END

===Traveling===
  围着篝火，一群士兵分享着他们骑马旅行的故事和经历。讲到穿越险恶地形的旅程和与旧世界居民的遭遇时，声音中充满了冒险的兴奋和友爱的关切。

  一名士兵说：“保养战马是一项严峻的挑战。骑手和骏马之间的纽带是与众不同的……”

  故事编织出冒险的织锦，士兵们被带到了遥远的国度和桀骜不驯的荒野。他们思考着骑马的技巧以及骑手和坐骑之间牢不可破的纽带，对骑马旅行的艺术有了更深的理解。
    
    //Give Xp
            ~ GiveSkillExperience("Riding",1500)
            ~ GiveSkillExperience("Athletics",1500)
    -> END
    
===Survival===
  在噼噼啪啪的篝火声中，一群士兵分享了他们对野外生存的见解。他们讲述了面对大自然挑战时的机智和耐力，他们的声音带着饱经风雨的重量。

  “各位注意注意，”一名士兵开了口，他的声音沉稳而自信，“因为我将传授如何在最茂密的野林中正确生存。从觅食，到穿越密林，到淌过沼泽，关键在于了解这片土地的节奏……”

  随着故事展开，士兵们已然陶醉于生存的艺术当中，学会了解读自然的迹象，适应自然的要求。这些故事强调了医术、侦察和跑动的重要性，让士兵们对野外这个无情却令人向往的世界产生肃然起敬。
    
    //Give Xp
            ~ GiveSkillExperience("Medicine",1000)
            ~ GiveSkillExperience("Scouting",1000)
            ~ GiveSkillExperience("Athletics",1000)
    -> END


-> END


























