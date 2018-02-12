using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorSales
{
    class VectorClass
    {
        public int x { get; set; }
        public int y { get; set; }
        public int z { get; set; }



        public VectorClass(int _valueX, int _valueY, int _valueZ = 0)
        {
            this.x = _valueX;
            this.y = _valueY;
            this.z = _valueZ;
        }

        public VectorClass(int _value)
        {
            this.x = this.y;
        }

        public int AddThemTogether()
        {
            return this.x + this.y;

        }

        public int MultiplyValues()
        {
            return this.x * this.y;

        }

    }
}