using Consignor;
using Consignor.ShipmentExporter;
using Consignor.ShipmentServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsignorTest
{
    class Program
    {
        static void Main(string[] args)
        {
            MainAsync().Wait();
            
        }
        static async Task MainAsync()
        {
            try
            {
                ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, error) => { return true; };
                var ssurl = "https://ws.consignorportal.com:8000/PortalData/PortalData.svc";
                var ssactorid = 226;
                var sskey = "Jxq8SfrG9H";
                var shpCSID = 887707;
                List<int> actors = new List<int> {  };
                //var request = new GetEventsRequest { password = "cryos2014", userName = "cryos", eventDateTimeStart = DateTime.Now.AddHours(-1), eventDateTimeEnd = DateTime.Now };
                var ss = ConsignorService.CreateShipmentExporter(ssurl, "cryos", "cryos2014");
                var details = (await ss.GetShipmentsByShipmentNumberAsync("20001973021", actors.ToArray(), "1Z3ER6129193975336", new DateTime(2016,4,1,1,0,0), new DateTime(2016, 4, 21, 23, 0, 0)));
                
                Console.WriteLine("Done");
            }
            catch (Exception ex)
            {

                
            }
        }
    }
}
