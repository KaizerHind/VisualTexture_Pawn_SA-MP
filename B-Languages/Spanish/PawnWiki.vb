Public Class VSWiki

    Private CordX As Integer
    Private CordY As Integer
    Private MoveForm As Boolean

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
            "",
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
                HKTags.Text = "playerid, dialogid, response, listitem,
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
                HKTags.Text = "Sin parametros"
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
                HKTags.Text = "Sin parametros"
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
                HKTags.Text = "playerid, Float:fX, Float:fY, Float:fZ"
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
                Title1.Text = "OnPlayerClickPlayer"
                Inform.Text = "Se llama cuando el jugador
clickea a otro en la tablist"
                HKTags.Text = "playerid, clickedplayerid, source."
                Subtitle1.Text = "OnPlayerClickPlayer"
                RichTextBox1.Text = "Funcion llamada cuanto el jugador selecciona a otro usuario en la TabList."
                RichTextBox2.Text = "| playerid | El id del jugador. |
| clickedplayerid | El id del jugador clickeado.|
| source | El source del click del jugador. |"
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
<pre class=""hljs""><code><span class=""hljs-function""><span class=""hljs-keyword"">public</span> <span class=""hljs-title"">OnPlayerClickPlayer</span><span class=""hljs-params"">(playerid, clickedplayerid, source)</span>
</span>{
    <span class=""hljs-keyword"">new</span> msg[<span class=""hljs-number"">32</span>];
    format(msg, <span class=""hljs-keyword"">sizeof</span>(msg), <span class=""hljs-string"">""Clickeaste al id %d""</span>, clickedplayerid);
    SendClientMessage(playerid, <span class=""hljs-number"">0xFFFFFFFF</span>, msg);
    <span class=""hljs-keyword"">return</span> <span class=""hljs-number"">1</span>;
}</code></pre>
</Body>
</html>"
            Case 7
                Panel2.Show()
                Panel3.Show()
                Title1.Text = "OnPlayerConnect"
                Inform.Text = "Este CallBack es llamado
cuando el jugador entra al servidor"
                HKTags.Text = "playerid"
                Subtitle1.Text = "OnPlayerConnect"
                RichTextBox1.Text = "Funcion llamada en cuanto el jugador accede al Servidor."
                RichTextBox2.Text = "| playerid | El id del jugador cuando se conecta. |"
                RichTextBox3.Text = "0 - Evitará que otros FilterScripts reciban esta devolución de llamada.
1 - Indica que este callback pasó al otro Script.
Siempre se llama primero en filterscripts."
                RichTextBox4.Text = "<!DOCTYPE html>
<html>
<head>
<link type=""text/css"" rel=""stylesheet"" href=""http://kai.pawnscript.com/github-markdown.css""/>
<link type=""text/css"" rel=""stylesheet"" href=""http://kai.pawnscript.com/hljs-github.min.css""/>
<link type=""text/css"" rel=""stylesheet"" href=""http://kai.pawnscript.com/pilcrow.css""/>
</head>
<Body>
<pre class=""hljs""><code><span class=""hljs-function""><span class=""hljs-keyword"">public</span> <span class=""hljs-title"">OnPlayerConnect</span><span class=""hljs-params"">(playerid)</span>
</span>{
    <span class=""hljs-keyword"">new</span> <span class=""hljs-built_in"">string</span>[<span class=""hljs-number"">64</span>], NombreJ[MAX_PLAYER_NAME];
    GetPlayerName(playerid,NombreJ,MAX_PLAYER_NAME);
    format(<span class=""hljs-built_in"">string</span>,<span class=""hljs-keyword"">sizeof</span> <span class=""hljs-built_in"">string</span>,<span class=""hljs-string"">""%s se conectó al servidor, Bienvenido!""</span>,NombreJ);
    SendClientMessageToAll(<span class=""hljs-number"">0xFFFFFFAA</span>,<span class=""hljs-built_in"">string</span>);
    <span class=""hljs-keyword"">return</span> <span class=""hljs-number"">1</span>;
}</code></pre>
</Body>
</html>"
            Case 8
                Panel2.Show()
                Panel3.Show()
                Title1.Text = "OnPlayerDeath"
                Inform.Text = "Este evento es llamado
