using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkylineAssessment
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string API_Output = @"{'Device':'Arista','Model':'X-Video','NIC':[{'Description':'Linksys ABR','MAC':'14:91:82:3C:D6:7D','Timestamp': '2020-03-23T18:25:43.511Z','Rx': '3698574500','Tx': '122558800'}] }";
                int frequency = 2;
                List<output> outputList = new List<output>();
                output outObj = new output();
                //Formula used to calculate bitrate is "Octets * frequency" for reception and transmission
                var parsed = JsonConvert.DeserializeObject<Fox_Xvideo>(API_Output);
                for (int i = 0; i < parsed.NICs.Count; i++)
                {
                    outObj.description = parsed.NICs[i].description;
                    outObj.MAC = parsed.NICs[i].MAC;
                    outObj.ts = parsed.NICs[i].ts;
                    outObj.bitrateRx = Int64.Parse(parsed.NICs[i].rx) * frequency;
                    outObj.bitrateTx = Int64.Parse(parsed.NICs[i].tx) * frequency;
                    outputList.Add(outObj);
                }

                string result = JsonConvert.SerializeObject(outputList);
                Console.WriteLine(result);
                Console.Read();
            }
            catch(Exception e)
            {
                Console.Write("Error occured :" , e.Message);
            }
        }
    }
}
