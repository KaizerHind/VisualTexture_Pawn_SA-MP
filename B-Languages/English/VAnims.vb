Public Class VAnims
    Private CordX As Integer
    Private CordY As Integer
    Private MoveForm As Boolean

    Dim strText As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListBox1.Items.AddRange(New Object() {
            "[PED]",
            "-  abseil",
            "-  ARRESTgun",
            "-  ATM",
            "-  bomber",
            "-  CAR_crawloutRHS",
            "-  CAR_doorlocked_LHS",
            "-  CAR_doorlocked_RHS",
            "-  cower",
            "-  endchat_01",
            "-  endchat_02",
            "-  endchat_03",
            "-  facgum",
            "-  factalk",
            "-  FALL_skyDive",
            "-  flee_lkaround_01",
            "-  fucku",
            "-  gas_cwr",
            "-  gum_eat",
            "-  handsup",
            "-  HIT_walk",
            "-  IDLE_chat",
            "-  IDLE_HBHB",
            "-  IDLE_ROCKET",
            "-  IDLE_taxi",
            "-  IDLE_tired",
            "-  KO_shot_face",
            "-  KO_shot_front",
            "-  KO_shot_stom",
            "-  KO_skid_front",
            "-  pass_Smoke_in_car",
            "-  phone_in",
            "-  phone_out",
            "-  phone_talk",
            "-  roadcross",
            "-  run_1armed",
            "-  run_armed",
            "-  run_civi",
            "-  run_fatold",
            "-  run_gang1",
            "-  run_old",
            "-  run_player",
            "-  Run_stop",
            "-  Run_Wuzi",
            "-  SEAT_down",
            "-  SEAT_idle",
            "-  SEAT_up",
            "-  Smoke_in_car",
            "-  Swim_Tread",
            "-  WALK_drunk",
            "-  WALK_fatold",
            "-  WALK_gang1",
            "-  WALK_gang2",
            "-  Walk_Wuzi",
            "-  WOMAN_walkpro",
            "-  WOMAN_walkshop",
            "-  XPRESSscratch",
            "",
            "[Airport]",
            "-  thrw_barl_thrw",
            "",
            "[Attractors]",
            "-  Stepsit_in",
            "-  Stepsit_loop",
            "-  Stepsit_out",
            "",
            "[Bar]",
            "-  Barcustom_get",
            "-  Barcustom_loop",
            "-  Barcustom_order",
            "-  BARman_idle",
            "-  Barserve_bottle",
            "-  Barserve_give",
            "-  Barserve_glass",
            "-  Barserve_in",
            "-  Barserve_loop",
            "-  Barserve_order",
            "-  dnk_stndF_loop",
            "-  dnk_stndM_loop",
            "",
            "[Baseball]",
            "-  Bat_1",
            "-  Bat_2",
            "-  Bat_3",
            "-  Bat_4",
            "-  Bat_IDLE",
            "-  Bat_M",
            "",
            "[Bd_Fire]",
            "-  BD_GF_Wave",
            "-  BD_Panic_01",
            "-  BD_Panic_02",
            "-  BD_Panic_03",
            "-  BD_Panic_04",
            "-  BD_Panic_Loop",
            "-  Grlfrd_Kiss_03",
            "-  M_smklean_loop",
            "-  Playa_Kiss_03",
            "-  wash_up",
            "",
            "[Beach]",
            "-  bather",
            "-  Lay_Bac_Loop",
            "-  ParkSit_M_loop",
            "-  ParkSit_W_loop",
            "-  SitnWait_loop_W",
            "",
            "[Benchpress]",
            "-  gym_bp_celebrate",
            "-  gym_bp_down",
            "-  gym_bp_getoff",
            "-  gym_bp_geton",
            "-  gym_bp_up_A",
            "-  gym_bp_up_B",
            "-  gym_bp_up_smooth",
            "",
            "[Biked]",
            "-  BIKEd_Back",
            "-  BIKEd_hit",
            "",
            "[Bikeh]",
            "-  BIKEh_Back",
            "-  BIKEh_hit",
            "",
            "[Bikeleap]",
            "-  struggle_cesar",
            "-  struggle_driver",
            "",
            "[Bikes]",
            "-  BIKEs_Back",
            "-  BIKEs_hit",
            "",
            "[Bike_Dbz]",
            "-  Pass_Driveby_BWD",
            "-  Pass_Driveby_FWD",
            "-  Pass_Driveby_LHS",
            "-  Pass_Driveby_RHS",
            "",
            "[Blowjobz]",
            "-  BJ_Car_End_P",
            "-  BJ_Car_End_W",
            "-  BJ_Car_Loop_P",
            "-  BJ_Car_Loop_W",
            "-  BJ_Car_Start_P",
            "-  BJ_Car_Start_W",
            "-  BJ_Couch_End_P",
            "-  BJ_Couch_End_W",
            "-  BJ_Couch_Loop_P",
            "-  BJ_Couch_Loop_W",
            "-  BJ_Couch_Start_P",
            "-  BJ_Couch_Start_W",
            "-  BJ_Stand_End_P",
            "-  BJ_Stand_End_W",
            "-  BJ_Stand_Loop_P",
            "-  BJ_Stand_Loop_W",
            "-  BJ_Stand_Start_P",
            "-  BJ_Stand_Start_W",
            "",
            "[Bomber]",
            "-  Plant",
            "-  Plant_2Idle",
            "-  Plant_Crouch_In",
            "-  Plant_Loop",
            "",
            "[Box]",
            "-  boxhipin",
            "-  boxhipup",
            "-  boxshdwn",
            "-  catch_box",
            "",
            ""})

        RichTextBox1.Visible = False
        PictureBox1.Visible = False
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Select Case ListBox1.SelectedIndex
            Case 0
                PictureBox1.Visible = False
                RichTextBox1.Enabled = False
                RichTextBox1.Visible = False
                ListBox1.SelectedIndex = True
                RichTextBox1.Text = ""

            Case 1
                PictureBox1.Image = Global.VisualTextures.My.Resources.ped_abseil
                PictureBox1.Visible = True
                RichTextBox1.Enabled = True
                RichTextBox1.Visible = True
                RichTextBox1.Text =
"new Variable;
Variable = CreateActor(ID, X, Y, Z, RZ);
ApplyActorAnimation(Variable, ""PED"", ""abseil"", 4.0, 1, 1, 1, 0, 0);"
            Case 2
                PictureBox1.Image = Global.VisualTextures.My.Resources.ped_ARRESTgun
                PictureBox1.Visible = True
                RichTextBox1.Enabled = True
                RichTextBox1.Visible = True
                RichTextBox1.Text =
"new Variable;
Variable = CreateActor(ID, X, Y, Z, RZ);
ApplyActorAnimation(Variable, ""PED"", ""ARRESTgun"", 4.0, 1, 1, 1, 0, 0);"
            Case 3
                PictureBox1.Image = Global.VisualTextures.My.Resources.ped_ATM
                PictureBox1.Visible = True
                RichTextBox1.Enabled = True
                RichTextBox1.Visible = True
                RichTextBox1.Text =
"new Variable;
Variable = CreateActor(ID, X, Y, Z, RZ);
ApplyActorAnimation(Variable, ""PED"", ""ATM"", 4.0, 1, 1, 1, 0, 0);"
            Case 4
                PictureBox1.Image = Global.VisualTextures.My.Resources.ped_bomber
                PictureBox1.Visible = True
                RichTextBox1.Enabled = True
                RichTextBox1.Visible = True
                RichTextBox1.Text =
"new Variable;
Variable = CreateActor(ID, X, Y, Z, RZ);
ApplyActorAnimation(Variable, ""PED"", ""bomber"", 4.0, 1, 1, 1, 0, 0);"
            Case 5
                PictureBox1.Image = Global.VisualTextures.My.Resources.ped_CAR_crawloutRHS
                PictureBox1.Visible = True
                RichTextBox1.Enabled = True
                RichTextBox1.Visible = True
                RichTextBox1.Text =
"new Variable;
Variable = CreateActor(ID, X, Y, Z, RZ);
ApplyActorAnimation(Variable, ""PED"", ""CAR_crawloutRHS"", 4.0, 1, 1, 1, 0, 0);"
            Case 6
                PictureBox1.Image = Global.VisualTextures.My.Resources.ped_CAR_doorlocked_LHS
                PictureBox1.Visible = True
                RichTextBox1.Enabled = True
                RichTextBox1.Visible = True
                RichTextBox1.Text =
"new Variable;
Variable = CreateActor(ID, X, Y, Z, RZ);
ApplyActorAnimation(Variable, ""PED"", ""CAR_doorlocked_LHS"", 4.0, 1, 1, 1, 0, 0);"
            Case 7
                PictureBox1.Image = Global.VisualTextures.My.Resources.ped_CAR_doorlocked_RHS
                PictureBox1.Visible = True
                RichTextBox1.Enabled = True
                RichTextBox1.Visible = True
                RichTextBox1.Text =
"new Variable;
Variable = CreateActor(ID, X, Y, Z, RZ);
ApplyActorAnimation(Variable, ""PED"", ""CAR_doorlocked_RHS"", 4.0, 1, 1, 1, 0, 0);"
            Case 8
                PictureBox1.Image = Global.VisualTextures.My.Resources.ped_cower
                PictureBox1.Visible = True
                RichTextBox1.Enabled = True
                RichTextBox1.Visible = True
                RichTextBox1.Text =
"new Variable;
Variable = CreateActor(ID, X, Y, Z, RZ);
ApplyActorAnimation(Variable, ""PED"", ""cower"", 4.0, 1, 1, 1, 0, 0);"
            Case 9
                PictureBox1.Image = Global.VisualTextures.My.Resources.ped_endchat_01
                PictureBox1.Visible = True
                RichTextBox1.Enabled = True
                RichTextBox1.Visible = True
                RichTextBox1.Text =
"new Variable;
Variable = CreateActor(ID, X, Y, Z, RZ);
ApplyActorAnimation(Variable, ""PED"", ""endchat_01"", 4.0, 1, 1, 1, 0, 0);"
            Case 10
                PictureBox1.Image = Global.VisualTextures.My.Resources.ped_endchat_02
                PictureBox1.Visible = True
                RichTextBox1.Enabled = True
                RichTextBox1.Visible = True
                RichTextBox1.Text =
