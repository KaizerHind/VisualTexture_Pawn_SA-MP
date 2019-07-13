Public Class PawnWiki

    Private Sub PawnWiki_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel2.Hide()
        ListBox1.Visible = 1
        ListBox1.Enabled = 1
        RichTextBox4.Hide()

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
            
            ' ------------- Inicio de categoria functions ------------- '
            Case 2
                Panel2.Show()

                Title1.Text = "OnDialogResponse"
                Inform.Text = "Se llama cuando el jugador responde
a un dialogo enviado anteriormente"
                Tags.Text = "playerid, dialogid, response, listitem,
inputtext[]"
                Subtitle1.Text = "OnDialogResponse"
                RichTextBox1.Text = "Se llama cuando el jugador responde a un dialogo enviado anteriormente."
                RichTextBox2.Text = "| playerid, ID Jugador, | dialogid, ID dialogo, | response, Si el dialogo responde o no (boolean), | listitem, ID seleccionado del dialogo, | inputtext[], Dato ingresado en un dialogo de input |"
                RichTextBox3.Text = "0 - Evitará que otros FilterScripts reciban esta devolución de llamada. Siempre se llama primero en los FilterScripts, por lo que al volver 1, se bloquea la visualización de otros FilterScripts."
                RichTextBox4.Text = "<!DOCTYPE html>
<html>
<head>
<link type=""text/css"" rel=""stylesheet"" href=""http://kai.pawnscript.com/github-markdown.css""/>
<link type=""text/css"" rel=""stylesheet"" href=""http://kai.pawnscript.com/hljs-github.min.css""/>
<link type=""text/css"" rel=""stylesheet"" href=""http://kai.pawnscript.com/pilcrow.css""/>
</head>
<Body>
<pre class=""hljs""><code><span class=""hljs-meta"">#<span class=""hljs-meta-keyword"">define</span> DIALOG_PW 1</span>
<span class=""hljs-comment"">// DIALOG_PW será el dialogo con el id 1</span>
ShowPlayerDialog(playerid, DIALOG_PW, DIALOG_STYLE_MSGBOX, <span class=""hljs-string"">""Duda""</span>, <span class=""hljs-string"">""Te gusta PawnWiki?""</span>, <span class=""hljs-string"">""Si""</span>, <span class=""hljs-string"">""No""</span>);

<span class=""hljs-function""><span class=""hljs-keyword"">public</span> <span class=""hljs-title"">OnDialogResponse</span><span class=""hljs-params"">(playerid, dialogid, response, listitem, inputtext[])</span>
</span>{
    <span class=""hljs-keyword"">if</span>(dialogid == DIALOG_PW)
    {
        <span class=""hljs-keyword"">if</span>(response) <span class=""hljs-comment"">// si acepta</span>
        {
            SendClientMessage(playerid, COLOR_GREEN, <span class=""hljs-string"">""Gracias por aceptar!""</span>);
        }
        <span class=""hljs-keyword"">else</span> <span class=""hljs-comment"">// si rechaza o aprieta esc</span>
        {
            Kick(playerid);
        }
        <span class=""hljs-keyword"">return</span> <span class=""hljs-number"">1</span>; <span class=""hljs-comment"">// retornas 1</span>
    }

    <span class=""hljs-keyword"">return</span> <span class=""hljs-number"">0</span>; <span class=""hljs-comment"">// retornas 0</span>
}</code></pre>
</Body>
</html>"

            Case 3
                Panel2.Show()
                Panel3.Show()
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
                RichTextBox4.Text = "<!DOCTYPE html>