cuando un jugador muere."
                HKTags.Text = "playerid, killerid, reason"
                Subtitle1.Text = "OnPlayerDeath"
                RichTextBox1.Text = "Funcion llamada en cuanto un jugador es asesinado."
                RichTextBox2.Text = "| playerid | El id del jugador cuando se conecta. |
| killerid | El id del jugador que lo mató.|
| reason | El id de la razón de muerte del jugador (ids de armas por ejemplo) |"
                RichTextBox3.Text = "0 - Evitará que otros FilterScripts reciban esta devolución de llamada.
1 - Indica que este callback pasó al otro Script.
Siempre se llama primero en filterscripts."
                RichTextBox4.Text = "<!DOCTYPE html>
<html>
<head>
<link type=""text/css"" rel=""stylesheet"" href=""http://kai.pawnscript.com/github-markdown.css""/>
<link type=""text/css"" rel=""stylesheet"" href=""http://kai.pawnscript.com/hljs-github.min.css""/>
<link type=""text/css"" rel=""stylesheet"" href=""http://kai.pawnscript.com/pilcrow.css""/>
</head>
<Body>
<pre class=""hljs""><code><span class=""hljs-keyword"">new</span> muertes[MAX_PLAYERS];
<span class=""hljs-keyword"">new</span> kills[MAX_PLAYERS];

<span class=""hljs-function""><span class=""hljs-keyword"">public</span> <span class=""hljs-title"">OnPlayerDeath</span><span class=""hljs-params"">(playerid, killerid, reason)</span>
</span>{
    <span class=""hljs-keyword"">if</span>(killerid != INVALID_PLAYER_ID)
    {
        kills[killerid] ++; <span class=""hljs-comment"">// le sumamos una kill al que mató</span>
    }

    muertes[playerid] ++; <span class=""hljs-comment"">// le sumamos una muerte al que murió</span>
    <span class=""hljs-keyword"">return</span> <span class=""hljs-number"">1</span>;
}</code></pre>
</Body>
</html>"

            Case 9
                Panel2.Show()
                Panel3.Show()
                Title1.Text = "OnPlayerDisconnect"
                Inform.Text = "Este evento es llamado
cuando el jugador abandona o cierra la sesion del
servidor."
                HKTags.Text = "playerid, reason"
                Subtitle1.Text = "OnPlayerDisconnect"
                RichTextBox1.Text = "Este evento es llamado cuando el jugador abandona o cierra la sesion del servidor."
                RichTextBox2.Text = "| ID | Razón | Descripción | |--------------------------| | 0 | Timeout/Crash | Al jugador se le crasheó/Se le lageó extremadamente. | | 1 | Quitó | El jugador uso /q o /quit y/o se desconectó. | | 2 | Kick/Ban | El jugador fue expulsado o exiliado. |"
                RichTextBox3.Text = "0 - Evitará que otros FilterScripts reciban esta devolución de llamada.
1 - Indica que este callback pasó al otro Script.
Siempre se llama primero en filterscripts."
                RichTextBox4.Text = "<!DOCTYPE html>
<html>
<head>
<link type=""text/css"" rel=""stylesheet"" href=""http://kai.pawnscript.com/github-markdown.css""/>
<link type=""text/css"" rel=""stylesheet"" href=""http://kai.pawnscript.com/hljs-github.min.css""/>
<link type=""text/css"" rel=""stylesheet"" href=""http://kai.pawnscript.com/pilcrow.css""/>
</head>
<Body>
<pre class=""hljs""><code><span class=""hljs-function""><span class=""hljs-keyword"">public</span> <span class=""hljs-title"">OnPlayerDisconnect</span><span class=""hljs-params"">(playerid, reason)</span>
</span>{
    <span class=""hljs-keyword"">new</span> <span class=""hljs-built_in"">string</span>[<span class=""hljs-number"">64</span>], NombreJ[MAX_PLAYER_NAME];
    GetPlayerName(playerid,NombreJ,MAX_PLAYER_NAME);
    format(<span class=""hljs-built_in"">string</span>,<span class=""hljs-keyword"">sizeof</span> <span class=""hljs-built_in"">string</span>,<span class=""hljs-string"">""%s se desconectó del servidor!""</span>,NombreJ);
    SendClientMessageToAll(<span class=""hljs-number"">0xFFFFFFAA</span>,<span class=""hljs-built_in"">string</span>);
    <span class=""hljs-keyword"">return</span> <span class=""hljs-number"">1</span>;
}</code></pre>
</Body>
</html>"
            Case 10
                Panel2.Show()
                Panel3.Show()
                Title1.Text = "OnPlayerEnterVehicle"
                Inform.Text = "Se llama cuando el