"new Variable;
Variable = CreateActor(ID, X, Y, Z, RZ);
ApplyActorAnimation(Variable, ""PED"", ""endchat_02"", 4.0, 1, 1, 1, 0, 0);"
            Case 11
                PictureBox1.Image = Global.VisualTextures.My.Resources.ped_endchat_03
                PictureBox1.Visible = True
                RichTextBox1.Enabled = True
                RichTextBox1.Visible = True
                RichTextBox1.Text =
"new Variable;
Variable = CreateActor(ID, X, Y, Z, RZ);
ApplyActorAnimation(Variable, ""PED"", ""endchat_03"", 4.0, 1, 1, 1, 0, 0);"
            Case 12
                PictureBox1.Image = Global.VisualTextures.My.Resources.ped_facgum
                PictureBox1.Visible = True
                RichTextBox1.Enabled = True
                RichTextBox1.Visible = True
                RichTextBox1.Text =
"new Variable;
Variable = CreateActor(ID, X, Y, Z, RZ);
ApplyActorAnimation(Variable, ""PED"", ""facgum"", 4.0, 1, 1, 1, 0, 0);"
            Case 13
                PictureBox1.Image = Global.VisualTextures.My.Resources.ped_factalk
                PictureBox1.Visible = True
                RichTextBox1.Enabled = True
                RichTextBox1.Visible = True
                RichTextBox1.Text =
"new Variable;
Variable = CreateActor(ID, X, Y, Z, RZ);
ApplyActorAnimation(Variable, ""PED"", ""factalk"", 4.0, 1, 1, 1, 0, 0);"
            Case 14
                PictureBox1.Image = Global.VisualTextures.My.Resources.ped_FALL_skyDive
                PictureBox1.Visible = True
                RichTextBox1.Enabled = True
                RichTextBox1.Visible = True
                RichTextBox1.Text =
"new Variable;
Variable = CreateActor(ID, X, Y, Z, RZ);
ApplyActorAnimation(Variable, ""PED"", ""FALL_skyDive"", 4.0, 1, 1, 1, 0, 0);"
            Case 15
                PictureBox1.Image = Global.VisualTextures.My.Resources.ped_flee_lkaround_01
                PictureBox1.Visible = True
                RichTextBox1.Enabled = True
                RichTextBox1.Visible = True
                RichTextBox1.Text =
"new Variable;
Variable = CreateActor(ID, X, Y, Z, RZ);
ApplyActorAnimation(Variable, ""PED"", ""flee_lkaround_01"", 4.0, 1, 1, 1, 0, 0);"
            Case 16
                PictureBox1.Image = Global.VisualTextures.My.Resources.ped_fucku
                PictureBox1.Visible = True
                RichTextBox1.Enabled = True
                RichTextBox1.Visible = True
                RichTextBox1.Text =
"new Variable;
Variable = CreateActor(ID, X, Y, Z, RZ);
ApplyActorAnimation(Variable, ""PED"", ""fucku"", 4.0, 1, 1, 1, 0, 0);"
            Case 17
                PictureBox1.Image = Global.VisualTextures.My.Resources.ped_gas_cwr
                PictureBox1.Visible = True
                RichTextBox1.Enabled = True
                RichTextBox1.Visible = True
                RichTextBox1.Text =
"new Variable;
Variable = CreateActor(ID, X, Y, Z, RZ);
ApplyActorAnimation(Variable, ""PED"", ""gas_cwr"", 4.0, 1, 1, 1, 0, 0);"
            Case 18
                PictureBox1.Image = Global.VisualTextures.My.Resources.ped_gum_eat
                PictureBox1.Visible = True
                RichTextBox1.Enabled = True
                RichTextBox1.Visible = True
                RichTextBox1.Text =
"new Variable;
Variable = CreateActor(ID, X, Y, Z, RZ);
ApplyActorAnimation(Variable, ""PED"", ""gum_eat"", 4.0, 1, 1, 1, 0, 0);"
            Case 19
                PictureBox1.Image = Global.VisualTextures.My.Resources.ped_handsup
                PictureBox1.Visible = True
                RichTextBox1.Enabled = True
                RichTextBox1.Visible = True
                RichTextBox1.Text =
"new Variable;
Variable = CreateActor(ID, X, Y, Z, RZ);
ApplyActorAnimation(Variable, ""PED"", ""handsup"", 4.0, 1, 1, 1, 0, 0);"
            Case 20
                PictureBox1.Image = Global.VisualTextures.My.Resources.ped_HIT_walk
                PictureBox1.Visible = True
                RichTextBox1.Enabled = True
                RichTextBox1.Visible = True
                RichTextBox1.Text =
"new Variable;
Variable = CreateActor(ID, X, Y, Z, RZ);
ApplyActorAnimation(Variable, ""PED"", ""HIT_walk"", 4.0, 1, 1, 1, 0, 0);"
            Case 21
                PictureBox1.Image = Global.VisualTextures.My.Resources.ped_IDLE_chat
                PictureBox1.Visible = True
                RichTextBox1.Enabled = True
                RichTextBox1.Visible = True
                RichTextBox1.Text =
"new Variable;
Variable = CreateActor(ID, X, Y, Z, RZ);
ApplyActorAnimation(Variable, ""PED"", ""IDLE_chat"", 4.0, 1, 1, 1, 0, 0);"
            Case 22
                PictureBox1.Image = Global.VisualTextures.My.Resources.ped_IDLE_HBHB
                PictureBox1.Visible = True
                RichTextBox1.Enabled = True
                RichTextBox1.Visible = True
                RichTextBox1.Text =
"new Variable;
Variable = CreateActor(ID, X, Y, Z, RZ);
ApplyActorAnimation(Variable, ""PED"", ""IDLE_HBHB"", 4.0, 1, 1, 1, 0, 0);"
            Case 23
                PictureBox1.Image = Global.VisualTextures.My.Resources.ped_IDLE_ROCKET
                PictureBox1.Visible = True
                RichTextBox1.Enabled = True
                RichTextBox1.Visible = True
                RichTextBox1.Text =
"new Variable;
Variable = CreateActor(ID, X, Y, Z, RZ);
ApplyActorAnimation(Variable, ""PED"", ""IDLE_ROCKET"", 4.0, 1, 1, 1, 0, 0);"
            Case 24
                PictureBox1.Image = Global.VisualTextures.My.Resources.ped_IDLE_taxi
                PictureBox1.Visible = True
                RichTextBox1.Enabled = True
                RichTextBox1.Visible = True
                RichTextBox1.Text =
"new Variable;
Variable = CreateActor(ID, X, Y, Z, RZ);
ApplyActorAnimation(Variable, ""PED"", ""IDLE_taxi"", 4.0, 1, 1, 1, 0, 0);"
            Case 25
                PictureBox1.Image = Global.VisualTextures.My.Resources.ped_IDLE_tired
                PictureBox1.Visible = True
                RichTextBox1.Enabled = True
                RichTextBox1.Visible = True
                RichTextBox1.Text =
"new Variable;
Variable = CreateActor(ID, X, Y, Z, RZ);
ApplyActorAnimation(Variable, ""PED"", ""IDLE_tired"", 4.0, 1, 1, 1, 0, 0);"
            Case 26
                PictureBox1.Image = Global.VisualTextures.My.Resources.ped_KO_shot_face
                PictureBox1.Visible = True
                RichTextBox1.Enabled = True
                RichTextBox1.Visible = True
                RichTextBox1.Text =
"new Variable;
Variable = CreateActor(ID, X, Y, Z, RZ);
ApplyActorAnimation(Variable, ""PED"", ""KO_shot_face"", 4.0, 1, 1, 1, 0, 0);"
            Case 27
                PictureBox1.Image = Global.VisualTextures.My.Resources.ped_KO_shot_front
                PictureBox1.Visible = True
                RichTextBox1.Enabled = True
                RichTextBox1.Visible = True
                RichTextBox1.Text =
"new Variable;
Variable = CreateActor(ID, X, Y, Z, RZ);
ApplyActorAnimation(Variable, ""PED"", ""KO_shot_front"", 4.0, 1, 1, 1, 0, 0);"
            Case 28
                PictureBox1.Image = Global.VisualTextures.My.Resources.ped_KO_shot_stom
                PictureBox1.Visible = True
                RichTextBox1.Enabled = True
                RichTextBox1.Visible = True
                RichTextBox1.Text =
"new Variable;
Variable = CreateActor(ID, X, Y, Z, RZ);
ApplyActorAnimation(Variable, ""PED"", ""KO_shot_stom"", 4.0, 1, 1, 1, 0, 0);"
            Case 29
                PictureBox1.Image = Global.VisualTextures.My.Resources.ped_KO_skid_front
                PictureBox1.Visible = True
                RichTextBox1.Enabled = True
                RichTextBox1.Visible = True
                RichTextBox1.Text =
"new Variable;
Variable = CreateActor(ID, X, Y, Z, RZ);
ApplyActorAnimation(Variable, ""PED"", ""KO_skid_front"", 4.0, 1, 1, 1, 0, 0);"
            Case 30
                PictureBox1.Image = Global.VisualTextures.My.Resources.ped_pass_Smoke_in_car
                PictureBox1.Visible = True
                RichTextBox1.Enabled = True
                RichTextBox1.Visible = True
                RichTextBox1.Text =
"new Variable;
Variable = CreateActor(ID, X, Y, Z, RZ);
ApplyActorAnimation(Variable, ""PED"", ""pass_Smoke_in_car"", 4.0, 1, 1, 1, 0, 0);"
            Case 31
                PictureBox1.Image = Global.VisualTextures.My.Resources.ped_phone_in
                PictureBox1.Visible = True
                RichTextBox1.Enabled = True
                RichTextBox1.Visible = True
                RichTextBox1.Text =
"new Variable;
Variable = CreateActor(ID, X, Y, Z, RZ);
ApplyActorAnimation(Variable, ""PED"", ""phone_in"", 4.0, 1, 1, 1, 0, 0);"
            Case 32
                PictureBox1.Image = Global.VisualTextures.My.Resources.ped_phone_out
                PictureBox1.Visible = True
                RichTextBox1.Enabled = True
                RichTextBox1.Visible = True
                RichTextBox1.Text =
