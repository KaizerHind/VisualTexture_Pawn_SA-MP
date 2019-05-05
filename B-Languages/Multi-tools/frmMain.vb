Public Class frmMain

    Private CordX As Integer
    Private CordY As Integer
    Private MoveForm As Boolean

    Dim g_VehicleModelNames() As String = {"Landstalker", "Bravura", "Buffalo", "Linerunner", "Perenniel", "Sentinel", "Dumper", "Firetruck", "Trashmaster", "Stretch", "Manana", "Infernus", "Voodoo", "Pony", "Mule", "Cheetah", "Ambulance", "Leviathan", "Moonbeam", "Esperanto", "Taxi", "Washington", "Bobcat", "Mr Whoopee", "BF Injection", "Hunter", "Premier", "Enforcer", "Securicar", "Banshee", "Predator", "Bus", "Rhino", "Barracks", "Hotknife", "Article Trailer", "Previon", "Coach", "Cabbie", "Stallion", "Rumpo", "RC Bandit", "Romero", "Packer", "Monster", "Admiral", "Squallo", "Seasparrow", "Pizzaboy", "Tram", "Article Trailer 2", "Turismo", "Speeder", "Reefer", "Tropic", "Flatbed", "Yankee", "Caddy", "Solair", "Berkley's RC Van", "Skimmer", "PCJ-600", "Faggio", "Freeway", "RC Baron", "RC Raider", "Glendale", "Oceanic", "Sanchez", "Sparrow", "Patriot", "Quad", "Coastguard", "Dinghy", "Hermes", "Sabre", "Rustler", "ZR-350", "Walton", "Regina", "Comet", "BMX", "Burrito", "Camper", "Marquis", "Baggage", "Dozer", "Maverick", "SAN News Maverick", "Rancher", "FBI Rancher", "Virgo", "Greenwood", "Jetmax", "Hotring Racer", "Sandking", "Blista Compact", "Police Maverick", "Boxville", "Benson", "Mesa", "RC Goblin", "Hotring Racer", "Hotring Racer", "Bloodring Banger", "Rancher", "Super GT", "Elegant", "Journey", "Bike", "Mountain Bike", "Beagle", "Cropduster", "Stuntplane", "Tanker", "Roadtrain", "Nebula", "Majestic", "Buccaneer", "Shamal", "Hydra", "FCR-900", "NRG-500", "Cop Bike (HPV-1000)", "Cement Truck", "Towtruck", "Fortune", "Cadrona", "FBI Truck", "Willard", "Forklift", "Tractor", "Combine Harvester", "Feltzer", "Remington", "Slamvan", "Blade", "Freight (Train)", "Brownstreak (Train)", "Vortex", "Vincent", "Bullet", "Clover", "Sadler", "Firetruck LA", "Hustler", "Intruder", "Primo", "Cargobob", "Tampa", "Sunrise", "Merit", "Utility Van", "Nevada", "Yosemite", "Windsor", "Monster ""A""", "Monster ""B""", "Uranus", "Jester", "Sultan", "Stratum", "Elegy", "Raindance", "RC Tiger", "Flash", "Tahoma", "Savanna", "Bandito", "Freight Flat Trailer (Train)", "Streak Trailer (Train)", "Kart", "Mower", "Dune", "Sweeper", "Broadway", "Tornado", "AT-400", "DFT-30", "Huntley", "Stafford", "BF-400", "Newsvan", "Tug", "Petrol Trailer", "Emperor", "Wayfarer", "Euros", "Hotdog", "Club", "Freight Box Trailer (Train)", "Article Trailer 3", "Andromada", "Dodo", "RC Cam", "Launch", "Police Car (LSPD)", "Police Car (SFPD)", "Police Car (LVPD)", "Police Ranger", "Picador", "S.W.A.T.", "Alpha", "Phoenix", "Glendale Shit", "Sadler Shit", "Baggage Trailer ""A""", "Baggage Trailer ""B""", "Tug Stairs Trailer", "Boxburg", "Farm Trailer", "Utility Trailer"}
    Dim g_VehicleModelImages() As Image = {My.Resources.Vehicle_400, My.Resources.Vehicle_401, My.Resources.Vehicle_402, My.Resources.Vehicle_403, My.Resources.Vehicle_404, My.Resources.Vehicle_405, My.Resources.Vehicle_406, My.Resources.Vehicle_407, My.Resources.Vehicle_408, My.Resources.Vehicle_409, My.Resources.Vehicle_410, My.Resources.Vehicle_411, My.Resources.Vehicle_412, My.Resources.Vehicle_413, My.Resources.Vehicle_414, My.Resources.Vehicle_415, My.Resources.Vehicle_416, My.Resources.Vehicle_417, My.Resources.Vehicle_418, My.Resources.Vehicle_419, My.Resources.Vehicle_420, My.Resources.Vehicle_421, My.Resources.Vehicle_422, My.Resources.Vehicle_423, My.Resources.Vehicle_424, My.Resources.Vehicle_425, My.Resources.Vehicle_426, My.Resources.Vehicle_427, My.Resources.Vehicle_428, My.Resources.Vehicle_429, My.Resources.Vehicle_430, My.Resources.Vehicle_431, My.Resources.Vehicle_432, My.Resources.Vehicle_433, My.Resources.Vehicle_434, My.Resources.Vehicle_435, My.Resources.Vehicle_436, My.Resources.Vehicle_437, My.Resources.Vehicle_438, My.Resources.Vehicle_439, My.Resources.Vehicle_440, My.Resources.Vehicle_441, My.Resources.Vehicle_442, My.Resources.Vehicle_443, My.Resources.Vehicle_444, My.Resources.Vehicle_445, My.Resources.Vehicle_446, My.Resources.Vehicle_447, My.Resources.Vehicle_448, My.Resources.Vehicle_449, My.Resources.Vehicle_450, My.Resources.Vehicle_451, My.Resources.Vehicle_452, My.Resources.Vehicle_453, My.Resources.Vehicle_454, My.Resources.Vehicle_455, My.Resources.Vehicle_456, My.Resources.Vehicle_457, My.Resources.Vehicle_458, My.Resources.Vehicle_459, My.Resources.Vehicle_460, My.Resources.Vehicle_461, My.Resources.Vehicle_462, My.Resources.Vehicle_463, My.Resources.Vehicle_464, My.Resources.Vehicle_465, My.Resources.Vehicle_466, My.Resources.Vehicle_467, My.Resources.Vehicle_468, My.Resources.Vehicle_469, My.Resources.Vehicle_470, My.Resources.Vehicle_471, My.Resources.Vehicle_472, My.Resources.Vehicle_473, My.Resources.Vehicle_474, My.Resources.Vehicle_475, My.Resources.Vehicle_476, My.Resources.Vehicle_477, My.Resources.Vehicle_478, My.Resources.Vehicle_479, My.Resources.Vehicle_480, My.Resources.Vehicle_481, My.Resources.Vehicle_482, My.Resources.Vehicle_483, My.Resources.Vehicle_484, My.Resources.Vehicle_485, My.Resources.Vehicle_486, My.Resources.Vehicle_487, My.Resources.Vehicle_488, My.Resources.Vehicle_489, My.Resources.Vehicle_490, My.Resources.Vehicle_491, My.Resources.Vehicle_492, My.Resources.Vehicle_493, My.Resources.Vehicle_494, My.Resources.Vehicle_495, My.Resources.Vehicle_496, My.Resources.Vehicle_497, My.Resources.Vehicle_498, My.Resources.Vehicle_499, My.Resources.Vehicle_500, My.Resources.Vehicle_501, My.Resources.Vehicle_502, My.Resources.Vehicle_503, My.Resources.Vehicle_504, My.Resources.Vehicle_505, My.Resources.Vehicle_506, My.Resources.Vehicle_507, My.Resources.Vehicle_508, My.Resources.Vehicle_509, My.Resources.Vehicle_510, My.Resources.Vehicle_511, My.Resources.Vehicle_512, My.Resources.Vehicle_513, My.Resources.Vehicle_514, My.Resources.Vehicle_515, My.Resources.Vehicle_516, My.Resources.Vehicle_517, My.Resources.Vehicle_518, My.Resources.Vehicle_519, My.Resources.Vehicle_520, My.Resources.Vehicle_521, My.Resources.Vehicle_522, My.Resources.Vehicle_523, My.Resources.Vehicle_524, My.Resources.Vehicle_525, My.Resources.Vehicle_526, My.Resources.Vehicle_527, My.Resources.Vehicle_528, My.Resources.Vehicle_529, My.Resources.Vehicle_530, My.Resources.Vehicle_531, My.Resources.Vehicle_532, My.Resources.Vehicle_533, My.Resources.Vehicle_534, My.Resources.Vehicle_535, My.Resources.Vehicle_536, My.Resources.Vehicle_537, My.Resources.Vehicle_538, My.Resources.Vehicle_539, My.Resources.Vehicle_540, My.Resources.Vehicle_541, My.Resources.Vehicle_542, My.Resources.Vehicle_543, My.Resources.Vehicle_544, My.Resources.Vehicle_545, My.Resources.Vehicle_546, My.Resources.Vehicle_547, My.Resources.Vehicle_548, My.Resources.Vehicle_549, My.Resources.Vehicle_550, My.Resources.Vehicle_551, My.Resources.Vehicle_552, My.Resources.Vehicle_553, My.Resources.Vehicle_554, My.Resources.Vehicle_555, My.Resources.Vehicle_556, My.Resources.Vehicle_557, My.Resources.Vehicle_558, My.Resources.Vehicle_559, My.Resources.Vehicle_560, My.Resources.Vehicle_561, My.Resources.Vehicle_562, My.Resources.Vehicle_563, My.Resources.Vehicle_564, My.Resources.Vehicle_565, My.Resources.Vehicle_566, My.Resources.Vehicle_567, My.Resources.Vehicle_568, My.Resources.Vehicle_569, My.Resources.Vehicle_570, My.Resources.Vehicle_571, My.Resources.Vehicle_572, My.Resources.Vehicle_573, My.Resources.Vehicle_574, My.Resources.Vehicle_575, My.Resources.Vehicle_576, My.Resources.Vehicle_577, My.Resources.Vehicle_578, My.Resources.Vehicle_579, My.Resources.Vehicle_580, My.Resources.Vehicle_581, My.Resources.Vehicle_582, My.Resources.Vehicle_583, My.Resources.Vehicle_584, My.Resources.Vehicle_585, My.Resources.Vehicle_586, My.Resources.Vehicle_587, My.Resources.Vehicle_588, My.Resources.Vehicle_589, My.Resources.Vehicle_590, My.Resources.Vehicle_591, My.Resources.Vehicle_592, My.Resources.Vehicle_593, My.Resources.Vehicle_594, My.Resources.Vehicle_595, My.Resources.Vehicle_596, My.Resources.Vehicle_597, My.Resources.Vehicle_598, My.Resources.Vehicle_599, My.Resources.Vehicle_600, My.Resources.Vehicle_601, My.Resources.Vehicle_602, My.Resources.Vehicle_603, My.Resources.Vehicle_604, My.Resources.Vehicle_605, My.Resources.Vehicle_606, My.Resources.Vehicle_607, My.Resources.Vehicle_608, My.Resources.Vehicle_609, My.Resources.Vehicle_610, My.Resources.Vehicle_611}
    Dim g_SoundID() As Integer = {1002, 1009, 1027, 1035, 1039, 1052, 1053, 1054, 1055, 1056, 1057, 1058, 1062, 1068, 1076, 1083, 1084, 1085, 1097, 1130, 1131, 1132, 1133, 1134, 1135, 1136, 1137, 1138, 1139, 1140, 1141, 1142, 1144, 1145, 1147, 1148, 1149, 1150, 1153, 1163, 1165, 1169, 1183, 1185, 1187, 1190}
    Dim g_SoundFile() As System.IO.UnmanagedMemoryStream = {My.Resources.SOUND_CEILING_VENT_LAND, My.Resources.SOUND_BONNET_DENT, My.Resources.SOUND_WHEEL_OF_FORTUNE_CLACKER, My.Resources.SOUND_SHUTTER_DOOR_START, My.Resources.SOUND_PARACHUTE_OPEN, My.Resources.SOUND_AMMUNATION_BUY_WEAPON, My.Resources.SOUND_AMMUNATION_BUY_WEAPON_DENIED, My.Resources.SOUND_SHOP_BUY, My.Resources.SOUND_SHOP_BUY_DENIED, My.Resources.SOUND_RACE_321, My.Resources.SOUND_RACE_GO, My.Resources.SOUND_PART_MISSION_COMPLETE, My.Resources.SOUND_GOGO_TRACK_START_MUSIC_, My.Resources.SOUND_DUAL_TRACK_START_MUSIC_, My.Resources.SOUND_BEE_TRACK_START_MUSIC_, My.Resources.SOUND_ROULETTE_ADD_CASH, My.Resources.SOUND_ROULETTE_REMOVE_CASH, My.Resources.SOUND_ROULETTE_NO_CASH, My.Resources.SOUND_AWARD_TRACK_START, My.Resources.SOUND_PUNCH_PED, My.Resources.SOUND_AMMUNATION_GUN_COLLISION, My.Resources.SOUND_CAMERA_SHOT, My.Resources.SOUND_BUY_CAR_MOD, My.Resources.SOUND_BUY_CAR_RESPRAY, My.Resources.SOUND_BASEBALL_BAT_HIT_PED, My.Resources.SOUND_STAMP_PED, My.Resources.SOUND_CHECKPOINT_AMBER, My.Resources.SOUND_CHECKPOINT_GREEN, My.Resources.SOUND_CHECKPOINT_RED, My.Resources.SOUND_CAR_SMASH_CAR, My.Resources.SOUND_CAR_SMASH_GATE, My.Resources.SOUND_OTB_TRACK_START, My.Resources.SOUND_PED_HIT_WATER_SPLASH, My.Resources.SOUND_RESTAURANT_TRAY_COLLISION, My.Resources.SOUND_SWEETS_HORN, My.Resources.SOUND_MAGNET_VEHICLE_COLLISION, My.Resources.SOUND_PROPERTY_PURCHASED, My.Resources.SOUND_PICKUP_STANDARD, My.Resources.SOUND_GARAGE_DOOR_START, My.Resources.SOUND_PED_COLLAPSE, My.Resources.SOUND_SHUTTER_DOOR_SLOW_START, My.Resources.SOUND_RESTAURANT_TRAY_COLLISION, My.Resources.SOUND_DRIVING_AWARD_TRACK_START, My.Resources.SOUND_BIKE_AWARD_TRACK_START, My.Resources.SOUND_PILOT_AWARD_TRACK_START, My.Resources.SOUND_SLAP}
    Dim g_WeatherID() As String = {"0 to 7", "08", "09", "10", "11", "12", "16", "17 to 18", "19", "20", "21", "22", "23 to 26", "27 to 29", "30 to 32", "33", "34", "35", "36 to 38", "39", "40 to 42", "43", "44", "45", "1337", "-1337"}
    Dim g_WeatherPic() As Image = {My.Resources.sa_mp_000, My.Resources.sa_mp_001, My.Resources.sa_mp_002, My.Resources.sa_mp_003, My.Resources.sa_mp_004, My.Resources.sa_mp_005, My.Resources.sa_mp_006, My.Resources.sa_mp_007, My.Resources.sa_mp_008, My.Resources.sa_mp_009, My.Resources.sa_mp_010, My.Resources.sa_mp_011, My.Resources.sa_mp_012, My.Resources.sa_mp_013, My.Resources.sa_mp_014, My.Resources.sa_mp_015, My.Resources.sa_mp_016, My.Resources.sa_mp_017, My.Resources.sa_mp_018, My.Resources.sa_mp_019, My.Resources.sa_mp_020, My.Resources.sa_mp_021, My.Resources.sa_mp_022, My.Resources.sa_mp_023, My.Resources.sa_mp_024, My.Resources.sa_mp_025}
    Dim g_GameTextStyle() As Image = {My.Resources.Game_text_type0, My.Resources.Game_text_type1, My.Resources.Game_text_type2, My.Resources.Game_text_type3, My.Resources.Game_text_type4, My.Resources.Game_text_type5, My.Resources.Game_text_type6}
    Dim g_ExplosionVisible() As String = {"Yes", "Yes", "Yes", "Yes", "Yes", "Yes", "Yes", "Yes", "No", "No", "Yes", "Yes", "Yes", "No"}
    Dim g_ExplosionSplits() As String = {"No", "No", "No", "No", "Yes", "Yes", "No", "No", "No", "No", "No", "No", "No", "No"}
    Dim g_ExplosionRange() As String = {"Large", "Normal", "Large", "Large", "Normal", "Normal", "Very Large", "Huge", "Normal", "Normal", "Large", "Small", "Very Small", "Large"}
    Dim g_AnimationLists(127) As ListBox
    Dim g_WeaponImages() As Image = {My.Resources.Weapon_0, My.Resources.Weapon_1, My.Resources.Weapon_2, My.Resources.Weapon_3, My.Resources.Weapon_4, My.Resources.Weapon_5, My.Resources.Weapon_6, My.Resources.Weapon_7, My.Resources.Weapon_8, My.Resources.Weapon_9, My.Resources.Weapon_10, My.Resources.Weapon_11, My.Resources.Weapon_12, My.Resources.Weapon_13, My.Resources.Weapon_14, My.Resources.Weapon_15, My.Resources.Weapon_16, My.Resources.Weapon_17, My.Resources.Weapon_18, My.Resources.Weapon_22, My.Resources.Weapon_23, My.Resources.Weapon_24, My.Resources.Weapon_25, My.Resources.Weapon_26, My.Resources.Weapon_27, My.Resources.Weapon_28, My.Resources.Weapon_29, My.Resources.Weapon_30, My.Resources.Weapon_31, My.Resources.Weapon_32, My.Resources.Weapon_33, My.Resources.Weapon_34, My.Resources.Weapon_35, My.Resources.Weapon_36, My.Resources.Weapon_37, My.Resources.Weapon_38, My.Resources.Weapon_39, My.Resources.Weapon_40, My.Resources.Weapon_41, My.Resources.Weapon_42, My.Resources.Weapon_43, My.Resources.Weapon_44, My.Resources.Weapon_45, My.Resources.Weapon_46}
    Dim g_WeaponSlots() As Integer = {0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 10, 10, 10, 10, 10, 10, 8, 8, 8, 2, 2, 2, 3, 3, 3, 4, 4, 5, 5, 4, 6, 6, 7, 7, 7, 7, 8, 12, 9, 9, 9, 11, 11, 11}
    Dim g_WeaponModels() As Integer = {0, 331, 333, 334, 335, 336, 337, 338, 339, 341, 321, 322, 323, 324, 325, 326, 342, 343, 344, 346, 347, 348, 349, 350, 351, 352, 353, 355, 356, 372, 357, 358, 359, 360, 361, 362, 363, 364, 365, 366, 367, 368, 369, 371}
    Dim g_WeaponID() As Integer = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46}
    Dim g_WeaponPictures() As Image = {My.Resources.sa_mp_060, My.Resources.sa_mp_061, My.Resources.sa_mp_062, My.Resources.sa_mp_063, My.Resources.sa_mp_064, My.Resources.sa_mp_065, My.Resources.sa_mp_066, My.Resources.sa_mp_067, My.Resources.sa_mp_068, My.Resources.sa_mp_069, My.Resources.sa_mp_070, My.Resources.sa_mp_071, My.Resources.sa_mp_072, My.Resources.sa_mp_073, My.Resources.sa_mp_074, My.Resources.sa_mp_075, My.Resources.sa_mp_076, My.Resources.sa_mp_077, My.Resources.sa_mp_078, My.Resources.sa_mp_079, My.Resources.sa_mp_080, My.Resources.sa_mp_081, My.Resources.sa_mp_082, My.Resources.sa_mp_083, My.Resources.sa_mp_084, My.Resources.sa_mp_085, My.Resources.sa_mp_086, My.Resources.sa_mp_087, My.Resources.sa_mp_088, My.Resources.sa_mp_089, My.Resources.sa_mp_090, My.Resources.sa_mp_091, My.Resources.sa_mp_092, My.Resources.sa_mp_093, My.Resources.sa_mp_094, My.Resources.sa_mp_095, My.Resources.sa_mp_096, My.Resources.sa_mp_097, My.Resources.sa_mp_098, My.Resources.sa_mp_099, My.Resources.sa_mp_100, My.Resources.sa_mp_101, My.Resources.sa_mp_102, My.Resources.sa_mp_103}
    Dim g_MiscPickups() As Image = {My.Resources.sa_mp_104, My.Resources.sa_mp_105, My.Resources.sa_mp_106, My.Resources.sa_mp_107, My.Resources.sa_mp_108, My.Resources.sa_mp_109, My.Resources.sa_mp_110, My.Resources.sa_mp_111, My.Resources.sa_mp_112, My.Resources.sa_mp_113, My.Resources.sa_mp_114, My.Resources.sa_mp_115, My.Resources.sa_mp_116, My.Resources.sa_mp_117, My.Resources.sa_mp_118, My.Resources.sa_mp_119, My.Resources.sa_mp_120, My.Resources.sa_mp_121, My.Resources.sa_mp_122, My.Resources.sa_mp_123, My.Resources.sa_mp_124, My.Resources.sa_mp_125, My.Resources.sa_mp_126, My.Resources.sa_mp_127, My.Resources.sa_mp_128, My.Resources.sa_mp_129, My.Resources.sa_mp_130}
    Dim g_WeaponPickups() As Image = {My.Resources.sa_mp_131, My.Resources.sa_mp_132, My.Resources.sa_mp_133, My.Resources.sa_mp_134, My.Resources.sa_mp_135, My.Resources.sa_mp_136, My.Resources.sa_mp_137, My.Resources.sa_mp_138, My.Resources.sa_mp_139, My.Resources.sa_mp_140, My.Resources.sa_mp_141, My.Resources.sa_mp_142, My.Resources.sa_mp_143, My.Resources.sa_mp_144, My.Resources.sa_mp_145, My.Resources.sa_mp_146, My.Resources.sa_mp_147, My.Resources.sa_mp_148, My.Resources.sa_mp_149, My.Resources.sa_mp_150, My.Resources.sa_mp_151, My.Resources.sa_mp_152, My.Resources.sa_mp_153, My.Resources.sa_mp_154, My.Resources.sa_mp_155, My.Resources.sa_mp_156, My.Resources.sa_mp_157, My.Resources.sa_mp_158, My.Resources.sa_mp_159, My.Resources.sa_mp_160, My.Resources.sa_mp_161, My.Resources.sa_mp_162, My.Resources.sa_mp_163, My.Resources.sa_mp_164, My.Resources.sa_mp_165, My.Resources.sa_mp_166, My.Resources.sa_mp_167, My.Resources.sa_mp_168, My.Resources.sa_mp_169, My.Resources.sa_mp_170, My.Resources.sa_mp_171, My.Resources.sa_mp_172, My.Resources.sa_mp_173, My.Resources.sa_mp_174, My.Resources.sa_mp_175, My.Resources.sa_mp_176}
    Dim g_SkinModelName() As String = {"cj", "truth", "maccer", "male01", "bfori", "bfost", "vbfycrp", "bfyri", "bfyst", "bmori", "bmost", "bmyap", "bmybu", "bmybe", "bmydj", "bmyri", "bmycr", "bmyst", "wmybmx", "wbdyg1", "wbdyg2", "wmybp", "wmycon", "bmydrug", "wmydrug", "hmydrug", "dwfolc", "dwmolc1", "dwmolc2", "dwmylc1", "hmogar", "wmygol1", "wmygol2", "hfori", "hfost", "hfyri", "hfyst", "hmori", "hmost", "hmybe", "hmyri", "hmycr", "hmyst", "omokung", "wmymech", "bmymoun", "wmymoun", "ofost", "ofyri", "ofyst", "omori", "omost", "omyri", "omyst", "wmyplt", "wmopj", "bfypro", "hfypro", "bmypol1", "bmypol2", "wmoprea", "sbfyst", "wmosci", "swmyhp1", "swmyhp2", "swfopro", "wfystew", "swmotr1", "wmotr1", "bmotr1", "vbmybox", "vwmybox", "vhmyelv", "vbmyelv", "vimyelv", "vwfypro", "vwfyst1", "wfori", "wfost", "wfyjg", "wfyro", "wfyst", "wmori", "wmost", "wmyjg", "wmylg", "wmyri", "wmyro", "wmycr", "wmyst", "ballas1", "ballas2", "ballas3", "fam1", "fam2", "fam3", "lsv1", "lsv2", "lsv3", "maffa", "maffb", "mafboss", "vla1", "vla2", "vla3", "triada", "triadb", "triboss", "dnb1", "dnb2", "dnb3", "vmaff1", "vmaff2", "vmaff3", "vmaff4", "dnmylc", "dnfolc1", "dnfolc2", "dnfylc", "dnmolc1", "dnmolc2", "sbmotr2", "swmotr2", "sbmytr3", "swmotr3", "wfybe", "bfybe", "hfybe", "sofybu", "sbmyst", "sbmycr", "bmycg", "wfycrk", "hmycm", "wmybu", "bfybu", "wfybu", "dwfylc1", "wfypro", "wmyconb", "wmybe", "wmypizz", "bmobar", "cwfyhb", "cwmofr", "cwmohb1", "cwmohb2", "cwmyfr", "cwmyhb1", "bmyboun", "wmyboun", "wmomib", "bmymib", "wmybell", "bmochil", "sofyri", "somyst", "vwmybjd", "vwfycrp", "sfr1", "sfr2", "sfr3", "bmybar", "wmybar", "wfysex", "wmyammo", "bmytatt", "vwmycr", "vbmocd", "vbmycr", "vhmycr", "sbmyri", "somyri", "somybu", "swmyst", "wmyva", "copgrl3", "gungrl3", "mecgrl3", "nurgrl3", "crogrl3", "gangrl3", "cwfofr", "cwfohb", "cwfyfr1", "cwfyfr2", "cwmyhb2", "dwfylc2", "dwmylc2", "omykara", "wmykara", "wfyburg", "vwmycd", "vhfypro", "omonood", "omoboat", "wfyclot", "vwmotr1", "vwmotr2", "vwfywai", "sbfori", "swfyri", "wmyclot", "sbfost", "sbfyri", "sbmocd", "sbmori", "sbmost", "shmycr", "sofori", "sofost", "sofyst", "somobu", "somori", "somost", "swmotr5", "swfori", "swfost", "swfyst", "swmocd", "swmori", "swmost", "shfypro", "sbfypro", "swmotr4", "swmyri", "smyst", "smyst2", "sfypro", "vbfyst2", "vbfypro", "vhfyst3", "bikera", "bikerb", "bmypimp", "swmycr", "wfylg", "wmyva2", "bmosec", "bikdrug", "wmych", "sbfystr", "swfystr", "heck1", "heck2", "bmycon", "wmycd1", "bmocd", "vwfywa2", "wmoice", "tenpen", "pulaski", "Hernandez", "dwayne", "smoke", "sweet", "ryder", "Unknown", "laemt1", "lvemt1", "sfemt1", "lafd1", "lvfd1", "sffd1", "lapd1", "sfpd1", "lvpd1", "csher", "lapdm1", "swat", "fbi", "army", "dsher"}
    Dim g_SkinName() As String = {"Main Character", "The Truth", "Maccer", "Taxi Driver/Train Driver", "Normal Ped", "Normal Ped", "Casino Worker", "Normal Ped", "Normal Ped", "Normal Ped", "RS Haul Owner", "Airport Ground Worker", "Normal Ped", "Beach Visitor", "Normal Ped", "Madd Dogg's Manager", "Normal Ped", "Normal Ped", "BMXer", "Madd Dogg Bodyguard", "Madd Dogg Bodyguard", "Mountain Climber", "Builder", "Drug Dealer", "Drug Dealer", "Drug Dealer", "Farm-Town inhabitant", "Farm-Town inhabitant", "Farm-Town inhabitant", "Farm-Town inhabitant", "Normal Ped", "Golfer", "Golfer", "Normal Ped", "Normal Ped", "Normal Ped", "Normal Ped", "Normal Ped", "Normal Ped", "Beach Visitor", "Normal Ped", "Normal Ped", "Normal Ped", "Snakehead (Da Nang)", "Mechanic", "Mountain Biker", "Mountain Biker", "Normal Ped", "Normal Ped", "Normal Ped", "Feds", "Normal Ped", "Normal Ped", "Normal Ped", "Pilot", "Colonel Fuhrberger", "Prostitute", "Prostitute", "Pool Player", "Pool Player", "Priest", "Normal Ped", "Scientist", "Normal Ped", "Jethro", "Prostitute", "Normal Ped", "Homeless", "Homeless", "Homeless", "Boxer", "Boxer", "Elvis Wannabe", "Elvis Wannabe", "Elvis Wannabe", "Prostitute", "Whore", "Normal Ped", "Normal Ped", "Whore", "Beach Visitor", "Normal Ped", "Normal Ped", "Normal Ped", "Jogger", "Beach Visitor", "Normal Ped", "Skeelering", "Biker", "Normal Ped", "Balla", "Balla", "Balla", "Grove Street Families", "Grove Street Families", "Grove Street Families", "Los Santos Vagos", "Los Santos Vagos", "Los Santos Vagos", "The Russian Mafia", "The Russian Mafia", "The Russian Mafia", "Varios Los Aztecas", "Varios Los Aztecas", "Varios Los Aztecas", "Traid", "Traid", "Traid", "Da Nang Boy", "Da Nang Boy", "Da Nang Boy", "The Mafia", "The Mafia", "The Mafia", "The Mafia", "Farm Inhabitant", "Farm Inhabitant", "Farm Inhabitant", "Farm Inhabitant", "Farm Inhabitant", "Farm Inhabitant", "Homeless", "Homeless", "Normal Ped", "Homeless", "Beach Visitor", "Beach Visitor", "Beach Visitor", "Office Worker", "Taxi Driver", "Normal Ped", "Normal Ped", "Beach Visitor", "Beach Visitor", "Director", "Secretary", "Secretary", "Normal Ped", "Prostitute", "Coffee mam'", "Beach Visitor", "Well Stacked Pizza", "Normal Ped", "Farmer", "Farmer", "Farmer", "Farmer", "Farmer", "Farmer", "Bouncer", "Bouncer", "MIB Agent", "MIB Agent", "Cluckin' Bell", "Food Vendor", "Normal Ped", "Normal Ped", "Casino Worker", "Hotel Services", "San Fierro Rifa", "San Fierro Rifa", "San Fierro Rifa", "Tatoo Shop", "Tatoo Shop", "Whore", "Ammu-Nation Salesmen", "Normal Ped", "Punker", "Normal Ped", "Normal Ped", "Normal Ped", "Normal Ped", "Normal Ped", "Buisnessman", "Normal Ped", "Valet", "Barbara Schternvart", "Helena Wankstein", "Michelle Cannes", "Katie Zhan", "Millie Perkins", "Denise Robinson", "Farm-Town inhabitant", "Farm-Town inhabitant", "Farm-Town inhabitant", "Farm-Town inhabitant", "Farmer", "Farmer", "Farmer", "Karate Teacher", "Karate Teacher", "Burger Shot Cashier", "Normal Ped", "Prostitute", "Well Stacked Pizza", "Normal Ped", "Shop Staff", "Homeless", "Weird old man", "Normal Ped", "Normal Ped", "Normal Ped", "Shop Staff", "Normal Ped", "Secretary", "Taxi Driver", "Normal Ped", "Normal Ped", "Normal Ped", "Sofori", "Normal Ped", "Normal Ped", "Normal Ped", "Normal Ped", "Normal Ped", "Homeless", "Normal Ped", "Normal Ped", "Normal Ped", "Normal Ped", "Normal Ped", "Normal Ped", "Prostitute", "Prostitute", "Homeless", "The D.A", "Afro-American", "Mexican", "Prostitute", "Whore", "Prostitute", "Whore", "Biker", "Biker", "Pimp", "Normal Ped", "Beach Visitor", "Naked Valet", "Bus Driver", "Drug Dealer", "Limo Driver", "Whore", "Whore", "Golfer", "Golfer", "Construction Site", "Normal Ped", "Taxi Driver", "Normal Ped", "Clown", "Tenpenny", "Pulaski", "Crooked Cop", "Dwaine", "Big Smoke", "Sweet", "Ryder", "Mafia Boss", "Paramedic", "Paramedic", "Paramedic", "Firefighter", "Firefighter", "Firefighter", "Los Santos Police", "San Fierro Police", "Las Venturas Police", "Country Sheriff", "San Andreas Police Dept.", "S.W.A.T Special Forces", "Federal Agents", "San Andreas Army", "Desert Sheriff"}
    Dim g_SkinLocation() As String = {"Anywhere", "San Fierro and Las Venturas", "Las Venturas and Los Santos", "San Andreas", "San Andreas", "San Andreas", "Las Venturas Casinos", "San Andreas", "San Andreas", "San Andreas", "San Andreas", "Airports", "San Andreas", "Beaches of SA", "San Andreas", "San Andreas", "San Andreas", "San Andreas", "Los Santos", "Madd Dogg's Mansion", "Madd Dogg's Mansion", "San Andreas", "Doherty", "Los Santos", "San Fierro", "Las Venturas", "San Andreas", "San Andreas", "San Andreas", "San Andreas", "San Andreas", "San Andreas", "San Andreas", "San Andreas", "San Andreas", "San Andreas", "San Andreas", "San Andreas", "San Andreas", "Beaches of SA", "San Andreas", "San Andreas", "San Andreas", "San Andreas", "San Andreas", "San Andreas", "San Andreas", "San Andreas", "San Andreas", "San Andreas", "San Andreas", "San Andreas", "San Andreas", "San Andreas", "San Andreas", "San Andreas", "San Andreas", "San Andreas", "Bars", "Bars", "Las Venturas", "San Andreas", "Area 69", "San Andreas", "San Fierro", "San Andreas", "San Andreas", "San Andreas", "San Andreas", "San Andreas", "San Andreas Gyms", "San Andreas Gyms", "San Andreas", "San Andreas", "San Andreas", "San Andreas", "San Andreas", "San Andreas", "San Andreas", "San Andreas", "Beaches of SA", "San Andreas", "San Andreas", "San Andreas", "San Andreas", "Beaches of SA", "San Andreas", "San Andreas", "San Andreas", "San Andreas", "Los Santos", "Los Santos", "Los Santos", "Los Santos", "Los Santos", "Los Santos", "Los Santos", "Los Santos", "Los Santos", "Around SA", "Around SA", "Around SA", "Los Santos", "Los Santos", "Los Santos", "San Fierro", "San Fierro", "San Fierro", "San Fierro", "San Fierro", "San Fierro", "Las Venturas", "Las Venturas", "Las Venturas", "Las Venturas", "San Andreas", "San Andreas", "San Andreas", "San Andreas", "San Andreas", "San Andreas", "San Andreas", "San Andreas", "San Andreas", "San Andreas", "Beaches of SA", "Beaches of SA", "Beaches of SA", "San Andreas", "San Fierro", "San Andreas", "San Andreas", "Beaches of SA", "Beaches of SA", "San Andreas", "San Andreas", "San Andreas", "San Andreas", "San Andreas", "San Andreas", "Beaches of SA", "San Andreas", "San Andreas", "San Andreas", "San Andreas", "San Andreas", "San Andreas", "San Andreas", "San Andreas", "San Andreas", "San Andreas", "San Andreas", "San Andreas", "San Andreas", "Food Stalls", "San Andreas", "San Andreas", "San Andreas", "San Andreasin", "San Fierro", "San Fierro", "San Fierro", "San Andreas", "San Andreas", "San Andreas", "San Andreas", "San Andreas", "San Andreas", "San Andreas", "San Andreas", "San Andreas", "San Andreas", "San Andreas", "San Andreas", "San Andreas", "San Andreas", "El Quebrados", "Blueberry", "San Fierro", "San Fierro", "Las Venturas", "Los Santos", "San Andreas", "San Andreas", "San Andreas", "San Andreas", "San Andreas", "San Andreas", "San Andreas", "San Andreas", "San Andreas", "San Andreas", "San Andreas", "San Andreas", "San Andreas", "San Andreas", "San Andreas", "San Andreas", "San Andreas", "San Andreas", "San Andreas", "San Andreas", "San Andreas", "San Andreas", "San Andreas", "San Fierro", "San Andreas", "San Andreas", "San Andreas", "San Andreas", "San Andreas", "San Andreas", "San Andreas", "San Andreas", "San Andreas", "San Andreas", "San Andreas", "San Andreas", "San Andreas", "San Andreas", "San Andreas", "San Andreas", "San Andreas", "San Andreas", "San Andreas", "San Fierro", "San Andreas", "San Andreas", "San Andreas", "San Andreas", "San Andreas", "San Andreas", "San Andreas", "San Andreas", "San Fierro", "San Andreas", "Beaches of SA", "Los Santos", "San Fierro", "San Andreas", "San Andreas", "San Andreas", "San Andreas", "San Andreas", "San Andreas", "San Fierro", "San Andreas", "San Andreas", "San Andreas", "San Andreas", "Missions", "Missions", "Missions", "San Fierro", "Los Santos", "Los Santos", "Los Santos", "Los Santos", "Los Santos", "Las Venturas", "San Fierro", "Los Santos", "Las Venturas", "San Fierro", "Los Santos", "San Fierro", "Las Venturas", "Countryside", "San Andreas", "San Andreas", "San Andreas", "San Andreas", "Desert"}
    Dim g_SkinGender() As String = {"Male", "Male", "Male", "Male", "Female", "Female", "Female", "Female", "Female", "Male", "Male", "Male", "Male", "Male", "Male", "Male", "Male", "Male", "Male", "Male", "Male", "Male", "Male", "Male", "Male", "Male", "Female", "Male", "Male", "Male", "Male", "Male", "Male", "Male", "Female", "Female", "Female", "Male", "Male", "Male", "Male", "Male", "Male", "Male", "Male", "Male", "Male", "Female", "Female", "Female", "Male", "Male", "Male", "Male", "Male", "Male", "Female", "Female", "Male", "Male", "Male", "Female", "Male", "Male", "Male", "Female", "Female", "Female", "Male", "Male", "Male", "Male", "Male", "Male", "Male", "Female", "Female", "Female", "Female", "Female", "Female", "Female", "Male", "Male", "Male", "Male", "Male", "Male", "Male", "Male", "Male", "Male", "Male", "Male", "Male", "Male", "Male", "Male", "Male", "Male", "Male", "Male", "Male", "Male", "Male", "Male", "Male", "Male", "Male", "Male", "Male", "Male", "Male", "Male", "Male", "Male", "Female", "Female", "Female", "Male", "Male", "Male", "Male", "Male", "Male", "Female", "Female", "Female", "Female", "Male", "Male", "Male", "Female", "Male", "Male", "Female", "Female", "Female", "Female", "Male", "Male", "Male", "Male", "Female", "Male", "Male", "Male", "Male", "Male", "Male", "Male", "Male", "Male", "Male", "Male", "Female", "Male", "Male", "Female", "Male", "Male", "Male", "Male", "Male", "Female", "Male", "Male", "Male", "Male", "Male", "Male", "Male", "Male", "Male", "Male", "Male", "Female", "Female", "Female", "Female", "Female", "Female", "Female", "Female", "Female", "Female", "Male", "Female", "Male", "Male", "Male", "Female", "Male", "Female", "Male", "Male", "Female", "Male", "Male", "Female", "Female", "Female", "Male", "Female", "Female", "Male", "Male", "Male", "Male", "Female", "Female", "Female", "Male", "Male", "Male", "Male", "Female", "Female", "Female", "Male", "Male", "Male", "Female", "Female", "Male", "Male", "Male", "Male", "Female", "Female", "Female", "Female", "Male", "Male", "Male", "Male", "Female", "Male", "Male", "Male", "Male", "Female", "Female", "Male", "Male", "Male", "Male", "Male", "Female", "Male", "Male", "Male", "Male", "Male", "Male", "Male", "Male", "Male", "Male", "Male", "Male", "Male", "Male", "Male", "Male", "Male", "Male", "Male", "Male", "Male", "Male", "Male", "Male"}
    Dim g_SkinImage() As Image = {My.Resources.Skin_0, My.Resources.Skin_0_001, My.Resources.Skin_0_002, My.Resources.Skin_7, My.Resources.Skin_9, My.Resources.Skin_10, My.Resources.Skin_11, My.Resources.Skin_12, My.Resources.Skin_13, My.Resources.Skin_14, My.Resources.Skin_15, My.Resources.Skin_16, My.Resources.Skin_17, My.Resources.Skin_18, My.Resources.Skin_19, My.Resources.Skin_20, My.Resources.Skin_21, My.Resources.Skin_22, My.Resources.Skin_23, My.Resources.Skin_24, My.Resources.Skin_25, My.Resources.Skin_26, My.Resources.Skin_27, My.Resources.Skin_28, My.Resources.Skin_29, My.Resources.Skin_30, My.Resources.Skin_31, My.Resources.Skin_32, My.Resources.Skin_33, My.Resources.Skin_34, My.Resources.Skin_35, My.Resources.Skin_36, My.Resources.Skin_37, My.Resources.Skin_38, My.Resources.Skin_39, My.Resources.Skin_40, My.Resources.Skin_41, My.Resources.Skin_43, My.Resources.Skin_44, My.Resources.Skin_45, My.Resources.Skin_46, My.Resources.Skin_47, My.Resources.Skin_48, My.Resources.Skin_49, My.Resources.Skin_50, My.Resources.Skin_51, My.Resources.Skin_52, My.Resources.Skin_54, My.Resources.Skin_55, My.Resources.Skin_56, My.Resources.Skin_57, My.Resources.Skin_58, My.Resources.Skin_59, My.Resources.Skin_60, My.Resources.Skin_61, My.Resources.Skin_62, My.Resources.Skin_63, My.Resources.Skin_64, My.Resources.Skin_66, My.Resources.Skin_67, My.Resources.Skin_68, My.Resources.Skin_69, My.Resources.Skin_70, My.Resources.Skin_72, My.Resources.Skin_73, My.Resources.Skin_75, My.Resources.Skin_76, My.Resources.Skin_77, My.Resources.Skin_78, My.Resources.Skin_79, My.Resources.Skin_80, My.Resources.Skin_81, My.Resources.Skin_82, My.Resources.Skin_83, My.Resources.Skin_84, My.Resources.Skin_85, My.Resources.Skin_87, My.Resources.Skin_88, My.Resources.Skin_89, My.Resources.Skin_90, My.Resources.Skin_92, My.Resources.Skin_93, My.Resources.Skin_94, My.Resources.Skin_95, My.Resources.Skin_96, My.Resources.Skin_97, My.Resources.Skin_98, My.Resources.Skin_99, My.Resources.Skin_100, My.Resources.Skin_101, My.Resources.Skin_102, My.Resources.Skin_103, My.Resources.Skin_104, My.Resources.Skin_105, My.Resources.Skin_106, My.Resources.Skin_107, My.Resources.Skin_108, My.Resources.Skin_109, My.Resources.Skin_110, My.Resources.Skin_111, My.Resources.Skin_112, My.Resources.Skin_113, My.Resources.Skin_114, My.Resources.Skin_115, My.Resources.Skin_116, My.Resources.Skin_117, My.Resources.Skin_118, My.Resources.Skin_120, My.Resources.Skin_121, My.Resources.Skin_122, My.Resources.Skin_123, My.Resources.Skin_124, My.Resources.Skin_125, My.Resources.Skin_126, My.Resources.Skin_127, My.Resources.Skin_128, My.Resources.Skin_129, My.Resources.Skin_130, My.Resources.Skin_131, My.Resources.Skin_132, My.Resources.Skin_133, My.Resources.Skin_134, My.Resources.Skin_135, My.Resources.Skin_136, My.Resources.Skin_137, My.Resources.Skin_138, My.Resources.Skin_139, My.Resources.Skin_140, My.Resources.Skin_141, My.Resources.Skin_142, My.Resources.Skin_143, My.Resources.Skin_144, My.Resources.Skin_145, My.Resources.Skin_146, My.Resources.Skin_147, My.Resources.Skin_148, My.Resources.Skin_150, My.Resources.Skin_151, My.Resources.Skin_152, My.Resources.Skin_153, My.Resources.Skin_154, My.Resources.Skin_155, My.Resources.Skin_156, My.Resources.Skin_157, My.Resources.Skin_158, My.Resources.Skin_159, My.Resources.Skin_160, My.Resources.Skin_161, My.Resources.Skin_162, My.Resources.Skin_163, My.Resources.Skin_164, My.Resources.Skin_165, My.Resources.Skin_166, My.Resources.Skin_167, My.Resources.Skin_168, My.Resources.Skin_169, My.Resources.Skin_170, My.Resources.Skin_171, My.Resources.Skin_172, My.Resources.Skin_173, My.Resources.Skin_174, My.Resources.Skin_175, My.Resources.Skin_176, My.Resources.Skin_177, My.Resources.Skin_178, My.Resources.Skin_179, My.Resources.Skin_180, My.Resources.Skin_181, My.Resources.Skin_182, My.Resources.Skin_183, My.Resources.Skin_184, My.Resources.Skin_185, My.Resources.Skin_186, My.Resources.Skin_187, My.Resources.Skin_188, My.Resources.Skin_189, My.Resources.Skin_190, My.Resources.Skin_191, My.Resources.Skin_192, My.Resources.Skin_193, My.Resources.Skin_194, My.Resources.Skin_195, My.Resources.Skin_196, My.Resources.Skin_197, My.Resources.Skin_198, My.Resources.Skin_199, My.Resources.Skin_200, My.Resources.Skin_201, My.Resources.Skin_202, My.Resources.Skin_203, My.Resources.Skin_204, My.Resources.Skin_205, My.Resources.Skin_206, My.Resources.Skin_207, My.Resources.Skin_209, My.Resources.Skin_210, My.Resources.Skin_211, My.Resources.Skin_212, My.Resources.Skin_213, My.Resources.Skin_214, My.Resources.Skin_215, My.Resources.Skin_216, My.Resources.Skin_217, My.Resources.Skin_218, My.Resources.Skin_219, My.Resources.Skin_220, My.Resources.Skin_221, My.Resources.Skin_222, My.Resources.Skin_223, My.Resources.Skin_224, My.Resources.Skin_225, My.Resources.Skin_226, My.Resources.Skin_227, My.Resources.Skin_228, My.Resources.Skin_229, My.Resources.Skin_230, My.Resources.Skin_231, My.Resources.Skin_232, My.Resources.Skin_233, My.Resources.Skin_234, My.Resources.Skin_235, My.Resources.Skin_236, My.Resources.Skin_237, My.Resources.Skin_238, My.Resources.Skin_239, My.Resources.Skin_240, My.Resources.Skin_241, My.Resources.Skin_242, My.Resources.Skin_243, My.Resources.Skin_244, My.Resources.Skin_245, My.Resources.Skin_246, My.Resources.Skin_247, My.Resources.Skin_248, My.Resources.Skin_249, My.Resources.Skin_250, My.Resources.Skin_251, My.Resources.Skin_252, My.Resources.Skin_253, My.Resources.Skin_254, My.Resources.Skin_255, My.Resources.Skin_256, My.Resources.Skin_257, My.Resources.Skin_258, My.Resources.Skin_259, My.Resources.Skin_260, My.Resources.Skin_261, My.Resources.Skin_262, My.Resources.Skin_263, My.Resources.Skin_264, My.Resources.Skin_0, My.Resources.Skin_0, My.Resources.Skin_0, My.Resources.Skin_0, My.Resources.Skin_0, My.Resources.Skin_0, My.Resources.Skin_0, My.Resources.Skin_0, My.Resources.Skin_274, My.Resources.Skin_275, My.Resources.Skin_276, My.Resources.Skin_277, My.Resources.Skin_278, My.Resources.Skin_279, My.Resources.Skin_280, My.Resources.Skin_281, My.Resources.Skin_282, My.Resources.Skin_283, My.Resources.Skin_284, My.Resources.Skin_285, My.Resources.Skin_286, My.Resources.Skin_287, My.Resources.Skin_288}

    Dim player As New Media.SoundPlayer
    Dim g_LastSelected As Integer = 0

    Private Sub frmMain_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            MoveForm = 1
            CordX = e.X
            CordY = e.Y
            Me.Cursor = Cursors.NoMove2D
        End If
    End Sub

    Private Sub frmMain_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If MoveForm Then
            Me.Location = New Point((Me.Left + e.X - CordX), (Me.Top + e.Y - CordY))
        End If
    End Sub

    Private Sub frmMain_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        MoveForm = 0
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub tabVehicles_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles tabVehicles.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            MoveForm = 1
            CordX = e.X
            CordY = e.Y
            Me.Cursor = Cursors.NoMove2D
        End If
    End Sub

    Private Sub tabVehicles_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles tabVehicles.MouseMove
        If MoveForm Then
            Me.Location = New Point((Me.Left + e.X - CordX), (Me.Top + e.Y - CordY))
        End If
    End Sub

    Private Sub tabVehicles_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles tabVehicles.MouseUp
        MoveForm = 0
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub tabSounds_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles tabSounds.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            MoveForm = 1
            CordX = e.X
            CordY = e.Y
            Me.Cursor = Cursors.NoMove2D
        End If
    End Sub

    Private Sub tabSounds_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles tabSounds.MouseMove
        If MoveForm Then
            Me.Location = New Point((Me.Left + e.X - CordX), (Me.Top + e.Y - CordY))
        End If
    End Sub

    Private Sub tabSounds_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles tabSounds.MouseUp
        MoveForm = 0
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub tabWeather_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles tabWeather.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            MoveForm = 1
            CordX = e.X
            CordY = e.Y
            Me.Cursor = Cursors.NoMove2D
        End If
    End Sub

    Private Sub tabWeather_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles tabWeather.MouseMove
        If MoveForm Then
            Me.Location = New Point((Me.Left + e.X - CordX), (Me.Top + e.Y - CordY))
        End If
    End Sub

    Private Sub tabWeather_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles tabWeather.MouseUp
        MoveForm = 0
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub tabColors_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles tabColors.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            MoveForm = 1
            CordX = e.X
            CordY = e.Y
            Me.Cursor = Cursors.NoMove2D
        End If
    End Sub

    Private Sub tabColors_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles tabColors.MouseMove
        If MoveForm Then
            Me.Location = New Point((Me.Left + e.X - CordX), (Me.Top + e.Y - CordY))
        End If
    End Sub

    Private Sub tabColors_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles tabColors.MouseUp
        MoveForm = 0
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub tabGameText_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles tabGameText.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            MoveForm = 1
            CordX = e.X
            CordY = e.Y
            Me.Cursor = Cursors.NoMove2D
        End If
    End Sub

    Private Sub tabGameText_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles tabGameText.MouseMove
        If MoveForm Then
            Me.Location = New Point((Me.Left + e.X - CordX), (Me.Top + e.Y - CordY))
        End If
    End Sub

    Private Sub tabGameText_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles tabGameText.MouseUp
        MoveForm = 0
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub tabPickups_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles tabPickups.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            MoveForm = 1
            CordX = e.X
            CordY = e.Y
            Me.Cursor = Cursors.NoMove2D
        End If
    End Sub

    Private Sub tabPickups_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles tabPickups.MouseMove
        If MoveForm Then
            Me.Location = New Point((Me.Left + e.X - CordX), (Me.Top + e.Y - CordY))
        End If
    End Sub

    Private Sub tabPickups_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles tabPickups.MouseUp
        MoveForm = 0
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub tabExplosions_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles tabExplosions.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            MoveForm = 1
            CordX = e.X
            CordY = e.Y
            Me.Cursor = Cursors.NoMove2D
        End If
    End Sub

    Private Sub tabExplosions_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles tabExplosions.MouseMove
        If MoveForm Then
            Me.Location = New Point((Me.Left + e.X - CordX), (Me.Top + e.Y - CordY))
        End If
    End Sub

    Private Sub tabExplosions_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles tabExplosions.MouseUp
        MoveForm = 0
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub tabCallbacks_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles tabCallbacks.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            MoveForm = 1
            CordX = e.X
            CordY = e.Y
            Me.Cursor = Cursors.NoMove2D
        End If
    End Sub

    Private Sub tabCallbacks_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles tabCallbacks.MouseMove
        If MoveForm Then
            Me.Location = New Point((Me.Left + e.X - CordX), (Me.Top + e.Y - CordY))
        End If
    End Sub

    Private Sub tabCallbacks_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles tabCallbacks.MouseUp
        MoveForm = 0
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub tabWeapons_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles tabWeapons.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            MoveForm = 1
            CordX = e.X
            CordY = e.Y
            Me.Cursor = Cursors.NoMove2D
        End If
    End Sub

    Private Sub tabWeapons_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles tabWeapons.MouseMove
        If MoveForm Then
            Me.Location = New Point((Me.Left + e.X - CordX), (Me.Top + e.Y - CordY))
        End If
    End Sub

    Private Sub tabWeapons_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles tabWeapons.MouseUp
        MoveForm = 0
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub tabSkins_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles tabSkins.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            MoveForm = 1
            CordX = e.X
            CordY = e.Y
            Me.Cursor = Cursors.NoMove2D
        End If
    End Sub

    Private Sub tabSkins_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles tabSkins.MouseMove
        If MoveForm Then
            Me.Location = New Point((Me.Left + e.X - CordX), (Me.Top + e.Y - CordY))
        End If
    End Sub

    Private Sub tabSkins_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles tabSkins.MouseUp
        MoveForm = 0
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub mnuMain_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles mnuMain.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            MoveForm = 1
            CordX = e.X
            CordY = e.Y
            Me.Cursor = Cursors.NoMove2D
        End If
    End Sub

    Private Sub mnuMain_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles mnuMain.MouseMove
        If MoveForm Then
            Me.Location = New Point((Me.Left + e.X - CordX), (Me.Top + e.Y - CordY))
        End If
    End Sub

    Private Sub mnuMain_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles mnuMain.MouseUp
        MoveForm = 0
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub frmMain_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Try
            If Me.WindowState = FormWindowState.Minimized And My.Settings.Minimize = True Then
                Me.WindowState = FormWindowState.Minimized
                NotifyIcon1.Visible = True
                Me.Hide()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub VehicleParser(ByVal selection As String)
        Dim index As Integer = FindStringIndex(selection, g_VehicleModelNames)
        picVehicles.Image = g_VehicleModelImages(index)
        txtVModelID.Text = index + 400
        TextBox1.Text = selection
    End Sub

    Public Function FindStringIndex(ByVal word As String, ByVal ArrayToSearch() As String) As Integer
        Dim WordIndex As Integer = Array.IndexOf(ArrayToSearch, word)
        Return WordIndex
    End Function

    Private Sub lstBikes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstBikes.SelectedIndexChanged
        VehicleParser(lstBikes.SelectedItem.ToString)
    End Sub

    Private Sub lstPlanes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstPlanes.SelectedIndexChanged
        VehicleParser(lstPlanes.SelectedItem.ToString)
    End Sub

    Private Sub listBoats_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles listBoats.SelectedIndexChanged
        VehicleParser(listBoats.SelectedItem.ToString)
    End Sub

    Private Sub listCars_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles listCars.SelectedIndexChanged
        VehicleParser(listCars.SelectedItem.ToString)
    End Sub

    Private Sub lstCopters_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstCopters.SelectedIndexChanged
        VehicleParser(lstCopters.SelectedItem.ToString)
    End Sub

    Private Sub lstOffroad_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstOffroad.SelectedIndexChanged
        VehicleParser(lstOffroad.SelectedItem.ToString)
    End Sub

    Private Sub lstTrailer_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstTrailer.SelectedIndexChanged
        VehicleParser(lstTrailer.SelectedItem.ToString)
    End Sub

    Private Sub lstRCVehicles_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstRCVehicles.SelectedIndexChanged
        VehicleParser(lstRCVehicles.SelectedItem.ToString)
    End Sub

    Private Sub lstIndustrial_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstIndustrial.SelectedIndexChanged
        VehicleParser(lstIndustrial.SelectedItem.ToString)
    End Sub

    Private Sub btnPlay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlay.Click
        Dim index As Integer = lstSounds.SelectedIndex
        player.Stream = g_SoundFile(index)

        txtSongName.Text = lstSounds.SelectedItem.ToString
        txtSoundID.Text = g_SoundID(index)

        player.Play()
    End Sub

    Private Sub btnStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStop.Click
        player.Stop()
    End Sub

    Private Sub lstSounds_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstSounds.SelectedIndexChanged
        Dim index As Integer = lstSounds.SelectedIndex

        txtSelectedSoundID.Text = g_SoundID(index)
        txtSelectedSoundName.Text = lstSounds.SelectedItem.ToString
    End Sub

    Private Sub lstWeather_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstWeather.SelectedIndexChanged
        Dim index As Integer = lstWeather.SelectedIndex

        txtWeatherID.Text = g_WeatherID(index)
        picWeather.Image = g_WeatherPic(index)
    End Sub

    Private Sub btnColorMap_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnColorMap.Click
        frmColorMap.Show()
    End Sub

    Private Sub btnColorVehicles_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnColorVehicles.Click
        frmVehicleColors.Show()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim index As Integer = ComboBox1.SelectedIndex

        picGameText.Image = g_GameTextStyle(index)
    End Sub

    Private Sub btnMiscPickups_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMiscPickups.Click
        lstMiscPickups.Show()
        lstPickupTypes.Hide()
        lstWeaponPickups.Hide()
    End Sub

    Private Sub btnWeaponPickups_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWeaponPickups.Click
        lstMiscPickups.Hide()
        lstPickupTypes.Hide()
        lstWeaponPickups.Show()
    End Sub

    Private Sub btnPickupTypes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPickupTypes.Click
        lstMiscPickups.Hide()
        lstPickupTypes.Show()
        lstWeaponPickups.Hide()
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        Dim index As Integer = ComboBox2.SelectedIndex()

        txtVisible.Text = g_ExplosionVisible(index)
        txtRange.Text = g_ExplosionRange(index)
        txtSplits.Text = g_ExplosionSplits(index)
    End Sub

    Private Sub lstWeapons_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstWeapons.SelectedIndexChanged
        Dim index As Integer = lstWeapons.SelectedIndex()

        picWeaponIcon.Image = g_WeaponImages(index)
        picWeaponImage.Image = g_WeaponPictures(index)

        txtWeaponID.Text = g_WeaponID(index)
        txtWeaponModel.Text = g_WeaponModels(index)
        txtWeaponSlot.Text = g_WeaponSlots(index)
    End Sub

    Private Sub lstMiscPickups_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstMiscPickups.SelectedIndexChanged
        Dim index As Integer = lstMiscPickups.SelectedIndex()

        picPickup.Image = g_MiscPickups(index)
    End Sub

    Private Sub lstWeaponPickups_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstWeaponPickups.SelectedIndexChanged
        Dim index As Integer = lstWeaponPickups.SelectedIndex()

        picPickup.Image = g_WeaponPickups(index)
    End Sub

    Private Sub lstSkinID_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstSkinID.SelectedIndexChanged
        Dim index As Integer = lstSkinID.SelectedIndex

        txtModelName.Text = g_SkinModelName(index)
        txtCharacterName.Text = g_SkinName(index)
        txtLocation.Text = g_SkinLocation(index)
        txtGender.Text = g_SkinGender(index)

        picSkin.Image = g_SkinImage(index)
    End Sub

    Private Sub SettingsToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SettingsToolStripMenuItem4.Click
        'My.Settings.Minimize = SettingsToolStripMenuItem4.Checked
    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        NotifyIcon1.Visible = False
        Me.Show()
    End Sub

    Private Sub AboutToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem3.Click
        AboutBox1.Show()
    End Sub

    Private Sub CreditsToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreditsToolStripMenuItem1.Click
        Form4.Show()
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Application.Exit()
    End Sub
End Class