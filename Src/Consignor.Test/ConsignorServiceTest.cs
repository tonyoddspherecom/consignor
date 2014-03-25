using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net;
using System.Threading.Tasks;

namespace Consignor.Test
{
    [TestClass]
    public class ConsignorServiceTest
    {
        [TestMethod]
        public async Task TestMethod1()
        {
            ServicePointManager.ServerCertificateValidationCallback = ((senders, certificate, chain, sslPolicyErrors) => true);
            var ssurl = "https://qa-tic03.facility.dir.dk/json/ShipmentServerModule.dll";
            var sskey = "sample";
            var ssactorid = 63;
            var saurl = "http://qa-ws01.facility.dir.dk/ShipAdvisor/main.asmx";
            var sauser = "Flexerman21073";
            var sapass = "Gm15/46exRF";

            var ss = ConsignorService.CreateShipmentServer(ssurl, ssactorid, sskey);
            var sa = ConsignorService.CreateShipAdvisor(saurl, sauser, sapass);
            var result = await sa.SearchForDropPointsAsync(60, "10916000028", "NO", "", "0580", "", 2);
        }
    }
}