"new Variable;
Variable = CreateActor(ID, X, Y, Z, RZ);
ApplyActorAnimation(Variable, ""PED"", ""phone_out"", 4.0, 1, 1, 1, 0, 0);"
            Case 33
                PictureBox1.Image = Global.VisualTextures.My.Resources.ped_phone_talk
                PictureBox1.Visible = True
                RichTextBox1.Enabled = True
                RichTextBox1.Visible = True
                RichTextBox1.Text =
"new Variable;
Variable = CreateActor(ID, X, Y, Z, RZ);
ApplyActorAnimation(Variable, ""PED"", ""phone_talk"", 4.0, 1, 1, 1, 0, 0);"
            Case 34
                PictureBox1.Image = Global.VisualTextures.My.Resources.ped_roadcross
                PictureBox1.Visible = True
                RichTextBox1.Enabled = True
                RichTextBox1.Visible = True
                RichTextBox1.Text =
"new Variable;
Variable = CreateActor(ID, X, Y, Z, RZ);
ApplyActorAnimation(Variable, ""PED"", ""roadcross"", 4.0, 1, 1, 1, 0, 0);"
            Case 35
                PictureBox1.Image = Global.VisualTextures.My.Resources.ped_run_1armed
                PictureBox1.Visible = True
                RichTextBox1.Enabled = True
                RichTextBox1.Visible = True
                RichTextBox1.Text =
"new Variable;
Variable = CreateActor(ID, X, Y, Z, RZ);
ApplyActorAnimation(Variable, ""PED"", ""run_1armed"", 4.0, 1, 1, 1, 0, 0);"
            Case 36
                PictureBox1.Image = Global.VisualTextures.My.Resources.ped_run_armed
                PictureBox1.Visible = True
                RichTextBox1.Enabled = True
                RichTextBox1.Visible = True
                RichTextBox1.Text =
"new Variable;
Variable = CreateActor(ID, X, Y, Z, RZ);
ApplyActorAnimation(Variable, ""PED"", ""run_armed"", 4.0, 1, 1, 1, 0, 0);"
            Case 37
                PictureBox1.Image = Global.VisualTextures.My.Resources.ped_run_civi
                PictureBox1.Visible = True
                RichTextBox1.Enabled = True
                RichTextBox1.Visible = True
                RichTextBox1.Text =
"new Variable;
Variable = CreateActor(ID, X, Y, Z, RZ);
ApplyActorAnimation(Variable, ""PED"", ""run_civi"", 4.0, 1, 1, 1, 0, 0);"
            Case 38
                PictureBox1.Image = Global.VisualTextures.My.Resources.ped_run_fatold
                PictureBox1.Visible = True
                RichTextBox1.Enabled = True
                RichTextBox1.Visible = True
                RichTextBox1.Text =
"new Variable;
Variable = CreateActor(ID, X, Y, Z, RZ);
ApplyActorAnimation(Variable, ""PED"", ""run_fatold"", 4.0, 1, 1, 1, 0, 0);"
            Case 39
                PictureBox1.Image = Global.VisualTextures.My.Resources.ped_run_gang1
                PictureBox1.Visible = True
                RichTextBox1.Enabled = True
                RichTextBox1.Visible = True
                RichTextBox1.Text =
"new Variable;
Variable = CreateActor(ID, X, Y, Z, RZ);
ApplyActorAnimation(Variable, ""PED"", ""run_gang1"", 4.0, 1, 1, 1, 0, 0);"
            Case 40
                PictureBox1.Image = Global.VisualTextures.My.Resources.ped_run_old
                PictureBox1.Visible = True
                RichTextBox1.Enabled = True
                RichTextBox1.Visible = True
                RichTextBox1.Text =
"new Variable;
Variable = CreateActor(ID, X, Y, Z, RZ);
ApplyActorAnimation(Variable, ""PED"", ""run_old"", 4.0, 1, 1, 1, 0, 0);"
            Case 41
                PictureBox1.Image = Global.VisualTextures.My.Resources.ped_run_player
                PictureBox1.Visible = True
                RichTextBox1.Enabled = True
                RichTextBox1.Visible = True
                RichTextBox1.Text =
"new Variable;
Variable = CreateActor(ID, X, Y, Z, RZ);
ApplyActorAnimation(Variable, ""PED"", ""run_player"", 4.0, 1, 1, 1, 0, 0);"
            Case 42
                PictureBox1.Image = Global.VisualTextures.My.Resources.ped_Run_stop
                PictureBox1.Visible = True
                RichTextBox1.Enabled = True
                RichTextBox1.Visible = True
                RichTextBox1.Text =
"new Variable;
Variable = CreateActor(ID, X, Y, Z, RZ);
ApplyActorAnimation(Variable, ""PED"", ""Run_stop"", 4.0, 1, 1, 1, 0, 0);"
            Case 43
                PictureBox1.Image = Global.VisualTextures.My.Resources.ped_Run_Wuzi
                PictureBox1.Visible = True
                RichTextBox1.Enabled = True
                RichTextBox1.Visible = True
                RichTextBox1.Text =
"new Variable;
Variable = CreateActor(ID, X, Y, Z, RZ);
ApplyActorAnimation(Variable, ""PED"", ""Run_Wuzi"", 4.0, 1, 1, 1, 0, 0);"
            Case 44
                PictureBox1.Image = Global.VisualTextures.My.Resources.ped_SEAT_down
                PictureBox1.Visible = True
                RichTextBox1.Enabled = True
                RichTextBox1.Visible = True
                RichTextBox1.Text =
"new Variable;
Variable = CreateActor(ID, X, Y, Z, RZ);
ApplyActorAnimation(Variable, ""PED"", ""SEAT_down"", 4.0, 1, 1, 1, 0, 0);"
            Case 45
                PictureBox1.Image = Global.VisualTextures.My.Resources.ped_SEAT_idle
                PictureBox1.Visible = True
                RichTextBox1.Enabled = True
                RichTextBox1.Visible = True
                RichTextBox1.Text =
"new Variable;
Variable = CreateActor(ID, X, Y, Z, RZ);
ApplyActorAnimation(Variable, ""PED"", ""SEAT_idle"", 4.0, 1, 1, 1, 0, 0);"
            Case 46
                PictureBox1.Image = Global.VisualTextures.My.Resources.ped_SEAT_up
                PictureBox1.Visible = True
                RichTextBox1.Enabled = True
                RichTextBox1.Visible = True
                RichTextBox1.Text =
"new Variable;
Variable = CreateActor(ID, X, Y, Z, RZ);
ApplyActorAnimation(Variable, ""PED"", ""SEAT_up"", 4.0, 1, 1, 1, 0, 0);"
            Case 47
                PictureBox1.Image = Global.VisualTextures.My.Resources.ped_Smoke_in_car
                PictureBox1.Visible = True
                RichTextBox1.Enabled = True
                RichTextBox1.Visible = True
                RichTextBox1.Text =
"new Variable;
Variable = CreateActor(ID, X, Y, Z, RZ);
ApplyActorAnimation(Variable, ""PED"", ""Smoke_in_car"", 4.0, 1, 1, 1, 0, 0);"
            Case 48
                PictureBox1.Image = Global.VisualTextures.My.Resources.ped_Swim_Tread
                PictureBox1.Visible = True
                RichTextBox1.Enabled = True
                RichTextBox1.Visible = True
                RichTextBox1.Text =
"new Variable;
Variable = CreateActor(ID, X, Y, Z, RZ);
ApplyActorAnimation(Variable, ""PED"", ""Swim_Tread"", 4.0, 1, 1, 1, 0, 0);"
            Case 49
                PictureBox1.Image = Global.VisualTextures.My.Resources.ped_WALK_drunk
                PictureBox1.Visible = True
                RichTextBox1.Enabled = True
                RichTextBox1.Visible = True
                RichTextBox1.Text =
"new Variable;
Variable = CreateActor(ID, X, Y, Z, RZ);
ApplyActorAnimation(Variable, ""PED"", ""WALK_drunk"", 4.0, 1, 1, 1, 0, 0);"
            Case 50
                PictureBox1.Image = Global.VisualTextures.My.Resources.ped_WALK_fatold
                PictureBox1.Visible = True
                RichTextBox1.Enabled = True
                RichTextBox1.Visible = True
                RichTextBox1.Text =
"new Variable;
Variable = CreateActor(ID, X, Y, Z, RZ);
ApplyActorAnimation(Variable, ""PED"", ""WALK_fatold"", 4.0, 1, 1, 1, 0, 0);"
            Case 51
                PictureBox1.Image = Global.VisualTextures.My.Resources.ped_WALK_gang1
                PictureBox1.Visible = True
                RichTextBox1.Enabled = True
                RichTextBox1.Visible = True
                RichTextBox1.Text =
"new Variable;
Variable = CreateActor(ID, X, Y, Z, RZ);
ApplyActorAnimation(Variable, ""PED"", ""WALK_gang1"", 4.0, 1, 1, 1, 0, 0);"
            Case 52
                PictureBox1.Image = Global.VisualTextures.My.Resources.ped_WALK_gang2
                PictureBox1.Visible = True
                RichTextBox1.Enabled = True
                RichTextBox1.Visible = True
                RichTextBox1.Text =
"new Variable;
Variable = CreateActor(ID, X, Y, Z, RZ);
ApplyActorAnimation(Variable, ""PED"", ""WALK_gang2"", 4.0, 1, 1, 1, 0, 0);"
            Case 53
                PictureBox1.Image = Global.VisualTextures.My.Resources.ped_Walk_Wuzi
                PictureBox1.Visible = True
                RichTextBox1.Enabled = True
                RichTextBox1.Visible = True
                RichTextBox1.Text =
"new Variable;
Variable = CreateActor(ID, X, Y, Z, RZ);
ApplyActorAnimation(Variable, ""PED"", ""Walk_Wuzi"", 4.0, 1, 1, 1, 0, 0);"
            Case 54
                PictureBox1.Image = Global.VisualTextures.My.Resources.ped_WOMAN_walkpro
                PictureBox1.Visible = True
                RichTextBox1.Enabled = True
                RichTextBox1.Visible = True
                RichTextBox1.Text =