jugador entra a un vehiculo."
                HKTags.Text = "playerid, vehicleid, ispassenger"
                Subtitle1.Text = "OnPlayerEnterVehicle"
                RichTextBox1.Text = "Evento llamado cuando jugador entra en un vehiculo."
                RichTextBox2.Text = "| playerid | El id del jugador. |
| vehicleid | El id del vehículo.|
| ispassenger | Es pasajero o no (boolean) |"
                RichTextBox3.Text = "Este callback no controla retornos.
Siempre se llama primero en filterscripts."
                RichTextBox4.Text = "<!DOCTYPE html>
<html>
<head>
<link type=""text/css"" rel=""stylesheet"" href=""http://kai.pawnscript.com/github-markdown.css""/>
<link type=""text/css"" rel=""stylesheet"" href=""http://kai.pawnscript.com/hljs-github.min.css""/>
<link type=""text/css"" rel=""stylesheet"" href=""http://kai.pawnscript.com/pilcrow.css""/>
</head>
<Body>
<pre class=""hljs""><code><span class=""hljs-function""><span class=""hljs-keyword"">public</span> <span class=""hljs-title"">OnPlayerEnterVehicle</span><span class=""hljs-params"">(playerid, vehicleid, ispassenger)</span>
</span>{
    <span class=""hljs-keyword"">new</span> <span class=""hljs-built_in"">string</span>[<span class=""hljs-number"">128</span>];
    format(<span class=""hljs-built_in"">string</span>, <span class=""hljs-keyword"">sizeof</span>(<span class=""hljs-built_in"">string</span>), <span class=""hljs-string"">""Entraste en el vehículo id %i""</span>, vehicleid);
    SendClientMessage(playerid, <span class=""hljs-number"">0xFFFFFFFF</span>, <span class=""hljs-built_in"">string</span>);
    <span class=""hljs-keyword"">return</span> <span class=""hljs-number"">1</span>;
}</code></pre>
</Body>
</html>"
            Case 11
                Panel2.Show()
                Panel3.Show()
                Title1.Text = "OnPlayerExitVehicle"
                Inform.Text = "Se llama cuando el
jugador sale de un vehiculo"
                HKTags.Text = "playerid, vehicleid"
                Subtitle1.Text = "OnPlayerExitVehicle"
                RichTextBox1.Text = "Evento llamado cuando el jugador sale del interior de un vehiculo."
                RichTextBox2.Text = "| playerid | El id del jugador. |
| vehicleid | El id del vehículo. |"
                RichTextBox3.Text = "Este callback no controla retornos.
Siempre se llama primero en filterscripts."
                RichTextBox4.Text = "<!DOCTYPE html>
<html>
<head>
<link type=""text/css"" rel=""stylesheet"" href=""http://kai.pawnscript.com/github-markdown.css""/>
<link type=""text/css"" rel=""stylesheet"" href=""http://kai.pawnscript.com/hljs-github.min.css""/>
<link type=""text/css"" rel=""stylesheet"" href=""http://kai.pawnscript.com/pilcrow.css""/>
</head>
<Body>
<pre class=""hljs""><code><span class=""hljs-function""><span class=""hljs-keyword"">public</span> <span class=""hljs-title"">OnPlayerExitVehicle</span><span class=""hljs-params"">(playerid, vehicleid)</span>
</span>{
    <span class=""hljs-keyword"">new</span> <span class=""hljs-built_in"">string</span>[<span class=""hljs-number"">128</span>];
    format(<span class=""hljs-built_in"">string</span>, <span class=""hljs-keyword"">sizeof</span>(<span class=""hljs-built_in"">string</span>), <span class=""hljs-string"">""Saliste del vehículo id %i""</span>, vehicleid);
    SendClientMessage(playerid, <span class=""hljs-number"">0xFFFFFFFF</span>, <span class=""hljs-built_in"">string</span>);
    <span class=""hljs-keyword"">return</span> <span class=""hljs-number"">1</span>;
}</code></pre>
</Body>
</html>"
            Case 12
                Panel2.Show()
                Panel3.Show()
                Title1.Text = "OnPlayerKeyStateChange"
                Inform.Text = "Informacion agregada
