using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace com.profillingTool.models
{
    class Profile
    {
       
        public int id { get; set; }
        public int jobcode { get; set; }
        public int center {get; set;}
        public string profileName {get; set;}
        public string description {get; set;}

    }
}