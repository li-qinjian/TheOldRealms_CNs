//Global story tags
# title: 旅行商人
# frequency: Abundant
# development: false
# illustration: trader

INCLUDE include.ink

->START

===START===
当你沿着尘土飞扬的道路上前行时，眼前出现了一道独特的风景线——五颜六色的商队篷车，幽静之地的流动商店。
你好奇的靠了过去，一位旅行商人迎面向你走来。他面带微笑，滔滔不绝讲述遥远国度的故事，并邀请你参观他的商品。
->choices
    
    =choices
    +[浏览他的商品]
        ~ OpenInventoryAsTrade()
    ->AfterShopping
    *[继续你的旅行（离开）] 你决定还是赶路为好。->END

===AfterShopping===
在你饱览商人五花八门的奇珍异宝之后，他恭敬地低下头，对你的欣赏和购买表示感谢。
    -> END
