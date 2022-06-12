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

            var res = db.reservations.Where(x => x.date_res <= date_archivage).ToList();

            var resArchive = new reservationarchive();

            var countColumns = res.Count;

            foreach (var entity in res)
            {
                var row = new reservationarchive();
                row.chambreid = entity.chambreid;
                row.clientid = entity.clientid;
                row.date_res = entity.date_res;
                row.date_debut = entity.date_debut;
                row.date_fin = entity.date_fin;
                row.date_pay_arrhes = entity.date_pay_arrhes;

                db.reservationarchives.Add(row);
                db.reservations.Remove(entity);
                db.SaveChanges();

                Console.WriteLine("l'archivage a  été effectué");

            }


        }



    }
}
