﻿namespace Genesis.Configuration;

public class GameConstants
{
    public static int[] BOWS =
    {
        9185, 839, 845, 847, 851, 855, 859, 841, 843,
        849, 853, 857, 861, 4212, 4214, 4215, 11235, 4216, 4217, 4218,
        4219, 4220, 4221, 4222, 4223, 6724, 4734, 4934, 4935, 4936, 4937
    };

    public static int[] CROSSBOWS =
    {
        837, 4734, 9174, 9177, 9179, 9181, 9183, 9185
    };

    public static int[] ARROWS =
    {
        882, 884, 886, 888, 890, 892, 4740, 11212,
        9140, 9141, 4142, 9143, 9144, 9240, 9241, 9242, 9243, 9244, 9245
    };

    public static int[] BOLTS =
    {
        877, 878, 879, 880, 881, 8882, 9140, 9141,
        9142, 9143, 9144, 9236, 9237, 9238, 9239, 9240, 9241, 9242,
        9243, 9244, 9245, 9337, 9338, 9339, 9340, 9341, 9342
    };

    public static int[] NO_ARROW_DROP =
    {
        4212, 4214, 4215, 4216, 4217, 4218,
        4219, 4220, 4221, 4222, 4223, 4734, 4934, 4935, 4936, 4937
    };

    public static int[] OTHER_RANGE_WEAPONS =
    {
        863, 864, 865, 866, 867, 868,
        869, 806, 807, 808, 809, 810, 811, 825, 826, 827, 828, 829, 830,
        800, 801, 802, 803, 804, 805, 6522
    };

    public static Dictionary<int, int> FOODS = new()
    {
        { 385, 20 } // shark
    };


    public static int[] INCOMING_SIZES =
    {
        0, 0, 0, 1, -1, 0, 0, 0, 0, 0, //0
        0, 0, 0, 0, 8, 0, 6, 2, 2, 0, //10
        0, 2, 0, 6, 0, 12, 0, 0, 0, 0, //20
        0, 0, 0, 0, 0, 8, 4, 0, 0, 2, //30
        2, 6, 0, 6, 0, -1, 0, 0, 0, 0, //40
        0, 0, 0, 12, 0, 0, 0, 0, 8, 0, //50
        0, 8, 0, 0, 0, 0, 0, 0, 0, 0, //60
        6, 0, 2, 2, 8, 6, 0, -1, 0, 6, //70
        0, 0, 0, 0, 0, 1, 4, 6, 0, 0, //80
        0, 0, 0, 0, 0, 3, 0, 0, -1, 0, //90
        0, 13, 0, -1, 0, 0, 0, 0, 0, 0, //100
        0, 0, 0, 0, 0, 0, 0, 6, 0, 0, //110
        1, 0, 6, 0, 0, 0, -1, 0, 2, 6, //120
        0, 4, 6, 8, 0, 6, 0, 0, 0, 2, //130
        0, 0, 0, 0, 0, 6, 0, 0, 0, 0, //140
        0, 0, 1, 2, 0, 2, 6, 0, 0, 0, //150
        0, 0, 0, 0, -1, -1, 0, 0, 0, 0, //160
        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, //170
        0, 8, 0, 3, 0, 2, 0, 0, 8, 1, //180
        0, 0, 12, 0, 0, 0, 0, 0, 0, 0, //190
        2, 0, 0, 0, 0, 0, 0, 0, 4, 0, //200
        4, 0, 0, 0, 7, 8, 0, 0, 10, 0, //210
        0, 0, 0, 0, 0, 0, -1, 0, 6, 0, //220
        1, 0, 0, 0, 6, 0, 6, 8, 1, 0, //230
        0, 4, 0, 0, 0, 0, -1, 0, -1, 4, //240
        0, 0, 6, 6, 0, 0, 0 //250
    };

