﻿using System.Collections.Generic;
// 操作返回(为了区分与WINDOWS的HRESULT不同，所以不用HRESULT来做返回值)
public enum OPERATE_RESULT
{
	OR_OK								= 0,	// 成功
	OR_ERROR							= -1,	// 未知错误
	OR_DIE								= -2,	// 你已死亡
	OR_INVALID_SKILL					= -3,	// 无效技能
	OR_TARGET_DIE						= -4,	// 目标已死亡
	OR_LACK_MANA						= -5,	// MANA不足
	OR_COOL_DOWNING						= -6,	// 冷确时间未到
	OR_NO_TARGET						= -7,	// 没有目标
	OR_INVALID_TARGET					= -8,	// 无效目标
	OR_OUT_RANGE						= -9,	// 超出范围
	OR_IN_RANGE							= -10,	// 距离太近
	OR_NO_PLATFORM						= -11,	// 没有操作平台
	OR_OUT_PLATFORM						= -12,	// 离操作平台太远
	OR_NO_TOOL							= -13,	// 没有操作工具
	OR_STUFF_LACK						= -14,	// 缺少材料
	OR_BAG_OUT_OF_SPACE					= -15,	// 背包缺少空间
	OR_WARNING							= -16,	// 理论上这些错误将被客户端过滤，所以如果出现，可能来自于一些外挂
	OR_BUSY								= -17,	// 正在做其它事情
	OR_MISSION_HAVE						= -18,	// 已经拥有该任务
	OR_MISSION_LIST_FULL				= -19,	// 任务记录已满
	OR_MISSION_NOT_FIND					= -20,	// 没找到该任务
	OR_EXP_LACK							= -21,	// 熟练度不够
	OR_CHAR_DO_NOT_KNOW_THIS_SKILL		= -22,	// 角色还不会这种技能
	OR_NO_SCRIPT						= -23,	// 目标角色无脚本
	OR_NOT_ENOUGH_HP					= -24,	// 没有足够的生命值
	OR_NOT_ENOUGH_RAGE					= -25,	// 没有足够的怒气值
	OR_NOT_ENOUGH_STRIKE_POINT			= -26,	// 没有足够的连击点
	OR_NOT_ENOUGH_ITEM					= -27,	// 没有足够的道具
	OR_NOT_ENOUGH_VIGOR					= -28,	// 没有足够的活力
	OR_NO_LEVEL							= -29, 	// 技能等级不够
	OR_CANNOT_UPGRADE					= -30,	// 宝石无法再升级
	OR_FAILURE							= -31,	// 操作失败
	OR_GEM_CONFLICT						= -32,	// 一件装备上不允许装备同类型的宝石
	OR_NEED_IN_FURY_STANCE				= -33,	// 需要在狂暴状态下使用
	OR_INVALID_TARGET_POS				= -34,	// 无效目标点
	OR_GEM_SLOT_LACK					= -35,	// 缺乏宝石插口
	OR_LIMIT_MOVE						= -36,	// 无法移动
	OR_LIMIT_USE_SKILL					= -37,	// 无法使用技能
	OR_INACTIVE_SKILL					= -38,	// 使用尚未激活的技能
	OR_TOO_MUCH_HP						= -39,	// HP大于限定数值
	OR_NEED_A_WEAPON					= -40,	// 需要一把武器
	OR_NEED_HIGH_LEVEL_XINFA			= -41,	// 等级不够
	OR_NEED_LEARN_SKILL_FIRST			= -42,	// 尚未学会此技能
	OR_NEED_MENPAI_FOR_LEVELUP			= -43,	// 你必须拜师进入一个门派才能继续升级
	OR_U_CANNT_DO_THIS_RIGHT_NOW		= -44, 	// 你现在无法这样做
	OR_ROBOT_TIMEOUT					= -45,  // 挂机时间超时
	OR_NEED_HAPPINESS					= -46,  // 你的宠物快乐度不足60，不能出战，需要驯养
	OR_NEED_HIGH_LEVEL					= -47,	// 你的等级不够
	OR_CANNOT_GETEXP					= -48,	// 你的宠物已无法得到经验
	OR_NEED_LIFE						= -49,  // 你的宠物寿命为0，无法再召唤，请为其增加寿命
	OR_EXP_FULL							= -50,  // 您的经验已经到达上限
	OR_TOO_MANY_TRAPS					= -51, 	// 无法设置更多的此类陷阱
	OR_PET_PLACARD_ISSUE_FAILED			= -52,	// 发布失败
	OR_PET_PLACARD_NOT_APPOINT_PET		= -53,	// 未指定宠物
	OR_PET_PLACARD_ONLY_CAN_ISSUE_ONE	= -54,	// 对不起，同时只能发布一只宠
	OR_PET_PLACARD_NEED_PET_TYPE		= -55,	// 对不起，你的宠好像不是宝宝哦
	OR_PET_PLACARD_NEED_PET_LEVEL		= -56,	// 对不起，你的宠级别还不够哦
	OR_PET_PLACARD_NEED_PET_HAPPINESS	= -57,	// 对不起，你的宠快乐值不够高
	OR_PET_PLACARD_NEED_PET_LIFE		= -58,	// 对不起，你的宠寿命不够
	OR_NEED_IN_STEALTH_MODE				= -59,	// 需要在隐身状态下使用
	OR_NOT_ENOUGH_ENERGY				= -60,	// 对不起，你的精力不足
	OR_CAN_NOT_MOVE_STALL_OPEN			= -61,	// 无法在摆摊中移动
	OR_NEED_IN_SHIELD_MODE				= -62,	// 需要在护体保护下
	OR_PET_DIE							= -63,	// 你的宠物已经死亡
	OR_PET_HADRECALL_NEEDHAPPINESS		= -64,	// 你的宠物快乐度不足60，已被收回
	OR_PET_HADRECALL_NEEDLIFE			= -65,	// 你的宠物寿命为0，已被收回
	OR_GEM_NOT_FIT_EQUIP				= -66,	// 这种宝石不能镶嵌在这种装备上
	OR_CANNOT_ASK_PETDETIAL				= -67,	// 你无法察看该宠物的信息
	OR_VARIANCEPET_CANNOT_RETURNTOCHILD = -68,  // 变异宠不能进行还童
	OR_COMBAT_CANNOT_RETURNTOCHILD		= -69,  // 出战宠不能进行还童
	OR_IMPASSABLE_ZONE					= -70,	// 不可走区域
	OR_NEED_SETMINORPASSWORD			= -71,	// 需要设置 二级密码
	OR_NEED_UNLOCKMINORPASSWORD			= -72,	// 需要解锁 二级密码
	OR_PETINEXCHANGE_CANNOT_GOFIGHT		= -73,	// 正在交易的宠物无法出战
	OR_HASSPOUSE_CANNOT_RETURNTOCHILD	= -74,  // 已经有配偶的宠物不能还童
	OR_CAN_NOT_FIND_SPECIFIC_ITEM		= -75,	// 缺少指定物品
	OR_HOUSE_SLOT_IS_EMPTY				= -76,	// 需要先装备座骑
	OR_NEED_EQUITATION_FIRST			= -77,	// 需要先学会相应的骑术
	OR_USE_A_DAMAGED_EQUIPMENT			= -78,	// 装备已经损坏
	OR_EQUIPMENT_DAMAGED				= -79,	// 装备已经损坏
	OR_PET_PROCREATE_HAE_REGISTER				= -80,	// 双方中有一人的珍兽已经在此繁殖，不能同时繁殖1个以上的珍兽
	OR_PET_PROCREATE_NO_LOCALITY				= -81,	// 已经没有空位了
	OR_PET_PROCREATE_NEED_BABY_PET				= -82,	// 双方珍兽必需都是珍兽宝宝
	OR_PET_PROCREATE_NEED_SAME_PHYLE			= -83,	// 双方珍兽必需是同类
	OR_PET_PROCREATE_NEED_GENERATION			= -84,	// 双方珍兽必需都是一代珍兽
	OR_PET_PROCREATE_NEED_HAPPINESS				= -85,	// 双方珍兽快乐度必需为满值
	OR_PET_PROCREATE_NEED_SEX					= -86,	// 双方珍兽必需为异性
	OR_PET_PROCREATE_NEED_LEEL_DIFFERENCE		= -87,	// 双方珍兽等级差必需小于5
	OR_PET_PROCREATE_NEED_SPOUSE				= -88,	// 双方珍兽必需无配偶或互为配偶
	OR_PET_PROCREATE_NEED_MONEY					= -89,	// 金钱不够
	OR_PET_PROCREATE_NEED_NO_FIGHT_STATE		= -90,	// 双方珍兽必需都未出战
	OR_PET_PROCREATE_NEED_LIFE					= -91,	// 双方珍兽寿命必需大于1000
	OR_PET_PROCREATE_ERROR_REGISTER				= -92,	// 双方中有一人并没有珍兽在此繁殖
	OR_PET_PROCREATE_NO_FINISHED				= -93,	// 繁殖还未完成
	OR_PET_PROCREATE_HUMAN_PET_LIST_NO_SPACE	= -94,	// 双方有一个人珍兽列表没有足够的空间
	OR_PET_PROCREATE_NEED_2TEAMMEMBER			= -95,	// 必需要两人组成才可以
	OR_PET_PROCREATE_TEAMMEMBER_TOO_FAR			= -96,	// 另一个队员离你太远了
	OR_PET_PROCREATE_NEED_LEEL					= -97,	// 必需达到相应等级
	OR_PET_PROCREATE_NEED_DISTANCE_LEVEL		= -98,	// 与上一次繁殖的时间间隔必需到达20
	OR_PET_PROCREATE_NEED_LEADER				= -99,	// 必需是队长才能有这种操作
	OR_CANNOT_TAKE_MOREPET						= -100,	// 现在不能携带更多的珍兽
	OR_CALLOFHUMAN_NOTSAMESCENE					= -101,	// 你不在普通场景且目标和你不在同一场景
	OR_DRIDE_INVALID_ACCETP						= -102,	// 目标已经取消了对你的邀请
	OR_DRIDE_NOT_RIDE_MOUNT						= -103,	// 邀请者并没有骑上坐骑
	OR_DRIDE_TARGET_MUST_NOT_RIDE_MOUNT			= -104,	// 被邀请者必需没有骑上坐骑
	OR_DRIDE_TARGET_MUST_IDLE					= -105,	// 被邀请者必需为休闲状态
	OR_DRIDE_OUT_RANGE							= -106,	// 被邀请者与你的距离太远
	OR_DRIDE_TARGET_MUST_NOT_CHANGED_MODEL		= -107,	// 被邀请者必需不能变身
	OR_DRIDE_TARGET_MUST_NOT_BY_BUS				= -108,	// 被邀请者必需不能在坐骑上
	OR_DRIDE_MUST_NOT_TEAM_FOLLOW				= -109,	// 邀请者必需不能在组队跟随状态
	OR_DRIDE_TARGET_MUST_NOT_TEAM_FOLLOW		= -110,	// 被邀请者必需不能在组队跟随状态
	OR_REVENGE_NEED_TARGET_ONLINE				= -120,	// 查找不到该玩家
	OR_REVENGE_NEED_TARGET_LEVEL				= -121,	// 对方等级太低
	OR_REVENGE_NOT_TARGET						= -122,	// 你并没有仇杀目标
	OR_REVENGE_NEED_LEVEL						= -123,	// 江湖太危险，还不大适合你
	OR_REVENGE_NEED_PKVALUE						= -124,	// 你杀气太重，还是收手吧
	OR_REVENGE_NEED_NO_TARGET					= -125,	// 你还是先了了现有的仇恨吧
	OR_REVENGE_NEED_COOLDOWN					= -126,	// 你今天已经积累了太多仇恨
	OR_REVENGE_NEED_UNLOCK_PASSWORD				= -127,	// 危险操作，请先打开二级密码
	OR_REVENGE_INVALID_TARGET					= -128,	// 你不能仇杀指定目标
	//												  ,
	OR_CANTDO_DIE								= -130,	// 你已经死亡，无法那样做
	OR_CANTDO_LIMIT_MOVE						= -131,	// 你无法移动
	OR_CANTDO_TEAM_FOLLOW_LEADER				= -132,	// 你正处于组队跟随状态，无法那样做
	OR_CANTDO_TEAM_FOLLOW_MEMBER				= -133,	// 你正处于组队跟随状态，无法那样做
	OR_CANTDO_BUS_PASSENGER						= -134,	// 你现在无法那样做
	OR_CANTDO_BUS_CHAUFFEUR						= -135,	// 你现在无法那样做
	OR_CANTDO_MOUNT_PASSENGER					= -136,	// 你正在坐骑上，无法那样做
	OR_CANTDO_MOUNT_CHAUFFEUR					= -137,	// 你正在坐骑上，无法那样做
	OR_CANTDO_FOR_RIDING						= -138,	// 骑乘时无法进行这种操作
	OR_CANTDO_TERROR							= -139,	// 恐惧状态无法进行这种操作
	OR_CANTDO_INSTALL							= -140,	// 摆摊状态无法进行这种操作
	OR_PET_COMPOUND_BUSY						= -150,	// 你必需在站立状态下才能做
	OR_PET_COMPOUND_CANT_IN_SCENE				= -151,	// 出战珍兽不能合成
	OR_PET_COMPOUND_NEED_PET_LEVEL				= -152,	// 你的珍兽不够30级
	OR_PET_COMPOUND_CANT_VARIANCE				= -153,	// 变异珍兽不能合成
	OR_PET_COMPOUND_CANT_HAVE_SPOUSE			= -154,	// 已交配过的珍兽不能合成
	//OR_PET_PROCREATE_NO_FINISHED				= -155,	// 别急，你们的珍兽还未繁殖完毕
	//OR_PET_PROCREATE_HUMAN_PET_LIST_NO_SPACE	= -156,	// 对不起，你身上的背包空间不够2个
	OR_PET_NOTYOURPET                           = -157, // 这个珍兽目前不属于你，不能捕捉。
	OR_PET_PROCREATE_QUERY						= -158,	// 查询珍兽繁殖进度
	OR_HEALTH_IS_FULL							= -159,	// 生命值已满
	OR_MANA_IS_FULL								= -160,	// 内力值已满
	OR_SOMETHING_IN_THE_WAY						= -161, // 行进方向上有障碍物
	OR_PVP_MODE_SWITCH_DELAY					= -162,	// 从现在起，如果十分钟内不参与PK，您将自动进入和平模式
	OR_DUEL_CAN_NOT_FIND_USER					= -163,	// 查找不到该玩家或玩家不在线
	OR_DUEL_TARGET_LEVEL_LOW					= -164,	// 对方等级太低
	OR_DUEL_LEVEL_LOW							= -165,	// 您的等级太低, 决斗行为还不大适合你
	OR_DUEL_PKVALUE_OVER_LIMIT					= -166, // 你杀气太重，还是收手吧
	OR_DUEL_ALREADY_IN_DUEL						= -167, // 您已经在和目标决斗了
	OR_DUEL_LIST_FULL							= -168, // 您的决斗名额都安排满了,还是先解决一些吧
	OR_DUEL_TARGET_LIST_FULL					= -169, // 目标的决斗日程都安排满了, 您还是等一等吧.
	OR_DUEL_BUSY								= -170,	// 您现在很忙,等会儿再试试吧.
	OR_DUEL_TARGET_BUSY							= -171,	// 目标现在很忙,等会儿再试试吧.
	OR_DUEL_NEED_UNLOCK_PASSWORD				= -172, // 危险操作，请先打开二级密码

