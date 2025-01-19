using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApplicationProgramingInterfaceNedir.API.APIModel
{
    [Serializable]
    public class CategoryDTO
    {
        public int ID {  get; set; }
        public string Name { get; set; }
        public byte[] Picture { get; set; }

        [NonSerialized]
        public string Description;
    }
}