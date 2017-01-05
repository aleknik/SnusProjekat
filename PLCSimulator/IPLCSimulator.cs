using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PLCSimulator
{
    public interface IPLCSimulator
    {
        double Read(string address);
        bool Write(string address, double value);
    }
}
