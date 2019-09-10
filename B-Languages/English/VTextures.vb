Public Class VTextures
    Private CordX As Integer
    Private CordY As Integer
    Private MoveForm As Boolean

    Dim strText As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListBox1.Items.AddRange(New Object() {"1.- Doors", "2.- Walls", "3.- Windows", "4.- Floors", "5.-Metals", "6- Colors", "7.- Furnitures", "8.- Accesories", "9.- Random"})

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Select Case ListBox1.SelectedIndex
            Case 0
                'Habilitacion de RadioButtons.'
                Panel1.Show()
                RadioButton1.Visible = True
                RadioButton2.Visible = True
                RadioButton3.Visible = True
                RadioButton4.Visible = True
                RadioButton5.Visible = True
                RadioButton6.Visible = True
                RadioButton7.Visible = True
                RadioButton8.Visible = True
                RadioButton9.Visible = True
                RadioButton10.Visible = True
                RadioButton11.Visible = True
                RadioButton12.Visible = True
                RadioButton13.Visible = True
                RadioButton14.Visible = True
                RadioButton15.Visible = True
                RadioButton16.Visible = True
                RadioButton17.Visible = True
                RadioButton18.Visible = True
                RadioButton19.Visible = True
                RadioButton20.Visible = True
                RadioButton21.Visible = True
                RadioButton22.Visible = True
                RadioButton23.Visible = True
                RadioButton24.Visible = True
                RadioButton25.Visible = True
                RadioButton26.Visible = True
                RadioButton27.Visible = True
                RadioButton28.Visible = True
                RadioButton29.Visible = True
                RadioButton30.Visible = True
                RadioButton31.Visible = True
                RadioButton32.Visible = True
                RadioButton33.Visible = True
                RadioButton34.Visible = True
                RadioButton35.Visible = True
                RadioButton36.Visible = True
                RadioButton37.Visible = True
                RadioButton38.Visible = True
                RadioButton39.Visible = True
                RadioButton40.Visible = True
                RadioButton41.Visible = True
                RadioButton42.Visible = True
                RadioButton43.Visible = True
                RadioButton44.Visible = True
                RadioButton45.Visible = True
                RadioButton46.Visible = True
                RadioButton47.Visible = True
                RadioButton48.Visible = True
                RadioButton49.Visible = True
                RadioButton50.Visible = True
                RadioButton51.Visible = True
                RadioButton52.Visible = True
                RadioButton53.Visible = True
                RadioButton54.Visible = True
                RadioButton55.Visible = True
                RadioButton56.Visible = True
                RadioButton57.Visible = True
                RadioButton58.Visible = True
                RadioButton59.Visible = True
                RadioButton60.Visible = True
                RadioButton61.Visible = True
                RadioButton62.Visible = True
                RadioButton63.Visible = True
                RadioButton64.Visible = True
                RadioButton65.Visible = True
                RadioButton66.Visible = True
                RadioButton67.Visible = True
                RadioButton68.Visible = True
                RadioButton69.Visible = True
                RadioButton70.Visible = True
                RadioButton71.Visible = True
                RadioButton72.Visible = True
                RadioButton73.Visible = True
                RadioButton74.Visible = True
                RadioButton75.Visible = True
                RadioButton76.Visible = True
                RadioButton77.Visible = True
                RadioButton78.Visible = True
                RadioButton79.Visible = True
                RadioButton80.Visible = True
                RadioButton81.Visible = True
                RadioButton82.Visible = True
                RadioButton83.Visible = True
                RadioButton84.Visible = True
                RadioButton85.Visible = True
                RadioButton86.Visible = True
                RadioButton87.Visible = True
                RadioButton88.Visible = True
                RadioButton89.Visible = True
                RadioButton90.Visible = True
                RadioButton91.Visible = True
                RadioButton92.Visible = True
                RadioButton93.Visible = True
                RadioButton94.Visible = True
                RadioButton95.Visible = True
                RadioButton96.Visible = True
                RadioButton97.Visible = True
                RadioButton98.Visible = True
                RadioButton99.Visible = True
                RadioButton100.Visible = True
                RadioButton101.Visible = True
                RadioButton102.Visible = True
                RadioButton103.Visible = True
                RadioButton104.Visible = True
                RadioButton105.Visible = True
                RadioButton106.Visible = True
                RadioButton107.Visible = True
                RadioButton108.Visible = True
                RadioButton109.Visible = True
                RadioButton110.Visible = True
                RadioButton111.Visible = True
                RadioButton112.Visible = True
                RadioButton113.Visible = True
                RadioButton114.Visible = True
                RadioButton115.Visible = True
                RadioButton116.Visible = True
                RadioButton117.Visible = True
                RadioButton118.Visible = True
                RadioButton119.Visible = True
                RadioButton120.Visible = True
                RadioButton121.Visible = True
                RadioButton122.Visible = True
                RadioButton123.Visible = True
                RadioButton124.Visible = True
                RadioButton125.Visible = True
                RadioButton126.Visible = True
                RadioButton127.Visible = True
                RadioButton128.Visible = True
                RadioButton129.Visible = True
                RadioButton130.Visible = True
                RadioButton131.Visible = True
                RadioButton132.Visible = True
                RadioButton133.Visible = True
                RadioButton134.Visible = True
                RadioButton135.Visible = True
                RadioButton136.Visible = True
                RadioButton137.Visible = True
                RadioButton138.Visible = True
                RadioButton139.Visible = True
                RadioButton140.Visible = True
                RadioButton141.Visible = True
                RadioButton142.Visible = True
                RadioButton143.Visible = True
                RadioButton144.Visible = True
                RadioButton145.Visible = True
                RadioButton146.Visible = True
                RadioButton147.Visible = True
                RadioButton148.Visible = True
                RadioButton149.Visible = True
                RadioButton150.Visible = True
                RadioButton151.Visible = True
                RadioButton152.Visible = True
                RadioButton153.Visible = True
                RadioButton154.Visible = True
                RadioButton155.Visible = True
                RadioButton156.Visible = True
                RadioButton157.Visible = True
                RadioButton158.Visible = True
                RadioButton159.Visible = True
                RadioButton160.Visible = True
                RadioButton161.Visible = True
                RadioButton162.Visible = True
                RadioButton163.Visible = True
                RadioButton164.Visible = True
                RadioButton165.Visible = True
                RadioButton166.Visible = True
                RadioButton167.Visible = True
                RadioButton168.Visible = True
                RadioButton169.Visible = True
                RadioButton170.Visible = True
                RadioButton171.Visible = True
                RadioButton172.Visible = True
                RadioButton173.Visible = True
                RadioButton174.Visible = True
                RadioButton175.Visible = True
                RadioButton176.Visible = True
                RadioButton177.Visible = True
                RichTextBox1.Text = ""

                'Item: Puertas.
                PictureBox1.Image = Global.VisualTextures.My.Resources.a51_blastdoor
                PictureBox1.Visible = True
                PictureBox2.Image = Global.VisualTextures.My.Resources.a51_intdoor
                PictureBox2.Visible = True
                PictureBox3.Image = Global.VisualTextures.My.Resources.a51_weedoors
                PictureBox3.Visible = True
                PictureBox4.Image = Global.VisualTextures.My.Resources.aarprt6LAS
                PictureBox4.Visible = True
                PictureBox5.Image = Global.VisualTextures.My.Resources.alleydoor2
                PictureBox5.Visible = True
                PictureBox6.Image = Global.VisualTextures.My.Resources.alleydoor9b
                PictureBox6.Visible = True
                PictureBox7.Image = Global.VisualTextures.My.Resources.ballydoor01_128
                PictureBox7.Visible = True
                PictureBox8.Image = Global.VisualTextures.My.Resources.Bow_Loadingbay_Door
                PictureBox8.Visible = True
                PictureBox9.Image = Global.VisualTextures.My.Resources.compdoor2_LAe
                PictureBox9.Visible = True
                PictureBox10.Image = Global.VisualTextures.My.Resources.compdoor4_LAe
                PictureBox10.Visible = True
                PictureBox11.Image = Global.VisualTextures.My.Resources.comptdoor2
                PictureBox11.Visible = True
                PictureBox12.Image = Global.VisualTextures.My.Resources.corporate1
                PictureBox12.Visible = True
                PictureBox13.Image = Global.VisualTextures.My.Resources.corporate3green_128
                PictureBox13.Visible = True
                PictureBox14.Image = Global.VisualTextures.My.Resources.des_backdoor1
                PictureBox14.Visible = True
                PictureBox15.Image = Global.VisualTextures.My.Resources.flatdoor01_law
                PictureBox15.Visible = True
                PictureBox16.Image = Global.VisualTextures.My.Resources.garagedoor4_law
                PictureBox16.Visible = True
                PictureBox17.Image = Global.VisualTextures.My.Resources.GB_truckdepot29
                PictureBox17.Visible = True
                PictureBox18.Image = Global.VisualTextures.My.Resources.gz_vicdoor1
                PictureBox18.Visible = True
                PictureBox19.Image = Global.VisualTextures.My.Resources.gz_vicdoor2
                PictureBox19.Visible = True
                PictureBox20.Image = Global.VisualTextures.My.Resources.lasbevcit7
                PictureBox20.Visible = True
                PictureBox21.Image = Global.VisualTextures.My.Resources.lasjmdoorgud
                PictureBox21.Visible = True
                PictureBox22.Image = Global.VisualTextures.My.Resources.lasmalhus92
                PictureBox22.Visible = True
                PictureBox23.Image = Global.VisualTextures.My.Resources.liftdoorsac256
                PictureBox23.Visible = True
                PictureBox24.Image = Global.VisualTextures.My.Resources.LoadingDoorClean
                PictureBox24.Visible = True
                PictureBox25.Image = Global.VisualTextures.My.Resources.shopdoor01_law
                PictureBox25.Visible = True
                PictureBox26.Image = Global.VisualTextures.My.Resources.sjmhoodalldr
                PictureBox26.Visible = True
                PictureBox27.Image = Global.VisualTextures.My.Resources.staddoors1
                PictureBox27.Visible = True
                PictureBox28.Image = Global.VisualTextures.My.Resources.sw_door12
                PictureBox28.Visible = True
                PictureBox29.Image = Global.VisualTextures.My.Resources.sw_sheddoor2
                PictureBox29.Visible = True
                PictureBox30.Image = Global.VisualTextures.My.Resources.vgncorpdoor1_512
                PictureBox30.Visible = True
                PictureBox31.Image = Global.VisualTextures.My.Resources.vgsclubdoor02_128
                PictureBox31.Visible = True
                PictureBox32.Image = Global.VisualTextures.My.Resources.Was_scrpyd_door_in_hngr
                PictureBox32.Visible = True
                PictureBox33.Image = Global.VisualTextures.My.Resources.wilsdoor_01_la
                PictureBox33.Visible = True
                PictureBox34.Image = Global.VisualTextures.My.Resources.ws_airportdoors1
                PictureBox34.Visible = True
                PictureBox35.Image = Global.VisualTextures.My.Resources.ws_airportwin2
                PictureBox35.Visible = True
                PictureBox36.Image = Global.VisualTextures.My.Resources.ws_altz_wall5_door
                PictureBox36.Visible = True
                PictureBox37.Image = Global.VisualTextures.My.Resources.ws_doubledoor1
                PictureBox37.Visible = True
                PictureBox38.Image = Global.VisualTextures.My.Resources.ws_doubledoor4
                PictureBox38.Visible = True
                PictureBox39.Image = Global.VisualTextures.My.Resources.ws_guardhousedoor
                PictureBox39.Visible = True
                PictureBox40.Image = Global.VisualTextures.My.Resources.ws_rollerdoor_fire
                PictureBox40.Visible = True
                PictureBox41.Image = Global.VisualTextures.My.Resources.alleydoor3
                PictureBox41.Visible = True
                PictureBox42.Image = Global.VisualTextures.My.Resources.alleydoor4
                PictureBox42.Visible = True
                PictureBox43.Image = Global.VisualTextures.My.Resources.alleydoor6
                PictureBox43.Visible = True
                PictureBox44.Image = Global.VisualTextures.My.Resources.alleydoor8
                PictureBox44.Visible = True
                PictureBox45.Image = Global.VisualTextures.My.Resources.bevdoor01_law
                PictureBox45.Visible = True
                PictureBox46.Image = Global.VisualTextures.My.Resources.bigwhite_4
                PictureBox46.Visible = True
                PictureBox47.Image = Global.VisualTextures.My.Resources.bigwhite_5
                PictureBox47.Visible = True
                PictureBox48.Image = Global.VisualTextures.My.Resources.Bow_bar_entrance_door
                PictureBox48.Visible = True
                PictureBox49.Image = Global.VisualTextures.My.Resources.Bow_LoadingBayDoor
                PictureBox49.Visible = True
                PictureBox50.Image = Global.VisualTextures.My.Resources.clubdoor1_256
                PictureBox50.Visible = True
                PictureBox51.Image = Global.VisualTextures.My.Resources.comptdoor3
                PictureBox51.Visible = True
                PictureBox52.Image = Global.VisualTextures.My.Resources.comptdoor4
                PictureBox52.Visible = True
                PictureBox53.Image = Global.VisualTextures.My.Resources.garagedoor5_law
                PictureBox53.Visible = True
                PictureBox54.Image = Global.VisualTextures.My.Resources.garargeb2
                PictureBox54.Visible = True
                PictureBox55.Image = Global.VisualTextures.My.Resources.gz_sf_door12b
                PictureBox55.Visible = True
                PictureBox56.Image = Global.VisualTextures.My.Resources.halldoor01_law
                PictureBox56.Visible = True
                PictureBox57.Image = Global.VisualTextures.My.Resources.hosdoor01_law
                PictureBox57.Visible = True
                PictureBox58.Image = Global.VisualTextures.My.Resources.int02_128
                PictureBox58.Visible = True
                PictureBox59.Image = Global.VisualTextures.My.Resources.liftdoors_kb_256
                PictureBox59.Visible = True
                PictureBox60.Image = Global.VisualTextures.My.Resources.Lombard_door1
                PictureBox60.Visible = True
                PictureBox61.Image = Global.VisualTextures.My.Resources.metaldoor01_256
                PictureBox61.Visible = True
                PictureBox62.Image = Global.VisualTextures.My.Resources.pawn_door01
                PictureBox62.Visible = True
                PictureBox63.Image = Global.VisualTextures.My.Resources.plainwoodoor2
                PictureBox63.Visible = True
                PictureBox64.Image = Global.VisualTextures.My.Resources.sf_garagedr1
                PictureBox64.Visible = True
                PictureBox65.Image = Global.VisualTextures.My.Resources.shitydoor1_256
                PictureBox65.Visible = True
                PictureBox66.Image = Global.VisualTextures.My.Resources.shopgrating128H
                PictureBox66.Visible = True
                PictureBox67.Image = Global.VisualTextures.My.Resources.sl_grngarage1
                PictureBox67.Visible = True
                PictureBox68.Image = Global.VisualTextures.My.Resources.sl_prisongate1
                PictureBox68.Visible = True
                PictureBox69.Image = Global.VisualTextures.My.Resources.sl_shopshttr1
                PictureBox69.Visible = True
                PictureBox70.Image = Global.VisualTextures.My.Resources.sw_backdoor02
                PictureBox70.Visible = True
                PictureBox71.Image = Global.VisualTextures.My.Resources.sw_door11
                PictureBox71.Visible = True
                PictureBox72.Image = Global.VisualTextures.My.Resources.sw_shutters1
                PictureBox72.Visible = True
                PictureBox73.Image = Global.VisualTextures.My.Resources.vengardoor01_SFW
                PictureBox73.Visible = True
                PictureBox74.Image = Global.VisualTextures.My.Resources.ws_basheddoor1
                PictureBox74.Visible = True
                PictureBox75.Image = Global.VisualTextures.My.Resources.ws_bigblackdoor
                PictureBox75.Visible = True
                PictureBox76.Image = Global.VisualTextures.My.Resources.ws_garagedoor2_blue
                PictureBox76.Visible = True
                PictureBox77.Image = Global.VisualTextures.My.Resources.ws_garagedoor2_green
                PictureBox77.Visible = True
                PictureBox78.Image = Global.VisualTextures.My.Resources.ws_garagedoor2_white
                PictureBox78.Visible = True
                PictureBox79.Image = Global.VisualTextures.My.Resources.ws_garagedoor3_green
                PictureBox79.Visible = True
                PictureBox80.Image = Global.VisualTextures.My.Resources.ws_garagedoor3_pink
                PictureBox80.Visible = True
                PictureBox81.Image = Global.VisualTextures.My.Resources.ws_garagedoor3_white
                PictureBox81.Visible = True
                PictureBox82.Image = Global.VisualTextures.My.Resources.ws_garagedoor4_peach
                PictureBox82.Visible = True
                PictureBox83.Image = Global.VisualTextures.My.Resources.ws_glassnbrassdoor
                PictureBox83.Visible = True
                PictureBox84.Image = Global.VisualTextures.My.Resources.ws_hangardoor
                PictureBox84.Visible = True
                PictureBox85.Image = Global.VisualTextures.My.Resources.ws_painted_doors1
                PictureBox85.Visible = True
                PictureBox86.Image = Global.VisualTextures.My.Resources.ws_painted_doors2
                PictureBox86.Visible = True
                PictureBox87.Image = Global.VisualTextures.My.Resources.ws_painted_doors3
                PictureBox87.Visible = True
                PictureBox88.Image = Global.VisualTextures.My.Resources.ws_reinforcedbutwonky
                PictureBox88.Visible = True
                PictureBox89.Image = Global.VisualTextures.My.Resources.ws_rollerdoor_silver
                PictureBox89.Visible = True
                PictureBox90.Image = Global.VisualTextures.My.Resources.ws_security_door
                PictureBox90.Visible = True
                PictureBox91.Image = Global.VisualTextures.My.Resources.ws_wood_doors1
                PictureBox91.Visible = True
                PictureBox92.Image = Global.VisualTextures.My.Resources.ws_wood_doors2
                PictureBox92.Visible = True
                PictureBox93.Image = Global.VisualTextures.My.Resources._711doors1
                PictureBox93.Visible = True
                PictureBox94.Image = Global.VisualTextures.My.Resources.ab_ACcarrierDoor
                PictureBox94.Visible = True
                PictureBox95.Image = Global.VisualTextures.My.Resources.airportdoor1
                PictureBox95.Visible = True
                PictureBox96.Image = Global.VisualTextures.My.Resources.alleydoor1
                PictureBox96.Visible = True
                PictureBox97.Image = Global.VisualTextures.My.Resources.alleydoor7
                PictureBox97.Visible = True
                PictureBox98.Image = Global.VisualTextures.My.Resources.alleydoorb256
                PictureBox98.Visible = True
                PictureBox99.Image = Global.VisualTextures.My.Resources.alleydoorz256
                PictureBox99.Visible = True
                PictureBox100.Image = Global.VisualTextures.My.Resources.bevdoor02_law
                PictureBox100.Visible = True
                PictureBox101.Image = Global.VisualTextures.My.Resources.bevdoor03_law
                PictureBox101.Visible = True
                PictureBox102.Image = Global.VisualTextures.My.Resources.bevdoor04_law
                PictureBox102.Visible = True
                PictureBox103.Image = Global.VisualTextures.My.Resources.Bow_door_graffiti_128
                PictureBox103.Visible = True
                PictureBox104.Image = Global.VisualTextures.My.Resources.Bow_Load_Door
                PictureBox104.Visible = True
                PictureBox105.Image = Global.VisualTextures.My.Resources.cargodoor_128
                PictureBox105.Visible = True
                PictureBox106.Image = Global.VisualTextures.My.Resources.carparkdoor1_256
                PictureBox106.Visible = True
                PictureBox107.Image = Global.VisualTextures.My.Resources.casinodoor_frmnt
                PictureBox107.Visible = True
                PictureBox108.Image = Global.VisualTextures.My.Resources.cityhalldoor1
                PictureBox108.Visible = True
                PictureBox109.Image = Global.VisualTextures.My.Resources.CJ_DOOR6
                PictureBox109.Visible = True
                PictureBox110.Image = Global.VisualTextures.My.Resources.CJ_PIZZA_DOOR
                PictureBox110.Visible = True
                PictureBox111.Image = Global.VisualTextures.My.Resources.CJ_SCOR_DOOR
                PictureBox111.Visible = True
                PictureBox112.Image = Global.VisualTextures.My.Resources.CJ_SUB_DOORS
                PictureBox112.Visible = True
                PictureBox113.Image = Global.VisualTextures.My.Resources.compdoor1_LAe
                PictureBox113.Visible = True
                PictureBox114.Image = Global.VisualTextures.My.Resources.compdoor5_LAe
                PictureBox114.Visible = True
                PictureBox115.Image = Global.VisualTextures.My.Resources.compdoor6_LAe
                PictureBox115.Visible = True
                PictureBox116.Image = Global.VisualTextures.My.Resources.comptdoor1
                PictureBox116.Visible = True
                PictureBox117.Image = Global.VisualTextures.My.Resources.corporate2
                PictureBox117.Visible = True
                PictureBox118.Image = Global.VisualTextures.My.Resources.corporate3
                PictureBox118.Visible = True
                PictureBox119.Image = Global.VisualTextures.My.Resources.crapdoor1_256
                PictureBox119.Visible = True
                PictureBox120.Image = Global.VisualTextures.My.Resources.des_adobedoor1
                PictureBox120.Visible = True
                PictureBox121.Image = Global.VisualTextures.My.Resources.des_adobedoor2
                PictureBox121.Visible = True
                PictureBox122.Image = Global.VisualTextures.My.Resources.des_adobedoor3
                PictureBox122.Visible = True
                PictureBox123.Image = Global.VisualTextures.My.Resources.des_door1
                PictureBox123.Visible = True
                PictureBox124.Image = Global.VisualTextures.My.Resources.des_door2
                PictureBox124.Visible = True
                PictureBox125.Image = Global.VisualTextures.My.Resources.des_greendoor
                PictureBox125.Visible = True
                PictureBox126.Image = Global.VisualTextures.My.Resources.des_metaldoor1
                PictureBox126.Visible = True
                PictureBox127.Image = Global.VisualTextures.My.Resources.des_ntwndoor1
                PictureBox127.Visible = True
                PictureBox128.Image = Global.VisualTextures.My.Resources.des_ntwndoor2
                PictureBox128.Visible = True
                PictureBox129.Image = Global.VisualTextures.My.Resources.des_ntwndoor3
                PictureBox129.Visible = True
                PictureBox130.Image = Global.VisualTextures.My.Resources.des_ntwnwin6
                PictureBox130.Visible = True
                PictureBox131.Image = Global.VisualTextures.My.Resources.des_thfdoor
                PictureBox131.Visible = True
                PictureBox132.Image = Global.VisualTextures.My.Resources.des_wigwamdoor
                PictureBox132.Visible = True
                PictureBox133.Image = Global.VisualTextures.My.Resources.des_woodshopdoor1
                PictureBox133.Visible = True
                PictureBox134.Image = Global.VisualTextures.My.Resources.doornvent256128
                PictureBox134.Visible = True
                PictureBox135.Image = Global.VisualTextures.My.Resources.door_pan1_64_128
                PictureBox135.Visible = True
                PictureBox136.Image = Global.VisualTextures.My.Resources.drvin_door1
                PictureBox136.Visible = True
                PictureBox137.Image = Global.VisualTextures.My.Resources.drvin_door2
                PictureBox137.Visible = True
                PictureBox138.Image = Global.VisualTextures.My.Resources.dt_ind_door
                PictureBox138.Visible = True
                PictureBox139.Image = Global.VisualTextures.My.Resources.dt_scyscrap_door2
                PictureBox139.Visible = True
                PictureBox140.Image = Global.VisualTextures.My.Resources.GB_doorpur01
                PictureBox140.Visible = True
                PictureBox141.Image = Global.VisualTextures.My.Resources.inddoor1
                PictureBox141.Visible = True
                PictureBox142.Image = Global.VisualTextures.My.Resources.inddoor5
                PictureBox142.Visible = True
                PictureBox143.Image = Global.VisualTextures.My.Resources.inddoor7
                PictureBox143.Visible = True
                PictureBox144.Image = Global.VisualTextures.My.Resources.inddoordark128
                PictureBox144.Visible = True
                PictureBox145.Image = Global.VisualTextures.My.Resources.inddoorway128
                PictureBox145.Visible = True
                PictureBox146.Image = Global.VisualTextures.My.Resources.mp_carter_doorway
                PictureBox146.Visible = True
                PictureBox147.Image = Global.VisualTextures.My.Resources.sf_ship_door
                PictureBox147.Visible = True
                PictureBox148.Image = Global.VisualTextures.My.Resources.shopdoor02_law
                PictureBox148.Visible = True
                PictureBox149.Image = Global.VisualTextures.My.Resources.shopdoor3_64
                PictureBox149.Visible = True
                PictureBox150.Image = Global.VisualTextures.My.Resources.sjmhoodoor1
                PictureBox150.Visible = True
                PictureBox151.Image = Global.VisualTextures.My.Resources.slidingdoor01_128
                PictureBox151.Visible = True
                PictureBox152.Image = Global.VisualTextures.My.Resources.sl_presdoor01
                PictureBox152.Visible = True
                PictureBox153.Image = Global.VisualTextures.My.Resources.sl_presdoor02
                PictureBox153.Visible = True
                PictureBox154.Image = Global.VisualTextures.My.Resources.sw_door03
                PictureBox154.Visible = True
                PictureBox155.Image = Global.VisualTextures.My.Resources.sw_door04
                PictureBox155.Visible = True
                PictureBox156.Image = Global.VisualTextures.My.Resources.sw_door05
                PictureBox156.Visible = True
                PictureBox157.Image = Global.VisualTextures.My.Resources.sw_door07
                PictureBox157.Visible = True
                PictureBox158.Image = Global.VisualTextures.My.Resources.sw_door08
                PictureBox158.Visible = True
                PictureBox159.Image = Global.VisualTextures.My.Resources.sw_door09
                PictureBox158.Visible = True
                PictureBox160.Image = Global.VisualTextures.My.Resources.sw_door10
                PictureBox160.Visible = True
                PictureBox161.Image = Global.VisualTextures.My.Resources.sw_door13
                PictureBox161.Visible = True
                PictureBox162.Image = Global.VisualTextures.My.Resources.sw_door14
                PictureBox162.Visible = True
                PictureBox163.Image = Global.VisualTextures.My.Resources.sw_door15
                PictureBox163.Visible = True
                PictureBox164.Image = Global.VisualTextures.My.Resources.sw_door16
                PictureBox164.Visible = True
                PictureBox165.Image = Global.VisualTextures.My.Resources.sw_door17
                PictureBox165.Visible = True
                PictureBox166.Image = Global.VisualTextures.My.Resources.sw_door18
                PictureBox166.Visible = True
                PictureBox167.Image = Global.VisualTextures.My.Resources.sw_door19
                PictureBox167.Visible = True
                PictureBox168.Image = Global.VisualTextures.My.Resources.trail_door
                PictureBox168.Visible = True
                PictureBox169.Image = Global.VisualTextures.My.Resources.Was_scrpyd_door_dbl_grey
                PictureBox169.Visible = True
                PictureBox170.Image = Global.VisualTextures.My.Resources.Was_scrpyd_trailer_door
                PictureBox170.Visible = True
                PictureBox171.Image = Global.VisualTextures.My.Resources.ws_dampdoubledoor
                PictureBox171.Visible = True
                PictureBox172.Image = Global.VisualTextures.My.Resources.ws_doorframe
                PictureBox172.Visible = True
                PictureBox173.Image = Global.VisualTextures.My.Resources.ws_doorfront
                PictureBox173.Visible = True
                PictureBox174.Image = Global.VisualTextures.My.Resources.ws_doubledoor3
                PictureBox174.Visible = True
                PictureBox175.Image = Global.VisualTextures.My.Resources.ws_garagedoor2_yello
                PictureBox175.Visible = True
                PictureBox176.Image = Global.VisualTextures.My.Resources.ws_rollerdoor_blue
                PictureBox176.Visible = True
                PictureBox177.Image = Global.VisualTextures.My.Resources.ws_rollerdoor_silver2
                PictureBox177.Visible = True

            Case 1
                Panel1.Show()
                RadioButton1.Visible = True
                RadioButton2.Visible = True
                RadioButton3.Visible = True
                RadioButton4.Visible = True
                RadioButton5.Visible = True
                RadioButton6.Visible = True
                RadioButton7.Visible = True
                RadioButton8.Visible = True
                RadioButton9.Visible = True
                RadioButton10.Visible = True
                RadioButton11.Visible = True
                RadioButton12.Visible = True
                RadioButton13.Visible = True
                RadioButton14.Visible = True
                RadioButton15.Visible = True
                RadioButton16.Visible = True
                RadioButton17.Visible = True
                RadioButton18.Visible = True
                RadioButton19.Visible = True
                RadioButton20.Visible = True
                RadioButton21.Visible = True
                RadioButton22.Visible = True
                RadioButton23.Visible = True
                RadioButton24.Visible = True
                RadioButton25.Visible = True
                RadioButton26.Visible = True
                RadioButton27.Visible = True
                RadioButton28.Visible = True
                RadioButton29.Visible = True
                RadioButton30.Visible = True
                RadioButton31.Visible = True
                RadioButton32.Visible = True
                RadioButton33.Visible = True
                RadioButton34.Visible = True
                RadioButton35.Visible = True
                RadioButton36.Visible = True
                RadioButton37.Visible = True
                RadioButton38.Visible = True
                RadioButton39.Visible = True
                RadioButton40.Visible = True
                RadioButton41.Visible = True
                RadioButton42.Visible = True
                RadioButton43.Visible = True
                RadioButton44.Visible = True
                RadioButton45.Visible = True
                RadioButton46.Visible = True
                RadioButton47.Visible = True
                RadioButton48.Visible = True
                RadioButton49.Visible = True
                RadioButton50.Visible = True
                RadioButton51.Visible = True
                RadioButton52.Visible = True
                RadioButton53.Visible = True
                RadioButton54.Visible = True
                RadioButton55.Visible = True
                RadioButton56.Visible = True
                RadioButton57.Visible = True
                RadioButton58.Visible = True
                RadioButton59.Visible = True
                RadioButton60.Visible = True
                RadioButton61.Visible = True
                RadioButton62.Visible = True
                RadioButton63.Visible = True
                RadioButton64.Visible = True
                RadioButton65.Visible = True
                RadioButton66.Visible = True
                RadioButton67.Visible = True
                RadioButton68.Visible = True
                RadioButton69.Visible = True
                RadioButton70.Visible = True
                RadioButton71.Visible = True
                RadioButton72.Visible = True
                RadioButton73.Visible = True
                RadioButton74.Visible = True
                RadioButton75.Visible = True
                RadioButton76.Visible = True
                RadioButton77.Visible = True
                RadioButton78.Visible = True
                RadioButton79.Visible = True
                RadioButton80.Visible = True
                RadioButton81.Visible = True
                RadioButton82.Visible = True
                RadioButton83.Visible = True
                RadioButton84.Visible = True
                RadioButton85.Visible = True
                RadioButton86.Visible = True
                RadioButton87.Visible = True
                RadioButton88.Visible = True
                RadioButton89.Visible = True
                RadioButton90.Visible = True
                RadioButton91.Visible = True
                RadioButton92.Visible = True
                RadioButton93.Visible = True
                RadioButton94.Visible = True
                RadioButton95.Visible = True
                RadioButton96.Visible = True
                RadioButton97.Visible = True
                RadioButton98.Visible = True
                RadioButton99.Visible = True
                RadioButton100.Visible = True
                RadioButton101.Visible = True
                RadioButton102.Visible = True
                RadioButton103.Visible = True
                RadioButton104.Visible = True
                RadioButton105.Visible = True
                RadioButton106.Visible = True
                RadioButton107.Visible = True
                RadioButton108.Visible = True
                RadioButton109.Visible = True
                RadioButton110.Visible = True
                RadioButton111.Visible = True
                RadioButton112.Visible = True
                RadioButton113.Visible = True
                RadioButton114.Visible = True
                RadioButton115.Visible = True
                RadioButton116.Visible = True
                RadioButton117.Visible = True
                RadioButton118.Visible = True
                RadioButton119.Visible = True
                RadioButton120.Visible = True
                RadioButton121.Visible = True
                RadioButton122.Visible = True
                RadioButton123.Visible = True
                RadioButton124.Visible = True
                RadioButton125.Visible = True
                RadioButton126.Visible = True
                RadioButton127.Visible = True
                RadioButton128.Visible = True
                RadioButton129.Visible = True
                RadioButton130.Visible = True
                RadioButton131.Visible = True
                RadioButton132.Visible = True
                RadioButton133.Visible = True
                RadioButton134.Visible = True
                RadioButton135.Visible = True
                RadioButton136.Visible = True
                RadioButton137.Visible = True
                RadioButton138.Visible = True
                RadioButton139.Visible = True
                RadioButton140.Visible = True
                RadioButton141.Visible = True
                RadioButton142.Visible = True
                RadioButton143.Visible = True
                RadioButton144.Visible = True
                RadioButton145.Visible = True
                RadioButton146.Visible = True
                RadioButton147.Visible = True
                RadioButton148.Visible = True
                RadioButton149.Visible = True
                RadioButton150.Visible = True
                RadioButton151.Visible = True
                RadioButton152.Visible = True
                RadioButton153.Visible = True
                RadioButton154.Visible = True
                RadioButton155.Visible = True
                RadioButton156.Visible = True
                RadioButton157.Visible = True
                RadioButton158.Visible = True
                RadioButton159.Visible = True
                RadioButton160.Visible = True
                RadioButton161.Visible = True
                RadioButton162.Visible = True
                RadioButton163.Visible = True
                RadioButton164.Visible = True
                RadioButton165.Visible = True
                RadioButton166.Visible = True
                RadioButton167.Visible = True
                RadioButton168.Visible = True
                RadioButton169.Visible = True
                RadioButton170.Visible = True
                RadioButton171.Visible = True
                RadioButton172.Visible = True
                RadioButton173.Visible = True
                RadioButton174.Visible = True
                RadioButton175.Visible = True
                RadioButton176.Visible = True
                RadioButton177.Visible = True
                RichTextBox1.Text = ""

                '-------------------------------'

                PictureBox1.Visible = True
                PictureBox2.Visible = True
                PictureBox3.Visible = True
                PictureBox4.Visible = True
                PictureBox5.Visible = True
                PictureBox6.Visible = True
                PictureBox7.Visible = True
                PictureBox8.Visible = True
                PictureBox9.Visible = True
                PictureBox10.Visible = True
                PictureBox11.Visible = True
                PictureBox12.Visible = True
                PictureBox13.Visible = True
                PictureBox14.Visible = True
                PictureBox15.Visible = True
                PictureBox16.Visible = True
                PictureBox17.Visible = True
                PictureBox18.Visible = True
                PictureBox19.Visible = True
                PictureBox20.Visible = True
                PictureBox21.Visible = True
                PictureBox22.Visible = True
                PictureBox23.Visible = True
                PictureBox24.Visible = True
                PictureBox25.Visible = True
                PictureBox26.Visible = True
                PictureBox27.Visible = True
                PictureBox28.Visible = True
                PictureBox29.Visible = True
                PictureBox30.Visible = True
                PictureBox31.Visible = True
                PictureBox32.Visible = True
                PictureBox33.Visible = True
                PictureBox34.Visible = True
                PictureBox35.Visible = True
                PictureBox36.Visible = True
                PictureBox37.Visible = True
                PictureBox38.Visible = True
                PictureBox39.Visible = True
                PictureBox40.Visible = True
                PictureBox41.Visible = True
                PictureBox42.Visible = True
                PictureBox43.Visible = True
                PictureBox44.Visible = True
                PictureBox45.Visible = True
                PictureBox46.Visible = True
                PictureBox47.Visible = True
                PictureBox48.Visible = True
                PictureBox49.Visible = True
                PictureBox50.Visible = True
                PictureBox51.Visible = True
                PictureBox52.Visible = True
                PictureBox53.Visible = True
                PictureBox54.Visible = True
                PictureBox55.Visible = True
                PictureBox56.Visible = True
                PictureBox57.Visible = True
                PictureBox58.Visible = True
                PictureBox59.Visible = True
                PictureBox60.Visible = True
                PictureBox61.Visible = True
                PictureBox62.Visible = True
                PictureBox63.Visible = True
                PictureBox64.Visible = True
                PictureBox65.Visible = True
                PictureBox66.Visible = True
                PictureBox67.Visible = True
                PictureBox68.Visible = True
                PictureBox69.Visible = True
                PictureBox70.Visible = True
                PictureBox71.Visible = True
                PictureBox72.Visible = True
                PictureBox73.Visible = True
                PictureBox74.Visible = True
                PictureBox75.Visible = True
                PictureBox76.Visible = True
                PictureBox77.Visible = True
                PictureBox78.Visible = True
                PictureBox79.Visible = True
                PictureBox80.Visible = True
                PictureBox81.Visible = True
                PictureBox82.Visible = True
                PictureBox83.Visible = True
                PictureBox84.Visible = True
                PictureBox85.Visible = True
                PictureBox86.Visible = True
                PictureBox87.Visible = True
                PictureBox88.Visible = True
                PictureBox89.Visible = True
                PictureBox90.Visible = True
                PictureBox91.Visible = True
                PictureBox92.Visible = True
                PictureBox93.Visible = True
                PictureBox94.Visible = True
                PictureBox95.Visible = True
                PictureBox96.Visible = True
                PictureBox97.Visible = True
                PictureBox98.Visible = True
                PictureBox99.Visible = True
                PictureBox100.Visible = True
                PictureBox101.Visible = True
                PictureBox102.Visible = True
                PictureBox103.Visible = True
                PictureBox104.Visible = True
                PictureBox105.Visible = True
                PictureBox106.Visible = True
                PictureBox107.Visible = True
                PictureBox108.Visible = True
                PictureBox109.Visible = True
                PictureBox110.Visible = True
                PictureBox111.Visible = True
                PictureBox112.Visible = True
                PictureBox113.Visible = True
                PictureBox114.Visible = True
                PictureBox115.Visible = True
                PictureBox116.Visible = True
                PictureBox117.Visible = True
                PictureBox118.Visible = True
                PictureBox119.Visible = True
                PictureBox120.Visible = True
                PictureBox121.Visible = True
                PictureBox122.Visible = True
                PictureBox123.Visible = True
                PictureBox124.Visible = True
                PictureBox125.Visible = True
                PictureBox126.Visible = True
                PictureBox127.Visible = True
                PictureBox128.Visible = True
                PictureBox129.Visible = True
                PictureBox130.Visible = True
                PictureBox131.Visible = True
                PictureBox132.Visible = True
                PictureBox133.Visible = True
                PictureBox134.Visible = True
                PictureBox135.Visible = True
                PictureBox136.Visible = True
                PictureBox137.Visible = True
                PictureBox138.Visible = True
                PictureBox139.Visible = True
                PictureBox140.Visible = True
                PictureBox141.Visible = True
                PictureBox142.Visible = True
                PictureBox143.Visible = True
                PictureBox144.Visible = True
                PictureBox145.Visible = True
                PictureBox146.Visible = True
                PictureBox147.Visible = True
                PictureBox148.Visible = True
                PictureBox149.Visible = True
                PictureBox150.Visible = True
                PictureBox151.Visible = True
                PictureBox152.Visible = True
                PictureBox153.Visible = True
                PictureBox154.Visible = True
                PictureBox155.Visible = True
                PictureBox156.Visible = True
                PictureBox157.Visible = True
                PictureBox158.Visible = True
                PictureBox159.Visible = True
                PictureBox160.Visible = True
                PictureBox161.Visible = True
                PictureBox162.Visible = True
                PictureBox163.Visible = True
                PictureBox164.Visible = True
                PictureBox165.Visible = True
                PictureBox166.Visible = True
                PictureBox167.Visible = True
                PictureBox168.Visible = True
                PictureBox169.Visible = True
                PictureBox170.Visible = True
                PictureBox171.Visible = True
                PictureBox172.Visible = True
                PictureBox173.Visible = True
                PictureBox174.Visible = True
                PictureBox175.Visible = True
                PictureBox176.Visible = True
                PictureBox177.Visible = True
                'PictureBox1.Image = Global.VisualTextures.My.a51_floorpanel1
                'PictureBox2.Image = Global.VisualTextures.My.a51_panel2
                'PictureBox3.Image = Global.VisualTextures.My.a51_panels1
                'PictureBox4.Image = Global.VisualTextures.My.a51_strips1
                'PictureBox5.Image = Global.VisualTextures.My.a51_vent1
                'PictureBox6.Image = Global.VisualTextures.My.a51_wall1
                'PictureBox7.Image = Global.VisualTextures.My.brick
                'PictureBox8.Image = Global.VisualTextures.My.carparkwall12_256
                'PictureBox9.Image = Global.VisualTextures.My.concretegroundl1_256
                'PictureBox10.Image = Global.VisualTextures.My.concretewall22_256
                'PictureBox11.Image = Global.VisualTextures.My.concreteyellow256_copy
                'PictureBox12.Image = Global.VisualTextures.My.des_factower
                'PictureBox13.Image = Global.VisualTextures.My.ferry_build14
                'PictureBox14.Image = Global.VisualTextures.My.pcut_bot_law
                'PictureBox15.Image = Global.VisualTextures.My.rebrckwall_128
                'PictureBox16.Image = Global.VisualTextures.My.redmetal
                'PictureBox17.Image = Global.VisualTextures.My.shingles2
                'PictureBox18.Image = Global.VisualTextures.My.sl_vicbrikwall01
                'PictureBox19.Image = Global.VisualTextures.My.sl_vicwall01
                'PictureBox20.Image = Global.VisualTextures.My.sl_vicwall02
                'PictureBox21.Image = Global.VisualTextures.My.sw_olddrum1
                'PictureBox22.Image = Global.VisualTextures.My.wallgreyred128


            Case 2
                Panel1.Hide()
            Case 3
                Panel1.Hide()
            Case 4
                Panel1.Hide()
            Case 5
                Panel1.Hide()
            Case 6
                Panel1.Hide()
            Case 7
                Panel1.Hide()
            Case 8
                Panel1.Hide()
        End Select
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        Select Case ListBox1.SelectedIndex
            Case 0
                RichTextBox1.Text = "SetObjectMaterial(TuVariable1, 0, 16656, ""a51_labs, ""a51_blastdoor"", 0xFFFFFFFF);"
        End Select
    End Sub
    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        Select Case ListBox1.SelectedIndex
            Case 0
                RichTextBox1.Text = "SetObjectMaterial(TuVariable2, 0, 16323, ""a51_ext, a51_intdoor, 0xFFFFFFFF);"
        End Select
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        Select Case ListBox1.SelectedIndex
            Case 0
                RichTextBox1.Text = "SetObjectMaterial(TuVariable3, 0, 16323, ""a51_ext, a51_weedoors, 0xFFFFFFFF);"
        End Select
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable4, 0, 4854, ""airport_las, aarprt6LAS, 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable5, 0, 16323, ""a51_ext, alleydoor2, 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton6.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable6, 0, 16323, ""a51_ext, alleydoor9b, 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton7_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton7.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable7, 0, 8979, ""ballys01, ballydoor01_128, 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton8_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton8.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable8, 0, 4854, ""airport_las, Bow_Loadingbay_Door, 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton9_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton9.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable9, 0, 5520, ""bdupshouse_lae, compdoor2_LAe, 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton10_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton10.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable10, 0, 5520, ""bdupshouse_lae, compdoor4_LAe, 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton11_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton11.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable11, 0, 6285, ""bev_law2, comptdoor2, 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton12_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton12.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable12, 0, 4552, ""ammu_lan2, corporate1, 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton13_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton13.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable13, 0, 5681, ""barrio1_lae, corporate3green_128, 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton14_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton14.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable14, 0, 16323, ""a51_ext, des_backdoor1, 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton15_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton15.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable15, 0, 10101, ""2notherbuildsfe, flatdoor01_law, 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton16_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton16.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable16, 0, 3605, ""bevmans01_la, garagedoor4_law, 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton17_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton17.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable17, 0, 10856, ""bakerybit_sfse, GB_truckdepot29, 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton18_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton18.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable18, 0, 10101, ""2notherbuildsfe, gz_vicdoor1, 0xFFFFFFFF);"
    End Sub
 
    Private Sub RadioButton19_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton19.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable19, 0, 10101, ""2notherbuildsfe, gz_vicdoor2, 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton20_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton20.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable20, 0, 3605, ""bevmans01_la, lasbevcit7, 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton21_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton21.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable21, 0, 3061, ""addoorx, lasjmdoorgud, 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton22_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton22.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable22, 0, 6285, ""bev_law2, lasmalhus92, 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton23_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton23.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable23, 0, 4854, ""airport_las, liftdoorsac256, 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton24_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton24.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable24, 0, 6282, ""beafron2_law2, LoadingDoorClean, 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton25_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton25.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable25, 0, 6285, ""bev_law2, shopdoor01_law, 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton26_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton26.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable26, 0, 3605, ""bevmans01_la, sjmhoodalldr, 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton27_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton27.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable27, 0, 9514, ""711_sfw, staddoors1, 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton28_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton28.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable28, 0, 4854, ""airport_las, sw_door12, 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton29_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton29.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable29, 0, 9514, ""711_sfw, sw_sheddoor2, 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton30_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton30.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable30, 0, 8979, ""ballys01, vgncorpdoor1_512, 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton31_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton31.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable31, 0, 10764, ""airport1_sfse, vgsclubdoor02_128, 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton32_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton32.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable32, 0, 16294, ""a51_undergrnd, Was_scrpyd_door_in_hngr, 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton33_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton33.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable33, 0, 3605, ""bevmans01_la, wilsdoor_01_la, 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton34_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton34.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable34, 0, 10764, ""airport1_sfse, ws_airportdoors1, 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton35_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton35.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable35, 0, 10755, ""airportrminl_sfse, ws_airportwin2, 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton36_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton36.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable36, 0, 10891, ""bakery_sfse, ws_altz_wall5_door, 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton37_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton37.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable37, 0, 10764, ""airport1_sfse, ws_doubledoor1, 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton38_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton38.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable38, 0, 10891, ""bakery_sfse, ws_doubledoor4, 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton39_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton39.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable39, 0, 1569, ""adam_v_doort, ws_guardhousedoor, 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton40_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton40.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable40, 0, 10764, ""airport1_sfse, ws_rollerdoor_fire, 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton41_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton41.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable41, 0, 8057, ""vgsswarehse02"", ""alleydoor3"", 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton42_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton42.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariabl42, 0, 7315, ""vgnfremnt1"", ""alleydoor4"", 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton43_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton43.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable43, 0, 19794, ""civic04_lan"", ""alleydoor6"", 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton44_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton44.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable44, 0, 8057, ""vgsswarehse02"", ""alleydoor8"", 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton45_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton45.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable45, 0, 9510, ""boxybld2_sfw "", ""bevdoor01_law"", 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton46_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton46.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable46, 0, 6104, ""gazlaw2"", ""bigwhite_4"", 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton47_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton47.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable47, 0, 10270, ""bigwhitesfe"", ""bigwhite_5"", 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton48_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton48.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable48, 0, 6104, ""gazlaw2"", ""Bow_bar_entrance_door"", 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton49_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton49.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable49, 0, 8057, ""vgsswarehse02"", ""Bow_LoadingBayDoor"", 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton50_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton50.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable50, 0, 7289, ""vgnfremnt2"", ""clubdoor1_256"", 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton51_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton51.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable51, 0, 9510, ""boxybld2_sfw"", ""comptdoor3"", 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton52_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton52.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable52, 0, 12976, ""sw_diner1"", ""comptdoor4"", 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton53_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton53.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable53, 0, 9516, ""bigboxtemp1"", ""garagedoor5_law"", 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton54_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton54.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable54, 0, 9911, ""fishwarf"", ""garargeb2"", 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton55_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton55.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable55, 0, 9739, ""vict_sfw"", ""gz_sf_door12b"", 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton56_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton56.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable56, 0, 17536, ""lae2bigbloc"", ""halldoor01_law"", 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton57_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton57.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable57, 0, 19794, ""civic04_lan"", ""hosdoor01_law"", 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton58_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton58.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable58, 0, 9516, ""bigboxtemp1"", ""int02_128"", 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton59_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton59.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable59 0, 10270, ""bigwhitesfe"", ""liftdoors_kb_256"", 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton60_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton60.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable60, 0, 6065, ""law_beach2"", ""Lombard_door1"", 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton61_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton61.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable61, 0, 3928, ""weemap "", ""metaldoor01_256"", 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton62_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton62.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable62, 0, 6104, ""gazlaw2"", ""pawn_door01"", 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton63_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton63.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable63, 0, 3899, ""hospital2"", ""plainwoodoor2"", 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton64_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton64.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable64, 0, 6065, ""law_beach2"", ""sf_garagedr1"", 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton65_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton65.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable65, 0, 4193, ""lanblokb2"", ""shitydoor1_256"", 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton66_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton66.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable66, 0, 3906, ""libertyhi5"", ""shopgrating128H"", 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton67_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton67.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable67, 0, 10055, ""slapart01sfe"", ""sl_grngarage1"", 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton68_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton68.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable68, 0, 19794, ""civic04_lan"", ""sl_prisongate1"", 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton69_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton69.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable69, 0, 4193, ""lanblokb2"", ""sl_shopshttr1"", 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton70_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton70.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable70, 0, 4198, ""lanriver"", ""sw_backdoor02"", 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton71_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton71.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable71, 0, 3971, ""cj_airprt"", ""sw_door11"", 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton72_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton72.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable72, 0, 12931, ""sw_brewery"", ""sw_shutters1"", 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton73_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton73.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable73, 0, 9510, ""boxybld2_sfw"", ""vengardoor01_sfw"", 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton74_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton74.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable74, 0, 11317, ""carshow_sfse"", ""ws_basheddoor1"", 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton75_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton75.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable75, 0, 4193, ""lanblokb2"", ""ws_bigblackdoor"", 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton76_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton76.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable76, 0, 3824, ""boxhses_sfsx "", ""ws_garagedoor2_blue"", 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton77_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton77.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable77, 0, 3824, ""boxhses_sfsx "", ""ws_garagedoor2_green"", 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton78_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton78.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable78, 0, 3824, ""boxhses_sfsx "", ""ws_garagedoor2_white"", 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton79_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton79.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable79, 0, 3824, ""boxhses_sfsx "", ""ws_garagedoor3_green"", 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton80_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton80.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable80, 0, 3824, ""boxhses_sfsx "", ""ws_garagedoor3_pink"", 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton81_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton81.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable81, 0, 9516, ""bigboxtemp1 "", ""ws_garagedoor3_white"", 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton82_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton82.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable82, 0, 4198, ""lanriver "", ""ws_garagedoor4_peach"", 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton83_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton83.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable83, 0, 9917, ""smallertxd"", ""ws_glassnbrassdoor"", 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton84_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton84.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable84, 0, 16775, ""des_boneyard "", ""ws_hangardoor"", 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton85_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton85.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable85 0, 6065, ""law_beach2 "", ""ws_painted_doors1"", 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton86_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton86.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable86, 0, 3824, ""boxhses_sfsx"", ""ws_painted_doors2"", 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton87_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton87.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable87, 0, 3824, ""boxhses_sfsx"", ""ws_painted_doors3"", 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton88_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton88.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable88, 0, 11014, ""drivingschool_sfse"", ""ws_reinforcedbutwonky"", 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton89_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton89.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable89, 0, 11317, ""carshow_sfse"", ""ws_rollerdoor_silver"", 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton90_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton90.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable90, 0, 9300, ""gazsfn1"", ""ws_security_door"", 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton91_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton91.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable91, 0, 3824, ""boxhses_sfsx"", ""ws_wood_doors1"", 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton92_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton92.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable92, 0, 3824, ""boxhses_sfsx"", ""ws_wood_doors2"", 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton93_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton93.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable93, 0, 5785, ""melrosetr1_lawn"", ""711doors1"", 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton94_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton94.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable94, 0, 11145, ""carrierint_sfs"", ""ab_ACcarrierDoor"", 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton95_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton95.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable95, 0, 3899, ""hospital2"", ""airportdoor1"", 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton96_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton96.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable96, 0, 11464, ""desn_trainstuff"", ""alleydoor1"", 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton97_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton97.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable97, 0, 9237, ""hrbr_sfn"", ""alleydoor7"", 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton98_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton98.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable98, 0, 7491, ""vgncorp1"", ""alleydoorb256"", 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton99_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton99.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable99, 0, 8038, ""vgssairport02"", ""alleydoorz256"", 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton100_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton100.CheckedChanged
            RichTextBox1.Text = "SetObjectMaterial(TuVariable1, 0, 4010, ""lanblokb2"", ""bevdoor02_law"", 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton101_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton101.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable1, 0, 17553, ""ebeachcineblok"", ""bevdoor03_law"", 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton102_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton102.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable1, 0, 3598, ""hillhousex_la1_2"", ""bevdoor04_law"", 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton103_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton103.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable1, 0, 18200, ""w_town2cs_t"", ""Bow_door_graffiti_128"", 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton104_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton104.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable1, 0, 7493, ""vgwestabats"", ""Bow_Load_Door"", 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton105_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton105.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable1, 0, 5154, ""dkcargoshp_las2"", ""cargodoor_128"", 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton106_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton106.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable1, 0, 16398, ""desn2_peckers"", ""carparkdoor1_256"", 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton107_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton107.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable1, 0, 6988, ""vgnfremnt1"", ""casinodoor_frmnt"", 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton108_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton108.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable1, 0, 3980, ""cityhall_lan"", ""cityhalldoor1"", 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton109_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton109.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable1, 0, 11389, ""hubint1_sfse"", ""CJ_DOOR6"", 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton110_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton110.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable1, 0, 18023, ""genintintfastc"", ""CJ_PIZZA_DOOR"", 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton111_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton111.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable1, 0, 1490, ""int_doors"", ""CJ_SCOR_DOOR"", 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton112_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton112.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable1, 0, 10631, ""queensammo_sfs"", ""CJ_SUB_DOORS"", 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton113_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton113.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable1, 0, 3646, ""ganghouse1_lax"", ""compdoor1_LAe"", 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton114_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton114.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable1, 0, 3698, ""comedbarrio1_la"", ""compdoor5_LAe"", 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton115_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton115.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable1, 0, 17537, ""eastls4_lae2"", ""compdoor6_LAe"", 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton116_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton116.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable1, 0, 17566, ""contachou1_lae2"", ""comptdoor1"", 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton117_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton117.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable1, 0, 6332, ""rodeo01_law2"", ""corporate2"", 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton118_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton118.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable1, 0, 5725, ""sunrise08_lawn"", ""corporate3"", 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton119_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton119.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable1, 0, 7088, ""casinoshops1"", ""crapdoor1_256"", 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton120_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton120.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable1, 0, 16011, ""des_ntown"", ""des_adobedoor1"", 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton121_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton121.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable1, 0, 11440, ""des_pueblo"", ""des_adobedoor2"", 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton122_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton122.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable1, 0, 16051, ""oldwest"", ""des_adobedoor3"", 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton123_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton123.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable1, 0, 16051, ""oldwest"", ""des_door1"", 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton124_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton124.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable1, 0, 18282, ""cw_truckstopcs_t"", ""des_door2"", 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton125_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton125.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable1, 0, 11471, ""des_wtownmain"", ""des_greendoor"", 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton126_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton126.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable1, 0, 16011, ""des_ntown"", ""des_metaldoor1"", 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton127_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton127.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable1, 0, 16011, ""des_ntown"", ""des_ntwndoor1"", 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton128_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton128.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable1, 0, 16011, ""des_ntown"", ""des_ntwndoor2"", 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton129_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton129.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable1, 0, 16011, ""des_ntown"", ""des_ntwndoor3"", 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton130_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton130.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable1, 0, 16010, ""des_nstuff"", ""des_ntwnwin6"", 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton131_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton131.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable1, 0, 11425, ""des_clifftown"", ""des_thfdoor"", 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton132_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton132.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable1, 0, 11449, ""des_nstuff"", ""des_wigwamdoor"", 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton133_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton133.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable1, 0, 11449, ""des_nwtownw"", ""des_woodshopdoor1"", 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton134_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton134.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable1, 0, 17538, ""losflor4_lae2"", ""doornvent256128"", 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton135_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton135.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable1, 0, 13816, ""lahills_safe1"", ""door_pan1_64_128"", 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton136_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton136.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable1, 0, 16004, ""des_teepee"", ""drvin_door1"", 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton137_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton137.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable1, 0, 16069, ""des_stownstrip1"", ""drvin_door2"", 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton138_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton138.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable1, 0, 17946, ""carter_mainmap"", ""dt_ind_door"", 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton139_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton139.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable1, 0, 10028, ""copshop_sfe"", ""dt_scyscrap_door2"", 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton140_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton140.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable1, 0, 17700, ""gangblok1_lae2"", ""GB_doorpur01"", 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton141_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton141.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable1, 0, 12814, ""factorycunte"", ""inddoor1"", 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton142_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton142.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable1, 0, 18265, ""w_town3cs_t"", ""inddoor5"", 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton143_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton143.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable1, 0, 3905, ""libertyhi2"", ""inddoor7"", 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton144_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton144.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable1, 0, 3897, ""libertyhi"", ""inddoordark128"", 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton145_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton145.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable1, 0, 3897, ""libertyhi"", ""inddoorway128"", 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton146_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton146.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable1, 0, 17946, ""carter_mainmap"", ""mp_carter_doorway"", 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton147_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton147.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable1, 0, 10226, ""sfeship1"", ""sf_ship_door"", 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton148_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton148.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable1, 0, 5709, ""melrose17_lawn"", ""shopdoor02_law"", 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton149_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton149.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable1, 0, 3902, ""libertyhi3"", ""shopdoor3_64"", 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton150_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton150.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable1, 0, 17562, ""coast_apts"", ""sjmhoodoor1"", 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton151_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton151.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable1, 0, 8488, ""flamingo1"", ""slidingdoor01_128"", 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton152_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton152.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable1, 0, 9259, ""presidio01_sfn"", ""sl_presdoor01"", 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton153_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton153.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable1, 0, 9259, ""presidio01_sfn"", ""sl_presdoor02"", 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton154_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton154.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable1, 0, 12862, ""sw_block03"", ""sw_door03"", 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton155_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton155.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable1, 0, 12862, ""sw_block03"", ""sw_door04"", 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton156_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton156.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable1, 0, 12862, ""sw_block03"", ""sw_door05"", 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton157_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton157.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable1, 0, 14538, ""ab_xit_box"", ""sw_door07"", 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton158_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton158.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable1, 0, 12923, ""sw_block05"", ""sw_door08"", 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton159_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton159.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable1, 0, 12946, ""ce_bankalley1"", ""sw_door09"", 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton160_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton160.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable1, 0, 12850, ""cunte_block1"", ""sw_door10"", 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton161_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton161.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable1, 0, 3314, ""ce_burbhouse"", ""sw_door13"", 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton162_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton162.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable1, 0, 17532, ""lae2grnd"", ""sw_door14"", 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton163_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton163.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable1, 0, 13131, ""cunte_blockammo"", ""sw_door15"", 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton164_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton164.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable1, 0, 13363, ""cephotoblockcs_t"", ""sw_door16"", 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton165_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton165.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable1, 0, 13364, ""cetown3cs_t"", ""sw_door17"", 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton166_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton166.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable1, 0, 13364, ""cetown3cs_t"", ""sw_door18"", 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton167_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton167.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable1, 0, 16005, ""des_stownmain2"", ""sw_door19"", 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton168_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton168.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable1, 0, 3241, ""conhooses"", ""trail_door"", 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton169_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton169.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable1, 0, 18246, ""cw_junkyard2cs_t"", ""Was_scrpyd_door_dbl_grey"", 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton170_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton170.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable1, 0, 18246, ""cw_junkyard2cs_t"", ""Was_scrpyd_trailer_door"", 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton171_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton171.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable1, 0, 11088, ""crackfactdem_sfs"", ""ws_dampdoubledoor"", 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton172_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton172.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable1, 0, 3820, ""boxhses_sfsx"", ""ws_doorframe"", 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton173_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton173.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable1, 0, 11145, ""carrierint_sfs"", ""ws_doorfront"", 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton174_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton174.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable1, 0, 12848, ""cunte_town1"", ""ws_doubledoor3"", 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton175_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton175.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable1, 0, 17562, ""coast_apts"", ""ws_garagedoor2_yello"", 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton176_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton176.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable1, 0, 10610, ""fedmint_sfs"", ""ws_rollerdoor_blue"", 0xFFFFFFFF);"
    End Sub

    Private Sub RadioButton177_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton177.CheckedChanged
        RichTextBox1.Text = "SetObjectMaterial(TuVariable1, 0, 10375, ""subshops_sfs"", ""ws_rollerdoor_silver2"", 0xFFFFFFFF);"
    End Sub

    Private Sub LOGToolStripMenuItem_Click(sender As Object, e As EventArgs)
        LOG.Show()
        Me.Hide()
    End Sub

    Private Sub ToolStripMenuItem12_Click(sender As Object, e As EventArgs)
        MessageBox.Show("Option temporarily disabled.")
        'SpanishTexture.Show()
        'Me.Hide()
    End Sub

    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs)
        VAnims.Show()
        Me.Hide()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub LOGToolStripMenuItem_Click_1(sender As Object, e As EventArgs)
        LOG.Show()
    End Sub

    Private Sub CreditsToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Credits.Show()
    End Sub

    Private Sub VTextures_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            MoveForm = 1
            CordX = e.X
            CordY = e.Y
            Me.Cursor = Cursors.NoMove2D
        End If
    End Sub

    Private Sub VTextures_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If MoveForm Then
            Me.Location = New Point((Me.Left + e.X - CordX), (Me.Top + e.Y - CordY))
        End If
    End Sub

    Private Sub VTextures_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
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

    Private Sub Panel1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            MoveForm = 1
            CordX = e.X
            CordY = e.Y
            Me.Cursor = Cursors.NoMove2D
        End If
    End Sub

    Private Sub Panel1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseMove
        If MoveForm Then
            Me.Location = New Point((Me.Left + e.X - CordX), (Me.Top + e.Y - CordY))
        End If
    End Sub

    Private Sub Panel1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseUp
        MoveForm = 0
        Me.Cursor = Cursors.Default
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

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub

    Private Sub ToolStripMenuItem10_Click_1(sender As Object, e As EventArgs) Handles ToolStripMenuItem10.Click
        Contact.Show()
    End Sub

    Private Sub LOGToolStripMenuItem_Click_2(sender As Object, e As EventArgs) Handles LOGToolStripMenuItem.Click
        LOG.Show()
    End Sub

    Private Sub CreditsToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles CreditsToolStripMenuItem.Click
        Credits.Show()
    End Sub

    Private Sub ToolStripMenuItem4_Click_1(sender As Object, e As EventArgs) Handles ToolStripMenuItem4.Click
        VAnims.Show()
        Me.Hide()
    End Sub

    Private Sub PawnWikiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PawnWikiToolStripMenuItem.Click
        VSWiki.Show()
        Me.Hide()
    End Sub

    Private Sub ToolStripMenuItem9_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem9.Click
        System.Diagnostics.Process.Start("https://github.com/KaizerHind/VisualTexture_Pawn_SA-MP/releases/")
    End Sub

    Private Sub CloseBtn_Click(sender As Object, e As EventArgs) Handles CloseBtn.Click
        Environment.Exit(1)
    End Sub
End Class