<html>
<head>
<link type=""text/css"" rel=""stylesheet"" href=""http://kai.pawnscript.com/github-markdown.css""/>
<link type=""text/css"" rel=""stylesheet"" href=""http://kai.pawnscript.com/hljs-github.min.css""/>
<link type=""text/css"" rel=""stylesheet"" href=""http://kai.pawnscript.com/pilcrow.css""/>
</head>
<Body>
<pre class=""hljs""><code><span class=""hljs-function""><span class=""hljs-keyword"">public</span> <span class=""hljs-title"">OnGameModeExit</span><span class=""hljs-params"">()</span>
</span>{
    print(<span class=""hljs-string"">""El GameMode se cerró""</span>);
    <span class=""hljs-keyword"">return</span> <span class=""hljs-number"">1</span>;
}</code></pre>
</Body>
</html>"
            Case 4
                Panel2.Show()
                Panel3.Show()
                Title1.Text = "OnGameModeInit"
                Inform.Text = "Se llama cuando el GameMode inicia"
                Tags.Text = "Sin parametros"
                Subtitle1.Text = "OnGameModeInit"
                RichTextBox1.Text = "Esta funcion incia en cuanto el servidor es encendido."
                RichTextBox2.Text = "Sin parametros"
                RichTextBox3.Text = "Evitará que otros FilterScripts reciban esta devolución de llamada.
1 - Indica que este callback pasó al otro Script.
Siempre se llama primero en gamemodes."
                RichTextBox4.Text = "<!DOCTYPE html>
<html>
<head>
<link type=""text/css"" rel=""stylesheet"" href=""http://kai.pawnscript.com/github-markdown.css""/>
<link type=""text/css"" rel=""stylesheet"" href=""http://kai.pawnscript.com/hljs-github.min.css""/>
<link type=""text/css"" rel=""stylesheet"" href=""http://kai.pawnscript.com/pilcrow.css""/>
</head>
<Body>
<pre class=""hljs""><code><span class=""hljs-function""><span class=""hljs-keyword"">public</span> <span class=""hljs-title"">OnGameModeInit</span><span class=""hljs-params"">()</span>
</span>{
    print(<span class=""hljs-string"">""El GameMode se inició correctamente""</span>);
    <span class=""hljs-keyword"">return</span> <span class=""hljs-number"">1</span>;
}</code></pre>
</Body>
</html>"

            Case 5
                Panel2.Show()
                Panel3.Show()
                Title1.Text = "OnPlayerClickMap"
                Inform.Text = "Se llama cuando el jugador
clickea el mapa del menu esc"
                Tags.Text = "playerid, Float:fX, Float:fY, Float:fZ"
                Subtitle1.Text = "OnPlayerClickMap"
                RichTextBox1.Text = "Esta funcion es llamada cuando un jugador se encuentra en el menu
de pausa y usa la seccion del Mapa."
                RichTextBox2.Text = "| playerid | El id del jugador. |
| Float:fX | Posición X donde el jugador clickeó|
| Float:fY | Posición Y donde el jugador clickeó|
| Float:fZ | Posición Z donde el jugador clickeó (No es precisa, lee las notas)|"
                RichTextBox3.Text = "0 - Evitará que otros FilterScripts reciban esta devolución de llamada.
1 - Indica que este callback pasó al otro Script.
Siempre se llama primero en gamemodes."
                RichTextBox4.Text = "<!DOCTYPE html>
<html>
<head>
<link type=""text/css"" rel=""stylesheet"" href=""http://kai.pawnscript.com/github-markdown.css""/>
<link type=""text/css"" rel=""stylesheet"" href=""http://kai.pawnscript.com/hljs-github.min.css""/>
<link type=""text/css"" rel=""stylesheet"" href=""http://kai.pawnscript.com/pilcrow.css""/>
</head>
<Body>
<pre class=""hljs""><code><span class=""hljs-function""><span class=""hljs-keyword"">public</span> <span class=""hljs-title"">OnPlayerClickMap</span><span class=""hljs-params"">(playerid, Float:fX, Float:fY, Float:fZ)</span>
</span>{
    <span class=""hljs-built_in"">printf</span>(<span class=""hljs-string"">""El jugador id %s clickeó en el mapa X: %f, Y: %f, Z: %f""</span>, playerid, fX, fY, fZ);
    <span class=""hljs-keyword"">return</span> <span class=""hljs-number"">1</span>;
}</code></pre>
</Body>
</html>"
            Case 6
                Panel2.Show()
                Panel3.Show()
                Title1.Text = ""
                Inform.Text = ""
                Tags.Text = ""
                Subtitle1.Text = ""
                RichTextBox1.Text = ""
                RichTextBox2.Text = ""
                RichTextBox3.Text = ""
                RichTextBox4.Text = "<!DOCTYPE html>