    public static int[] capes =
    {
        1007, 1019, 1021, 1023, 1027, 1029, 1031, 1052, 2412, 2413, 2414, 4304, 4315, 4317, 4319, 4321, 4323, 4325,
        4327, 4329, 4331, 4333, 4335, 4337, 4339, 4341, 4343, 4345, 4347, 4349, 4351, 4353, 4355, 4357, 4359, 4361,
        4363, 4365, 4367, 4369, 4371, 4373, 4375, 4377, 4379, 4381, 4383, 4385, 4387, 4389, 4391, 4393, 4395, 4397,
        4399, 4401, 4403, 4405, 4407, 4409, 4411, 4413, 4514, 4516, 6070, 6570
    };

    public static int[] boots =
    {
        88, 89, 626, 628, 630, 632, 634, 1061, 1837, 1846, 2577, 2579, 2894, 2904, 2914, 2924, 2934, 3061, 3105, 3107,
        3791, 4097, 4107, 4117, 4119, 4121, 4123, 4125, 4127, 4129, 4131, 4310, 5062, 5063, 5064, 5345, 5557, 6069,
        6106, 6143, 6145, 6147, 6328
    };

    public static int[] gloves =
    {
        1059, 1063, 1065, 1580, 2487, 2489, 2491, 2902, 2912, 2922, 2932, 2942, 3060, 3799, 4095, 4105, 4115, 4308,
        5556, 6068, 6110, 6149, 6151, 6153, 775, 7462
    };

    public static int[] shields =
    {
        1171, 1173, 1175, 1177, 1179, 1181, 1183, 1185, 1187, 1189, 1191, 1193, 1195, 1197, 1199, 1201, 1540, 2589,
        2597, 2603, 2611, 2621, 2629, 2659, 2667, 2675, 2890, 3122, 3488, 3758, 3839, 3840, 3841, 3842, 3843, 3844,
        4072, 4156, 4224, 4225, 4226, 4227, 4228, 4229, 4230, 4231, 4232, 4233, 4234, 4302, 4507, 4512, 6215, 6217,
        6219, 6221, 6223, 6225, 6227, 6229, 6231, 6233, 6235, 6237, 6239, 6241, 6243, 6245, 6247, 6249, 6251, 6253,
        6255, 6257, 6259, 6261, 6263, 6265, 6267, 6269, 6271, 6273, 6275, 6277, 6279, 6524
    };

    public static int[] hats =
    {
        5525, 5527, 5529, 5531, 5533, 5535, 5537, 5539, 5541, 5543, 5545, 5547, 5549, 5551, 74, 579, 656, 658, 660, 662,
        664, 740, 1017, 1037, 1038, 1040, 1042, 1044, 1046, 1048, 1050, 1053, 1055, 1057, 1137, 1139, 1141, 1143, 1145,
        1147, 1149, 1151, 1153, 1155, 1157, 1159, 1161, 1163, 1165, 1506, 1949, 2422, 2581, 2587, 2595, 2605, 2613,
        2619, 2627, 2631, 2651, 2657, 2673, 2900, 2910, 2920, 2930, 2940, 2978, 2979, 2980, 2981, 2982, 2983, 2984,
        2985, 2986, 2987, 2988, 2989, 2990, 2991, 2992, 2993, 2994, 2995, 3057, 3385, 3486, 3748, 3749, 3751, 3753,
        3755, 3797, 4041, 4042, 4071, 4089, 4099, 4109, 4164, 4302, 4506, 4511, 4513, 4515, 4551, 4567, 4708, 4716,
        4724, 4745, 4753, 4856, 4857, 4858, 4859, 4880, 4881, 4882, 4883, 4904, 4905, 4906, 4907, 4952, 4953, 4954,
        4955, 4976, 4977, 4978, 4979, 5013, 5014, 5554, 5574, 6109, 6128, 6131, 6137, 6182, 6188, 6335, 6337, 6339,
        6345, 6355, 6365, 6375, 1167
    };

    public static int[] amulets =
    {
        86, 87, 295, 421, 552, 589, 1478, 1692, 1694, 1696, 1698, 1700, 1702, 1704, 1706, 1708, 1710, 1712, 1725, 1727,
        1729, 1731, 4021, 4081, 4250, 4677, 6040, 6041, 6208, 6585
    };

