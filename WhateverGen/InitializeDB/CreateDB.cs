
/*PROTECTED REGION ID(CreateDB_imports) ENABLED START*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using WhateverGenNHibernate.EN.Whatever;
using WhateverGenNHibernate.CEN.Whatever;
using WhateverGenNHibernate.CAD.Whatever;
using WhateverGenNHibernate.CP.Whatever;


/*PROTECTED REGION END*/
namespace InitializeDB
{
public class CreateDB
{
public static void Create (string databaseArg, string userArg, string passArg)
{
        String database = databaseArg;
        String user = userArg;
        String pass = passArg;

        // Conex DB
        SqlConnection cnn = new SqlConnection (@"Server=(local)\sqlexpress; database=master; integrated security=yes");

        // Order T-SQL create user
        String createUser = @"IF NOT EXISTS(SELECT name FROM master.dbo.syslogins WHERE name = '" + user + @"')
            BEGIN
                CREATE LOGIN ["                                                                                                                                     + user + @"] WITH PASSWORD=N'" + pass + @"', DEFAULT_DATABASE=[master], CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF
            END"                                                                                                                                                                                                                                                                                    ;

        //Order delete user if exist
        String deleteDataBase = @"if exists(select * from sys.databases where name = '" + database + "') DROP DATABASE [" + database + "]";
        //Order create databas
        string createBD = "CREATE DATABASE " + database;
        //Order associate user with database
        String associatedUser = @"USE [" + database + "];CREATE USER [" + user + "] FOR LOGIN [" + user + "];USE [" + database + "];EXEC sp_addrolemember N'db_owner', N'" + user + "'";
        SqlCommand cmd = null;

        try
        {
                // Open conex
                cnn.Open ();

                //Create user in SQLSERVER
                cmd = new SqlCommand (createUser, cnn);
                cmd.ExecuteNonQuery ();

                //DELETE database if exist
                cmd = new SqlCommand (deleteDataBase, cnn);
                cmd.ExecuteNonQuery ();

                //CREATE DB
                cmd = new SqlCommand (createBD, cnn);
                cmd.ExecuteNonQuery ();

                //Associate user with db
                cmd = new SqlCommand (associatedUser, cnn);
                cmd.ExecuteNonQuery ();

                System.Console.WriteLine ("DataBase create sucessfully..");
        }
        catch (Exception ex)
        {
                throw ex;
        }
        finally
        {
                if (cnn.State == ConnectionState.Open) {
                        cnn.Close ();
                }
        }
}

public static void InitializeData ()
{
        /*PROTECTED REGION ID(initializeDataMethod) ENABLED START*/
        try
        {
                // Insert the initilizations of entities using the CEN classes
                UsuarioCAD usu = new UsuarioCAD ();
                UsuarioCEN usucen = new UsuarioCEN (usu);
                UsuarioEN usuen = new UsuarioEN ();
                UsuarioCP usucp = new UsuarioCP ();

                UsuarioCAD usu2 = new UsuarioCAD ();
                UsuarioCEN usucen2 = new UsuarioCEN (usu2);
                UsuarioEN usuen2 = new UsuarioEN ();
                UsuarioCP usucp2 = new UsuarioCP ();

                AdminCAD adm = new AdminCAD ();
                AdminCEN admcen = new AdminCEN (adm);
                AdminEN admen = new AdminEN ();
                AdminCP admcp = new AdminCP ();

                EventoCAD eve = new EventoCAD ();
                EventoCEN evecen = new EventoCEN (eve);
                EventoEN even = new EventoEN ();
                EventoCP evecp = new EventoCP ();

                RetoCAD ret = new RetoCAD ();
                RetoCEN retcen = new RetoCEN (ret);
                RetoEN reten = new RetoEN ();
                RetoCP retcp = new RetoCP ();

                ReporteCAD rep = new ReporteCAD ();
                ReporteCEN repcen = new ReporteCEN (rep);
                ReporteEN repen = new ReporteEN ();
                ReporteCP repcp = new ReporteCP ();

                MapaCAD map = new MapaCAD ();
                MapaCEN mapcen = new MapaCEN (map);
                MapaEN mapen = new MapaEN ();
                MapaCP mapcp = new MapaCP ();

                MapaCAD map2 = new MapaCAD ();
                MapaCEN mapcen2 = new MapaCEN (map);
                MapaEN mapen2 = new MapaEN ();
                MapaCP mapcp2 = new MapaCP ();

                MapaCAD map3 = new MapaCAD ();
                MapaCEN mapcen3 = new MapaCEN (map);
                MapaEN mapen3 = new MapaEN ();
                MapaCP mapcp3 = new MapaCP ();

                PuntuacionCAD punt = new PuntuacionCAD ();
                PuntuacionCEN puntcen = new PuntuacionCEN (punt);
                PuntuacionEN punten = new PuntuacionEN ();
                PuntuacionCP puntcp = new PuntuacionCP ();

                PuntuacionCAD punt2 = new PuntuacionCAD ();
                PuntuacionCEN puntcen2 = new PuntuacionCEN (punt);
                PuntuacionEN punten2 = new PuntuacionEN ();
                PuntuacionCP puntcp2 = new PuntuacionCP ();

                PasoCAD pas = new PasoCAD ();
                PasoCEN pascen = new PasoCEN (pas);
                PasoEN pasen = new PasoEN ();
                PasoCP pascp = new PasoCP ();

                ComentarioCAD com = new ComentarioCAD ();
                ComentarioCEN comcen = new ComentarioCEN (com);
                ComentarioEN comen = new ComentarioEN ();
                ComentarioCP comcp = new ComentarioCP ();

                ComentarioCAD com2 = new ComentarioCAD ();
                ComentarioCEN comcen2 = new ComentarioCEN (com);
                ComentarioEN comen2 = new ComentarioEN ();
                ComentarioCP comcp2 = new ComentarioCP ();

                ComentarioCAD com3 = new ComentarioCAD ();
                ComentarioCEN comcen3 = new ComentarioCEN (com);
                ComentarioEN comen3 = new ComentarioEN ();
                ComentarioCP comcp3 = new ComentarioCP ();


                GymkanaCAD gym = new GymkanaCAD ();
                GymkanaCEN gymcen = new GymkanaCEN (gym);
                GymkanaEN gymen = new GymkanaEN ();
                GymkanaCP gymcp = new GymkanaCP ();




                //insertamos valores en el usuarioEN
                usuen.Nombre = "Admin";
                usuen.Edad = 20;
                usuen.Sexo = "Hombre";
                usuen.Facebook = "face";
                usuen.Instagram = "insta";
                usuen.Twitter = "twitter";
                usuen.Contrasena = "123456";
                usuen.Email = "pa@gmail.com";
                usuen.Foto = "si";

                usucen.Registro(usuen);

            
                   //creamos admin
                var aux = usucp.HacerAdmin(usuen.ID, usuen.Nombre);
                
                /*
                 
                   
                 
                 *
                 *
                 *  //insertamos valores en el usuarioEN
                 *  usuen2.Nombre = "Javier";
                 *  usuen2.Edad = 10;
                 *  usuen2.Sexo = "Hombre";
                 *  usuen2.Facebook = "face";
                 *  usuen2.Instagram = "insta";
                 *  usuen2.Twitter = "twitter";
                 *  usuen2.Contrasena = "123";
                 *  usuen2.Email = "ja5@gmail.com";
                 *  usuen2.Foto = "si";
                 *
                 *  usucen2.Registro (usuen2);
                 *
                 *
                 *
                 *
                 *  //creamos el evento
                 *  even.Titulo = "quedada para ruta de la tapa";
                 *  even.Descripcion = "la idea es ir un grupo grande de gente de bar en bar";
                 *  even.Usuario = usuen;
                 *  even.Precio = 0;
                 *  even.Fecha = new DateTime (2008, 5, 1, 8, 30, 52);
                 *
                 *  evecp.CrearEvento (even, 27, 28, 8);
                 *
                 *
                 *  //creamos un reto
                 *  reten.Titulo = "no hay huevos a venir a clase desnudo";
                 *  reten.Descripcion = "pues eso, venir a clase y demostrarme tu valentia";
                 *  reten.Precio = 0;
                 *  reten.Imagen = "";
                 *  reten.Tipo = "";
                 *  reten.Usuario = usuen;
                 *
                 *  retcen.CrearReto (reten);
                 *
                 *
                 *  //creamos gymkana
                 *  gymen.Titulo = "quedada para ruta de la tapa";
                 *  gymen.Descripcion = "la idea es ir un grupo grande de gente de bar en bar";
                 *  gymen.Usuario = usuen;
                 *  gymen.Precio = 0;
                 *  gymen.Fecha = new DateTime (2008, 5, 1, 8, 30, 52);
                 *  gymen.NumPasos = 5;
                 *
                 *  gymcp.CrearGymkana (gymen, 27, 29, 8);
                 *
                 *
                 *  //creamos los comentarios
                 *
                 *  var id_comen = comcp.CrearComentarioParaReto (reten.ID, "pos ta wapo el reto", usuen.ID);
                 *  //   var aux = com.GetAll(0, -1);
                 *  var id_comen2 = comcp2.CrearComentarioParaEvento (even.ID, "pos ta wapo el evento", usuen2.ID);
                 *
                 *
                 *  //creamos una puntuacion
                 *  var id_punt = puntcp.CrearPuntuacionParaEvento (even.ID, 5, usuen.ID);
                 *  var id_punt2 = puntcp2.CrearPuntuacionParaReto (reten.ID, 10, usuen.ID);
                 *
                 *
                 *  //creamos un reporte
                 *  var id_repor = repcp.ReportarEvento (usuen.ID, even.ID, "porque si");
                 *  var id_repor2 = repcp.ReportarReto (usuen.ID, reten.ID, "porque no");
                 *
                 *
                 *  //creamos el mapa de un paso
                 *  mapen3.Latitud = 39.5;
                 *  mapen3.Longitud = -1.5;
                 *  mapen3.Zoom = 16;
                 *
                 *  //creamos paso
                 *  pasen.Descripcion = "paso hola";
                 *  pasen.Gymkana = gymen;
                 *  pasen.Mapa = mapen3;
                 *  gymcp.AnadirPaso (pasen, mapen3, gymen);
                 *
                 *
                 *
                 *
                 *  var debugPoint = usucen.GetAll (0, 0);
                 *  var debugPoint2 = comcen.GetAll (0, 0);
                 *  var debugPoint3 = comcen2.GetAll (0, 0);
                 *  var debugPoint4 = evecen.GetAll (0, 0);
                 *  var debugPoint5 = gymcen.GetAll (0, 0);
                 *  var debugPoint6 = mapcen.GetAll (0, 0);
                 *  var debugPoint7 = pascen.GetAll (0, 0);
                 *  var debugPoint8 = puntcen.GetID (punten.Id);
                 *  var debugPoint9 = puntcen2.GetID (punten2.Id);
                 *  var debugPoint10 = retcen.GetAll (0, 0);
                 *  var debugPoint11 = admcen.GetAll (0, 0);
                 *
                 *  ///////////////////////CUSTOM//////////////////////
                 *
                 *  //USUARIO
                 *  var debugPoint15 = usucen.RecuperarContasena (usuen.Email, usuen.Nombre);
                 *
                 *  //EVENTO
                 *  evecen.VerEvento (even.ID);
                 *  var debugPoint16 = evecen.GetID (even.ID);
                 *
                 *  //PASO
                 *  var debugPoint12 = pascen.GetAll (0, 0);
                 *  for (int i = 0; i < debugPoint12.Count; i++) {
                 *          pascen.VerPaso (i);
                 *  }
                 *  pascen.VerPasos (gymen.ID);
                 *
                 *
                 *  //GYMKANA.
                 *  var debugPoint13 = gymcen.VerPasos (gymen.ID);
                 *
                 *  //PUNTUACIONES
                 *  var aux = puntcen.VerMediaEvento (even.ID);
                 *  var aux2 = puntcen.VerMediaReto (reten.ID);
                 *  //var aux3 = puntcen.FiltrarPuntuacionPorEventoYUsuario (usuen.ID, even.ID);
                 *  //var aux4 = puntcen.FiltrarPuntuacionPorUsuarioYReto (usuen.ID, reten.ID);
                 *
                 *  //REPORTE
                 *  repcen.ConsultarReporte (usuen.ID, reten.ID, -1);
                 *
                 *  repcen.ConsultarReporte (usuen.ID, -1, even.ID);
                 *
                 *
                 *  //////////////////////MODIFY//////////////////////
                 *  //Usuario
                 *  usucen.CambiarContrasena (usuen.ID, "456");
                 *  debugPoint = usucen.GetAll (0, 0);
                 *  usucen.CambiarCorreo (usuen.ID, "hola@gmail.com");
                 *  debugPoint = usucen.GetAll (0, 0);
                 *  usucen.CambiarFoto (usuen.ID, "Foto2");
                 *  debugPoint = usucen.GetAll (0, 0);
                 *  usucen.ModificarRedesSociales ("insta2", "face2", "twitter2", usuen.ID);
                 *  debugPoint = usucen.GetAll (0, 0);
                 *
                 *  //COMENTARIO
                 *  comcen.ModificarComentario ("MOTIVO NUEVO", id_comen);
                 *  debugPoint2 = comcen.GetAll (0, 0);
                 *  comcen2.ModificarComentario ("MOTIVO NUEVO 2", id_comen2);
                 *  debugPoint3 = comcen2.GetAll (0, 0);
                 *
                 *
                 *  //EVENTO
                 *  even.Descripcion = "Nueva descripcion evento";
                 *  evecp.ModificarEvento (mapen, even);
                 *  debugPoint4 = evecen.GetAll (0, 0);
                 *
                 *
                 *  //GYMKANA
                 *  gymen.Descripcion = "Nueva descripcion gymkana";
                 *  gymcp.ModificarGymkana (gymen, mapen);
                 *  debugPoint5 = gymcen.GetAll (0, 0);
                 *
                 *
                 *  //MAPA
                 *  //var mapa = mapcen.FiltrarMapa (40, -1, 10);
                 *  debugPoint6 = mapcen.GetAll (0, 0);
                 *
                 *
                 *  //PASO
                 *  pasen.Descripcion = "Nueva Descripcion Paso";
                 *  pascp.ModificarPaso (pasen, mapen3);
                 *  debugPoint7 = pascen.GetAll (0, 0);
                 *
                 *
                 *  //PUNTUACION
                 *  puntcen.ModificarPuntuacion (521552, id_punt);
                 *  debugPoint8 = puntcen.GetID (id_punt);
                 *
                 *  puntcen2.ModificarPuntuacion (21, id_punt2);
                 *  debugPoint9 = puntcen2.GetID (id_punt2);
                 *
                 *  //RETO
                 *  reten.Descripcion = "NUEVA DESCRIPCION RETO";
                 *  retcen.ModificarReto (reten);
                 *  debugPoint10 = retcen.GetAll (0, 0);
                 *
                 *  ///////////////////////CUSTOM//////////////////////
                 *
                 *  //USUARIO
                 *  //debugPoint15 = usucen.RecuperarContasena (usuen.Email, usuen.Nombre);
                 *
                 *  //EVENTO
                 *  evecen.VerEvento (even.ID);
                 *  debugPoint16 = evecen.GetID (even.ID);
                 *
                 *  //PASO
                 *  debugPoint12 = pascen.GetAll (0, 0);
                 *  for (int i = 0; i < debugPoint12.Count; i++) {
                 *          pascen.VerPaso (i);
                 *  }
                 *  var aux7 = pascen.VerPasos (gymen.ID);
                 *
                 *
                 *  //GYMKANA.
                 *  debugPoint13 = gymcen.VerPasos (gymen.ID);
                 *
                 *  //PUNTUACIONES
                 *  puntcen.VerMediaEvento (even.ID);
                 *  puntcen.VerMediaReto (reten.ID);
                 *  //puntcen.VerVoto (usuen.ID, gymen.ID, -1);
                 *  //puntcen.VerVoto (usuen.ID, -1, reten.ID);
                 *
                 *  //REPORTE
                 *  var ver = repcen.ConsultarReporte (usuen.ID, reten.ID, -1);
                 *  var ver2 = repcen.ConsultarReporte (usuen.ID, -1, even.ID);
                 *
                 *  /////////////////////DESTROY/////////////////////
                 *
                 *  //usucp.BorrarUsuario (usuen.ID);
                 *  var a = usucen.GetAll (0, 0);
                 *  //admcp.BorrarEvento (admen.ID);
                 *  var b = evecen.GetAll (0, 0);
                 *  //   evecp.CrearEvento (even, 50, 30, 10);
                 *  b = evecen.GetAll (0, 0);
                 *  // admcp.BorrarRetos (admen.ID);
                 *  var c = retcen.GetAll (0, 0);
                 *  //retcen.CrearReto (reten);
                 *  c = retcen.GetAll (0, 0);
                 *  var d = retcen.GetAll (0, 0);
                 *  var co = comcen.GetAll (0, 0);
                 *  //admcp.DeshacerAdmin (admen.ID);
                 *  //var u= admcen.GetAll (0, 0);
                 *
                 *
                 *  //    comcen.BorrarComentario (comen.ID);
                 *  var e = comcen.GetAll (0, 0);
                 *
                 *  evecp.BorrarEvento (even.ID);;
                 *  b = evecen.GetAll (0, 0);
                 *
                 *  //pascp.BorrarPaso (pasen.ID);
                 *  var g = pascen.GetAll (0, 0);
                 *
                 *  gymcp.BorrarGymkana (gymen.ID);
                 *  var f = gymcen.GetAll (0, 0);
                 *
                 *  var h = repcen.GetAll (0, 0);
                 *  repcp.BorrarReportesEvento (even.ID);
                 *  h = repcen.GetAll (0, 0);
                 *
                 *  repcp.BorrarReportesReto (reten.ID);
                 *  var y = repcen.GetAll (0, 0);
                 *
                 *  retcp.BorrarReto (repen.ID);
                 *  var k = retcen.GetAll (0, 0);
                 *
                 */

                /*PROTECTED REGION END*/
        }
        catch (Exception ex)
        {
                System.Console.WriteLine (ex.InnerException);
                throw ex;
        }
}
}
}