<html>
<head>
<link type=""text/css"" rel=""stylesheet"" href=""http://kai.pawnscript.com/github-markdown.css""/>
<link type=""text/css"" rel=""stylesheet"" href=""http://kai.pawnscript.com/hljs-github.min.css""/>
<link type=""text/css"" rel=""stylesheet"" href=""http://kai.pawnscript.com/pilcrow.css""/>
</head>
<Body>

</Body>
</html>"
            Case 7
                Panel2.Show()
                Panel3.Show()
                Title1.Text = ""
                Inform.Text = ""
                Tags.Text = ""
                Subtitle1.Text = ""
                RichTextBox1.Text = ""
                RichTextBox2.Text = ""
                RichTextBox3.Text = ""
                RichTextBox4.Text = "<!DOCTYPE html>
<html>
<head>
<link type=""text/css"" rel=""stylesheet"" href=""http://kai.pawnscript.com/github-markdown.css""/>
<link type=""text/css"" rel=""stylesheet"" href=""http://kai.pawnscript.com/hljs-github.min.css""/>
<link type=""text/css"" rel=""stylesheet"" href=""http://kai.pawnscript.com/pilcrow.css""/>
</head>
<Body>

</Body>
</html>"
            Case 8
                Panel2.Show()
                Panel3.Show()
                Title1.Text = ""
                Inform.Text = ""
                Tags.Text = ""
                Subtitle1.Text = ""
                RichTextBox1.Text = ""
                RichTextBox2.Text = ""
                RichTextBox3.Text = ""
                RichTextBox4.Text = "<!DOCTYPE html>
<html>
<head>
<link type=""text/css"" rel=""stylesheet"" href=""http://kai.pawnscript.com/github-markdown.css""/>
<link type=""text/css"" rel=""stylesheet"" href=""http://kai.pawnscript.com/hljs-github.min.css""/>
<link type=""text/css"" rel=""stylesheet"" href=""http://kai.pawnscript.com/pilcrow.css""/>
</head>
<Body>

</Body>
</html>"

            Case 9
                Panel2.Show()
                Panel3.Show()
                Title1.Text = ""
                Inform.Text = ""
                Tags.Text = ""
                Subtitle1.Text = ""
                RichTextBox1.Text = ""
                RichTextBox2.Text = ""
                RichTextBox3.Text = ""
                RichTextBox4.Text = "<!DOCTYPE html>
<html>
<head>
<link type=""text/css"" rel=""stylesheet"" href=""http://kai.pawnscript.com/github-markdown.css""/>
<link type=""text/css"" rel=""stylesheet"" href=""http://kai.pawnscript.com/hljs-github.min.css""/>
<link type=""text/css"" rel=""stylesheet"" href=""http://kai.pawnscript.com/pilcrow.css""/>
</head>
<Body>

</Body>
</html>"
            Case 10
                Panel2.Show()
                Panel3.Show()
                Title1.Text = ""
                Inform.Text = ""
                Tags.Text = ""
                Subtitle1.Text = ""
                RichTextBox1.Text = ""
                RichTextBox2.Text = ""
                RichTextBox3.Text = ""
                RichTextBox4.Text = "<!DOCTYPE html>
