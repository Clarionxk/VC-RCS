    G_ �����  H_M ���� ����� _���v�����mA � �  '� d� _�������&�mA � �  '� d� _
����
���,kA  �  �   '�  d� _l�����&�mA$ �$ �$  '�$ dN VAR +   ARENA_DOOR_1    ARENA_DOOR_2    CAR_SHOWROOM_ASSET �  CURRENT_TIME_IN_MS �  CUT_SCENE_TIME |   DEFAULT_WAIT_TIME    FILM_STUDIO_ASSET �  FILM_STUDIO_BACK_GATE_CLOSED   FILM_STUDIO_BACK_GATE_OPEN   FILM_STUDIO_FRONT_GATE_CLOSED   FILM_STUDIO_FRONT_GATE_OPEN   ICE_CREAM_FACTORY_ASSET �  LANCE_VANCE �   ONMISSION 9  PASSED_ASS1_RUB_OUT �   PASSED_COK1_THE_CHASE �   PASSED_COK2_PHNOM_PENH_86 �   PASSED_COK3_THE_FASTEST_BOAT �   PASSED_COK4_SUPPLY_AND_DEMAND �   PASSED_COL1_TREACHEROUS_SWINE �   PASSED_COL2_MALL_SHOOTOUT �   PASSED_COL3_GUARDIAN_ANGELS �   PASSED_COL4_SIR_YES_SIR �   PASSED_COL5_ALL_HANDS_ON_DECK �   PASSED_HAT1_JUJU_SCRAMBLE   PASSED_HAT2_BOMBS_AWAY   PASSED_HAT3_DIRTY_LICKINS   PASSED_KENT1_DEATH_ROW �   PASSED_LAW1_THE_PARTY �   PASSED_LAW2_BACK_ALLEY_BRAWL �   PASSED_LAW3_JURY_FURY �   PASSED_LAW4_RIOT �   PASSED_ROCK1_LOVE_JUICE    PASSED_ROCK2_PSYCHO_KILLER !  PASSED_ROCK3_PUBLICITY_TOUR "  PASSED_TEX1_FOUR_IRON �   PGA1    PGA2    PGA3    PGA4 	   PLAYER_ACTOR    PLAYER_CHAR    PRINT_WORKS_ASSET �  FLAG   SRC #  {$CLEO .cs} //directive to compile a CLEO script

0000: NOP //to avoid a jump-at-zro-offset bug

:label1
0001: wait 0 ms                      
0247: request_model #PGA
0002: jump @label2 

:label2
00D6: if 
0248:   model #PGA available 
004D: jump_if_false @label1 
0002: jump @label3

:label3 
$PGA1 = Actor.Create(Gang2, #PGA, -1468.0024, -323.4333, 14.8681)
02AB: set_actor $PGA1 immunities 1 1 1 1 1 
01B2: give_actor $PGA1 weapon 32 ammo 9999 // Load the weapon model before using this 
02E2: set_actor $PGA1 weapon_accuracy_to 100 
$PGA2 = Actor.Create(Gang2, #PGA, -1479.1147, -309.9681, 14.8682)
02AB: set_actor $PGA2 immunities 1 1 1 1 1 
01B2: give_actor $PGA2 weapon 32 ammo 9999 // Load the weapon model before using this 
02E2: set_actor $PGA2 weapon_accuracy_to 100 
$PGA3 = Actor.Create(Gang2, #PGA, -1477.4387, -322.0853, 14.6984)
02AB: set_actor $PGA3 immunities 1 1 1 1 1 
01B2: give_actor $PGA3 weapon 32 ammo 9999 // Load the weapon model before using this 
02E2: set_actor $PGA3 weapon_accuracy_to 100
$PGA4 = Actor.Create(Gang2, #PGA, -1487.0444, -310.1152, 14.8682)
02AB: set_actor $PGA4 immunities 1 1 1 1 1 
01B2: give_actor $PGA4 weapon 32 ammo 9999 // Load the weapon model before using this 
02E2: set_actor $PGA4 weapon_accuracy_to 100
004E: end_thread
	  __SBFTR 