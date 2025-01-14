//Global story tags
# title: 森林集市
# frequency: Uncommon
# development: false
# illustration: trader

INCLUDE include.ink

VAR HorsePrice = 2000
VAR FoodPrice = 10
VAR HorseBetPrice = 500
VAR HorseBetPayout = 2500
VAR WinHorseRace = 0
    ~ WinHorseRace = RANDOM(0,1)
VAR TurnipPrice = 50

-> Start

===Start===
当你的军队行进时，突然在一个空地上看到了一个令人惊讶的景象——一个热闹的集市，它被称为莫尔斯利布狂欢节。帐篷骄傲地矗立着，色彩在斑驳的阳光下跳动。笑声与马的喷鼻声交织在一起，构成了这个快乐聚会的核心。

商人们招手示意，他们的眼睛闪烁着淘气的光芒，以比卷轴上标准价格更低的折扣价兜售马匹。空气中飘荡着诱人的烤肉、起泡的啤酒和酸酸的葡萄酒的香气。在欢乐的人群中，一个农民咧嘴笑着，提供了一个奇怪的萝卜，奇怪地与著名的双尾彗星相似。只需一便士，你就有机会拥有这个奇妙的奇迹。
    ->choices

    =choices
    * [加入马市的人群。]->HorseStalls
    * [品尝集市的美食。]->FoodStalls
    * [在赛马中测试你的运气。]->HorseRaces
    * [检查那个奇怪的萝卜。]->Turnip
    * [继续穿越树林的旅程。]->Leave

===HorseStalls===
集市的中心在马市，哪里最为繁忙。傲慢的骏马翩翩起舞，它们的眼睛凶猛而野性。其中一匹马特别引起了你的注意。它有着光滑的乌黑被毛，在阳光下闪闪发光，它的眼睛似乎有着一丝狡黠的闪光。
    ->choices

    =choices
    + [按照商人的价格购买这匹马。({HorsePrice} gold)]->BuyHorse
    * [劝说商人降低价格。 {print_player_skill_chance("Charm",150)}]->PersuadeMerchant
    * [回到集市的中心。]->Start.choices

===BuyHorse===
{HasEnoughGold(HorsePrice): 你与商人达成了交易。你用第纳尔交换了坚固的马鞍和缰绳。兴奋涌上心头，你骑上了这匹马。你们之间的联系是立即建立的，这匹马似乎对你的触摸充满了信任和渴望。 {GiveGold(-HorsePrice)} {GiveItem("t2_empire_horse",1)} | 你没有足够的第纳尔。}

* [返回狂欢节]->Start.choices

===PersuadeMerchant===
{perform_player_skill_check("Charm",150): -> success | -> fail}

    =success
    你的话语像是具有魔力，商人同意将价格降低50%。商人嘟囔着，但对你的谈判技巧表示尊重。
    ~HorsePrice = 1000
    ->HorseStalls.choices

    =fail
    尽管你尽力讨价还价，但商人仍然坚持原价。
    ->HorseStalls.choices
    

===FoodStalls===
香气缭绕、诱人无比，引导着你来到一场美食盛宴。肉类嗞嗞作响，麦酒泡沫盈满——一场感官的狂欢。这里有丰富的食物可供选择，你可以选择享用。

* [沉醉于集市的盛宴中。 ({FoodPrice} gold)]->BuyFood
* [继续前行，抵制诱惑。]->Start

===BuyFood===
{HasEnoughGold(FoodPrice): 纵情享受。你大快朵颐，集市的美食在你的舌尖上奏响了一曲愉悦的交响乐。商人们对你的参与表示赞许。{GiveGold(-FoodPrice)} | 你没有足够的第纳尔。}

* [返回狂欢节。]->Start.choices

===HorseRaces===
一个露天赛场里爆发出欢呼声。马儿奔腾，骑手们驱策着它们去追求荣耀。
->choices

    =choices
    * [在一匹赛马上下注。({HorseBetPrice} 第纳尔 - 赢取 5 倍赔率)]->PlaceBet
    * [你决定不测试运气。]->Start.choices

===PlaceBet===
{not HasEnoughGold(HorseBetPrice): 你没有足够的第纳尔。 -> HorseRaces.choices}
~GiveGold(-HorseBetPrice)
{WinHorseRace: ->success | ->fail}
    =success
    你心潮澎湃地下了注。你下注的马风驰电掣并拿下了第一名，运气之神在向你微笑。周围尽是笑声和金币的叮当声。
    ~ GiveGold(HorseBetPayout)
    * [返回狂欢节。]->Start.choices

    =fail
    你心潮澎湃地下了注。你下注的马一马当先，但其他骑手很快就追了上来。最终，你的马只能获得一个较后的名次。周围尽是笑声和金币的叮当声。
    
    * [返回狂欢节。]->Start.choices

===Turnip===
当你凝视着这颗彗星形状的萝卜时，神秘感涌上心头让你无法自拔——如此异想天开的奇迹！农民咧嘴笑着，邀请你参加一个抽奖活动。
    ->choices

    =choices
    * [用一张抽奖券试试运气。({TurnipPrice} 第纳尔)]->BuyTicket
    * [运用你的洞察力寻找关于这颗萝卜的隐藏线索。{print_player_skill_chance("Roguery", 80)}]->PerceiveTurnip
    * [继续前行，将这颗奇特的萝卜抛在身后。]->Start.choices

===BuyTicket===
{HasEnoughGold(TurnipPrice): 用一枚硬币和一个微笑，你获得了参加抽奖的机会。谁知道呢？这颗彗星之吻的萝卜也许会成为你的。 {GiveGold(-TurnipPrice)} | 你没有足够的金币。 -> Turnip.choices}

紧张而刺激的氛围中，抽奖活动开始了，当主持人喊出中奖号码时，你屏住呼吸满怀期待。然而，这次幸运之神并没有站在你这一边。中奖号码并不属于你，一丝失望涌上心头。

* [返回狂欢节。]->Start.choices

=== PerceiveTurnip ===
{perform_player_skill_check("Roguery", 80): -> success | ->fail}

    =success
    你用敏锐的目光注意到了其他人可能会忽略的细节。这颗颗萝卜似乎没有任何奇怪的标记，也没感受到任何独特的魔法。它——就是一根萝卜。
    ->Turnip.choices
    
    =fail
    你的观察没有发现这颗萝卜有什么异常之处。
    ->Turnip.choices

===Leave===
随着集市的欢乐逐渐消退，你踏入荒野的怀抱，将集市的欢笑留在身后。
->END