    public static int[] arrows =
    {
        78, 598, 877, 878, 879, 880, 881, 882, 883, 884, 885, 886, 887, 888, 889, 890, 891, 892, 893, 942, 2532, 2533,
        2534, 2535, 2536, 2537, 2538, 2539, 2540, 2541, 2866, 4160, 4172, 4173, 4174, 4175, 4740, 5616, 5617, 5618,
        5619, 5620, 5621, 5622, 5623, 5624, 5625, 5626, 5627, 6061, 6062
    };

    public static int[] rings =
    {
        773, 1635, 1637, 1639, 1641, 1643, 1645, 2550, 2552, 2554, 2556, 2558, 2560, 2562, 2564, 2566, 2568, 2570, 2572,
        4202, 4657, 6465, 6737
    };

    public static int[] body =
    {
        544, 3140, 1101, 1103, 1105, 1107, 1109, 1111, 1113, 1115, 1117, 1119, 1121, 1123, 1125, 1127, 1129, 1131, 1133,
        1135, 2499, 2501, 2503, 2583, 2591, 2599, 2607, 2615, 2623, 2653, 2669, 3387, 3481, 4712, 4720, 4728, 4749,
        4892, 4893, 4894, 4895, 4916, 4917, 4918, 4919, 4964, 4965, 4966, 4967, 6107, 6133, 6322, 4736
    };

    public static int[] legs =
    {
        538, 542, 548, 1011, 1013, 1015, 1067, 1069, 1071, 1073, 1075, 1077, 1079, 1081, 1083, 1085, 1087, 1089, 1091,
        1093, 2585, 2593, 2601, 2609, 2617, 2625, 2655, 2663, 2671, 3059, 3389, 3472, 3473, 3474, 3475, 3476, 3477,
        3478, 3479, 3480, 3483, 3485, 3795, 4087, 4585, 4712, 4714, 4722, 4730, 4738, 4751, 4759, 4874, 4875, 4876,
        4877, 4898, 4899, 4900, 4901, 4922, 4923, 4924, 4925, 4946, 4947, 4948, 4949, 4970, 4971, 4972, 4973, 4994,
        4995, 4996, 4997, 5048, 5050, 5052, 5576, 6107, 6130, 6187, 6390, 2497, 1095
    };

    public static int[] platebody =
    {
        3140, 1115, 1117, 1119, 1121, 1123, 1125, 1127, 2583, 2591, 2599, 2607, 2615, 2623, 2653, 2669, 3481, 4720,
        4728, 4749, 4736, 544
    };

    public static int[] fullHelm =
        { 1165, 1153, 1155, 1157, 1159, 1161, 1163, 1165, 2587, 2595, 2605, 2613, 2619, 2627, 2657, 2673, 3486, 1167 };

    public static int[] fullMask = { 1165, 1053, 1055, 1057 };

