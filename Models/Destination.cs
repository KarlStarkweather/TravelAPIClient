using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace TravelAPIClient.Models
{
    public class Destination
    {
        public Destination()
        {
            this.Reviews = new HashSet<Review>();
        }

        public int DestinationID {get; set; }
        [Required]
        [StringLength(20)]
        public string Name {get; set; }
        [Required]
        [StringLength(20)]
        public string City {get; set; }
        [Required]
        [StringLength(20)]
        public string Country {get; set; }

        public virtual ICollection<Review> Reviews {get; set; }

        public static List<Destination> GetDestinations()
        {
            var apiCallTask = ApiHelper.GetAll();
            var result = apiCallTask.Result;

            JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
            List<Destination> destinationList = JsonConvert.DeserializeObject<List<Destination>>(jsonResponse.ToString());

            return destinationList;
        }

        public static Destination GetDetails(int id)
        {
            var apiCallTask = ApiHelper.Get(id);
            var result = apiCallTask.Result;

            JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
            Destination destination = JsonConvert.DeserializeObject<Destination>(jsonResponse.ToString());

            return destination;
        }

       public static void Post(Destination destination)
        {
            string jsonDestination = JsonConvert.SerializeObject(destination);
            var apiCallTask = ApiHelper.Post(jsonDestination);
        }

        public static void Put(Destination destination)
        {
            string jsonDestination = JsonConvert.SerializeObject(destination);
            var apiCallTask = ApiHelper.Put(destination.DestinationID, jsonDestination);
        }

        public static void Delete(int id)
        {
            var apiCallTask = ApiHelper.Delete(id);
        }


    }
}