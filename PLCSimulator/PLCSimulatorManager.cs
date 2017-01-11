using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace PLCSimulator
{
    /// <summary>
    /// PLC Simulator
    /// 
    /// 4 x ANALOG INPUT : ADDR001 - ADDR004
    /// 4 x ANALOG OUTPUT: ADDR005 - ADDR008
    /// 1 x DIGITAL INPUT: ADDR009
    /// 1 x DIGITAL OUTPUT: ADDR010
    /// </summary>
    public class PLCSimulatorManager : IPLCSimulator
    {
        private Dictionary<string, double> addressValues;

        public Dictionary<string, double> AddressValues
        {
            get { return addressValues; }
        }

        private object locker = new object();

        public PLCSimulatorManager()
        {
            addressValues = new Dictionary<string, double>();

            addressValues.Add("ADDR001", 0);
            addressValues.Add("ADDR002", 0);
            addressValues.Add("ADDR003", 0);
            addressValues.Add("ADDR004", 0);
            addressValues.Add("ADDR005", 0);
            addressValues.Add("ADDR006", 0);
            addressValues.Add("ADDR007", 0);
            addressValues.Add("ADDR008", 0);
            addressValues.Add("ADDR009", 0);
            addressValues.Add("ADDR010", 0);
        }

        public void StartPLCSimulator()
        {
            Thread t1 = new Thread(GeneratingAnalogInputs);
            t1.Start();

            Thread t2 = new Thread(GeneratingDigitalInputs);
            t2.Start();
        }

        public string[] GetAnalogInputs()
        {
            string[] addresses = new string[4];
            int c = 0;
            for (int i = 0; i < 4; i++)
            {
                addresses[c] = addressValues.Keys.ToList()[i];
                c++;
            }
            return addresses;
        }

        public string[] GetAnalogOutputs()
        {
            string[] addresses = new string[4];
            int c = 0;
            for (int i = 4; i < 8; i++)
            {
                addresses[c] = addressValues.Keys.ToList()[i];
                c++;
            }
            return addresses;
        }

        public string[] GetDigitalInputs()
        {
            string[] addresses = new string[1];
            addresses[0] = addressValues.Keys.ToList()[8];

            return addresses;
        }

        public string[] GetDigitalOutputs()
        {
            string[] addresses = new string[1];
            addresses[0] = addressValues.Keys.ToList()[9];
            return addresses;
        }

        private void GeneratingAnalogInputs()
        {
            while (true)
            {
                Thread.Sleep(100);

                lock (locker)
                {
                    addressValues["ADDR001"] = 100*Math.Sin((double) DateTime.Now.Second/60*Math.PI); //SINE
                    addressValues["ADDR002"] = 100*DateTime.Now.Second/60; //RAMP
                    addressValues["ADDR003"] = 100*Math.Cos((double) DateTime.Now.Second/60*Math.PI); //COSINE
                    addressValues["ADDR004"] = 100 - 100*DateTime.Now.Second/60; //RAMP
                }
            }
        }

        private void GeneratingDigitalInputs()
        {
            while (true)
            {
                Thread.Sleep(5000);

                lock (locker)
                {
                    if (addressValues["ADDR009"] == 0)
                    {
                        addressValues["ADDR009"] = 1;
                    }
                    else
                    {
                        addressValues["ADDR009"] = 0;
                    }
                }
            }
        }

        public double Read(string address)
        {
            lock (locker)
            {
                return addressValues[address];
            }
        }

        public bool Write(string address, double value)
        {
            lock (locker)
            {
                if (!addressValues.ContainsKey(address))
                {
                    return false;
                }
                addressValues[address] = value;
                return true;
            }
        }
    }
}