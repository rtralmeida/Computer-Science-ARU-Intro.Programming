using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataCopier
{

    class MyObjectClassV1
    {
        public int Position;

      
    }


    class MyObjectClassV2
    {
        private int _position;

        public int Position
        {
            get
            {
                return this._position;
            }
            set
            {
                _position = value;
            }
        }


    }

    class MyObjectClassV3
    {
        public int Position { get; set; }

    }
    
}