"new Variable;
Variable = CreateActor(ID, X, Y, Z, RZ);
ApplyActorAnimation(Variable, ""PED"", ""WOMAN_walkpro"", 4.0, 1, 1, 1, 0, 0);"
            Case 55
                PictureBox1.Image = Global.VisualTextures.My.Resources.ped_WOMAN_walkshop
                PictureBox1.Visible = True
                RichTextBox1.Enabled = True
                RichTextBox1.Visible = True
                RichTextBox1.Text =
"new Variable;
Variable = CreateActor(ID, X, Y, Z, RZ);
ApplyActorAnimation(Variable, ""PED"", ""WOMAN_walkshop"", 4.0, 1, 1, 1, 0, 0);"

            Case 56
                PictureBox1.Image = Global.VisualTextures.My.Resources.ped_XPRESSscratch
                PictureBox1.Visible = True
                RichTextBox1.Enabled = True
                RichTextBox1.Visible = True
                RichTextBox1.Text =
"new Variable;
Variable = CreateActor(ID, X, Y, Z, RZ);
ApplyActorAnimation(Variable, ""PED"", ""XPRESSscratch"", 4.0, 1, 1, 1, 0, 0);"

            Case 57
                PictureBox1.Visible = False
                RichTextBox1.Enabled = False
                RichTextBox1.Visible = False
                ListBox1.SelectedIndex = True
                RichTextBox1.Text = ""

            Case 58
                PictureBox1.Visible = False
                RichTextBox1.Enabled = False
                RichTextBox1.Visible = False
                ListBox1.SelectedIndex = True
                RichTextBox1.Text = ""

            Case 59
                PictureBox1.Image = Global.VisualTextures.My.Resources.airport_thrw_barl_thrw
                PictureBox1.Visible = True
                RichTextBox1.Enabled = True
                RichTextBox1.Visible = True
                RichTextBox1.Text =
"new Variable;
Variable = CreateActor(ID, X, Y, Z, RZ);
ApplyActorAnimation(Variable, ""airport"", ""thrw_barl_thrw"", 4.0, 1, 1, 1, 0, 0);"

            Case 60
                PictureBox1.Visible = False
                RichTextBox1.Enabled = False
                RichTextBox1.Visible = False
                ListBox1.SelectedIndex = True
                RichTextBox1.Text = ""

            Case 61
                PictureBox1.Visible = False
                RichTextBox1.Enabled = False
                RichTextBox1.Visible = False
                ListBox1.SelectedIndex = True
                RichTextBox1.Text = ""

            Case 62
                PictureBox1.Image = Global.VisualTextures.My.Resources.Attractors_Stepsit_in
                PictureBox1.Visible = True
                RichTextBox1.Enabled = True
                RichTextBox1.Visible = True
                RichTextBox1.Text =
"new Variable;
Variable = CreateActor(ID, X, Y, Z, RZ);
ApplyActorAnimation(Variable, ""Attractors"", ""Stepsit_in"", 4.0, 1, 1, 1, 0, 0);"

            Case 63
                PictureBox1.Image = Global.VisualTextures.My.Resources.Attractors_Stepsit_loop
                PictureBox1.Visible = True
                RichTextBox1.Enabled = True
                RichTextBox1.Visible = True
                RichTextBox1.Text =
"new Variable;
Variable = CreateActor(ID, X, Y, Z, RZ);
ApplyActorAnimation(Variable, ""Attractors"", ""Stepsit_loop"", 4.0, 1, 1, 1, 0, 0);"

            Case 64
                PictureBox1.Image = Global.VisualTextures.My.Resources.Attractors_Stepsit_out
                PictureBox1.Visible = True
                RichTextBox1.Enabled = True
                RichTextBox1.Visible = True
                RichTextBox1.Text =
"new Variable;
Variable = CreateActor(ID, X, Y, Z, RZ);
ApplyActorAnimation(Variable, ""Attractors"", ""Stepsit_out"", 4.0, 1, 1, 1, 0, 0);"

            Case 65
                PictureBox1.Visible = False
                RichTextBox1.Enabled = False
                RichTextBox1.Visible = False
                ListBox1.SelectedIndex = True
                RichTextBox1.Text = ""

            Case 66
                PictureBox1.Visible = False
                RichTextBox1.Enabled = False
                RichTextBox1.Visible = False
                ListBox1.SelectedIndex = True
                RichTextBox1.Text = ""

            Case 67
                PictureBox1.Image = Global.VisualTextures.My.Resources.BAR_Barcustom_get
                PictureBox1.Visible = True
                RichTextBox1.Enabled = True
                RichTextBox1.Visible = True
                RichTextBox1.Text =
"new Variable;
Variable = CreateActor(ID, X, Y, Z, RZ);
ApplyActorAnimation(Variable, ""Bar"", ""Barcustom_get"", 4.0, 1, 1, 1, 0, 0);"

            Case 68
                PictureBox1.Image = Global.VisualTextures.My.Resources.BAR_Barcustom_loop
                PictureBox1.Visible = True
                RichTextBox1.Enabled = True
                RichTextBox1.Visible = True
                RichTextBox1.Text =
"new Variable;
Variable = CreateActor(ID, X, Y, Z, RZ);
ApplyActorAnimation(Variable, ""Bar"", ""Barcustom_loop"", 4.0, 1, 1, 1, 0, 0);"

            Case 69
                PictureBox1.Image = Global.VisualTextures.My.Resources.BAR_Barcustom_order
                PictureBox1.Visible = True
                RichTextBox1.Enabled = True
                RichTextBox1.Visible = True
                RichTextBox1.Text =
"new Variable;
Variable = CreateActor(ID, X, Y, Z, RZ);
ApplyActorAnimation(Variable, ""Bar"", ""Barcustom_order"", 4.0, 1, 1, 1, 0, 0);"

            Case 70
                PictureBox1.Image = Global.VisualTextures.My.Resources.BAR_BARman_idle
                PictureBox1.Visible = True
                RichTextBox1.Enabled = True
                RichTextBox1.Visible = True
                RichTextBox1.Text =
"new Variable;
Variable = CreateActor(ID, X, Y, Z, RZ);
ApplyActorAnimation(Variable, ""Bar"", ""BARman_idle"", 4.0, 1, 1, 1, 0, 0);"

            Case 71
                PictureBox1.Image = Global.VisualTextures.My.Resources.BAR_Barserve_give
                PictureBox1.Visible = True
                RichTextBox1.Enabled = True
                RichTextBox1.Visible = True
                RichTextBox1.Text =
"new Variable;
Variable = CreateActor(ID, X, Y, Z, RZ);
ApplyActorAnimation(Variable, ""Bar"", ""Barserve_give"", 4.0, 1, 1, 1, 0, 0);"

            Case 72
                PictureBox1.Image = Global.VisualTextures.My.Resources.BAR_Barserve_bottle
                PictureBox1.Visible = True
                RichTextBox1.Enabled = True
                RichTextBox1.Visible = True
                RichTextBox1.Text =
"new Variable;
Variable = CreateActor(ID, X, Y, Z, RZ);
ApplyActorAnimation(Variable, ""Bar"", ""Barserve_bottle"", 4.0, 1, 1, 1, 0, 0);"

            Case 73
                PictureBox1.Image = Global.VisualTextures.My.Resources.BAR_Barserve_glass
                PictureBox1.Visible = True
                RichTextBox1.Enabled = True
                RichTextBox1.Visible = True
                RichTextBox1.Text =
"new Variable;
Variable = CreateActor(ID, X, Y, Z, RZ);
ApplyActorAnimation(Variable, ""Bar"", ""Barserve_glass"", 4.0, 1, 1, 1, 0, 0);"

            Case 74
                PictureBox1.Image = Global.VisualTextures.My.Resources.BAR_Barserve_in
                PictureBox1.Visible = True
                RichTextBox1.Enabled = True
                RichTextBox1.Visible = True
                RichTextBox1.Text =
"new Variable;
Variable = CreateActor(ID, X, Y, Z, RZ);
ApplyActorAnimation(Variable, ""Bar"", ""Barserve_in"", 4.0, 1, 1, 1, 0, 0);"

            Case 75
                PictureBox1.Image = Global.VisualTextures.My.Resources.BAR_Barserve_loop
                PictureBox1.Visible = True
                RichTextBox1.Enabled = True
                RichTextBox1.Visible = True
                RichTextBox1.Text =
"new Variable;
Variable = CreateActor(ID, X, Y, Z, RZ);
ApplyActorAnimation(Variable, ""Bar"", ""Barserve_loop"", 4.0, 1, 1, 1, 0, 0);"

            Case 76
                PictureBox1.Image = Global.VisualTextures.My.Resources.BAR_Barserve_order
                PictureBox1.Visible = True
                RichTextBox1.Enabled = True
                RichTextBox1.Visible = True
                RichTextBox1.Text =
"new Variable;
Variable = CreateActor(ID, X, Y, Z, RZ);
ApplyActorAnimation(Variable, ""Bar"", ""Barserve_order"", 4.0, 1, 1, 1, 0, 0);"

            Case 77
                PictureBox1.Image = Global.VisualTextures.My.Resources.BAR_dnk_stndF_loop
                PictureBox1.Visible = True
                RichTextBox1.Enabled = True
                RichTextBox1.Visible = True
                RichTextBox1.Text =
"new Variable;
Variable = CreateActor(ID, X, Y, Z, RZ);
ApplyActorAnimation(Variable, ""Bar"", ""dnk_stndF_loop"", 4.0, 1, 1, 1, 0, 0);"

            Case 78
                PictureBox1.Image = Global.VisualTextures.My.Resources.BAR_dnk_stndM_loop
                PictureBox1.Visible = True
                RichTextBox1.Enabled = True
                RichTextBox1.Visible = True
                RichTextBox1.Text =