en Descripcion."
                HKTags.Text = "playerid, newkeys, oldkeys"
                Subtitle1.Text = "OnPlayerKeyStateChange"
                RichTextBox1.Text = "Se llama a este callback cuando se cambia (presiona / suelta) el estado de
cualquier tecla compatible. Las teclas direccionales no activan
OnPlayerKeyStateChange (arriba / abajo / izquierda / derecha)."
                RichTextBox2.Text = "| playerid | El id del jugador. |
| newkeys | Un mapa (máscara de bits) de las teclas que se mantienen actualmente. |
| oldkeys | Un mapa (máscara de bits) de las teclas que se mantenían anteriormente. |"
                RichTextBox3.Text = "Este callback no controla retornos.
Siempre se llama primero en filterscripts."
                RichTextBox4.Text = "<!DOCTYPE html>
<html>
<head>
<link type=""text/css"" rel=""stylesheet"" href=""http://kai.pawnscript.com/github-markdown.css""/>
<link type=""text/css"" rel=""stylesheet"" href=""http://kai.pawnscript.com/hljs-github.min.css""/>
<link type=""text/css"" rel=""stylesheet"" href=""http://kai.pawnscript.com/pilcrow.css""/>
</head>
<Body>
<pre class=""hljs""><code><span class=""hljs-keyword"">if</span> (newkeys &amp; KEY_FIRE) <span class=""hljs-comment"">// si preciona KEY_FIRE</span>

<span class=""hljs-meta"">#<span class=""hljs-meta-keyword"">define</span> HOLDING(%0) \
    ((newkeys &amp; (%0)) == (%0)) </span>

<span class=""hljs-keyword"">if</span> (HOLDING( KEY_FIRE )) <span class=""hljs-comment"">// si mantiene precionada la tecla KEY_FIRE</span>
<span class=""hljs-keyword"">if</span> (HOLDING( KEY_FIRE | KEY_CROUCH )) <span class=""hljs-comment"">// si mantiene precionadas las teclas KEY_FIRE y KEY_CROUCH</span>

<span class=""hljs-meta"">#<span class=""hljs-meta-keyword"">define</span> PRESSED(%0) \
    (((newkeys &amp; (%0)) == (%0)) &amp;&amp; ((oldkeys &amp; (%0)) != (%0)))</span>

<span class=""hljs-keyword"">if</span> (PRESSED( KEY_FIRE )) <span class=""hljs-comment"">// si presionó KEY_FIRE</span>
<span class=""hljs-keyword"">if</span> (PRESSED( KEY_FIRE | KEY_CROUCH )) <span class=""hljs-comment"">// si presionó las teclas KEY_FIRE  y KEY_CROUCH</span>

<span class=""hljs-meta"">#<span class=""hljs-meta-keyword"">define</span> RELEASED(%0) \
    (((newkeys &amp; (%0)) != (%0)) &amp;&amp; ((oldkeys &amp; (%0)) == (%0)))</span>

