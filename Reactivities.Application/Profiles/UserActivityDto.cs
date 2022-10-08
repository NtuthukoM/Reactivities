using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Reactivities.Application.Profiles
{
    public class UserActivityDto
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public DateTime Date { get; set; }
        [JsonIgnore]
        public string HostUsername { get; set; }
    }
}