"new Variable;
Variable = CreateActor(ID, X, Y, Z, RZ);
ApplyActorAnimation(Variable, ""Bar"", ""dnk_stndM_loop"", 4.0, 1, 1, 1, 0, 0);"

            Case 79
                PictureBox1.Visible = False
                RichTextBox1.Enabled = False
                RichTextBox1.Visible = False
                ListBox1.SelectedIndex = True
                RichTextBox1.Text = ""

            Case 80
                PictureBox1.Visible = False
                RichTextBox1.Enabled = False
                RichTextBox1.Visible = False
                ListBox1.SelectedIndex = True
                RichTextBox1.Text = ""

            Case 81
                PictureBox1.Image = Global.VisualTextures.My.Resources.BASEBALL_Bat_1
                PictureBox1.Visible = True
                RichTextBox1.Enabled = True
                RichTextBox1.Visible = True
                RichTextBox1.Text =
"new Variable;
Variable = CreateActor(ID, X, Y, Z, RZ);
ApplyActorAnimation(Variable, ""Baseball"", ""Bat_1"", 4.0, 1, 1, 1, 0, 0);"

            Case 82
                PictureBox1.Image = Global.VisualTextures.My.Resources.BASEBALL_Bat_2
                PictureBox1.Visible = True
                RichTextBox1.Enabled = True
                RichTextBox1.Visible = True
                RichTextBox1.Text =
"new Variable;
Variable = CreateActor(ID, X, Y, Z, RZ);
ApplyActorAnimation(Variable, ""Baseball"", ""Bat_2"", 4.0, 1, 1, 1, 0, 0);"

            Case 83
                PictureBox1.Image = Global.VisualTextures.My.Resources.BASEBALL_Bat_3
                PictureBox1.Visible = True
                RichTextBox1.Enabled = True
                RichTextBox1.Visible = True
                RichTextBox1.Text =
"new Variable;
Variable = CreateActor(ID, X, Y, Z, RZ);
ApplyActorAnimation(Variable, ""Baseball"", ""Bat_3"", 4.0, 1, 1, 1, 0, 0);"

            Case 85
                PictureBox1.Image = Global.VisualTextures.My.Resources.BASEBALL_Bat_4
                PictureBox1.Visible = True
                RichTextBox1.Enabled = True
                RichTextBox1.Visible = True
                RichTextBox1.Text =
"new Variable;
Variable = CreateActor(ID, X, Y, Z, RZ);
ApplyActorAnimation(Variable, ""Baseball"", ""Bat_4"", 4.0, 1, 1, 1, 0, 0);"

            Case 85
                PictureBox1.Image = Global.VisualTextures.My.Resources.BASEBALL_Bat_IDLE
                PictureBox1.Visible = True
                RichTextBox1.Enabled = True
                RichTextBox1.Visible = True
                RichTextBox1.Text =
"new Variable;
Variable = CreateActor(ID, X, Y, Z, RZ);
ApplyActorAnimation(Variable, ""Baseball"", ""Bat_IDLE"", 4.0, 1, 1, 1, 0, 0);"

            Case 86
                PictureBox1.Image = Global.VisualTextures.My.Resources.BASEBALL_Bat_M
                PictureBox1.Visible = True
                RichTextBox1.Enabled = True
                RichTextBox1.Visible = True
                RichTextBox1.Text =
"new Variable;
Variable = CreateActor(ID, X, Y, Z, RZ);
ApplyActorAnimation(Variable, ""Baseball"", ""Bat_M"", 4.0, 1, 1, 1, 0, 0);"


            Case 87
                PictureBox1.Visible = False
                RichTextBox1.Enabled = False
                RichTextBox1.Visible = False
                ListBox1.SelectedIndex = True
                RichTextBox1.Text = ""

            Case 88
                PictureBox1.Visible = False
                RichTextBox1.Enabled = False
                RichTextBox1.Visible = False
                ListBox1.SelectedIndex = True
                RichTextBox1.Text = ""

            Case 89
                PictureBox1.Image = Global.VisualTextures.My.Resources.bdfire_BD_GF_Wave
                PictureBox1.Visible = True
                RichTextBox1.Enabled = True
                RichTextBox1.Visible = True
                RichTextBox1.Text =
"new Variable;
Variable = CreateActor(ID, X, Y, Z, RZ);
ApplyActorAnimation(Variable, ""bdfire"", ""BD_GF_Wave"", 4.0, 1, 1, 1, 0, 0);"

            Case 90
                PictureBox1.Image = Global.VisualTextures.My.Resources.bdfire_BD_Panic_01
                PictureBox1.Visible = True
                RichTextBox1.Enabled = True
                RichTextBox1.Visible = True
                RichTextBox1.Text =
"new Variable;
Variable = CreateActor(ID, X, Y, Z, RZ);
ApplyActorAnimation(Variable, ""bdfire"", ""BD_Panic_01"", 4.0, 1, 1, 1, 0, 0);"

            Case 91
                PictureBox1.Image = Global.VisualTextures.My.Resources.bdfire_BD_Panic_02
                PictureBox1.Visible = True
                RichTextBox1.Enabled = True
                RichTextBox1.Visible = True
                RichTextBox1.Text =
"new Variable;
Variable = CreateActor(ID, X, Y, Z, RZ);
ApplyActorAnimation(Variable, ""bdfire"", ""BD_Panic_02"", 4.0, 1, 1, 1, 0, 0);"

            Case 92
                PictureBox1.Image = Global.VisualTextures.My.Resources.bdfire_BD_Panic_03
                PictureBox1.Visible = True
                RichTextBox1.Enabled = True
                RichTextBox1.Visible = True
                RichTextBox1.Text =
"new Variable;
Variable = CreateActor(ID, X, Y, Z, RZ);
ApplyActorAnimation(Variable, ""bdfire"", ""BD_Panic_03"", 4.0, 1, 1, 1, 0, 0);"

            Case 93
                PictureBox1.Image = Global.VisualTextures.My.Resources.bdfire_BD_Panic_04
                PictureBox1.Visible = True
                RichTextBox1.Enabled = True
                RichTextBox1.Visible = True
                RichTextBox1.Text =
"new Variable;
Variable = CreateActor(ID, X, Y, Z, RZ);
ApplyActorAnimation(Variable, ""bdfire"", ""BD_Panic_04"", 4.0, 1, 1, 1, 0, 0);"

            Case 94
                PictureBox1.Image = Global.VisualTextures.My.Resources.bdfire_BD_Panic_Loop
                PictureBox1.Visible = True
                RichTextBox1.Enabled = True
                RichTextBox1.Visible = True
                RichTextBox1.Text =
"new Variable;
Variable = CreateActor(ID, X, Y, Z, RZ);
ApplyActorAnimation(Variable, ""bdfire"", ""BD_Panic_Loop"", 4.0, 1, 1, 1, 0, 0);"

            Case 95
                PictureBox1.Image = Global.VisualTextures.My.Resources.bdfire_Grlfrd_Kiss_03
                PictureBox1.Visible = True
                RichTextBox1.Enabled = True
                RichTextBox1.Visible = True
                RichTextBox1.Text =
"new Variable;
Variable = CreateActor(ID, X, Y, Z, RZ);
ApplyActorAnimation(Variable, ""bdfire"", ""Grlfrd_Kiss_03"", 4.0, 1, 1, 1, 0, 0);"

            Case 96
                PictureBox1.Image = Global.VisualTextures.My.Resources.bdfire_M_smklean_loop
                PictureBox1.Visible = True
                RichTextBox1.Enabled = True
                RichTextBox1.Visible = True
                RichTextBox1.Text =
"new Variable;
Variable = CreateActor(ID, X, Y, Z, RZ);
ApplyActorAnimation(Variable, ""bdfire"", ""M_smklean_loop"", 4.0, 1, 1, 1, 0, 0);"

            Case 97
                PictureBox1.Image = Global.VisualTextures.My.Resources.bdfire_Playa_Kiss_03
                PictureBox1.Visible = True
                RichTextBox1.Enabled = True
                RichTextBox1.Visible = True
                RichTextBox1.Text =
"new Variable;
Variable = CreateActor(ID, X, Y, Z, RZ);
ApplyActorAnimation(Variable, ""bdfire"", ""Playa_Kiss_03"", 4.0, 1, 1, 1, 0, 0);"

            Case 98
                PictureBox1.Image = Global.VisualTextures.My.Resources.bdfire_wash_up
                PictureBox1.Visible = True
                RichTextBox1.Enabled = True
                RichTextBox1.Visible = True
                RichTextBox1.Text =
"new Variable;
Variable = CreateActor(ID, X, Y, Z, RZ);
ApplyActorAnimation(Variable, ""bdfire"", ""wash_up"", 4.0, 1, 1, 1, 0, 0);"

            Case 99
                PictureBox1.Visible = False
                RichTextBox1.Enabled = False
                RichTextBox1.Visible = False
                ListBox1.SelectedIndex = True
                RichTextBox1.Text = ""

            Case 100
                PictureBox1.Visible = False
                RichTextBox1.Enabled = False
                RichTextBox1.Visible = False
                ListBox1.SelectedIndex = True
                RichTextBox1.Text = ""

            Case 101
                PictureBox1.Image = Global.VisualTextures.My.Resources.Beach_bather
                PictureBox1.Visible = True
                RichTextBox1.Enabled = True
                RichTextBox1.Visible = True
                RichTextBox1.Text =
"new Variable;
Variable = CreateActor(ID, X, Y, Z, RZ);
ApplyActorAnimation(Variable, ""Beach"", ""bather"", 4.0, 1, 1, 1, 0, 0);"

            Case 102
                PictureBox1.Image = Global.VisualTextures.My.Resources.Beach_Lay_Bac_Loop
                PictureBox1.Visible = True
                RichTextBox1.Enabled = True
                RichTextBox1.Visible = True
                RichTextBox1.Text =
"new Variable;
Variable = CreateActor(ID, X, Y, Z, RZ);
ApplyActorAnimation(Variable, ""Beach"", ""Lay_Bac_Loop"", 4.0, 1, 1, 1, 0, 0);"

            Case 103
                PictureBox1.Image = Global.VisualTextures.My.Resources.Beach_ParkSit_M_loop
                PictureBox1.Visible = True
                RichTextBox1.Enabled = True
                RichTextBox1.Visible = True
                RichTextBox1.Text =
