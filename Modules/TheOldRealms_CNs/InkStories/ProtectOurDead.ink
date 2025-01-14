//Global story tags
# title: 死而瞑目
# frequency: Uncommon
# development: true
# illustration: campfirenight

INCLUDE include.ink

VAR PlayerWin = false
VAR PartyCanRaiseDead = false
            ~ PartyCanRaiseDead = PartyHasNecromancer(false)
VAR RaiseDeadSkillCheckTest = false
            ~ RaiseDeadSkillCheckTest = perform_party_skill_check("Spellcraft", 25)
//Scenarios notes
    //Rarity: COMMON
    //Repeatable: YES
    
    //Restrictions
        //Terrain: Empire, Bretonnia, Telia, Estalia, or Border Princes culture
    
    //Triggers:
        //While travelling on campaign map
    
    //Scenario Explanation
    
        //Main: You are traveling and a peasant asks you to rid the local graveyard of a necromancer.
		// Rewards: faith exp + small amount of gold or skeleton troops + staff.

->START

===START===
整天的行军后，你的士兵正准备安营扎寨。但你清楚在日落之后，尤其是午夜时分，这里会变得非常危险。 #STR_Start1
这时，你的士兵厉声呵斥一名正在走来的当地村民。他似乎没有携带武器。 #illustration: stranger #STR_Start2
这名男子解释说，一名近期而来的亡灵法师，在村里的墓地里复活死者。虽然这个村子很穷，但他们会给任何杀死亡灵法师的人一笔微薄的奖励。 #STR_Start3 
-> choices

    =choices
    *[我们会帮你杀掉这个亡灵法师的。] ->accept
    *[太可恶了，这些骷髅本为我所用！] ->accept
    *[下次再说吧，我们还有更重要的事情要做。] -> deny
    
    =accept
    村里人说，这个亡灵法师每晚都会带着几具骷髅。你决定就在墓地里偷袭他。  #STR_Accept1
    
    ->enterArena
    
    =deny
    ->END

    =enterArena
    //~ OpenGraveyardMission()
    ...
    {PlayerWin: 感谢insert_deity_name，亡灵法师死了。 #STR_PlayerWin1}

    ->BattleResult
    
===BattleResult===
        *[返回村庄领取奖励 {GiveGold(500)}{GiveSkillExperience("Faith",1000)}]
		-> END
		
        //Necromancer option
        *{PartyCanRaiseDead}[尝试控制骷髅为你所用。 {print_party_skill_chance("Spellcraft", 25)}]
                {RaiseDeadSkillCheckTest: -> raiseSucceed | -> raiseFail}
    
        =raiseSucceed
        复活死者后，你搜刮了亡灵法师身上任何有价值的东西。 {GiveItem("tor_vc_weapon_staff_nm_001", 1)} #STR_HelpNecromancerSuccess
            
            ~ChangePartyTroopCount("tor_vc_skeleton",8)
            -> END
        
        =raiseFail
        虽然你复活失败了，但至少还有亡灵法师的法杖。 {GiveItem("tor_vc_weapon_staff_nm_001", 1)} #STR_HelpNecromancerFail
            -> END