<span class=""hljs-keyword"">if</span> (RELEASED( KEY_FIRE )) <span class=""hljs-comment"">// si soltó KEY_FIRE</span>
<span class=""hljs-keyword"">if</span> (RELEASED( KEY_FIRE | KEY_CROUCH )) <span class=""hljs-comment"">// si soltó las teclas KEY_FIRE  y KEY_CROUCH</span></code></pre><h2 id=""ejemplo"">Ejemplo</h2>
<pre class=""hljs""><code><span class=""hljs-function""><span class=""hljs-keyword"">public</span> <span class=""hljs-title"">OnPlayerKeyStateChange</span><span class=""hljs-params"">(playerid, newkeys, oldkeys)</span>
</span>{
    <span class=""hljs-keyword"">if</span> (PRESSED(KEY_JUMP)) <span class=""hljs-comment"">// si preciona KEY_JUMP</span>
    {
        <span class=""hljs-keyword"">new</span>
            Float:x,
            Float:y,
            Float:z;
        GetPlayerPos(playerid, x, y, z);
        SetPlayerPos(playerid, x, y, z + <span class=""hljs-number"">10.0</span>);
    }
    <span class=""hljs-keyword"">return</span> <span class=""hljs-number"">1</span>;
}</code></pre>
</Body>
</html>"
            Case 13
                Panel2.Show()
                Panel3.Show()
                Title1.Text = "OnPlayerRequestSpawn"
                Inform.Text = "Evento llamado cuando
un jugador usa las
opciones de spawn."
                HKTags.Text = "playerid"
                Subtitle1.Text = "OnPlayerRequestSpawn"
                RichTextBox1.Text = "Se llama cuando un jugador intenta Spawnear mediante la selección de clase presionando
SHIFT o haciendo clic en el botón 'Spawn'"
                RichTextBox2.Text = "playerid"
                RichTextBox3.Text = "0 - Evitará que el jugador se spawnee.
Siempre se llama primero en los filterscripts, por lo que devolver 0 también bloquea otras secuencias de comandos para que no lo vean."
                RichTextBox4.Text = "<!DOCTYPE html>
<html>
<head>
<link type=""text/css"" rel=""stylesheet"" href=""http://kai.pawnscript.com/github-markdown.css""/>
<link type=""text/css"" rel=""stylesheet"" href=""http://kai.pawnscript.com/hljs-github.min.css""/>
<link type=""text/css"" rel=""stylesheet"" href=""http://kai.pawnscript.com/pilcrow.css""/>
</head>
<Body>
<pre class=""hljs""><code><span class=""hljs-function""><span class=""hljs-keyword"">public</span> <span class=""hljs-title"">OnPlayerRequestSpawn</span><span class=""hljs-params"">(playerid)</span>
</span>{
    <span class=""hljs-keyword"">if</span>(!IsPlayerAdmin(playerid))
    {
        SendClientMessage(playerid, <span class=""hljs-number"">-1</span>, <span class=""hljs-string"">""No puedes spawnear""</span>);
        <span class=""hljs-keyword"">return</span> <span class=""hljs-number"">0</span>;
    }
    <span class=""hljs-keyword"">return</span> <span class=""hljs-number"">1</span>;
}</code></pre>
</Body>
</html>"
            Case 14
                Panel2.Show()
                Panel3.Show()
                Title1.Text = "OnPlayerSpawn"
                Inform.Text = "Evento llamado cuando
un jugador Loguea/Spawnea
en el Mapa."
                HKTags.Text = "playerid"
                Subtitle1.Text = "OnPlayerSpawn"
                RichTextBox1.Text = "Este evento es llamado cuando un jugador spawnea en en el mapa de SanAndreas."
                RichTextBox2.Text = "| playerid | El id del jugador. |"
                RichTextBox3.Text = "0 - Evitará que otros FilterScripts reciban esta devolución de llamada.
1 - Indica que este callback pasó al otro Script."
                RichTextBox4.Text = "<!DOCTYPE html>
