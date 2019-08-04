using Matrix.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MatrixApp.Models
{
    [Serializable]
    public class RoomsViewModel
    {
        public MatrixRoom[] rooms;
    }   
}
