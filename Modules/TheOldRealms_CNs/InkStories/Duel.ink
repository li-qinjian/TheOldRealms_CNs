//Global story tags
# title: 刀锋艺术
# frequency: Special
# development: false
# illustration: roadpoint2

INCLUDE include.ink

VAR PlayerWin = false
VAR MetBefore = true
    ~ MetBefore = GetPlayerHasCustomTag("MetVittorio")
VAR DeniedBefore = true
    ~ DeniedBefore = GetPlayerHasCustomTag("DeniedVittorio")
    
    ~ SetTextVariable("MetBefore",MetBefore)
    ~ SetTextVariable("DeniedBefore1",DeniedBefore)
    ~ SetTextVariable("DeniedBefore2",DeniedBefore)
    ~ SetTextVariable("MetBefore2",MetBefore)

->START

===START===
当你沿着蜿蜒的道路继续旅行时，微风的轻声低语伴随着你的每一步。
突然，逼近的脚步声引起了你的注意。抬头一看，{not MetBefore: 你发现一个神秘的身影自信地走近。当他靠近时，你的目光被一把精美制作的细剑的闪光所吸引。陌生人停在你面前，脸上带着温暖的笑容，审视着你。}{MetBefore: 你发现了熟悉的身影，著名的提利尔剑客维托里奥·德卢卡以自信的步伐向你的团队走来。{not DeniedBefore: 记忆中的前一次相遇涌上心头，第一次决斗的激动仍然在你的脑海中挥之不去。}} #illustration: stranger
{not MetBefore: "啊，能在这条孤寂的道路上遇到一群值得尊敬的战士，真是运气之至。" 他们说道。 "我是来自遥远的提利尔之地的剑术大师维托里奥·德卢卡。我走遍了天涯海角，寻找能够与我在战斗中匹敌的对手。现在，命运将我带到了你们面前。愿意以友谊之名来证明你的剑术吗？我们可以加入一点赌注，让它变得更加有趣。"}
{MetBefore:当维托里奥走近时，你的目光被一把精美制作的细剑的闪光所吸引，他脸上洋溢着温暖的笑容，他评估着你。"啊，能在这条孤寂的道路上再次相遇，真是幸运之至，" 他说道，声音中带着一丝玩味的语气。 "我看得出你作为一位战士的火焰在燃烧。{not DeniedBefore:愿意再次在一场比赛中证明你的剑术吗？"} {DeniedBefore:愿意这次再来证明你的剑术吗？}}
~ SetPlayerCustomTag("MetVittorio")
-> choices

=choices
*[接受挑战。] ->accept
*[以后再说把。我们没有时间浪费。] -> deny

=accept
{not MetBefore: 受到这个提议的吸引，你回以微笑，对他提出的赌注感到好奇。}
{not MetBefore: "带有赌注的决斗？我听着呢"你回答道，对这个想法持开放态度。}
{not MetBefore: 剑客的眼睛闪烁着期待，他解释了条件。"如果你赢了，我将给予你5000金币，作为对你技艺的肯定。如果我获胜，我只要求能有幸与你一较高下，没有其他要求。"}
眼中闪烁着兴奋的光芒，你接受了剑客的挑战，坚定的微笑浮现在你的脸上。"好吧"你说道，"我接受你的提议，维托里奥·德卢卡。让我们使这场决斗成为一个令人难忘的{MetBefore: once more}经历吧。"
当你的战友们为你欢呼时，你命令他们在路边扎营，将空地变成一个即兴的竞技场。#illustration: meadow
竞技场准备就绪，你走进中心，心怀激动地跳动着。你的战友们围成一圈观看比赛，他们的表情充满了兴奋和自豪。
->enterArena

=deny
~ SetPlayerCustomTag("DeniedVittorio")
维托里奥的表情依然从容，但他嘴角微微上扬，露出一丝傲慢的笑容。
"可惜，"他回答道，声音中带着一丝轻蔑。“我本希望能找到一个值得我花费时间的人，但看来关于你的威名被夸大了。”
维托里奥·德卢卡以一种傲慢的优雅结束了这次相遇，鞠了一个轻蔑的躬，他的举止流露出无可置疑的优越感。
->END

=enterArena
~ OpenDuelMission()
...
{PlayerWin: 当剑的交击声渐渐消散时，你战友们的欢呼声充满了空气，在你艰苦战斗胜利的余波中回荡着。 {SetPlayerCustomTag("DefeatedVittorio")}}
{PlayerWin: 你站在临时搭建的战斗场中心，胸膛急促地起伏着，胜利的喜悦充盈着你的心。提利尔著名剑客维托里奥·德卢卡伸出手，表示尊重，他脸上洋溢着真诚的微笑。"战得漂亮，"他说道，声音中充满了敬佩之情。}
{PlayerWin: 你和维托里奥之间的友谊中，在他承认他的赌注，慷慨地奉上5000第纳尔，并赞赏你的技艺的时候得到了巩固。{GiveGold(5000)}} 
{not PlayerWin: 随着决斗的结束，空气中弥漫着各种情绪。你的战友们默默地以尊敬的眼神注视着，著名的提利尔剑客维托里奥·德卢卡从这场激烈的比赛中胜出。}
{not PlayerWin:你退后一步，以赞赏的点头承认他的技艺。维托里奥站在临时搭建的战斗场中心，他的细剑在渐渐消失的光线中闪烁，胜利的微笑洋溢在他的脸上。"的确是一位强大的对手，"他说道，声音中带着对自己成就的自豪之情。"你勇敢地战斗了，但这次胜利是我的。"}
维托里奥·德卢卡向着你的队伍礼貌的告别。不管决斗的结果如何，他的优雅举止和言辞的优雅都没有改变。
->END
