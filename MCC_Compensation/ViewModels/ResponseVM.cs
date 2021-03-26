using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace API.ViewModels
{
    public class ResponseVM<Entity>
    {
        public StatusType Status { get; set; }
        public string Message { get; set; }
        public Entity Result { get; set; }

        public enum StatusType
        {
            Success,
            Warning,
            Failed
        }
    }
}
