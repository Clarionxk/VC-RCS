    G �����  HM ���� ����� �������f��A � �  '� d� h�������>�A � �  '� d� ���ޛ���mA  �  �   '�  d� R<��������mA$ �$ �$ !'�$ d� H���
�����mA( �( �( '�( d� �������.kA, �, �, '�, d� ����s�����mA0 �0 �0 '�0 d� ���X���w-kA4 �4 �4 '�4 dN VAR /   ARENA_DOOR_1    ARENA_DOOR_2    ARMY1    ARMY2    ARMY3    ARMY4 	   ARMY5 
   ARMY6    ARMY7    ARMY8    CAR_SHOWROOM_ASSET �  CURRENT_TIME_IN_MS �  CUT_SCENE_TIME |   DEFAULT_WAIT_TIME    FILM_STUDIO_ASSET �  FILM_STUDIO_BACK_GATE_CLOSED   FILM_STUDIO_BACK_GATE_OPEN   FILM_STUDIO_FRONT_GATE_CLOSED   FILM_STUDIO_FRONT_GATE_OPEN   ICE_CREAM_FACTORY_ASSET �  LANCE_VANCE �   ONMISSION 9  PASSED_ASS1_RUB_OUT �   PASSED_COK1_THE_CHASE �   PASSED_COK2_PHNOM_PENH_86 �   PASSED_COK3_THE_FASTEST_BOAT �   PASSED_COK4_SUPPLY_AND_DEMAND �   PASSED_COL1_TREACHEROUS_SWINE �   PASSED_COL2_MALL_SHOOTOUT �   PASSED_COL3_GUARDIAN_ANGELS �   PASSED_COL4_SIR_YES_SIR �   PASSED_COL5_ALL_HANDS_ON_DECK �   PASSED_HAT1_JUJU_SCRAMBLE   PASSED_HAT2_BOMBS_AWAY   PASSED_HAT3_DIRTY_LICKINS   PASSED_KENT1_DEATH_ROW �   PASSED_LAW1_THE_PARTY �   PASSED_LAW2_BACK_ALLEY_BRAWL �   PASSED_LAW3_JURY_FURY �   PASSED_LAW4_RIOT �   PASSED_ROCK1_LOVE_JUICE    PASSED_ROCK2_PSYCHO_KILLER !  PASSED_ROCK3_PUBLICITY_TOUR "  PASSED_TEX1_FOUR_IRON �   PLAYER_ACTOR    PLAYER_CHAR    PRINT_WORKS_ASSET �  FLAG   SRC $	  {$CLEO .cs} //directive to compile a CLEO script

0000: NOP //to avoid a jump-at-zro-offset bug

:label1
0001: wait 0 ms                      
0247: request_model #army 
0002: jump @label2 

:label2
00D6: if 
0248:   model #army available 
004D: jump_if_false @label1 
0002: jump @label3

:label3 
$ARMY1 = Actor.Create(Gang2, #ARMY, -1703.249, -326.1454, 20.7458)
02AB: set_actor $ARMY1 immunities 1 1 1 1 1 
01B2: give_actor $ARMY1 weapon 32 ammo 9999 // Load the weapon model before using this 
02E2: set_actor $ARMY1 weapon_accuracy_to 100 
$ARMY2 = Actor.Create(Gang2, #ARMY, -1700.7939, -307.8322, 20.7806)
02AB: set_actor $ARMY2 immunities 1 1 1 1 1 
01B2: give_actor $ARMY2 weapon 32 ammo 9999 // Load the weapon model before using this 
02E2: set_actor $ARMY2 weapon_accuracy_to 100 
$ARMY3 = Actor.Create(Gang2, #ARMY, -1688.6893, -311.7394, 14.8684)
02AB: set_actor $ARMY3 immunities 1 1 1 1 1 
01B2: give_actor $ARMY3 weapon 32 ammo 9999 // Load the weapon model before using this 
02E2: set_actor $ARMY3 weapon_accuracy_to 100 
$ARMY4 = Actor.Create(Gang2, #ARMY, -1689.885, -327.4727, 14.8683)
02AB: set_actor $ARMY4 immunities 1 1 1 1 1 
01B2: give_actor $ARMY4 weapon 33 ammo 9999 // Load the weapon model before using this 
02E2: set_actor $ARMY4 weapon_accuracy_to 100
$ARMY5 = Actor.Create(Gang2, #ARMY, -1742.5088, -271.3128, 14.8683)
02AB: set_actor $ARMY5 immunities 1 1 1 1 1 
01B2: give_actor $ARMY5 weapon 20 ammo 9999 // Load the weapon model before using this 
02E2: set_actor $ARMY5 weapon_accuracy_to 100
$ARMY6 = Actor.Create(Gang2, #ARMY, -1716.2172, -321.1488, 14.6989)
02AB: set_actor $ARMY6 immunities 1 1 1 1 1 
01B2: give_actor $ARMY6 weapon 19 ammo 9999 // Load the weapon model before using this 
02E2: set_actor $ARMY6 weapon_accuracy_to 100
$ARMY7 = Actor.Create(Gang2, #ARMY, -1718.9974, -273.441, 14.8683)
02AB: set_actor $ARMY7 immunities 1 1 1 1 1 
01B2: give_actor $ARMY7 weapon 20 ammo 9999 // Load the weapon model before using this 
02E2: set_actor $ARMY7 weapon_accuracy_to 100
$ARMY8 = Actor.Create(Gang2, #ARMY, -1648.4281, -321.1433, 14.6986)
02AB: set_actor $ARMY8 immunities 1 1 1 1 1 
01B2: give_actor $ARMY8 weapon 20 ammo 9999 // Load the weapon model before using this 
02E2: set_actor $ARMY8 weapon_accuracy_to 100
004E: end_thread
�  __SBFTR 