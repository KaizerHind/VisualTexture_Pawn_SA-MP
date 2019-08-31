Public Class LOG
    Dim Claves = {"#", "Cambios realizados:", "Diciembre", "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Julio", "2018", "2019", "02", "08", "13", "18", "19", "22", "26", "27"}
    Dim Example = {"temporalmente"}

    Private Declare Function LockWindowUpdate Lib "user32" (ByVal HWnd As Integer) As Integer

    Private Sub LOG_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MessageBox.Show("This version of updates, this written in spanish, if you don't understand this language, don't read it.")

        RichTextBox1.Text = "# Cambios realizados: 18 - Diciembre - 2018
.- Actualmente se encuentra en constante desarrollo, la sección de
   WikiSAMP.

    Descripción: Las guías que aquí se almacenan, únicamente son
    tutoriales básicos y avanzados, esto con el fin de no rellenar
    la sección con información irrelevante y demasiado básica, la
    sección contiene las guías Básicas, Medias, Avanzadas.

.- Se añadió la opción de Visualizar Guías por Imágenes.

   Descripción: debido a que el contenido de algunas era demasiado
    larga, y esto podría provocar que el Software se sobrecargue
    con información.

.- Se añadieron botones de visualización.

    Descripción: Se añadieron botones como '+Zoom y -Zoom' Botones
    de descarga de contenido en ciertas guías.
    (Wind. - Linux - Plugins - Pawn.CMD - Screenshots)

.- La sección de Texturas se encuentra en un 10% de desarrollo.

    Descripción: Actualmente las secciones de Texturas, Sonidos
    y Animaciones, se encuentran detenidas, debido a que se esta
    trabajando en lo mas prioritario, en cuanto se finalice la parte
    de WikiSAMP, se retomara esto, ya que estas secciones requieren
    de mas tiempo.

.- Se cambio la interfaz del apartado de 'Credits'.

    Descripción: Se cambio esta interfaz, la cual antes estaba hecha
    por un dialogo con texto, ahora esta hecha con una estética mas
    'bonita' en imágenes, con los logos de las personas.
    (Uso de Créditos de Guías)

.- Las opciones de lenguaje se encuentran en Desarrollo.

    Descripción: Las opciones de lenguaje, en especial Ingles, se
    encuentra en un 30% de desarrollo, debido a que se trabaja
    primero la hispana, y luego se hará un traspaso de Info. a Ingles.
    El Lenguaje de Portugués, aun se encuentra en proceso, esto
    con el fin de esperar a terminar una secciones enteramente.


# Cambios realizados: 19 - Enero - 2019

.- Se esta trabajando en la Versión ingles del Software, ya que
   esta algo incompleta.

    Descripción: Debido a que la Versión Inglesa esta un poco
    descuidada, uno de los desarrolladores esta trabajando en esta
    sección, para mantener esta al mismo paso que la versión hispana.

.- Se actualizo la sección de Visualizar Animaciones, ahora puedes
   mirar las animaciones de Ped.ifp.
    
    Descripción: Actualmente se añadirán las animaciones almacenadas
    en Anim.img y en cuts.img, no se sabe realmente si las animaciones
    de cuts.img puedan ser usadas, por lo que se va a probar, en  dado
    caso, solo se añadirán las animaciones almacenadas en anim.img.
    Se hicieron correcciones también en los fotogramas de las
    animaciones, ya que estaban con tamaños Azar, ahora todas poseen
    un tamaño correcto para visualizarse de mejor forma.

.- Correcciones de ortografía y mas.

    Descripción: Se hicieron correcciones ortográficos tanto en
    Guías, como en lenguajes pawn que contenía el Software en su
    información.


# Cambios realizados: 22 - Febrero - 2019

• Actualizaciones:

.- Se cancelaron temporalmente las Actualizaciones de la Version
   Latina.


# Cambios realizados: 26 - Marzo - 2019

.- Se agrego la informacion de los recientes cambios.

    Descripción: Se añadio la informacion de los LOGS con respecto a
    las actualizaciones realizadas.

.- Se descartaron algunas opciones con lenguaje español.

    Descripción: Algunas herramientas de la version española fueron
    descartadas, debido que eran lo mismo que la version Inglesa, por
    que algunas opciones de lenguaje español van a redirigir a las
    inglesas, y  viceversa.

# Cambios realizados: 27 - Marzo - 2019

