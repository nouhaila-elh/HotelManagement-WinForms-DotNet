using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using Npgsql;

namespace GestionHotel
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            System.Timers.Timer aTimer = new System.Timers.Timer(5 * 1000);  // every five seconds
            aTimer.Elapsed += new ElapsedEventHandler(DoArchive);
            aTimer.Start();
            
            Application.Run(new Home());

            
            
        }

        private static void DoArchive(object source, ElapsedEventArgs e)
        {
            Console.WriteLine(" Chercher l'existence des données à archiver");
            Model1 db = new Model1();

            DateTime date_archivage = DateTime.Today.AddMonths(-6);

            var res = db.reservations1.Where(x => x.date_res <= date_archivage).ToList();

           if(res !=null)
            {

            
            foreach (var entity in res)
            {
                 // Archivage du prestation liée à cette réservation 
                 var prestationObject = db.prestations1.Where(x => x.reservationid == entity.id).ToList();

                    if(prestationObject !=null)
                    {
                        foreach (var entity2 in prestationObject)
                        {
                            var rowPrestation = new prestation();
                            rowPrestation.reservationid = entity2.reservationid;
                            rowPrestation.date_consommation = entity2.date_consommation;
                            rowPrestation.prix_prestation = entity2.prix_prestation;
                            rowPrestation.description = entity2.description;
                            rowPrestation.type_prestation = entity2.type_prestation;
                            

                            db.prestations.Add(rowPrestation);
                            db.prestations1.Remove(entity2);
                            db.SaveChanges();

                        }

                    }


                    // Archivage de la réservation 
                    var row = new reservation();
                row.chambreid = entity.chambreid;
                row.clientid = entity.clientid;
                row.date_res = entity.date_res;
                row.date_debut = entity.date_debut;
                row.date_fin = entity.date_fin;
                row.date_pay_arrhes = entity.date_pay_arrhes;
                row.prix_res = entity.prix_res;
                row.arrhes = entity.arrhes;


                var clientobject = db.clients1.Find(entity.clientid);
                db.reservations.Add(row);
                db.reservations1.Remove(entity);
                db.SaveChanges();

                // Archivage du client

               
                
               if(clientobject !=null)
                    {
                        var rowClient = new client();
                        rowClient.nom = clientobject.nom;
                        rowClient.prenom = clientobject.prenom;
                        rowClient.address = clientobject.address;
                        rowClient.ville = clientobject.ville;
                        rowClient.code_postale = clientobject.code_postale;
                        rowClient.pays = clientobject.pays;
                        rowClient.tel = clientobject.tel;
                        rowClient.email = clientobject.email;

                        db.clients.Add(rowClient);
                        db.clients1.Remove(clientobject);
                        db.SaveChanges();
                    }
                




                    Console.WriteLine("l'archivage a  été effectué");
        
            }
            }

        }



    }
}