<html>
<head>
<link type=""text/css"" rel=""stylesheet"" href=""http://kai.pawnscript.com/github-markdown.css""/>
<link type=""text/css"" rel=""stylesheet"" href=""http://kai.pawnscript.com/hljs-github.min.css""/>
<link type=""text/css"" rel=""stylesheet"" href=""http://kai.pawnscript.com/pilcrow.css""/>
</head>
<Body>
<pre class=""hljs""><code><span class=""hljs-function""><span class=""hljs-keyword"">public</span> <span class=""hljs-title"">OnPlayerSpawn</span><span class=""hljs-params"">(playerid)</span>
</span>{
    <span class=""hljs-keyword"">new</span> NombreJ[MAX_PLAYER_NAME],
    <span class=""hljs-built_in"">string</span>[<span class=""hljs-number"">40</span>]; 
    GetPlayerName(playerid, NombreJ, <span class=""hljs-keyword"">sizeof</span>(NombreJ));
    format(<span class=""hljs-built_in"">string</span>, <span class=""hljs-keyword"">sizeof</span>(<span class=""hljs-built_in"">string</span>), <span class=""hljs-string"">""%s spawneó correctamente1""</span>, NombreJ);
    SendClientMessageToAll(<span class=""hljs-number"">0xFFFFFFFF</span>, <span class=""hljs-built_in"">string</span>);
    <span class=""hljs-keyword"">return</span> <span class=""hljs-number"">1</span>;
}</code></pre>
</Body>
</html>"
            Case 15
                Panel2.Show()
                Panel3.Show()
                Title1.Text = "OnPlayerText"
                Inform.Text = "Se llama cuando un
jugador envia un
texto al chat."
                HKTags.Text = "playerid, text[]"
                Subtitle1.Text = "OnPlayerText"
                RichTextBox1.Text = "Evento llamado cuando un jugador envia un texto al chat."
                RichTextBox2.Text = "| playerid | El id del jugador. |
| text[] | String enviado.|"
                RichTextBox3.Text = "0 - En este callback evitará que el texto se envíe a todos los jugadores.</p>
Siempre se llama primero en filterscripts de modo que devolver 0 no permite que otras secuencias de comandos lo vean."
                RichTextBox4.Text = "<!DOCTYPE html>
<html>
<head>
<link type=""text/css"" rel=""stylesheet"" href=""http://kai.pawnscript.com/github-markdown.css""/>
<link type=""text/css"" rel=""stylesheet"" href=""http://kai.pawnscript.com/hljs-github.min.css""/>
<link type=""text/css"" rel=""stylesheet"" href=""http://kai.pawnscript.com/pilcrow.css""/>
</head>
<Body>
<pre class=""hljs""><code><span class=""hljs-function""><span class=""hljs-keyword"">public</span> <span class=""hljs-title"">OnPlayerText</span><span class=""hljs-params"">(playerid, text[])</span>
</span>{
    <span class=""hljs-keyword"">new</span> pText[<span class=""hljs-number"">144</span>];
    format(pText, <span class=""hljs-keyword"">sizeof</span> (pText), <span class=""hljs-string"">""(%d) %s""</span>, playerid, text);
    SendPlayerMessageToAll(playerid, pText);
    <span class=""hljs-keyword"">return</span> <span class=""hljs-number"">0</span>;
}</code></pre>
</Body>
</html>"
            Case 16
                Panel2.Show()
                Panel3.Show()
                Title1.Text = "OnRconLoginAttempt"
                Inform.Text = "Se llama cuando un
jugador intenta
iniciar en RCON."
                HKTags.Text = "ip[], password[], sucess"
                Subtitle1.Text = "OnRconLoginAttempt"
                RichTextBox1.Text = "Evento llamado cuando un jugador intenta iniciar en modo RCON."
                RichTextBox2.Text = "| ip[] | El ip del jugador. |
| password[] | Contraseña enviada.|
| sucess | Contraseña correcta o no (boolean) |"
                RichTextBox3.Text = "Este callback no controla retornos.
Siempre se llama primero en filterscripts."
                RichTextBox4.Text = "<!DOCTYPE html>