    public static int[] helmetDb =
    {
        74, 579, 656, 658, 660, 662, 664, 740, 1017, 1025, 1037, 1038, 1040, 1042, 1044, 1046, 1048, 1050, 1053, 1055,
        1057, 1137, 1139, 1141, 1143, 1145, 1147, 1149, 1151, 1153, 1155, 1157, 1159, 1161, 1163, 1165, 1167, 1169,
        1506, 1949, 2422, 2581, 2587, 2595, 2605, 2613, 2619, 2627, 2631, 2633, 2635, 2637, 2639, 2641, 2643, 2645,
        2647, 2649, 2651, 2657, 2665, 2673, 2900, 2910, 2920, 2930, 2940, 2978, 2979, 2980, 2981, 2982, 2983, 2984,
        2985, 2986, 2987, 2988, 2989, 2990, 2991, 2992, 2993, 2994, 2995, 3057, 3327, 3329, 3331, 3333, 3335, 3337,
        3339, 3341, 3343, 3385, 3486, 3748, 3749, 3751, 3753, 3755, 3797, 4071, 4089, 4099, 4109, 4164, 4166, 4168,
        4302, 4502, 4506, 4511, 4513, 4515, 4551, 4567, 4611, 4708, 4716, 4724, 4732, 4745, 4753, 4856, 4857, 4858,
        4859, 4880, 4881, 4882, 4883, 4904, 4905, 4906, 4907, 4928, 4929, 4930, 4931, 4952, 4953, 4954, 4955, 4976,
        4977, 4978, 4979, 5013, 5014, 5525, 5527, 5529, 5531, 5533, 5535, 5537, 5539, 5541, 5543, 5545, 5547, 5554,
        5574, 6109, 6128, 6131, 6137, 6182, 6188, 6326, 6335, 6337, 6339, 6345, 6355, 6365, 6375, 6382, 6392, 6400,
        6547, 6548, 6621, 6623, 6656, 6665, 6856, 6858, 6860, 6862, 6885, 6886, 6887, 6918, 7003, 7112, 7124, 7130,
        7136, 7319, 7321, 7323, 7325, 7327, 7394, 7396, 7400, 7534, 7539, 7594, 7917, 8464, 8466, 8468, 8470, 8472,
        8474, 8476, 8478, 8480, 8482, 8484, 8486, 8488, 8490, 8492, 8494, 8682, 8684, 8686, 8688, 8690, 8692, 8694,
        8696, 8698, 8700, 8702, 8704, 8706, 8708, 8710, 8712, 8901, 8903, 8905, 8907, 8909, 8911, 8913, 8915, 8917,
        8919, 8921, 8924, 8925, 8926, 8927, 8928, 8949, 8950, 8959, 8960, 8961, 8962, 8963, 8964, 8965, 9068, 9069,
        9096, 9106, 9472, 9629, 9672, 9729, 9733, 9749, 9752, 9755, 9758, 9761, 9764, 9767, 9770, 9773, 9776, 9779,
        9782, 9785, 9788, 9791, 9794, 9797, 9800, 9803, 9806, 9809, 9812, 9814, 9920, 9925, 9945, 9946, 9950, 10039,
        10045, 10051, 10172, 10286, 10288, 10290, 10292, 10294, 10296, 10298, 10300, 10302, 10304, 10306, 10308, 10310,
        10312, 10314, 10334, 10342, 10350, 10374, 10382, 10390, 10392, 10398, 10452, 10454, 10456, 10507, 10547, 10548,
        10549, 10550, 10589, 10828, 10836, 10862, 10941, 11021, 11200, 11280, 11282, 11335, 11663, 11664, 11665, 11774,
        11775, 11776, 11777, 11778, 11779, 11780, 11781, 11782, 11783, 11784, 11826, 11847, 11850, 11851, 11862, 11863,
        11864, 11865, 11898, 11919, 11990, 12013, 12203, 12211, 12221, 12231, 12241, 12245, 12247, 12249, 12251, 12259,
        12271, 12283, 12293, 12299, 12301, 12303, 12305, 12307, 12309, 12311, 12313, 12319, 12321, 12323, 12325, 12337,
        12351, 12353, 12355, 12359, 12361, 12363, 12365, 12367, 12369, 12371, 12397, 12399, 12412, 12417, 12419, 12428,
        12430, 12432, 12434, 12453, 12455, 12457, 12466, 12476, 12486, 12496, 12504, 12512, 12516, 12518, 12520, 12522,
        12524, 12540, 12600, 12637, 12638, 12639, 12810, 12813, 12845, 12855, 12856, 12887, 12892, 12931, 13070, 13137,
        13138, 13139, 13140, 13197, 13199, 13203, 13223, 13258, 13281, 13283, 13330, 13332, 13334, 13336, 13338, 13343,
        13344, 13359, 13364, 13369, 13374, 13379, 13385, 13579, 13580, 13591, 13592, 13603, 13604, 13615, 13616, 13627,
        13628, 13646, 13647, 13655, 13667, 13668, 19639, 19641, 19643, 19645, 19647, 19649, 19687, 19699, 19724, 19727,
        19915, 19988, 19991, 20008, 20020, 20023, 20026, 20029, 20032, 20035, 20053, 20059, 20080, 20095, 20110, 20113,
        20116, 20119, 20122, 20125, 20128, 20146, 20178, 20193, 20205, 20246, 20266, 20269, 20439, 20561, 20562, 20563,
        20568, 20571, 20572, 20573, 20595, 20708, 20764, 20773, 20792, 20838, 21018, 21061, 21063, 21211, 21214, 21264,
        21266, 21282, 21298, 21720, 21778, 21782, 21786, 21838, 21847, 21859, 21888, 21890, 21900, 22121, 22159, 22161,
        22163, 22165, 22167, 22169, 22171, 22173, 22175, 22177, 22179, 22181, 22183, 22185, 22187, 22189, 22326, 22625,
        22638, 22650, 22689, 22713, 23047, 23073, 23075, 23101, 23252, 23255, 23258, 23270, 23273, 23312, 23407, 23448
    };