	OR_ENEMY_LIST_FULL							= -173, // 宣战列表已满
	OR_BUS_PASSENGERFULL						= -200,	// 目标已无空间
	OR_BUS_HASPASSENGER							= -201,	// 你已经在车上了
	OR_BUS_NOTINBUS								= -202,	// 你并不在车上
	OR_BUS_RUNNING								= -203,	// 车已经出站
	OR_BUS_HASMOUNT								= -204,	// 你已经在坐骑上了
	OR_BUS_HASPET								= -205,	// 宠物不能乘坐
	OR_BUS_CANNOT_TEAM_FOLLOW					= -206,	// 不能是组队跟随状态
	OR_BUS_CANNOT_DRIDE							= -207,	// 不能是双人骑乘状态
	OR_BUS_CANNOT_CHANGE_MODEL					= -208,	// 不能是变身状态
	OR_NOTENOUGH_MONEY							= -220, // 对不起，您身上携带的金钱不足。
	OR_NO_RIGHT_APPLY_CITY						= -230, // 您没有权限申请城市
	OR_GEM_NEED_STUFF							= -237, // 请放入宝石镶嵌符
	OR_EXE_SETPASSWORD							= -258,	// 打开设置二级密码界面
	OR_EXE_CHANGEPASSWORD						= -259,	// 打开修改二级密码界面
	OR_EXE_UNLOCKPASSWORD						= -260,	// 打开解锁界面
	OR_PET_PLACARD_AREALDY_HAD_SPOUSE			= -261, //珍兽已经有配偶了

