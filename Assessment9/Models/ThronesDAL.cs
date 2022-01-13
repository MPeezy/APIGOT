using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Assessment9.Models
{
    public class ThronesDAL
    {
        public Character GetSpecificCharacter(int id)
        {
            string url = $"https://anapioficeandfire.com/api/characters/" + id;

            HttpWebRequest request = WebRequest.CreateHttp(url);

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            StreamReader rd = new StreamReader(response.GetResponseStream());

            string output = rd.ReadToEnd();

            rd.Close();

            Character c = JsonConvert.DeserializeObject<Character>(output); 

            return c;


        }
    }
}