    public static Dictionary<string, WeaponData> WeaponInterfaceData { get; set; } = new()
    {
        { "Unarmed", new WeaponData(5855, 0, 5857, 200) },
        { "Whip", new WeaponData(12290, 12291, 12293, 200) },

        { "Bow", new WeaponData(1764, 1765, 1767, 200) },

        { "Staff", new WeaponData(328, 329, 331, 200) },
        { "Dart", new WeaponData(4446, 4447, 4449, 200) },
        { "Knife", new WeaponData(4446, 4447, 4449, 200) },
        { "Javelin", new WeaponData(4446, 4447, 4449, 200) },
        { "Toktz-xil-ul", new WeaponData(4446, 4447, 4449, 200) },
        { "Dagger", new WeaponData(2276, 2277, 2279, 200) },
        { "Sword", new WeaponData(2276, 2277, 2279, 200) },
        { "Pickaxe", new WeaponData(5570, 5571, 5573, 200) },
        { "Axe", new WeaponData(1698, 1699, 1701, 200) },
        { "Battleaxe", new WeaponData(1698, 1699, 1701, 200) },
        { "Halberd", new WeaponData(8460, 8461, 8463, 200) },
        { "Scythe", new WeaponData(8460, 8461, 8463, 200) },
        { "Spear", new WeaponData(4679, 4680, 4682, 200) },
        { "Mace", new WeaponData(3796, 3797, 3799, 200) },
        { "GiantClub", new WeaponData(425, 426, 428, 200) },
        { "Other", new WeaponData(2423, 2424, 2426, 200) }
    };

    // public static List<Potion> ALL_POTIONS = new()
    // {
    //     new Potion(2452, 2454, 2456, 2458, 229),  // ANTIFIRE_POTION
    //     new Potion(2440, 157, 159, 161, 229),  // SUPER_STRENGTH
    // };

    public Dictionary<int, int> WeaponTicks { get; set; } = new()
    {
        { 100, 2 },
        { 541, 2 },
        { 352, 2 },
        { 155, 2 },
        { 324, 2 }
    };

    public static bool IsItemInArray(int itemID, int[] array)
    {
        return Array.IndexOf(array, itemID) > -1;
    }

    public static bool IsFullMask(int itemID)
    {
        return IsItemInArray(itemID, fullMask);
    }

    public static bool IsFullHelm(int itemID)
    {
        return IsItemInArray(itemID, fullHelm);
    }

    public static bool IsFullBody(int itemID)
    {
        return IsItemInArray(itemID, platebody);
    }

    /// <summary>
    ///     This record holds the UI frame configuration for displaying weapon information within an interface.
    ///     It includes FrameIds for Main, Icon, and Text display areas, as well as an integer percentage for zoom level.
    /// </summary>
    /// <param name="MainFrameId">The frame which corresponds with a weapon type (e.g., swords have a slash frame).</param>
    /// <param name="IconFrameId">The frame that displays the weapon icon.</param>
    /// <param name="TextFrameId">The frame that displays the weapon name.</param>
    /// <param name="Zoom">The zoom level for the weapon icon as a percentage.</param>
    public record WeaponData(int MainFrameId, int IconFrameId, int TextFrameId, int Zoom);
}