    OR_NEED_MENPAI                              = -262, //需要对应门派
    OR_NEED_HIGH_AMBIT                          = -263, //需要更高的境界
    OR_NOT_YOUR                                 = -265, //该BUS不属于你
    OR_NEED_TEAM                                = -266, //需要加入队伍
    OR_NEED_GUILD                               = -267, //需要加入公会
    OR_SKILL_PASSIVE_LIMIT                      = -268, //被动技能不能使用

	OR_CUT_PATHROUTE					= -1000,// 不是错误，只是截短路径
	
	//////////////////////////////////////////////////////////////
	// 请勿忘了更改 GameDefine_Result.cpp 中有 s_aResultText 内容
};
public class GameDefineResult
{
    private Dictionary<int, string> resultInfo = new Dictionary<int, string>();
    static readonly GameDefineResult instance = new GameDefineResult();
    public static GameDefineResult Instance
    {
        get { return instance; }
    }
    private void InitResultDict()
    {
        resultInfo.Add((int)OPERATE_RESULT.OR_OK,"成功");
        resultInfo.Add((int)OPERATE_RESULT.OR_ERROR, "未知错误");
        resultInfo.Add((int)OPERATE_RESULT.OR_DIE, "你已死亡");
        resultInfo.Add((int)OPERATE_RESULT.OR_INVALID_SKILL, "无效技能");
        resultInfo.Add((int)OPERATE_RESULT.OR_TARGET_DIE, "目标已死亡");
        resultInfo.Add((int)OPERATE_RESULT.OR_LACK_MANA, "真气不足");
        resultInfo.Add((int)OPERATE_RESULT.OR_COOL_DOWNING, "冷却时间未到");
        resultInfo.Add((int)OPERATE_RESULT.OR_NO_TARGET, "没有目标");
        resultInfo.Add((int)OPERATE_RESULT.OR_INVALID_TARGET, "无效目标");
        resultInfo.Add((int)OPERATE_RESULT.OR_OUT_RANGE, "超出范围");
        resultInfo.Add((int)OPERATE_RESULT.OR_IN_RANGE, "距离太近");
        resultInfo.Add((int)OPERATE_RESULT.OR_NO_PLATFORM, "没有操作平台");
        resultInfo.Add((int)OPERATE_RESULT.OR_OUT_PLATFORM, "距离目标太远");
        resultInfo.Add((int)OPERATE_RESULT.OR_NO_TOOL, "没有操作工具");
        resultInfo.Add((int)OPERATE_RESULT.OR_STUFF_LACK, "缺少材料");
        resultInfo.Add((int)OPERATE_RESULT.OR_BAG_OUT_OF_SPACE, "背包缺少空间");
        resultInfo.Add((int)OPERATE_RESULT.OR_WARNING, "未知警告");
        resultInfo.Add((int)OPERATE_RESULT.OR_BUSY, "正在做其它事情");
        resultInfo.Add((int)OPERATE_RESULT.OR_MISSION_HAVE, "已经拥有该任务");
        resultInfo.Add((int)OPERATE_RESULT.OR_MISSION_LIST_FULL, "任务记录已满");
        resultInfo.Add((int)OPERATE_RESULT.OR_MISSION_NOT_FIND, "没找到该任务");
        resultInfo.Add((int)OPERATE_RESULT.OR_EXP_LACK, "熟练度不够");
        resultInfo.Add((int)OPERATE_RESULT.OR_CHAR_DO_NOT_KNOW_THIS_SKILL, "角色还不会这种技能");
        resultInfo.Add((int)OPERATE_RESULT.OR_NO_SCRIPT, "目标角色无脚本");
        resultInfo.Add((int)OPERATE_RESULT.OR_NOT_ENOUGH_HP, "没有足够的生命值");
        resultInfo.Add((int)OPERATE_RESULT.OR_NOT_ENOUGH_RAGE, "没有足够的怒气值");
        resultInfo.Add((int)OPERATE_RESULT.OR_NOT_ENOUGH_STRIKE_POINT, "没有足够的连击点");
        resultInfo.Add((int)OPERATE_RESULT.OR_NOT_ENOUGH_ITEM, "没有足够的道具");
        resultInfo.Add((int)OPERATE_RESULT.OR_NOT_ENOUGH_VIGOR, "没有足够的活力");
        resultInfo.Add((int)OPERATE_RESULT.OR_NO_LEVEL, "技能等级不够");
        resultInfo.Add((int)OPERATE_RESULT.OR_CANNOT_UPGRADE, "宝石无法再升级");
        resultInfo.Add((int)OPERATE_RESULT.OR_FAILURE, "操作失败");
        resultInfo.Add((int)OPERATE_RESULT.OR_GEM_CONFLICT, "一件装备上不允许装备同类型的宝石");
        resultInfo.Add((int)OPERATE_RESULT.OR_NEED_IN_FURY_STANCE, "需要在狂暴状态下使用");
        resultInfo.Add((int)OPERATE_RESULT.OR_INVALID_TARGET_POS, "无效目标点");
        resultInfo.Add((int)OPERATE_RESULT.OR_GEM_SLOT_LACK, "无法镶嵌更多宝石");
        resultInfo.Add((int)OPERATE_RESULT.OR_LIMIT_MOVE, "无法移动");
        resultInfo.Add((int)OPERATE_RESULT.OR_LIMIT_USE_SKILL, "无法使用技能");
        resultInfo.Add((int)OPERATE_RESULT.OR_INACTIVE_SKILL, "使用尚未激活的技能");
        resultInfo.Add((int)OPERATE_RESULT.OR_TOO_MUCH_HP, "生命值必须小于限定数值");
        resultInfo.Add((int)OPERATE_RESULT.OR_NEED_A_WEAPON, "本技能需要使用一把武器");
        resultInfo.Add((int)OPERATE_RESULT.OR_NEED_HIGH_LEVEL_XINFA, "你的等级不够");
        resultInfo.Add((int)OPERATE_RESULT.OR_NEED_LEARN_SKILL_FIRST, "尚未学会这个技能");
        resultInfo.Add((int)OPERATE_RESULT.OR_NEED_MENPAI_FOR_LEVELUP, "你必须加入一个门派才能继续升级");
        resultInfo.Add((int)OPERATE_RESULT.OR_U_CANNT_DO_THIS_RIGHT_NOW, "你现在无法这样做");
        resultInfo.Add((int)OPERATE_RESULT.OR_ROBOT_TIMEOUT, "挂机时间超时");
        resultInfo.Add((int)OPERATE_RESULT.OR_NEED_HAPPINESS, "你的宠物快乐度不足60，不能出战，需要驯养");
        resultInfo.Add((int)OPERATE_RESULT.OR_NEED_HIGH_LEVEL,"你的等级不够");
        resultInfo.Add((int)OPERATE_RESULT.OR_CANNOT_GETEXP, "你的宠物已无法得到经验");
        resultInfo.Add((int)OPERATE_RESULT.OR_NEED_LIFE, "你的宠物寿命为0，无法再召唤，请为其增加寿命");
        resultInfo.Add((int)OPERATE_RESULT.OR_EXP_FULL, "您的经验已经到达上限");
        resultInfo.Add((int)OPERATE_RESULT.OR_TOO_MANY_TRAPS, "无法设置更多的此类陷阱");
        resultInfo.Add((int)OPERATE_RESULT.OR_PET_PLACARD_ISSUE_FAILED, "发布失败");
        resultInfo.Add((int)OPERATE_RESULT.OR_PET_PLACARD_NOT_APPOINT_PET, "未指定宠物");
        resultInfo.Add((int)OPERATE_RESULT.OR_PET_PLACARD_ONLY_CAN_ISSUE_ONE, "对不起，同时只能发布一只宠");
        resultInfo.Add((int)OPERATE_RESULT.OR_PET_PLACARD_NEED_PET_TYPE, "对不起，你的宠好像不是宝宝哦");
        resultInfo.Add((int)OPERATE_RESULT.OR_PET_PLACARD_NEED_PET_LIFE, "对不起，你的宠寿命不够");
        resultInfo.Add((int)OPERATE_RESULT.OR_PET_PLACARD_NEED_PET_HAPPINESS, "对不起，你的宠快乐值不够高");
        resultInfo.Add((int)OPERATE_RESULT.OR_PET_PLACARD_NEED_PET_LEVEL, "对不起，你的宠级别还不够哦");
        resultInfo.Add((int)OPERATE_RESULT.OR_NEED_IN_STEALTH_MODE, "需要在隐身状态下使用");
        resultInfo.Add((int)OPERATE_RESULT.OR_NOT_ENOUGH_ENERGY, "没有足够的精力");
        resultInfo.Add((int)OPERATE_RESULT.OR_NEED_IN_SHIELD_MODE, "需要在护体保护下");
        resultInfo.Add((int)OPERATE_RESULT.OR_PET_DIE, "你的宠物已经死亡");
        
        resultInfo.Add((int)OPERATE_RESULT.OR_PET_HADRECALL_NEEDHAPPINESS, "你的宠物快乐度不足60，已被收回");
        resultInfo.Add((int)OPERATE_RESULT.OR_PET_HADRECALL_NEEDLIFE, "你的宠物寿命为0，已被收回");
        resultInfo.Add((int)OPERATE_RESULT.OR_CAN_NOT_MOVE_STALL_OPEN, "无法在摆摊中移动");
        resultInfo.Add((int)OPERATE_RESULT.OR_GEM_NOT_FIT_EQUIP, "这种宝石不能镶嵌在这种装备上");
        resultInfo.Add((int)OPERATE_RESULT.OR_CANNOT_ASK_PETDETIAL, "你无法察看该宠物的信息");
        resultInfo.Add((int)OPERATE_RESULT.OR_VARIANCEPET_CANNOT_RETURNTOCHILD, "变异宠不能进行还童");
        resultInfo.Add((int)OPERATE_RESULT.OR_COMBAT_CANNOT_RETURNTOCHILD, "出战宠不能进行还童");
        resultInfo.Add((int)OPERATE_RESULT.OR_IMPASSABLE_ZONE, "不可走区域");
        resultInfo.Add((int)OPERATE_RESULT.OR_NEED_SETMINORPASSWORD, "请先设置二级密码再重复刚才的操作");
        resultInfo.Add((int)OPERATE_RESULT.OR_NEED_UNLOCKMINORPASSWORD,"请先对二级密码进行解锁，再重复刚才的操作");
        resultInfo.Add((int)OPERATE_RESULT.OR_PETINEXCHANGE_CANNOT_GOFIGHT, "正在交易的宠物无法出战");
        resultInfo.Add((int)OPERATE_RESULT.OR_HASSPOUSE_CANNOT_RETURNTOCHILD, "已经有配偶的宠物不能还童");
        resultInfo.Add((int)OPERATE_RESULT.OR_CAN_NOT_FIND_SPECIFIC_ITEM, "缺少指定物品");
        resultInfo.Add((int)OPERATE_RESULT.OR_HOUSE_SLOT_IS_EMPTY, "需要先装备座骑");
        resultInfo.Add((int)OPERATE_RESULT.OR_NEED_EQUITATION_FIRST, "需要先学会相应的骑术");
        resultInfo.Add((int)OPERATE_RESULT.OR_USE_A_DAMAGED_EQUIPMENT, "装备已经损坏");
        resultInfo.Add((int)OPERATE_RESULT.OR_EQUIPMENT_DAMAGED, "装备已经损坏");
        resultInfo.Add((int)OPERATE_RESULT.OR_PET_PROCREATE_HAE_REGISTER	,"双方中有一人的珍兽已经在此繁殖，不能同时繁殖1个以上的珍兽");
        resultInfo.Add((int)OPERATE_RESULT.OR_PET_PROCREATE_NO_LOCALITY, "已经没有空位了");
        resultInfo.Add((int)OPERATE_RESULT.OR_PET_PROCREATE_NEED_BABY_PET, "双方珍兽必需都是珍兽宝宝");
        resultInfo.Add((int)OPERATE_RESULT.OR_PET_PROCREATE_NEED_SAME_PHYLE, "双方珍兽必需是同类");
        resultInfo.Add((int)OPERATE_RESULT.OR_PET_PROCREATE_NEED_GENERATION, "双方珍兽必需都是一代珍兽");
        resultInfo.Add((int)OPERATE_RESULT.OR_PET_PROCREATE_NEED_HAPPINESS, "双方珍兽快乐度必需为满值");
        resultInfo.Add((int)OPERATE_RESULT.OR_PET_PROCREATE_NEED_SEX, "双方珍兽必需为异性");
        resultInfo.Add((int)OPERATE_RESULT.OR_PET_PROCREATE_NEED_LEEL_DIFFERENCE, "双方珍兽等级差必需小于5");
        resultInfo.Add((int)OPERATE_RESULT.OR_PET_PROCREATE_NEED_SPOUSE, "双方珍兽必需无配偶或互为配偶");
        resultInfo.Add((int)OPERATE_RESULT.OR_PET_PROCREATE_NEED_MONEY, "金钱不够");
        resultInfo.Add((int)OPERATE_RESULT.OR_PET_PROCREATE_NEED_NO_FIGHT_STATE, "双方珍兽必需都未出战");
        resultInfo.Add((int)OPERATE_RESULT.OR_PET_PROCREATE_NEED_LIFE, "双方珍兽寿命必需大于1000");
        resultInfo.Add((int)OPERATE_RESULT.OR_PET_PROCREATE_ERROR_REGISTER, "双方中有一人并没有珍兽在此繁殖");
        resultInfo.Add((int)OPERATE_RESULT.OR_PET_PROCREATE_NO_FINISHED, "繁殖还未完成");
        resultInfo.Add((int)OPERATE_RESULT.OR_PET_PROCREATE_HUMAN_PET_LIST_NO_SPACE, "双方有一个人珍兽列表没有足够的空间");
        resultInfo.Add((int)OPERATE_RESULT.OR_PET_PROCREATE_NEED_2TEAMMEMBER, "必需要两人组成才可以");
        resultInfo.Add((int)OPERATE_RESULT.OR_PET_PROCREATE_TEAMMEMBER_TOO_FAR, "另一个队员离你太远了");
        resultInfo.Add((int)OPERATE_RESULT.OR_PET_PROCREATE_NEED_LEEL, "必需达到相应等级");
        resultInfo.Add((int)OPERATE_RESULT.OR_PET_PROCREATE_NEED_DISTANCE_LEVEL, "与上一次繁殖的时间间隔必需到达20");
        resultInfo.Add((int)OPERATE_RESULT.OR_PET_PROCREATE_NEED_LEADER, "必需是队长才能有这种操作");
        resultInfo.Add((int)OPERATE_RESULT.OR_CANNOT_TAKE_MOREPET, "现在不能携带更多的珍兽");
        resultInfo.Add((int)OPERATE_RESULT.OR_CALLOFHUMAN_NOTSAMESCENE, "你不在普通场景且目标和你不在同一场景");
        resultInfo.Add((int)OPERATE_RESULT.OR_DRIDE_INVALID_ACCETP, "目标已经取消了对你的邀请");
        resultInfo.Add((int)OPERATE_RESULT.OR_DRIDE_NOT_RIDE_MOUNT, "邀请者并没有骑上坐骑");
        resultInfo.Add((int)OPERATE_RESULT.OR_DRIDE_TARGET_MUST_NOT_RIDE_MOUNT, "被邀请者必需没有骑上坐骑");
        resultInfo.Add((int)OPERATE_RESULT.OR_DRIDE_TARGET_MUST_IDLE, "被邀请者必需为休闲状态");
        resultInfo.Add((int)OPERATE_RESULT.OR_DRIDE_OUT_RANGE, "被邀请者与你的距离太远");
        resultInfo.Add((int)OPERATE_RESULT.OR_DRIDE_TARGET_MUST_NOT_CHANGED_MODEL, "被邀请者必需不能变身");
        resultInfo.Add((int)OPERATE_RESULT.OR_DRIDE_TARGET_MUST_NOT_BY_BUS, "被邀请者必需不能在坐骑上");
        resultInfo.Add((int)OPERATE_RESULT.OR_DRIDE_MUST_NOT_TEAM_FOLLOW, "邀请者必需不能在组队跟随状态");
        resultInfo.Add((int)OPERATE_RESULT.OR_DRIDE_TARGET_MUST_NOT_TEAM_FOLLOW, "被邀请者必需不能在组队跟随状态");
        resultInfo.Add((int)OPERATE_RESULT.OR_REVENGE_NEED_TARGET_ONLINE, "查找不到该玩家");
        resultInfo.Add((int)OPERATE_RESULT.OR_REVENGE_NEED_TARGET_LEVEL, "对方等级太低");
        resultInfo.Add((int)OPERATE_RESULT.OR_REVENGE_NOT_TARGET, "你并没有仇杀目标");
        resultInfo.Add((int)OPERATE_RESULT.OR_REVENGE_NEED_LEVEL, "江湖太危险，还不大适合你");
        resultInfo.Add((int)OPERATE_RESULT.OR_REVENGE_NEED_PKVALUE, "你杀气太重，还是收手吧");
        resultInfo.Add((int)OPERATE_RESULT.OR_REVENGE_NEED_NO_TARGET, "你还是先了了现有的仇恨吧");
        resultInfo.Add((int)OPERATE_RESULT.OR_REVENGE_NEED_COOLDOWN, "你今天已经积累了太多仇恨");
        resultInfo.Add((int)OPERATE_RESULT.OR_REVENGE_NEED_UNLOCK_PASSWORD, "危险操作，请先打开二级密码");
        resultInfo.Add((int)OPERATE_RESULT.OR_REVENGE_INVALID_TARGET, "你不能仇杀指定目标");
        resultInfo.Add((int)OPERATE_RESULT.OR_CANTDO_DIE, "你已经死亡，无法那样做");
        resultInfo.Add((int)OPERATE_RESULT.OR_CANTDO_LIMIT_MOVE, "你无法移动");
        resultInfo.Add((int)OPERATE_RESULT.OR_CANTDO_TEAM_FOLLOW_LEADER, "你正处于组队跟随状态，无法那样做");
        resultInfo.Add((int)OPERATE_RESULT.OR_CANTDO_TEAM_FOLLOW_MEMBER, "你正处于组队跟随状态，无法那样做");
        resultInfo.Add((int)OPERATE_RESULT.OR_CANTDO_BUS_PASSENGER, "你现在无法那样做");
        resultInfo.Add((int)OPERATE_RESULT.OR_CANTDO_BUS_CHAUFFEUR, "你现在无法那样做");
        resultInfo.Add((int)OPERATE_RESULT.OR_CANTDO_MOUNT_PASSENGER, "你正在坐骑上，无法那样做");
        resultInfo.Add((int)OPERATE_RESULT.OR_CANTDO_MOUNT_CHAUFFEUR, "你正在坐骑上，无法那样做");
        resultInfo.Add((int)OPERATE_RESULT.OR_CANTDO_FOR_RIDING, "骑乘时无法进行这种操作");
        resultInfo.Add((int)OPERATE_RESULT.OR_CANTDO_TERROR, "恐惧状态无法进行这种操作");
        resultInfo.Add((int)OPERATE_RESULT.OR_CANTDO_INSTALL, "摆摊状态无法进行这种操作");
        resultInfo.Add((int)OPERATE_RESULT.OR_PET_COMPOUND_BUSY, "你必需在站立状态下才能做");
        resultInfo.Add((int)OPERATE_RESULT.OR_PET_COMPOUND_CANT_IN_SCENE, "出战珍兽不能合成");
        resultInfo.Add((int)OPERATE_RESULT.OR_PET_COMPOUND_NEED_PET_LEVEL, "你的珍兽不够30级");
        resultInfo.Add((int)OPERATE_RESULT.OR_PET_COMPOUND_CANT_VARIANCE, "变异珍兽不能合成");
        resultInfo.Add((int)OPERATE_RESULT.OR_PET_COMPOUND_CANT_HAVE_SPOUSE, "已交配过的珍兽不能合成");
        resultInfo.Add((int)OPERATE_RESULT.OR_PET_NOTYOURPET, " 这个珍兽目前不属于你，不能捕捉。");
        resultInfo.Add((int)OPERATE_RESULT.OR_PET_PROCREATE_QUERY, "查询珍兽繁殖进度");
        resultInfo.Add((int)OPERATE_RESULT.OR_HEALTH_IS_FULL, "生命值已满");
        resultInfo.Add((int)OPERATE_RESULT.OR_MANA_IS_FULL, "内力值已满");
        resultInfo.Add((int)OPERATE_RESULT.OR_SOMETHING_IN_THE_WAY, "行进方向上有障碍物");
        resultInfo.Add((int)OPERATE_RESULT.OR_PVP_MODE_SWITCH_DELAY, "从现在起，如果十分钟内不参与PK，您将自动进入和平模式");
        resultInfo.Add((int)OPERATE_RESULT.OR_DUEL_CAN_NOT_FIND_USER, "查找不到该玩家或玩家不在线");
        resultInfo.Add((int)OPERATE_RESULT.OR_DUEL_TARGET_LEVEL_LOW, "对方等级太低");
        resultInfo.Add((int)OPERATE_RESULT.OR_DUEL_LEVEL_LOW, "您的等级太低, 决斗行为还不大适合你");
        resultInfo.Add((int)OPERATE_RESULT.OR_DUEL_PKVALUE_OVER_LIMIT, "你杀气太重，还是收手吧");
        resultInfo.Add((int)OPERATE_RESULT.OR_DUEL_ALREADY_IN_DUEL, "您已经在和目标决斗了");
        resultInfo.Add((int)OPERATE_RESULT.OR_DUEL_LIST_FULL, "您的决斗名额都安排满了,还是先解决一些吧");
        resultInfo.Add((int)OPERATE_RESULT.OR_DUEL_TARGET_LIST_FULL, "目标的决斗日程都安排满了, 您还是等一等吧.");
        resultInfo.Add((int)OPERATE_RESULT.OR_DUEL_BUSY, "您现在很忙,等会儿再试试吧.");
        resultInfo.Add((int)OPERATE_RESULT.OR_DUEL_TARGET_BUSY, "目标现在很忙,等会儿再试试吧.");
        resultInfo.Add((int)OPERATE_RESULT.OR_DUEL_NEED_UNLOCK_PASSWORD, "危险操作，请先打开二级密码");
        resultInfo.Add((int)OPERATE_RESULT.OR_ENEMY_LIST_FULL, "宣战列表已满");
        resultInfo.Add((int)OPERATE_RESULT.OR_BUS_PASSENGERFULL, "目标已无空间");
        resultInfo.Add((int)OPERATE_RESULT.OR_BUS_HASPASSENGER, "你已经在车上了");
        resultInfo.Add((int)OPERATE_RESULT.OR_BUS_NOTINBUS, "你并不在车上");
        resultInfo.Add((int)OPERATE_RESULT.OR_BUS_RUNNING, "车已经出站");
        resultInfo.Add((int)OPERATE_RESULT.OR_BUS_HASMOUNT, "你已经在坐骑上了");
        resultInfo.Add((int)OPERATE_RESULT.OR_BUS_HASPET, "宠物不能乘坐");
        resultInfo.Add((int)OPERATE_RESULT.OR_BUS_CANNOT_TEAM_FOLLOW, "不能是组队跟随状态");
        resultInfo.Add((int)OPERATE_RESULT.OR_BUS_CANNOT_DRIDE, "不能是双人骑乘状态");
        resultInfo.Add((int)OPERATE_RESULT.OR_BUS_CANNOT_CHANGE_MODEL, "不能是变身状态");
        resultInfo.Add((int)OPERATE_RESULT.OR_NOTENOUGH_MONEY, "对不起，您身上携带的金钱不足。");
        resultInfo.Add((int)OPERATE_RESULT.OR_NO_RIGHT_APPLY_CITY, "您没有权限申请城市");
        resultInfo.Add((int)OPERATE_RESULT.OR_GEM_NEED_STUFF, "请放入宝石镶嵌符");
        resultInfo.Add((int)OPERATE_RESULT.OR_EXE_SETPASSWORD, "打开设置二级密码界面");
        resultInfo.Add((int)OPERATE_RESULT.OR_EXE_CHANGEPASSWORD, "打开修改二级密码界面");
        resultInfo.Add((int)OPERATE_RESULT.OR_EXE_UNLOCKPASSWORD, "打开解锁界面");
        resultInfo.Add((int)OPERATE_RESULT.OR_PET_PLACARD_AREALDY_HAD_SPOUSE,"珍兽已经有配偶了");
        resultInfo.Add((int)OPERATE_RESULT.OR_NEED_MENPAI, "这辆载具需要对应五行");
        resultInfo.Add((int)OPERATE_RESULT.OR_NEED_HIGH_AMBIT, "你需要更高的境界");
        resultInfo.Add((int)OPERATE_RESULT.OR_NOT_YOUR, "这辆载具不属于你");
        resultInfo.Add((int)OPERATE_RESULT.OR_NEED_TEAM, "你需要加入队伍");
        resultInfo.Add((int)OPERATE_RESULT.OR_NEED_GUILD, "你需要加入公会");
        resultInfo.Add((int)OPERATE_RESULT.OR_SKILL_PASSIVE_LIMIT, "被动技能不能使用");
    }

    public GameDefineResult()
    {
        InitResultDict();
    }

    public bool OR_SUCCEEDED(OPERATE_RESULT result)
    {
        return ((int)result >= 0);
    }

    public bool OR_FAILED(OPERATE_RESULT result)
    {
        return ((int)result < 0);
    }

    public string GetOResultText(OPERATE_RESULT code)
    {
        if(resultInfo.ContainsKey((int)code))
        {
            return resultInfo[(int)code];
        }
        return "找不到对应消息";
    }
};