<html>
<head>
<link type=""text/css"" rel=""stylesheet"" href=""http://kai.pawnscript.com/github-markdown.css""/>
<link type=""text/css"" rel=""stylesheet"" href=""http://kai.pawnscript.com/hljs-github.min.css""/>
<link type=""text/css"" rel=""stylesheet"" href=""http://kai.pawnscript.com/pilcrow.css""/>
</head>
<Body>

</Body>
</html>"
            Case 11
                Panel2.Show()
                Panel3.Show()
                Title1.Text = ""
                Inform.Text = ""
                Tags.Text = ""
                Subtitle1.Text = ""
                RichTextBox1.Text = ""
                RichTextBox2.Text = ""
                RichTextBox3.Text = ""
                RichTextBox4.Text = "<!DOCTYPE html>
<html>
<head>
<link type=""text/css"" rel=""stylesheet"" href=""http://kai.pawnscript.com/github-markdown.css""/>
<link type=""text/css"" rel=""stylesheet"" href=""http://kai.pawnscript.com/hljs-github.min.css""/>
<link type=""text/css"" rel=""stylesheet"" href=""http://kai.pawnscript.com/pilcrow.css""/>
</head>
<Body>

</Body>
</html>"
            Case 12
                Panel2.Show()
                Panel3.Show()
                Title1.Text = ""
                Inform.Text = ""
                Tags.Text = ""
                Subtitle1.Text = ""
                RichTextBox1.Text = ""
                RichTextBox2.Text = ""
                RichTextBox3.Text = ""
                RichTextBox4.Text = "<!DOCTYPE html>
<html>
<head>
<link type=""text/css"" rel=""stylesheet"" href=""http://kai.pawnscript.com/github-markdown.css""/>
<link type=""text/css"" rel=""stylesheet"" href=""http://kai.pawnscript.com/hljs-github.min.css""/>
<link type=""text/css"" rel=""stylesheet"" href=""http://kai.pawnscript.com/pilcrow.css""/>
</head>
<Body>

</Body>
</html>"
            Case 13
                Panel2.Show()
                Panel3.Show()
                Title1.Text = ""
                Inform.Text = ""
                Tags.Text = ""
                Subtitle1.Text = ""
                RichTextBox1.Text = ""
                RichTextBox2.Text = ""
                RichTextBox3.Text = ""
                RichTextBox4.Text = "<!DOCTYPE html>
<html>
<head>
<link type=""text/css"" rel=""stylesheet"" href=""http://kai.pawnscript.com/github-markdown.css""/>
<link type=""text/css"" rel=""stylesheet"" href=""http://kai.pawnscript.com/hljs-github.min.css""/>
<link type=""text/css"" rel=""stylesheet"" href=""http://kai.pawnscript.com/pilcrow.css""/>
</head>
<Body>

</Body>
</html>"
            Case 14
                Panel2.Show()
                Panel3.Show()
                Title1.Text = ""
                Inform.Text = ""
                Tags.Text = ""
                Subtitle1.Text = ""
                RichTextBox1.Text = ""
                RichTextBox2.Text = ""
                RichTextBox3.Text = ""
                RichTextBox4.Text = "<!DOCTYPE html>
<html>
<head>
<link type=""text/css"" rel=""stylesheet"" href=""http://kai.pawnscript.com/github-markdown.css""/>
<link type=""text/css"" rel=""stylesheet"" href=""http://kai.pawnscript.com/hljs-github.min.css""/>
<link type=""text/css"" rel=""stylesheet"" href=""http://kai.pawnscript.com/pilcrow.css""/>
</head>
<Body>

</Body>
</html>"
            Case 15
                Panel2.Show()
                Panel3.Show()
                Title1.Text = ""
                Inform.Text = ""
                Tags.Text = ""
                Subtitle1.Text = ""
                RichTextBox1.Text = ""
                RichTextBox2.Text = ""
                RichTextBox3.Text = ""
                RichTextBox4.Text = "<!DOCTYPE html>