.- Actualizacion de informacion y otros formularios.

    Descripción: Se agrego el Formulario de Contacto para soporte, en
    caso de querer contactar con un Developer.

.- Opciones de Idioma/Lenguajes.

    Descripción: Se agrego un formulario antes de la Index, la cual
    te permitira elegir si deseas iniciar con la Index en
    Ingles o Español, esto con el fin de leer la Informacion
    principal del programa.

# Cambios realizados: 02 - Julio - 2019

.- Fixeo de errores.
    
    Descripción: Se arreglaron 2 errores notorios en la app:
 
.- La sección Sprites no funcionaba ya que lanzaba un error a todos.

.- En la pantalla de carga estaba mal centrado el texto y la imagen.

# Cambios realizados: 08 - Julio - 2019

.- Se hicieron correcciones y cambios en algunas ventanas
tambien asi mismo se añadio nueva informacion y datos.

    Descripción: Se corrigieron las opciones de cerrar las ventanas, ya
    que estas no finalizaban los procesos totalmente, ahora lo hacen.

.- Se añadieron nuevos datos en la seccion de Texturas.

    Descripción: Se añadieron mas imagenes en la seccion de
    Texturas, ya que actualmente solo se disponia de
    puertas, ahora se podran visualizar mas secciones.

.- Diseño de bordes y ventanas.

    Descripción: Algunas ventanas tienen un nuevo diseño, esto con el
   fin de quitar ciertas opciones que no se desean mostrar, ya que
   estan programadas en el codigo.

# Cambios realizados: 13 - Julio - 2019

.- Nuevas opciones en menu e informacion adicional agregada en
   PawnWiki.

    Descripción: Se añadio toda la informacion de CallBacks en
   PawnWiki, ademas se hicieron otras correcciones con respecto
   al menu de cierre y se agregaron las opciones de redireccion
   a PawnWiki en cada ventana.

.- Interfaz de Codigo en PawnWiki mejorada.

    Descripción: Antes al visualizar el codigo de la PawnWiki se
   veia con otro diseño, por lo que ahora puedes verlo a traves
   de Codigo Html, de una forma mas dinamica de acorde a la
   apariencia en Github.

# Cambios realizados: 14 - Julio - 2019

.- Descartada la seccion ingles de Pawn Wiki.

    Descripción: Se descarto la opcion de usar la Wiki en Ingles
   debido a que esta puede ser consultada desde la Web, ademas
   de que era irrelevante e innecesario agregarla.

# Cambios realizados: 24 - Julio - 2019

.- Variables y contenido removido.

    Descripción: Se removieron algunas variables y contenido como
   imagenes y entre otras cosas de secciones que se implementaron
   en la version 1.1 para la PawnWiki anterior, esto con el fin de
   optimizar el peso del software y quitar lo que no se esta
   usando.

# Cambios realizados: 31 - Agosto - 2019

.- Arreglados BUGS al cerrar pestañas y botón de la X 
   Agregado Y reducción de peso del app.

    Descripción: Se arreglaron algunos bugs que permitian al 
   cerrar una pestaña que el proceso siga estando en 
   segundo plano y por lo tanto que no puedas volver
   a abrir la aplicación una vez cerrada.
   También se agregó el botón tipico de la X,
   para cerrar la app.
   Y por último se arregló el peso del app, de 230mb
   a 120mb aproximados. (.exe y carpeta sprites)"
    End Sub
    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged
        Try
            LockWindowUpdate(RichTextBox1.Handle.ToInt32)

            RichTextBox1.SelectionStart = 0
            RichTextBox1.SelectionLength = RichTextBox1.TextLength
            RichTextBox1.SelectionColor = RichTextBox1.ForeColor

            For Each CLAVE In Claves

                Dim Indexx As Integer = 0
                Dim Example As Integer = 0

                While Indexx <= RichTextBox1.Text.LastIndexOf(CLAVE)

                    RichTextBox1.Find(CLAVE, Indexx, RichTextBox1.TextLength, RichTextBoxFinds.WholeWord)
                    RichTextBox1.SelectionColor = Color.Green
                    Indexx = RichTextBox1.Text.IndexOf(CLAVE, Indexx) + 1
                End While
            Next
            RichTextBox1.SelectionStart = RichTextBox1.TextLength
            RichTextBox1.SelectionColor = RichTextBox1.ForeColor

            LockWindowUpdate(0)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub CloseBtn_Click(sender As Object, e As EventArgs) Handles CloseBtn.Click
        Close()
    End Sub
End Class