"new Variable;
Variable = CreateActor(ID, X, Y, Z, RZ);
ApplyActorAnimation(Variable, ""Beach"", ""ParkSit_M_loop"", 4.0, 1, 1, 1, 0, 0);"

            Case 104
                PictureBox1.Image = Global.VisualTextures.My.Resources.Beach_ParkSit_W_loop
                PictureBox1.Visible = True
                RichTextBox1.Enabled = True
                RichTextBox1.Visible = True
                RichTextBox1.Text =
"new Variable;
Variable = CreateActor(ID, X, Y, Z, RZ);
ApplyActorAnimation(Variable, ""Beach"", ""ParkSit_W_loop"", 4.0, 1, 1, 1, 0, 0);"

            Case 105
                PictureBox1.Image = Global.VisualTextures.My.Resources.Beach_SitnWait_loop_W
                PictureBox1.Visible = True
                RichTextBox1.Enabled = True
                RichTextBox1.Visible = True
                RichTextBox1.Text =
"new Variable;
Variable = CreateActor(ID, X, Y, Z, RZ);
ApplyActorAnimation(Variable, ""Beach"", ""SitnWait_loop_W"", 4.0, 1, 1, 1, 0, 0);"

            Case 106
                PictureBox1.Visible = False
                RichTextBox1.Enabled = False
                RichTextBox1.Visible = False
                ListBox1.SelectedIndex = True
                RichTextBox1.Text = ""

            Case 107
                PictureBox1.Visible = False
                RichTextBox1.Enabled = False
                RichTextBox1.Visible = False
                ListBox1.SelectedIndex = True
                RichTextBox1.Text = ""

            Case 108
                PictureBox1.Image = Global.VisualTextures.My.Resources.benchpress_gym_bp_celebrate
                PictureBox1.Visible = True
                RichTextBox1.Enabled = True
                RichTextBox1.Visible = True
                RichTextBox1.Text =
"new Variable;
Variable = CreateActor(ID, X, Y, Z, RZ);
ApplyActorAnimation(Variable, ""benchpress"", ""gym_bp_celebrate"", 4.0, 1, 1, 1, 0, 0);"

            Case 109
                PictureBox1.Image = Global.VisualTextures.My.Resources.benchpress_gym_bp_down
                PictureBox1.Visible = True
                RichTextBox1.Enabled = True
                RichTextBox1.Visible = True
                RichTextBox1.Text =
"new Variable;
Variable = CreateActor(ID, X, Y, Z, RZ);
ApplyActorAnimation(Variable, ""benchpress"", ""gym_bp_down"", 4.0, 1, 1, 1, 0, 0);"

            Case 110
                PictureBox1.Image = Global.VisualTextures.My.Resources.benchpress_gym_bp_getoff
                PictureBox1.Visible = True
                RichTextBox1.Enabled = True
                RichTextBox1.Visible = True
                RichTextBox1.Text =
"new Variable;
Variable = CreateActor(ID, X, Y, Z, RZ);
ApplyActorAnimation(Variable, ""benchpress"", ""gym_bp_getoff"", 4.0, 1, 1, 1, 0, 0);"

            Case 111
                PictureBox1.Image = Global.VisualTextures.My.Resources.benchpress_gym_bp_geton
                PictureBox1.Visible = True
                RichTextBox1.Enabled = True
                RichTextBox1.Visible = True
                RichTextBox1.Text =
"new Variable;
Variable = CreateActor(ID, X, Y, Z, RZ);
ApplyActorAnimation(Variable, ""benchpress"", ""gym_bp_geton"", 4.0, 1, 1, 1, 0, 0);"

            Case 112
                PictureBox1.Image = Global.VisualTextures.My.Resources.benchpress_gym_bp_up_A
                PictureBox1.Visible = True
                RichTextBox1.Enabled = True
                RichTextBox1.Visible = True
                RichTextBox1.Text =
"new Variable;
Variable = CreateActor(ID, X, Y, Z, RZ);
ApplyActorAnimation(Variable, ""benchpress"", ""gym_bp_up_A"", 4.0, 1, 1, 1, 0, 0);"

            Case 113
                PictureBox1.Image = Global.VisualTextures.My.Resources.benchpress_gym_bp_up_B
                PictureBox1.Visible = True
                RichTextBox1.Enabled = True
                RichTextBox1.Visible = True
                RichTextBox1.Text =
"new Variable;
Variable = CreateActor(ID, X, Y, Z, RZ);
ApplyActorAnimation(Variable, ""benchpress"", ""gym_bp_up_A"", 4.0, 1, 1, 1, 0, 0);"

            Case 114
                PictureBox1.Image = Global.VisualTextures.My.Resources.benchpress_gym_bp_up_smooth
                PictureBox1.Visible = True
                RichTextBox1.Enabled = True
                RichTextBox1.Visible = True
                RichTextBox1.Text =
"new Variable;
Variable = CreateActor(ID, X, Y, Z, RZ);
ApplyActorAnimation(Variable, ""benchpress"", ""gym_bp_up_smooth"", 4.0, 1, 1, 1, 0, 0);"

            Case 115
                PictureBox1.Visible = False
                RichTextBox1.Enabled = False
                RichTextBox1.Visible = False
                ListBox1.SelectedIndex = True
                RichTextBox1.Text = ""

            Case 116
                PictureBox1.Visible = False
                RichTextBox1.Enabled = False
                RichTextBox1.Visible = False
                ListBox1.SelectedIndex = True
                RichTextBox1.Text = ""

            Case 117
                PictureBox1.Image = Global.VisualTextures.My.Resources.BIKEd_Back
                PictureBox1.Visible = True
                RichTextBox1.Enabled = True
                RichTextBox1.Visible = True
                RichTextBox1.Text =
"new Variable;
Variable = CreateActor(ID, X, Y, Z, RZ);
ApplyActorAnimation(Variable, ""BIKEd"", ""BIKEd_Back"", 4.0, 1, 1, 1, 0, 0);"

            Case 118
                PictureBox1.Image = Global.VisualTextures.My.Resources.BIKEd_hit
                PictureBox1.Visible = True
                RichTextBox1.Enabled = True
                RichTextBox1.Visible = True
                RichTextBox1.Text =
"new Variable;
Variable = CreateActor(ID, X, Y, Z, RZ);
ApplyActorAnimation(Variable, ""BIKEd"", ""BIKEd_hit"", 4.0, 1, 1, 1, 0, 0);"

            Case 119
                PictureBox1.Visible = False
                RichTextBox1.Enabled = False
                RichTextBox1.Visible = False
                ListBox1.SelectedIndex = True
                RichTextBox1.Text = ""

            Case 120
                PictureBox1.Visible = False
                RichTextBox1.Enabled = False
                RichTextBox1.Visible = False
                ListBox1.SelectedIndex = True
                RichTextBox1.Text = ""

            Case 121
                PictureBox1.Image = Global.VisualTextures.My.Resources.BIKEh_Back
                PictureBox1.Visible = True
                RichTextBox1.Enabled = True
                RichTextBox1.Visible = True
                RichTextBox1.Text =
"new Variable;
Variable = CreateActor(ID, X, Y, Z, RZ);
ApplyActorAnimation(Variable, ""BIKEh"", ""BIKEh_Back"", 4.0, 1, 1, 1, 0, 0);"

            Case 122
                PictureBox1.Image = Global.VisualTextures.My.Resources.BIKEh_hit
                PictureBox1.Visible = True
                RichTextBox1.Enabled = True
                RichTextBox1.Visible = True
                RichTextBox1.Text =
"new Variable;
Variable = CreateActor(ID, X, Y, Z, RZ);
ApplyActorAnimation(Variable, ""BIKEh"", ""BIKEh_hit"", 4.0, 1, 1, 1, 0, 0);"

            Case 123
                PictureBox1.Visible = False
                RichTextBox1.Enabled = False
                RichTextBox1.Visible = False
                ListBox1.SelectedIndex = True
                RichTextBox1.Text = ""

            Case 124
                PictureBox1.Visible = False
                RichTextBox1.Enabled = False
                RichTextBox1.Visible = False
                ListBox1.SelectedIndex = True
                RichTextBox1.Text = ""

            Case 125
                PictureBox1.Image = Global.VisualTextures.My.Resources.bikeleap_struggle_cesar
                PictureBox1.Visible = True
                RichTextBox1.Enabled = True
                RichTextBox1.Visible = True
                RichTextBox1.Text =
"new Variable;
Variable = CreateActor(ID, X, Y, Z, RZ);
ApplyActorAnimation(Variable, ""bikeleap"", ""struggle_cesar"", 4.0, 1, 1, 1, 0, 0);"

            Case 126
                PictureBox1.Image = Global.VisualTextures.My.Resources.bikeleap_struggle_driver
                PictureBox1.Visible = True
                RichTextBox1.Enabled = True
                RichTextBox1.Visible = True
                RichTextBox1.Text =
"new Variable;
Variable = CreateActor(ID, X, Y, Z, RZ);
ApplyActorAnimation(Variable, ""bikeleap"", ""struggle_driver"", 4.0, 1, 1, 1, 0, 0);"

            Case 127
                PictureBox1.Visible = False
                RichTextBox1.Enabled = False
                RichTextBox1.Visible = False
                ListBox1.SelectedIndex = True
                RichTextBox1.Text = ""

            Case 128
                PictureBox1.Visible = False
                RichTextBox1.Enabled = False
                RichTextBox1.Visible = False
                ListBox1.SelectedIndex = True
                RichTextBox1.Text = ""

            Case 129
                PictureBox1.Image = Global.VisualTextures.My.Resources.BIKEs_Back
                PictureBox1.Visible = True
                RichTextBox1.Enabled = True
                RichTextBox1.Visible = True
                RichTextBox1.Text =
"new Variable;
Variable = CreateActor(ID, X, Y, Z, RZ);
ApplyActorAnimation(Variable, ""BIKEs"", ""BIKEs_Back"", 4.0, 1, 1, 1, 0, 0);"

            Case 130
                PictureBox1.Image = Global.VisualTextures.My.Resources.BIKEs_hit
                PictureBox1.Visible = True
                RichTextBox1.Enabled = True
                RichTextBox1.Visible = True
                RichTextBox1.Text =
