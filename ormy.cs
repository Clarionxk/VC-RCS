    G �����  HM ���� ����� >E1�&n���$1A � �  '� d� �4�΀���\1A � � '� d� g.�B����$1A  �  �  '�  d� \(2��u��W[1A$ �$ �$ '�$ d� �,.�LH���$1A( �( �( '�( d� G�/�P����$1A, �, �, '�, d� �&*D6����҂A0 �0 �0  '�0 d� �t+��[���̂A4 �4 �4 '�4 dN VAR /   ARENA_DOOR_1    ARENA_DOOR_2    ARMY1    ARMY2    ARMY3    ARMY4 	   ARMY44 
   ARMY5    ARMY6    ARMY7    CAR_SHOWROOM_ASSET �  CURRENT_TIME_IN_MS �  CUT_SCENE_TIME |   DEFAULT_WAIT_TIME    FILM_STUDIO_ASSET �  FILM_STUDIO_BACK_GATE_CLOSED   FILM_STUDIO_BACK_GATE_OPEN   FILM_STUDIO_FRONT_GATE_CLOSED   FILM_STUDIO_FRONT_GATE_OPEN   ICE_CREAM_FACTORY_ASSET �  LANCE_VANCE �   ONMISSION 9  PASSED_ASS1_RUB_OUT �   PASSED_COK1_THE_CHASE �   PASSED_COK2_PHNOM_PENH_86 �   PASSED_COK3_THE_FASTEST_BOAT �   PASSED_COK4_SUPPLY_AND_DEMAND �   PASSED_COL1_TREACHEROUS_SWINE �   PASSED_COL2_MALL_SHOOTOUT �   PASSED_COL3_GUARDIAN_ANGELS �   PASSED_COL4_SIR_YES_SIR �   PASSED_COL5_ALL_HANDS_ON_DECK �   PASSED_HAT1_JUJU_SCRAMBLE   PASSED_HAT2_BOMBS_AWAY   PASSED_HAT3_DIRTY_LICKINS   PASSED_KENT1_DEATH_ROW �   PASSED_LAW1_THE_PARTY �   PASSED_LAW2_BACK_ALLEY_BRAWL �   PASSED_LAW3_JURY_FURY �   PASSED_LAW4_RIOT �   PASSED_ROCK1_LOVE_JUICE    PASSED_ROCK2_PSYCHO_KILLER !  PASSED_ROCK3_PUBLICITY_TOUR "  PASSED_TEX1_FOUR_IRON �   PLAYER_ACTOR    PLAYER_CHAR    PRINT_WORKS_ASSET �  FLAG   SRC x	  {$CLEO .cs} //directive to compile a CLEO script
0000: NOP //to avoid a jump-at-zro-offset bug

:label1
0001: wait 0 ms                      
0247: request_model #ARMY
0002: jump @label2 

:label2
00D6: if 
0248:   model #ARMY available 
004D: jump_if_false @label1 
0002: jump @label3

:label3 
Actor.Create($ARMY1, 8, #ARMY, -709.0819, -1291.4421, 11.0715)
02AB: set_actor $ARMY1 immunities BP 1 FP 1 EP 1 CP 1 MP 1 
01B2: give_actor $ARMY1 weapon 32 ammo 9999 // Load the weapon model before using this 
02E2: set_actor $ARMY1 weapon_accuracy_to 100 
Actor.Create($ARMY2, 8, #ARMY, -723.9391, -1300.0251, 11.0852)
02AB: set_actor $ARMY2 immunities BP 1 FP 1 EP 1 CP 1 MP 1 
01B2: give_actor $ARMY2 weapon 11 ammo 9999 // Load the weapon model before using this 
02E2: set_actor $ARMY2 weapon_accuracy_to 100 
Actor.Create($ARMY3, 8, #ARMY, -697.6171, -1316.4143, 11.0715)
02AB: set_actor $ARMY3 immunities BP 1 FP 1 EP 1 CP 1 MP 1 
01B2: give_actor $ARMY3 weapon 31 ammo 9999 // Load the weapon model before using this 
02E2: set_actor $ARMY3 weapon_accuracy_to 100 
Actor.Create($ARMY4, 8, #ARMY,-712.6306, -1323.6769, 11.0848)
02AB: set_actor $ARMY4 immunities BP 1 FP 1 EP 1 CP 1 MP 1 
01B2: give_actor $ARMY4 weapon 19 ammo 9999 // Load the weapon model before using this 
02E2: set_actor $ARMY4 weapon_accuracy_to 100 
Actor.Create($ARMY44, 8, #ARMY, -696.6981, -1298.2593, 11.0715)
02AB: set_actor $ARMY44 immunities BP 1 FP 1 EP 1 CP 1 MP 1 
01B2: give_actor $ARMY44 weapon 31 ammo 9999 // Load the weapon model before using this 
02E2: set_actor $ARMY44 weapon_accuracy_to 100 
Actor.Create($ARMY5, 8, #ARMY, -703.3481, -1284.041, 11.0715)
02AB: set_actor $ARMY5 immunities BP 1 FP 1 EP 1 CP 1 MP 1 
01B2: give_actor $ARMY5 weapon 31 ammo 9999 // Load the weapon model before using this 
02E2: set_actor $ARMY5 weapon_accuracy_to 100 
Actor.Create($ARMY6, 8, #ARMY, 680.6055, -1285.1941, 16.3529)
02AB: set_actor $ARMY6 immunities BP 1 FP 1 EP 1 CP 1 MP 1 
01B2: give_actor $ARMY6 weapon 32 ammo 9999 // Load the weapon model before using this 
02E2: set_actor $ARMY6 weapon_accuracy_to 100 
Actor.Create($ARMY7, 8, #ARMY, -685.8253, -1274.8606, 16.3499)
02AB: set_actor $ARMY7 immunities BP 1 FP 1 EP 1 CP 1 MP 1 
01B2: give_actor $ARMY7 weapon 25 ammo 9999 // Load the weapon model before using this 
02E2: set_actor $ARMY7 weapon_accuracy_to 100 
004E: end_thread�  __SBFTR 