<html>
<head>
<link type=""text/css"" rel=""stylesheet"" href=""http://kai.pawnscript.com/github-markdown.css""/>
<link type=""text/css"" rel=""stylesheet"" href=""http://kai.pawnscript.com/hljs-github.min.css""/>
<link type=""text/css"" rel=""stylesheet"" href=""http://kai.pawnscript.com/pilcrow.css""/>
</head>
<Body>
<pre class=""hljs""><code><span class=""hljs-function""><span class=""hljs-keyword"">public</span> <span class=""hljs-title"">OnRconLoginAttempt</span><span class=""hljs-params"">(ip[], password[], success)</span>
</span>{
    <span class=""hljs-keyword"">if</span>(!success) <span class=""hljs-comment"">// Si la contraseña es incorrecta</span>
    {
        <span class=""hljs-built_in"">printf</span>(<span class=""hljs-string"">""Intentaron logear como RCON : Ip: %s Contraseña ingresada: %s""</span>, ip, password);
        <span class=""hljs-keyword"">new</span> pip[<span class=""hljs-number"">16</span>];
        <span class=""hljs-keyword"">for</span>(<span class=""hljs-keyword"">new</span> i = GetPlayerPoolSize(); i != <span class=""hljs-number"">-1</span>; --i) <span class=""hljs-comment"">//Loop a todos los jugadores</span>
        {
            GetPlayerIp(i, pip, <span class=""hljs-keyword"">sizeof</span>(pip));
            <span class=""hljs-keyword"">if</span>(!<span class=""hljs-built_in"">strcmp</span>(ip, pip, <span class=""hljs-literal"">true</span>)) <span class=""hljs-comment"">//si el ip es el mismo que el que falló al ingresar la contraseña</span>
            {
                SendClientMessage(i, <span class=""hljs-number"">0xFFFFFFFF</span>, <span class=""hljs-string"">""Wrong Password. Bye!""</span>); <span class=""hljs-comment"">//Enviar un mensaje</span>
                Kick(i); <span class=""hljs-comment"">//Ahora esta expulsado.</span>
            }
        }
    }
    <span class=""hljs-keyword"">return</span> <span class=""hljs-number"">1</span>;
}</code></pre>
</Body>
</html>"
            Case 17
                Panel2.Show()
                Panel3.Show()
                Title1.Text = "OnVehicleDeath"
                Inform.Text = "Se llama cuando el
vehículo es destruido."
                HKTags.Text = "vehicleid, killerid"
                Subtitle1.Text = "OnVehicleDeath"
                RichTextBox1.Text = "Evento llamado cuanto un vehiculo es destruido."
                RichTextBox2.Text = "| vehicleid | El id del vehículo. |
| killerid | El id del que lo rompió. (o el mas cercano al coche) |"
                RichTextBox3.Text = "Este callback no controla retornos.
Siempre se llama primero en filterscripts."
                RichTextBox4.Text = "<!DOCTYPE html>
<html>
<head>
<link type=""text/css"" rel=""stylesheet"" href=""http://kai.pawnscript.com/github-markdown.css""/>
<link type=""text/css"" rel=""stylesheet"" href=""http://kai.pawnscript.com/hljs-github.min.css""/>
<link type=""text/css"" rel=""stylesheet"" href=""http://kai.pawnscript.com/pilcrow.css""/>
</head>
<Body>
<pre class=""hljs""><code><span class=""hljs-function""><span class=""hljs-keyword"">public</span> <span class=""hljs-title"">OnVehicleDeath</span><span class=""hljs-params"">(vehicleid, killerid)</span>
</span>{
    <span class=""hljs-keyword"">new</span> <span class=""hljs-built_in"">string</span>[<span class=""hljs-number"">64</span>];
    format(<span class=""hljs-built_in"">string</span>, <span class=""hljs-keyword"">sizeof</span>(<span class=""hljs-built_in"">string</span>), <span class=""hljs-string"">""El vehículo id %i fue destruido por el jugador id %i.""</span>, vehicleid, killerid);
    SendClientMessageToAll(<span class=""hljs-number"">0xFFFFFFFF</span>, <span class=""hljs-built_in"">string</span>);
    <span class=""hljs-keyword"">return</span> <span class=""hljs-number"">1</span>;
}</code></pre>
</Body>
</html>"

            
            Case 18 
                Panel2.Show()
                Panel3.Show()
                Title1.Text = "OnVehicleSpawn"
                Inform.Text = "Se llama cuando el
vehículo spawnea."
                HKTags.Text = "vehicleid"
                Subtitle1.Text = "OnVehicleSpawn"
                RichTextBox1.Text = "Evento llamado cuando un vehiculo es spawneado."
                RichTextBox2.Text = "| vehicleid | El id del vehículo. |"
                RichTextBox3.Text = "0 - Evitará que otros FilterScripts reciban esta devolución de llamada.</p>