<html>
<head>
<link type=""text/css"" rel=""stylesheet"" href=""http://kai.pawnscript.com/github-markdown.css""/>
<link type=""text/css"" rel=""stylesheet"" href=""http://kai.pawnscript.com/hljs-github.min.css""/>
<link type=""text/css"" rel=""stylesheet"" href=""http://kai.pawnscript.com/pilcrow.css""/>
</head>
<Body>

</Body>
</html>"
            Case 16
                Panel2.Show()
                Panel3.Show()
                Title1.Text = ""
                Inform.Text = ""
                Tags.Text = ""
                Subtitle1.Text = ""
                RichTextBox1.Text = ""
                RichTextBox2.Text = ""
                RichTextBox3.Text = ""
                RichTextBox4.Text = "<!DOCTYPE html>
<html>
<head>
<link type=""text/css"" rel=""stylesheet"" href=""http://kai.pawnscript.com/github-markdown.css""/>
<link type=""text/css"" rel=""stylesheet"" href=""http://kai.pawnscript.com/hljs-github.min.css""/>
<link type=""text/css"" rel=""stylesheet"" href=""http://kai.pawnscript.com/pilcrow.css""/>
</head>
<Body>

</Body>
</html>"
            Case 17
                Panel2.Show()
                Panel3.Show()
                Title1.Text = ""
                Inform.Text = ""
                Tags.Text = ""
                Subtitle1.Text = ""
                RichTextBox1.Text = ""
                RichTextBox2.Text = ""
                RichTextBox3.Text = ""
                RichTextBox4.Text = "<!DOCTYPE html>
<html>
<head>
<link type=""text/css"" rel=""stylesheet"" href=""http://kai.pawnscript.com/github-markdown.css""/>
<link type=""text/css"" rel=""stylesheet"" href=""http://kai.pawnscript.com/hljs-github.min.css""/>
<link type=""text/css"" rel=""stylesheet"" href=""http://kai.pawnscript.com/pilcrow.css""/>
</head>
<Body>

</Body>
</html>"

            ' ------------- Inicio de categoria functions ------------- '
            Case 18 
                Panel2.Show()
                Panel3.Show()
                Title1.Text = ""
                Inform.Text = ""
                Tags.Text = ""
                Subtitle1.Text = ""
                RichTextBox1.Text = ""
                RichTextBox2.Text = ""
                RichTextBox3.Text = ""
                RichTextBox4.Text = "<!DOCTYPE html>
<html>
<head>
<link type=""text/css"" rel=""stylesheet"" href=""http://kai.pawnscript.com/github-markdown.css""/>
<link type=""text/css"" rel=""stylesheet"" href=""http://kai.pawnscript.com/hljs-github.min.css""/>
<link type=""text/css"" rel=""stylesheet"" href=""http://kai.pawnscript.com/pilcrow.css""/>
</head>
<Body>

</Body>
</html>"
            Case 19
                Panel2.Show()
                Panel3.Show()
                Title1.Text = ""
                Inform.Text = ""
                Tags.Text = ""
                Subtitle1.Text = ""
                RichTextBox1.Text = ""
                RichTextBox2.Text = ""
                RichTextBox3.Text = ""
                RichTextBox4.Text = "<!DOCTYPE html>
<html>
<head>
<link type=""text/css"" rel=""stylesheet"" href=""http://kai.pawnscript.com/github-markdown.css""/>
<link type=""text/css"" rel=""stylesheet"" href=""http://kai.pawnscript.com/hljs-github.min.css""/>
<link type=""text/css"" rel=""stylesheet"" href=""http://kai.pawnscript.com/pilcrow.css""/>
</head>
<Body>

</Body>
</html>"
            Case 20
                Panel2.Show()
                Panel3.Show()
                Title1.Text = ""
                Inform.Text = ""
                Tags.Text = ""
                Subtitle1.Text = ""
                RichTextBox1.Text = ""
                RichTextBox2.Text = ""
                RichTextBox3.Text = ""
                RichTextBox4.Text = "<!DOCTYPE html>
