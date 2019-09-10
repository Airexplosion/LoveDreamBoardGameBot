﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Native.Csharp.App.Event.Event_Me
{
    /// <summary>
    /// 帮助指令
    /// </summary>
    public static class Event_HelpDescription
    {
        public static string helpDescription(string input)
        {
            string helpCommand = input.Substring(3).Trim();//参数
            string helpReturn = $@"{helpCommand}不是固有指令！";
            switch (helpCommand.Substring(0, 2))
            {
                case "计算":
                    helpReturn = @"进行带mod运算的四则运算。支持e和π。
.计算 [算式]
范例：'.计算 (3+5)*2*π'";
                    break;
                case "骰子":
                    helpReturn = @"投掷若干枚自定义面数的骰子，并计算总点数。
.骰子 [数量*] [面数!]
数量：指示骰子的枚数，约束在1~999。不填则默认为'1'。
面数：指示骰子是几面骰，约束在1~999。
范例：'.骰子 2 6'";
                    break;
                case "创建":
                    helpReturn = @"创建1个可放置元素和记录文本的区域。
.创建 [区域]
范例：'.创建 私密牌堆'
值得一提的是，大部分指令紧接的后一个参数可以不使用空格分隔，如'.创建私密牌堆'。";
                    break;
                case "销毁":
                    helpReturn = @"销毁1个区域。
.销毁 [区域]
范例：'.销毁 竞技场'";
                    break;
                case "清空":
                    helpReturn = @"清空1个区域。
.清空 [区域]
范例：'.清空 怪兽卡区域'";
                    break;
                case "添加":
                    helpReturn = @"添加若干张牌进入区域末端。
.添加 [区域!] [牌名] [牌名*]
牌名：指示需要添加到区域末端的卡牌名称。多个牌名可用空格关联。
范例：'.添加 手牌 幸运币 伪造的幸运币'";
                    break;
                case "删除":
                    helpReturn = @"删除区域中对应牌名的最前端卡牌各1张。
.删除 [区域!] [牌名] [牌名*]
范例：'.删除 手牌 幽灵铠甲 进阶之灾'";
                    break;
                case "插入":
                    helpReturn = @"创建若干张牌，并将其插入到区域的任意位置。
.插入 [区域] [序号] [牌名] [牌名*]
序号：指示你决定将这些卡牌插入到区域的第几张卡牌之前，最小为'1'，可填'随机'。
牌名：指示需要插入到区域中的卡牌名称。多个牌名可用空格关联。
范例：'.插入 战场 2 阿古斯防御者'";
                    break;
                case "移除":
                    helpReturn = @"移除区域的第X张牌。
.移除 [区域] [序号]
序号：指示你意图移除区域第几张牌，最小为'1'，可填'随机'。
范例：'.移除 怪兽卡区域 3'";
                    break;
                case "抽牌":
                    helpReturn = @"将某区域前端的若干张卡牌移动到另一个区域的末端。
.抽牌 [旧区域!] [新区域!] [数量*]
旧区域：指示卡牌的来源区域。这个区域将失去最前端的X张牌。
新区域：指示卡牌的目标区域。卡牌将进入这个区域的末端。
数量：指示移动的卡牌数量，最小为'1'，不填则默认为'1'。
范例：'.抽牌 卡组 手牌 5'";
                    break;
                case "出牌":
                    helpReturn = @"从旧区域打出指定卡牌到新区域。
.出牌 [旧区域!] [新区域!] [牌名] [牌名*]
旧区域：指示卡牌的来源区域。这个区域将失去匹配牌名的随机卡牌。
新区域：指示卡牌的目标区域。卡牌将进入这个区域的末端。
牌名：指示需要打出的卡牌名称。多个牌名可用空格关联。
范例：'.出牌 手牌 战场 混沌法球'";
                    break;
                case "查看":
                    helpReturn = @"查看区域内容。
.查看 [区域!]
范例：'.查看 手牌'
特别地，当区域存在'假名【真名】'形式的卡牌名称，则只会显示'假名'。
这个形式可用于模拟盖牌，以及为卡牌添加不可见的标记。
这个形式的卡牌离开非私密区域时会揭示标记。";
                    break;
                case "洗牌":
                    helpReturn = @"将区域的所有卡牌打乱顺序。
.洗牌 [区域!]
范例：'.洗牌 私密牌堆'";
                    break;
                case "清点":
                    helpReturn = @"计算区域内的卡牌数量。
.清点 [区域!]
范例：'.清点 手牌'";
                    break;
                case "检索":
                    helpReturn = @"查找区域内包含关键字的卡牌并展示。
.检索 [区域] [字段] [所有*]
字段：指示你检索的关键字。
所有：输入'所有'则展示所有符合条件的对象，不填则展示随机1个符合条件的对象。
范例：'.检索 爆炸猫卡查 逗猫棒 所有'";
                    break;
                case "发现":
                    helpReturn = @"随机展示区域若干张不重复的卡牌。
.发现 [区域] [数量*]
数量：指示需要展示的卡牌数量，不填则默认为'3'。
范例：'.发现 对手手牌 2'
特别地，当区域不重复的卡牌数量不足时，则展示所有同名牌各1张。";
                    break;
                case "翻转":
                    helpReturn = @"将区域的牌序颠倒。
.翻转 [区域]
范例：'.翻转 卡组'";
                    break;
                case "去重":
                    helpReturn = @"合并区域的同名牌。
.去重 [区域]
范例：'.去重 千秋戏'";
                    break;
                case "转化":
                    helpReturn = @"将区域最前端1张或所有的指定卡牌转化为另一个名称。
.转化 [区域!] [旧牌名] [新牌名] [所有*]
旧牌名：指示需要转化的卡牌名称。
新牌名：指示转化后的卡牌名称。
所有：输入'所有'则转化所有符合条件的卡牌，不填则转化区域最前方的1张卡牌。
范例：'.转化 手牌 旋风 盖牌【旋风】'";
                    break;
                case "复制":
                    helpReturn = @"创建1个区域并从另1个区域复制内容。
.复制 [旧区域] [新区域]
范例：'.复制 初始牌组 牌组'";
                    break;
                case "属性":
                    helpReturn = @"记录或修改角色的属性。
.属性 [角色!] [键名:键值] [键名:键值*]
角色：指示你要记录或修改的角色名。使用'!'补全时，这个参数会补全为你的QQ号。
键名：指示角色某项属性的名称。'键名:键值'间使用空格来关联。
键值：指示角色某项属性的数据。冒号可替换为'+-*/'四则运算符进行键值的修改。
范例：'.属性
HP:10
MP-3
AP*2'
值得一提的是，所有指令的参数都能使用回车代替空格分隔。";
                    break;
                case "导入":
                    helpReturn = @"将CSV格式的文本导入到区域末端。
.导入 [区域] [文本]
文本：文本的行格式为：'[牌名],[数量]'
牌名：指示需要导入到区域末端的卡牌名称。
数量：指示需要导入几张牌。
范例：'.导入 卡组
旋风,3
大风暴,1
大龙卷,3
热带低气压,1
大寒波,2'";
                    break;
                case "开始":
                    helpReturn = @"开始1局游戏，自动绑定你的默认牌库、手牌、桌面和默认骰子面。绑定后，将'.'替换为'!'，可以自动补全部分指令
（骰子、添加、删除、抽牌、出牌、查看、转化、属性）
.开始 [游戏名]
范例：'.开始 心灵同步'
绑定后，可以简化操作如下：
.骰子 20
!骰子
.添加 手牌 幸运币
!添加 幸运币
.抽牌 卡组 手牌 5
!抽牌 5
.出牌 手牌 战场 混沌法球
!出牌 混沌法球
.属性 858271917 骰子:100
!属性 骰子:100
想要修改绑定的信息，可以使用'开始'指令重新初始化，也可使用'属性'指令对某项绑定对象进行修改。";
                    break;
                case "棋盘":
                    helpReturn = @"打开1个公共可写的石墨表格作为棋盘。
.棋盘 [房间号]
房间号：指示你需要打开的房间号，约束在0~9。
范例：'.棋盘 2";
                    break;
                case "变量":
                    helpReturn = @"设置1个变量，变量在所有指令中优先被解释。
.变量 [变量名] [字符串/【区域】/删除]
变量名：指示设置的变量名称。使用成对的英文方括号将变量名括起才能使用。
字符串：变量名的后1个参数可输入。输入一个字符串，字符串会被赋值给变量，如范例所示。
【区域】：变量名的后1个参数可输入。使用成对的中文方括号括起区域名，对应区域的内容将会读取并赋值给变量。
删除：变量名的后1个参数可输入。删除指定名称的变量。
范例：'.变量 Var 看新世'
'.查[Var]界'会被解释为'.查看新世界'并执行。
在指令扳机前输入'~'如：'~.查看[var]'可以开启变量延迟解释，用于解释定义复合指令中的变量。
变量非常适合搭配'如果'指令使用。";
                    break;
                case "定义":
                    helpReturn = @"自定义1个新指令。新指令会自动执行'#'后的每条指令。
.定义 [添加/删除] [.新指令 甲 乙 丙]#[.指令 甲 乙]#[.指令 甲 丙*]
添加/删除：指示了需要添加还是删除指令。删除指令时不需要输入指令参数，如：'.定义 删除 .抽指定牌'。
新指令 甲 乙 丙：新指令为自定义指令名；甲乙丙为自定义指令的参数。参数的个数必须为正整数。
指令 甲 乙：指示被自定义指令执行的复合指令中的1个指令。自定义指令执行时，子指令的参数会被转义为自定义指令的参数。指令之间用'#'连接。
范例：'.定义 添加 .抽指定牌 牌名#.出牌 私密套牌 手牌 牌名#.检索 手牌 牌名'
'.定义 删除 .抽指定牌'
特别地，你可以忽略'定义'和'如果'指令中指令名前的'.'扳机，而程序会为你自动补全：
'.定义 添加 抽指定牌 牌名#出牌 私密套牌 手牌 牌名'
但是如果你希望将结果私发，只能手动输入指令中所有的扳机：
'.定义 添加 抽指定牌 牌名#..出牌 私密套牌 手牌 牌名''";
                    break;
                case "如果":
                    helpReturn = @"如果表达式的结果大于/小于/等于/不等于指定值，执行'?'后的每条指令。
.如果 [表达式] [>/</=/!] [数值]?[指令 甲 乙]?[指令 甲 丙*]
表达式：表达式应为四则运算式子。表达式支持环境变量'骰子'和'清点'，它们的值为上次'骰子'和'清点'指令的结果。
>/</=/!：指示了比较符，代表的含义分别为大于、小于、等于、不等于。如果比较的结果为'真'，执行'?'后的每条指令。
数值：指示了比较的对象。这个参数限制为纯数。
指令 甲 乙：复合指令的子指令。可参考'定义'指令。
范例：'.如果 (骰子+1)*2 > [Var]?.添加 骰池 骰子?.清点 骰池'
'[变量名]'的形式表示这是一个自定义变量，详情参考'变量'指令。
如果你希望将结果私发，只需要在指令而非子指令前连发两次扳机，这点与'定义'指令不同。
'如果'指令非常适合嵌入到'定义'指令中使用。";
                    break;
                case "清理":
                    helpReturn = @"需要群主权限。清理若干天前创建的所有数据。
.清理 [天数]
天数：指示清理多少天前创建的所有数据。限制为非0自然数。
范例：'.清理 90'
为了其他玩家的游戏体验，强烈建议您不要清理90天以内的数据。";
                    break;
                case "退群":
                    helpReturn = @"需要管理员权限。使机器人退群。
.退群 [QQ号*]
QQ号：输入QQ号使对应的1个机器人退群，不填则使所有机器人退群。
范例：'.退群 858271917'
将机器人踢出群可能导致账户冻结，请使用这个指令使机器人安全退群。";
                    break;
                case "开启":
                    helpReturn = @"结束机器人的关闭状态。
.开启 [QQ号*]
QQ号：输入QQ号使对应的1个机器人开启，不填则使所有机器人开启。
范例：'.开启 858271917'
将机器人禁言可能导致账号数据异常，请使用这个指令开关机器人。输入QQ号开关群内对应的1个机器人。关闭期间不会处理群聊指令";
                    break;
                case "关闭":
                    helpReturn = @"结束机器人的开启状态。
.关闭 [QQ号*]
QQ号：输入QQ号使对应的1个机器人关闭，不填则使所有机器人关闭。
范例：'.关闭 858271917'
将机器人禁言可能导致账号数据异常，请使用这个指令开关机器人。输入QQ号开关群内对应的1个机器人。关闭期间不会处理群聊指令";
                    break;

                default:
                    break;
            }
            return helpReturn;
        }
    }
}