1 - Indica que este callback pasó al otro Script."
                RichTextBox4.Text = "<!DOCTYPE html>
<html>
<head>
<link type=""text/css"" rel=""stylesheet"" href=""http://kai.pawnscript.com/github-markdown.css""/>
<link type=""text/css"" rel=""stylesheet"" href=""http://kai.pawnscript.com/hljs-github.min.css""/>
<link type=""text/css"" rel=""stylesheet"" href=""http://kai.pawnscript.com/pilcrow.css""/>
</head>
<Body>
<pre class=""hljs""><code><span class=""hljs-function""><span class=""hljs-keyword"">public</span> <span class=""hljs-title"">OnVehicleSpawn</span><span class=""hljs-params"">(vehicleid)</span>
</span>{
    <span class=""hljs-built_in"">printf</span>(<span class=""hljs-string"">""El vehículo id %i spawneó!""</span>,vehicleid);
    <span class=""hljs-keyword"">return</span> <span class=""hljs-number"">1</span>;
}</code></pre>
</Body>
</html>"

            ' ------------- Inicio de categoria functions ------------- '
            Case 19
                Panel2.Hide()
                ListBox1.SelectedIndex = 0
                Panel2.Hide()


            Case 20
                Panel2.Show()
                Panel3.Show()
                Title1.Text = ""
                Inform.Text = ""
                HKTags.Text = ""
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
                HKTags.Text = ""
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
                HKTags.Text = ""
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
                HKTags.Text = ""
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
                HKTags.Text = ""
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
                HKTags.Text = ""
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
                HKTags.Text = ""
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
                HKTags.Text = ""
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
                HKTags.Text = ""
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
                HKTags.Text = ""
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

    Private Sub AnimationsViewerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AnimationsViewerToolStripMenuItem.Click
        VAnims.Show()
        Me.Hide()
    End Sub

    Private Sub TextureViewerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TextureViewerToolStripMenuItem.Click
        VTextures.Show()
        Me.Hide()
    End Sub

    Private Sub VisualizadorDeSpritesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VisualizadorDeSpritesToolStripMenuItem.Click
        VSprites.Show()
        Me.Hide()
    End Sub

    Private Sub SAMPScriptToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SAMPScriptToolStripMenuItem.Click
        frmMain.Show()
        Me.Hide()
    End Sub

    Private Sub PawnColorPickerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PawnColorPickerToolStripMenuItem.Click
        Pawncp.Show()
        Me.Hide()
    End Sub

    Private Sub ContactUsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContactUsToolStripMenuItem.Click
        Contact.Show()
    End Sub

    Private Sub LOGToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LOGToolStripMenuItem.Click
        LOG.Show()
    End Sub

    Private Sub CreditosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreditosToolStripMenuItem.Click
        Credits.Show()
    End Sub

    Private Sub PawnWiki_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            MoveForm = 1
            CordX = e.X
            CordY = e.Y
            Me.Cursor = Cursors.NoMove2D
        End If
    End Sub

    Private Sub PawnWiki_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If MoveForm Then
            Me.Location = New Point((Me.Left + e.X - CordX), (Me.Top + e.Y - CordY))
        End If
    End Sub

    Private Sub PawnWiki_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        MoveForm = 0
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub MenuStrip1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MenuStrip1.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            MoveForm = 1
            CordX = e.X
            CordY = e.Y
            Me.Cursor = Cursors.NoMove2D
        End If
    End Sub

    Private Sub MenuStrip1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MenuStrip1.MouseMove
        If MoveForm Then
            Me.Location = New Point((Me.Left + e.X - CordX), (Me.Top + e.Y - CordY))
        End If
    End Sub

    Private Sub MenuStrip1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MenuStrip1.MouseUp
        MoveForm = 0
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        System.Diagnostics.Process.Start("https://github.com/KaizerHind/VisualTexture_Pawn_SA-MP/releases/")
    End Sub

    Private Sub CloseBtn_Click(sender As Object, e As EventArgs) Handles CloseBtn.Click
        Environment.Exit(1)
    End Sub
End Class