<html>
<head>
<link type=""text/css"" rel=""stylesheet"" href=""http://kai.pawnscript.com/github-markdown.css""/>
<link type=""text/css"" rel=""stylesheet"" href=""http://kai.pawnscript.com/hljs-github.min.css""/>
<link type=""text/css"" rel=""stylesheet"" href=""http://kai.pawnscript.com/pilcrow.css""/>
</head>
<Body>

</Body>
</html>"
            Case 21
                Panel2.Show()
                Panel3.Show()
                Title1.Text = ""
                Inform.Text = ""
                Tags.Text = ""
                Subtitle1.Text = ""
                RichTextBox1.Text = ""
                RichTextBox2.Text = ""
                RichTextBox3.Text = ""
                RichTextBox4.Text = "<!DOCTYPE html>
<html>
<head>
<link type=""text/css"" rel=""stylesheet"" href=""http://kai.pawnscript.com/github-markdown.css""/>
<link type=""text/css"" rel=""stylesheet"" href=""http://kai.pawnscript.com/hljs-github.min.css""/>
<link type=""text/css"" rel=""stylesheet"" href=""http://kai.pawnscript.com/pilcrow.css""/>
</head>
<Body>

</Body>
</html>"
            Case 22
                Panel2.Show()
                Panel3.Show()
                Title1.Text = ""
                Inform.Text = ""
                Tags.Text = ""
                Subtitle1.Text = ""
                RichTextBox1.Text = ""
                RichTextBox2.Text = ""
                RichTextBox3.Text = ""
                RichTextBox4.Text = "<!DOCTYPE html>
<html>
<head>
<link type=""text/css"" rel=""stylesheet"" href=""http://kai.pawnscript.com/github-markdown.css""/>
<link type=""text/css"" rel=""stylesheet"" href=""http://kai.pawnscript.com/hljs-github.min.css""/>
<link type=""text/css"" rel=""stylesheet"" href=""http://kai.pawnscript.com/pilcrow.css""/>
</head>
<Body>

</Body>
</html>"
            Case 23
                Panel2.Show()
                Panel3.Show()
                Title1.Text = ""
                Inform.Text = ""
                Tags.Text = ""
                Subtitle1.Text = ""
                RichTextBox1.Text = ""
                RichTextBox2.Text = ""
                RichTextBox3.Text = ""
                RichTextBox4.Text = "<!DOCTYPE html>
<html>
<head>
<link type=""text/css"" rel=""stylesheet"" href=""http://kai.pawnscript.com/github-markdown.css""/>
<link type=""text/css"" rel=""stylesheet"" href=""http://kai.pawnscript.com/hljs-github.min.css""/>
<link type=""text/css"" rel=""stylesheet"" href=""http://kai.pawnscript.com/pilcrow.css""/>
</head>
<Body>

</Body>
</html>"
            Case 24
                Panel2.Show()
                Panel3.Show()
                Title1.Text = ""
                Inform.Text = ""
                Tags.Text = ""
                Subtitle1.Text = ""
                RichTextBox1.Text = ""
                RichTextBox2.Text = ""
                RichTextBox3.Text = ""
                RichTextBox4.Text = "<!DOCTYPE html>
<html>
<head>
<link type=""text/css"" rel=""stylesheet"" href=""http://kai.pawnscript.com/github-markdown.css""/>
<link type=""text/css"" rel=""stylesheet"" href=""http://kai.pawnscript.com/hljs-github.min.css""/>
<link type=""text/css"" rel=""stylesheet"" href=""http://kai.pawnscript.com/pilcrow.css""/>
</head>
<Body>

</Body>
</html>"
            Case 25    
                Panel2.Show()
                Panel3.Show()
                Title1.Text = ""
                Inform.Text = ""
                Tags.Text = ""
                Subtitle1.Text = ""
                RichTextBox1.Text = ""
                RichTextBox2.Text = ""
                RichTextBox3.Text = ""
                RichTextBox4.Text = "<!DOCTYPE html>