"new Variable;
Variable = CreateActor(ID, X, Y, Z, RZ);
ApplyActorAnimation(Variable, ""BIKEs"", ""BIKEs_hit"", 4.0, 1, 1, 1, 0, 0);"

            Case 131
                PictureBox1.Visible = False
                RichTextBox1.Enabled = False
                RichTextBox1.Visible = False
                ListBox1.SelectedIndex = True
                RichTextBox1.Text = ""

            Case 132
                PictureBox1.Visible = False
                RichTextBox1.Enabled = False
                RichTextBox1.Visible = False
                ListBox1.SelectedIndex = True
                RichTextBox1.Text = ""

            Case 133
                PictureBox1.Image = Global.VisualTextures.My.Resources.Bike_Dbz_Pass_Driveby_BWD
                PictureBox1.Visible = True
                RichTextBox1.Enabled = True
                RichTextBox1.Visible = True
                RichTextBox1.Text =
"new Variable;
Variable = CreateActor(ID, X, Y, Z, RZ);
ApplyActorAnimation(Variable, ""Bike_Dbz"", ""Pass_Driveby_BWD"", 4.0, 1, 1, 1, 0, 0);"

            Case 134
                PictureBox1.Image = Global.VisualTextures.My.Resources.Bike_Dbz_Pass_Driveby_FWD
                PictureBox1.Visible = True
                RichTextBox1.Enabled = True
                RichTextBox1.Visible = True
                RichTextBox1.Text =
"new Variable;
Variable = CreateActor(ID, X, Y, Z, RZ);
ApplyActorAnimation(Variable, ""Bike_Dbz"", ""Pass_Driveby_FWD"", 4.0, 1, 1, 1, 0, 0);"

            Case 135
                PictureBox1.Image = Global.VisualTextures.My.Resources.Bike_Dbz_Pass_Driveby_LHS
                PictureBox1.Visible = True
                RichTextBox1.Enabled = True
                RichTextBox1.Visible = True
                RichTextBox1.Text =
"new Variable;
Variable = CreateActor(ID, X, Y, Z, RZ);
ApplyActorAnimation(Variable, ""Bike_Dbz"", ""Pass_Driveby_LHS"", 4.0, 1, 1, 1, 0, 0);"

            Case 136
                PictureBox1.Image = Global.VisualTextures.My.Resources.Bike_Dbz_Pass_Driveby_RHS
                PictureBox1.Visible = True
                RichTextBox1.Enabled = True
                RichTextBox1.Visible = True
                RichTextBox1.Text =
"new Variable;
Variable = CreateActor(ID, X, Y, Z, RZ);
ApplyActorAnimation(Variable, ""Bike_Dbz"", ""Pass_Driveby_RHS"", 4.0, 1, 1, 1, 0, 0);"

            Case 137
                PictureBox1.Visible = False
                RichTextBox1.Enabled = False
                RichTextBox1.Visible = False
                ListBox1.SelectedIndex = True
                RichTextBox1.Text = ""

            Case 138
                PictureBox1.Visible = False
                RichTextBox1.Enabled = False
                RichTextBox1.Visible = False
                ListBox1.SelectedIndex = True
                RichTextBox1.Text = ""

            Case 139
                'PictureBox1.Image = Global.VisualTextures.My.Resources.BlowJobz_BJ_Car_End_P
                PictureBox1.Visible = True
                RichTextBox1.Enabled = True
                RichTextBox1.Visible = True
                RichTextBox1.Text =
"new Variable;
Variable = CreateActor(ID, X, Y, Z, RZ);
ApplyActorAnimation(Variable, ""Blowjobz"", ""BJ_Car_End_P"", 4.0, 1, 1, 1, 0, 0);"

            Case 140
                'PictureBox1.Image = Global.VisualTextures.My.Resources.BlowJobz_BJ_Car_End_W
                PictureBox1.Visible = True
                RichTextBox1.Enabled = True
                RichTextBox1.Visible = True
                RichTextBox1.Text =
"new Variable;
Variable = CreateActor(ID, X, Y, Z, RZ);
ApplyActorAnimation(Variable, ""Blowjobz"", ""BJ_Car_End_W"", 4.0, 1, 1, 1, 0, 0);"

            Case 141
                'PictureBox1.Image = Global.VisualTextures.My.Resources.BlowJobz_BJ_Car_Loop_P
                PictureBox1.Visible = True
                RichTextBox1.Enabled = True
                RichTextBox1.Visible = True
                RichTextBox1.Text =
"new Variable;
Variable = CreateActor(ID, X, Y, Z, RZ);
ApplyActorAnimation(Variable, ""Blowjobz"", ""BJ_Car_Loop_P"", 4.0, 1, 1, 1, 0, 0);"

            Case 142
                PictureBox1.Image = Global.VisualTextures.My.Resources.BlowJobz_BJ_Car_Loop_W
                PictureBox1.Visible = True
                RichTextBox1.Enabled = True
                RichTextBox1.Visible = True
                RichTextBox1.Text =
"new Variable;
Variable = CreateActor(ID, X, Y, Z, RZ);
ApplyActorAnimation(Variable, ""Blowjobz"", ""BJ_Car_Loop_W"", 4.0, 1, 1, 1, 0, 0);"

            Case 143
                PictureBox1.Image = Global.VisualTextures.My.Resources.BlowJobz_BJ_Car_Start_P
                PictureBox1.Visible = True
                RichTextBox1.Enabled = True
                RichTextBox1.Visible = True
                RichTextBox1.Text =
"new Variable;
Variable = CreateActor(ID, X, Y, Z, RZ);
ApplyActorAnimation(Variable, ""Blowjobz"", ""BJ_Car_Start_P"", 4.0, 1, 1, 1, 0, 0);"

            Case 144
                PictureBox1.Image = Global.VisualTextures.My.Resources.BlowJobz_BJ_Car_Start_W
                PictureBox1.Visible = True
                RichTextBox1.Enabled = True
                RichTextBox1.Visible = True
                RichTextBox1.Text =
"new Variable;
Variable = CreateActor(ID, X, Y, Z, RZ);
ApplyActorAnimation(Variable, ""Blowjobz"", ""BJ_Car_Start_W"", 4.0, 1, 1, 1, 0, 0);"

            Case 145
                'PictureBox1.Image = Global.VisualTextures.My.Resources.BlowJobz_BJ_Couch_End_P
                PictureBox1.Visible = True
                RichTextBox1.Enabled = True
                RichTextBox1.Visible = True
                RichTextBox1.Text =
"new Variable;
Variable = CreateActor(ID, X, Y, Z, RZ);
ApplyActorAnimation(Variable, ""Blowjobz"", ""BJ_Couch_End_P"", 4.0, 1, 1, 1, 0, 0);"

            Case 146
                'PictureBox1.Image = Global.VisualTextures.My.Resources.BlowJobz_BJ_Couch_End_W
                PictureBox1.Visible = True
                RichTextBox1.Enabled = True
                RichTextBox1.Visible = True
                RichTextBox1.Text =
"new Variable;
Variable = CreateActor(ID, X, Y, Z, RZ);
ApplyActorAnimation(Variable, ""Blowjobz"", ""BJ_Couch_End_W"", 4.0, 1, 1, 1, 0, 0);"

            Case 147
                'PictureBox1.Image = Global.VisualTextures.My.Resources.BlowJobz_BJ_Couch_Loop_P
                PictureBox1.Visible = True
                RichTextBox1.Enabled = True
                RichTextBox1.Visible = True
                RichTextBox1.Text =
"new Variable;
Variable = CreateActor(ID, X, Y, Z, RZ);
ApplyActorAnimation(Variable, ""Blowjobz"", ""BJ_Couch_Loop_P"", 4.0, 1, 1, 1, 0, 0);"

            Case 148
                'PictureBox1.Image = Global.VisualTextures.My.Resources.BlowJobz_BJ_Couch_Loop_W
                PictureBox1.Visible = True
                RichTextBox1.Enabled = True
                RichTextBox1.Visible = True
                RichTextBox1.Text =
"new Variable;
Variable = CreateActor(ID, X, Y, Z, RZ);
ApplyActorAnimation(Variable, ""Blowjobz"", ""BJ_Couch_Loop_W"", 4.0, 1, 1, 1, 0, 0);"

            Case 149
                'PictureBox1.Image = Global.VisualTextures.My.Resources.BlowJobz_BJ_Couch_Start_P
                PictureBox1.Visible = True
                RichTextBox1.Enabled = True
                RichTextBox1.Visible = True
                RichTextBox1.Text =
"new Variable;
Variable = CreateActor(ID, X, Y, Z, RZ);
ApplyActorAnimation(Variable, ""Blowjobz"", ""BJ_Couch_Start_P"", 4.0, 1, 1, 1, 0, 0);"

            Case 150
                PictureBox1.Image = Global.VisualTextures.My.Resources.BlowJobz_BJ_Couch_Start_W
                PictureBox1.Visible = True
                RichTextBox1.Enabled = True
                RichTextBox1.Visible = True
                RichTextBox1.Text =
"new Variable;
Variable = CreateActor(ID, X, Y, Z, RZ);
ApplyActorAnimation(Variable, ""Blowjobz"", ""BJ_Couch_Start_W"", 4.0, 1, 1, 1, 0, 0);"

            Case 151
                PictureBox1.Image = Global.VisualTextures.My.Resources.BlowJobz_BJ_Stand_End_P
                PictureBox1.Visible = True
                RichTextBox1.Enabled = True
                RichTextBox1.Visible = True
                RichTextBox1.Text =
"new Variable;
Variable = CreateActor(ID, X, Y, Z, RZ);
ApplyActorAnimation(Variable, ""Blowjobz"", ""BJ_Stand_End_P"", 4.0, 1, 1, 1, 0, 0);"

            Case 152
                ' PictureBox1.Image = Global.VisualTextures.My.Resources.BlowJobz_BJ_Stand_End_W
                PictureBox1.Visible = True
                RichTextBox1.Enabled = True
                RichTextBox1.Visible = True
                RichTextBox1.Text =
"new Variable;
Variable = CreateActor(ID, X, Y, Z, RZ);
ApplyActorAnimation(Variable, ""Blowjobz"", ""BJ_Stand_End_W"", 4.0, 1, 1, 1, 0, 0);"

            Case 153
                'PictureBox1.Image = Global.VisualTextures.My.Resources.BlowJobz_BJ_Stand_Loop_P
                PictureBox1.Visible = True
                RichTextBox1.Enabled = True
                RichTextBox1.Visible = True
                RichTextBox1.Text =
