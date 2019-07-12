Public Class PawnWiki

    'Dim Palred1 = {"define", "if", "else", "return"} 'MediumPurple
    'Dim PalPurple = {""}

    Private Sub PawnWiki_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel2.Hide()
        ListBox1.Visible = 1
        ListBox1.Enabled = 1

        ListBox1.Items.AddRange(New Object() {
            "    -- Callbacks --",
            "",
            "- OnDialogResponse",
            "- OnGamemodeExit",
            "- OnGamemodeInit",
            "- OnPlayerClickMap",
            "- OnPlayerClickPlayer",
            "- OnPlayerConnect",
            "- OnPlayerDeath",
            "- OnPlayerDisconnect",
            "- OnPlayerEnterVehicle",
            "- OnPlayerExitvehicle",
            "- OnPlayerKeyStateChange",
            "- OnPlayerRequestSpawn",
            "- OnPlayerSpawn",
            "- OnPlayerText",
            "- OnRconLoginAttempt",
            "- OnVehicleDeath",
            "- OnVehicleSpawn",
            "",
            "    -- functions --",
            "- Ban",
            "- CreateExplosion",
            "- CreatePickup",
            "- DestroyPickup",
            "- DisableInteriorEnterExits",
            "- GameTextForAll",
            "- GameTextForPlayer",
            "- GetMaxPlayers",
            "- GetPlayerFacingAngle",
            "- GetPlayerPos",
            "- GetPlayerVersion",
            "- GetweaponName",
            "- IsPlayerAdmin",
            "- IsPlayerInRangeOfPoint",
            "- Kick",
            "- SendClientMessage",
            "- SendClientMessagetoAll",
            "- SendRconCommand",
            "- SetPlayerFacingAngle",
            "- SetPlayerPos",
            "- SetSpawnInfo",
            "- ShowNameTags",
            "- ShowPlayerdialog",
            "- SpawnPlayer",
            ""})
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Select Case ListBox1.SelectedIndex
            Case 0
                Panel2.Hide()
                ListBox1.SelectedIndex = 0
                Panel2.Hide()
            Case 1
                Panel2.Hide()
                ListBox1.SelectedIndex = 0
                Panel2.Hide()

            Case 2
                Panel2.Show()

                Title1.Text = "OnDialogResponse"
                Inform.Text = "Se llama cuando el jugador responde
a un dialogo enviado anteriormente"
                Tags.Text = "playerid, dialogid, response, listitem,
inputtext[]"
                Subtitle1.Text = "OnDialogResponse"
                RichTextBox1.Text = "Se llama cuando el jugador responde a un dialogo enviado anteriormente."
                RichTextBox2.Text = "| playerid | ID Jugador | | dialogid | ID dialogo | | response | Si el dialogo responde o no (boolean) | | listitem | ID seleccionado del dialogo | | inputtext[] | Dato ingresado en un dialogo de input |"
                RichTextBox3.Text = "0 - Evitará que otros FilterScripts reciban esta devolución de llamada. Siempre se llama primero en los FilterScripts, por lo que al volver 1, se bloquea la visualización de otros FilterScripts."
                RichTextBox4.Text = "#define DIALOG_PW 1
// DIALOG_PW será el dialogo con el id 1
ShowPlayerDialog(playerid, DIALOG_PW, DIALOG_STYLE_MSGBOX, ""Duda"", ""Te gusta PawnWiki?"", ""Si"", ""No"");
 
public OnDialogResponse(playerid, dialogid, response, listitem, inputtext[])
{
    if(dialogid == DIALOG_PW)
    {
        if(response) // si acepta
        {
            SendClientMessage(playerid, COLOR_GREEN, ""Gracias por aceptar!"");
        }
        else // si rechaza o aprieta esc
        {
            Kick(playerid);
        }
        return 1; // retornas 1
    }
 
    return 0; // retornas 0
}"

            Case 3
                Panel2.Show()
                Title1.Text = "OnGameModeExit"
                Inform.Text = "Se llama cuando el GameMode
termina (cerrando el
samp-server.exe por ejemplo)"
                Tags.Text = "Sin parametros"
                Subtitle1.Text = "OnGameModeExit"
                RichTextBox1.Text = "Se llama cuando el GameMode termina (cerrando el samp-server.exe por ejemplo)"
                RichTextBox2.Text = "Sin parametros"
                RichTextBox3.Text = "0 - Evitará que otros FilterScripts reciban esta devolución de llamada.
1 - Indica que este callback pasó al otro Script.
Siempre se llama primero en gamemodes."
                RichTextBox4.Text = "public OnGameModeExit()
{
    print(""El GameMode se cerró"");
    return 1;
}"

        End Select
    End Sub

    Private Sub RichTextBox4_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox4.TextChanged

    End Sub
End Class