<html>
<head>
<link type=""text/css"" rel=""stylesheet"" href=""http://kai.pawnscript.com/github-markdown.css""/>
<link type=""text/css"" rel=""stylesheet"" href=""http://kai.pawnscript.com/hljs-github.min.css""/>
<link type=""text/css"" rel=""stylesheet"" href=""http://kai.pawnscript.com/pilcrow.css""/>
</head>
<Body>

</Body>
</html>"
            Case 26
                Panel2.Show()
                Panel3.Show()
                Title1.Text = ""
                Inform.Text = ""
                Tags.Text = ""
                Subtitle1.Text = ""
                RichTextBox1.Text = ""
                RichTextBox2.Text = ""
                RichTextBox3.Text = ""
                RichTextBox4.Text = "<!DOCTYPE html>
<html>
<head>
<link type=""text/css"" rel=""stylesheet"" href=""http://kai.pawnscript.com/github-markdown.css""/>
<link type=""text/css"" rel=""stylesheet"" href=""http://kai.pawnscript.com/hljs-github.min.css""/>
<link type=""text/css"" rel=""stylesheet"" href=""http://kai.pawnscript.com/pilcrow.css""/>
</head>
<Body>

</Body>
</html>"
            Case 27
                Panel2.Show()
                Panel3.Show()
                Title1.Text = ""
                Inform.Text = ""
                Tags.Text = ""
                Subtitle1.Text = ""
                RichTextBox1.Text = ""
                RichTextBox2.Text = ""
                RichTextBox3.Text = ""
                RichTextBox4.Text = "<!DOCTYPE html>
<html>
<head>
<link type=""text/css"" rel=""stylesheet"" href=""http://kai.pawnscript.com/github-markdown.css""/>
<link type=""text/css"" rel=""stylesheet"" href=""http://kai.pawnscript.com/hljs-github.min.css""/>
<link type=""text/css"" rel=""stylesheet"" href=""http://kai.pawnscript.com/pilcrow.css""/>
</head>
<Body>

</Body>
</html>"
            Case 28
                Panel2.Show()
                Panel3.Show()
                Title1.Text = ""
                Inform.Text = ""
                Tags.Text = ""
                Subtitle1.Text = ""
                RichTextBox1.Text = ""
                RichTextBox2.Text = ""
                RichTextBox3.Text = ""
                RichTextBox4.Text = "<!DOCTYPE html>
<html>
<head>
<link type=""text/css"" rel=""stylesheet"" href=""http://kai.pawnscript.com/github-markdown.css""/>
<link type=""text/css"" rel=""stylesheet"" href=""http://kai.pawnscript.com/hljs-github.min.css""/>
<link type=""text/css"" rel=""stylesheet"" href=""http://kai.pawnscript.com/pilcrow.css""/>
</head>
<Body>

</Body>
</html>"
            Case 29
                Panel2.Show()
                Panel3.Show()
                Title1.Text = ""
                Inform.Text = ""
                Tags.Text = ""
                Subtitle1.Text = ""
                RichTextBox1.Text = ""
                RichTextBox2.Text = ""
                RichTextBox3.Text = ""
                RichTextBox4.Text = "<!DOCTYPE html>
<html>
<head>
<link type=""text/css"" rel=""stylesheet"" href=""http://kai.pawnscript.com/github-markdown.css""/>
<link type=""text/css"" rel=""stylesheet"" href=""http://kai.pawnscript.com/hljs-github.min.css""/>
<link type=""text/css"" rel=""stylesheet"" href=""http://kai.pawnscript.com/pilcrow.css""/>
</head>
<Body>

</Body>
</html>"

        End Select
    End Sub

    Private Sub RichTextBox4_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox4.TextChanged
        WebBrowser1.DocumentText = RichTextBox4.Text
    End Sub

End Class