"new Variable;
Variable = CreateActor(ID, X, Y, Z, RZ);
ApplyActorAnimation(Variable, ""Blowjobz"", ""BJ_Stand_Loop_P"", 4.0, 1, 1, 1, 0, 0);"

            Case 154
                'PictureBox1.Image = Global.VisualTextures.My.Resources.BlowJobz_BJ_Stand_Loop_W
                PictureBox1.Visible = True
                RichTextBox1.Enabled = True
                RichTextBox1.Visible = True
                RichTextBox1.Text =
"new Variable;
Variable = CreateActor(ID, X, Y, Z, RZ);
ApplyActorAnimation(Variable, ""Blowjobz"", ""BJ_Stand_Loop_W"", 4.0, 1, 1, 1, 0, 0);"

            Case 155
                PictureBox1.Image = Global.VisualTextures.My.Resources.BlowJobz_BJ_Stand_Start_P
                PictureBox1.Visible = True
                RichTextBox1.Enabled = True
                RichTextBox1.Visible = True
                RichTextBox1.Text =
"new Variable;
Variable = CreateActor(ID, X, Y, Z, RZ);
ApplyActorAnimation(Variable, ""Blowjobz"", ""BJ_Stand_Start_P"", 4.0, 1, 1, 1, 0, 0);"

            Case 156
                PictureBox1.Image = Global.VisualTextures.My.Resources.BlowJobz_BJ_Stand_Start_W
                PictureBox1.Visible = True
                RichTextBox1.Enabled = True
                RichTextBox1.Visible = True
                RichTextBox1.Text =
"new Variable;
Variable = CreateActor(ID, X, Y, Z, RZ);
ApplyActorAnimation(Variable, ""Blowjobz"", ""BJ_Stand_Start_W"", 4.0, 1, 1, 1, 0, 0);"

            Case 157
                PictureBox1.Visible = False
                RichTextBox1.Enabled = False
                RichTextBox1.Visible = False
                ListBox1.SelectedIndex = True
                RichTextBox1.Text = ""

            Case 158
                PictureBox1.Visible = False
                RichTextBox1.Enabled = False
                RichTextBox1.Visible = False
                ListBox1.SelectedIndex = True
                RichTextBox1.Text = ""

            Case 159
                PictureBox1.Image = Global.VisualTextures.My.Resources.Bomber_BOM_Plant
                PictureBox1.Visible = True
                RichTextBox1.Enabled = True
                RichTextBox1.Visible = True
                RichTextBox1.Text =
"new Variable;
Variable = CreateActor(ID, X, Y, Z, RZ);
ApplyActorAnimation(Variable, ""Bomber"", ""Plant"", 4.0, 1, 1, 1, 0, 0);"

            Case 160
                PictureBox1.Image = Global.VisualTextures.My.Resources.Bomber_BOM_Plant_2Idle
                PictureBox1.Visible = True
                RichTextBox1.Enabled = True
                RichTextBox1.Visible = True
                RichTextBox1.Text =
"new Variable;
Variable = CreateActor(ID, X, Y, Z, RZ);
ApplyActorAnimation(Variable, ""Bomber"", ""Plant_2Idle"", 4.0, 1, 1, 1, 0, 0);"

            Case 161
                PictureBox1.Image = Global.VisualTextures.My.Resources.Bomber_BOM_Plant_Crouch_In
                PictureBox1.Visible = True
                RichTextBox1.Enabled = True
                RichTextBox1.Visible = True
                RichTextBox1.Text =
"new Variable;
Variable = CreateActor(ID, X, Y, Z, RZ);
ApplyActorAnimation(Variable, ""Bomber"", ""Plant_Crouch_In"", 4.0, 1, 1, 1, 0, 0);"

            Case 162
                PictureBox1.Image = Global.VisualTextures.My.Resources.Bomber_BOM_Plant_Loop
                PictureBox1.Visible = True
                RichTextBox1.Enabled = True
                RichTextBox1.Visible = True
                RichTextBox1.Text =
"new Variable;
Variable = CreateActor(ID, X, Y, Z, RZ);
ApplyActorAnimation(Variable, ""Bomber"", ""Plant_Loop"", 4.0, 1, 1, 1, 0, 0);"

            Case 163
                PictureBox1.Visible = False
                RichTextBox1.Enabled = False
                RichTextBox1.Visible = False
                ListBox1.SelectedIndex = True
                RichTextBox1.Text = ""

            Case 164
                PictureBox1.Visible = False
                RichTextBox1.Enabled = False
                RichTextBox1.Visible = False
                ListBox1.SelectedIndex = True
                RichTextBox1.Text = ""

            Case 165
                PictureBox1.Image = Global.VisualTextures.My.Resources.Box_boxhipin
                PictureBox1.Visible = True
                RichTextBox1.Enabled = True
                RichTextBox1.Visible = True
                RichTextBox1.Text =
"new Variable;
Variable = CreateActor(ID, X, Y, Z, RZ);
ApplyActorAnimation(Variable, ""Box"", ""boxhipin"", 4.0, 1, 1, 1, 0, 0);"

            Case 166
                PictureBox1.Image = Global.VisualTextures.My.Resources.Box_boxhipup
                PictureBox1.Visible = True
                RichTextBox1.Enabled = True
                RichTextBox1.Visible = True
                RichTextBox1.Text =
"new Variable;
Variable = CreateActor(ID, X, Y, Z, RZ);
ApplyActorAnimation(Variable, ""Box"", ""boxhipup"", 4.0, 1, 1, 1, 0, 0);"

            Case 167
                PictureBox1.Image = Global.VisualTextures.My.Resources.Box_boxshdwn
                PictureBox1.Visible = True
                RichTextBox1.Enabled = True
                RichTextBox1.Visible = True
                RichTextBox1.Text =
"new Variable;
Variable = CreateActor(ID, X, Y, Z, RZ);
ApplyActorAnimation(Variable, ""Box"", ""boxshdwn"", 4.0, 1, 1, 1, 0, 0);"

            Case 168
                PictureBox1.Image = Global.VisualTextures.My.Resources.Box_catch_box
                PictureBox1.Visible = True
                RichTextBox1.Enabled = True
                RichTextBox1.Visible = True
                RichTextBox1.Text =
"new Variable;
Variable = CreateActor(ID, X, Y, Z, RZ);
ApplyActorAnimation(Variable, ""Box"", ""catch_box"", 4.0, 1, 1, 1, 0, 0);"

            Case 169
                PictureBox1.Visible = False
                RichTextBox1.Enabled = False
                RichTextBox1.Visible = False
                ListBox1.SelectedIndex = True
                RichTextBox1.Text = ""

            Case 170
                PictureBox1.Visible = False
                RichTextBox1.Enabled = False
                RichTextBox1.Visible = False
                ListBox1.SelectedIndex = True
                RichTextBox1.Text = ""

        End Select
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Close()
    End Sub
    Private Sub LOGToolStripMenuItem_Click_1(sender As Object, e As EventArgs)
        LOG.Show()
    End Sub

    Private Sub TextureViewerToolStripMenuItem_Click(sender As Object, e As EventArgs)
        VTextures.Show()
        Me.Hide()
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs)
        Close()
    End Sub

    Private Sub CreditsToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Credits.Show()
    End Sub

    Private Sub VAnims_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            MoveForm = 1
            CordX = e.X
            CordY = e.Y
            Me.Cursor = Cursors.NoMove2D
        End If
    End Sub

    Private Sub VAnims_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If MoveForm Then
            Me.Location = New Point((Me.Left + e.X - CordX), (Me.Top + e.Y - CordY))
        End If
    End Sub

    Private Sub VAnims_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        MoveForm = 0
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub MenuStrip1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        If e.Button = Windows.Forms.MouseButtons.Left Then
            MoveForm = 1
            CordX = e.X
            CordY = e.Y
            Me.Cursor = Cursors.NoMove2D
        End If
    End Sub

    Private Sub MenuStrip1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        If MoveForm Then
            Me.Location = New Point((Me.Left + e.X - CordX), (Me.Top + e.Y - CordY))
        End If
    End Sub

    Private Sub MenuStrip1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        MoveForm = 0
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub ToolStripMenuItem5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ToolStripMenuItem10_Click(sender As Object, e As EventArgs)
        Contact.Show()
    End Sub

    Private Sub SpriteViewerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SpriteViewerToolStripMenuItem.Click
        VSprites.Show()
        Me.Hide()
    End Sub

    Private Sub PawnColorPickerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PawnColorPickerToolStripMenuItem.Click
        Pawncp.Show()
        Me.Hide()
    End Sub

    Private Sub SAMPScriptToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SAMPScriptToolStripMenuItem.Click
        frmMain.Show()
        Me.Hide()
    End Sub

    Private Sub ToolStripMenuItem5_Click_1(sender As Object, e As EventArgs)
        MessageBox.Show("This option is not in use yet.")
    End Sub

    Private Sub TextureViewerToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles TextureViewerToolStripMenuItem.Click
        VTextures.Show()
        Me.Hide()
    End Sub

    Private Sub ToolStripMenuItem6_Click_1(sender As Object, e As EventArgs)
        MessageBox.Show("This option is not in use yet.")
    End Sub

    Private Sub PawnWikiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PawnWikiToolStripMenuItem.Click
        VSWiki.Show()
        Me.Hide()
    End Sub

    Private Sub ToolStripMenuItem9_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem9.Click
        System.Diagnostics.Process.Start("https://github.com/KaizerHind/VisualTexture_Pawn_SA-MP/releases/")
    End Sub

    Private Sub ToolStripMenuItem10_Click_1(sender As Object, e As EventArgs) Handles ToolStripMenuItem10.Click
        Contact.Show()
    End Sub

    Private Sub LOGToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LOGToolStripMenuItem.Click
        LOG.Show()
    End Sub

    Private Sub CreditsToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles CreditsToolStripMenuItem.Click
        Credits.Show()
    End Sub

    Private Sub CloseBtn_Click(sender As Object, e As EventArgs) Handles CloseBtn.Click
        Environment.Exit(1)
    End Sub
End Class
