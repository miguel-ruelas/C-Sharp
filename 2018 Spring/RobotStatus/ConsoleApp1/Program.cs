using System;
using System.Collections.Generic;

namespace Robot_Status
{
    class Program
    {
        int[] k = new int[20];

        string[] status = { "OFF", "ON" };

        string[] BatLevel = { "none", "low", "medium", "full power" };

        Random rand = new Random();

        void createRobots()
        {

            for (int i = 0; i < 20; i++)
            {
                k[i] = rand.Next() & 0xFFFF;
            }

        }

        void showStatus(int index)
        {
            Console.WriteLine("Robot #" + index + ":");
            Console.WriteLine("Raw reading:");
            Console.WriteLine(getBinary(k[index]) + "\n");
            showSensors(index);
            showSpeed(index);
            showSensorReading(index);
            showVolume(index);
            showBattery(index);
            Console.WriteLine("********************************\n");
        }

        private void showBattery(int index)
        {
            string batStatus = BatLevel[getBatLevel(index)];
            Console.WriteLine("Battery:" + batStatus + "\n");
        }

        private int getBatLevel(int index)
        {
            //Console.Write("Raw Reading bits 14,13:");
            int u = k[index] >> 13 & 0x3;
            //Console.Write(getBinary(u) + "\n");
            return u;

        }

        private void showVolume(int index)
        {

            Console.Write("Raw Reading bits 9-12:");
            int u = k[index] >> 9 & 0xD;
            Console.Write(getBinary(u) + "\n");
            //Console.Write("Raw Reading bits 12,11:");
            u = k[index] >> 11 & 0x3;
            //Console.Write(getBinary(u) + "\n");
            int t = u << 1;
            //Console.Write("Raw Reading bits 12,11,0:");
            //Console.Write(getBinary(t) + "\n");
            u = k[index] >> 9 & 0x1;
            int v = t ^ u;
            Console.Write("Raw Reading bits 12,11,9:");
            Console.Write(getBinary(v) + "\n");

            Console.WriteLine("Volume:" + v + "\n");
        }

        private void showSpeed(int index)
        {
            int s = k[index] >> 1 & 0xF;
            Console.Write("Raw Reading bits 1-4:");
            Console.Write(getBinary(s) + "\n");
            Console.WriteLine("Speed:" + s + "\n");

        }
        private void setSpeed(int robot,int v)
        {
            int t = v << 1;
            int s = k[robot] & 65521;
            int x = t | s;
            k[robot] = x;
        }

        private void setSpeedAll(int v)
        {
            for (int i = 0; i < k.Length;i++)
            {
                setSpeed(i, v);
            }
        }

        private void showSensorReading(int index)
        {
            int s = k[index] >> 6 & 0x7;
            Console.Write("Raw Reading bits 6-8:");
            Console.Write(getBinary(s) + "\n");
            Console.WriteLine("Sensor Reading:" + s + "\n");

        }

        private void showSensors(int index)
        {

            string s1Status = status[getSensor(index, 15)];


            string s2Status = status[getSensor(index, 10)];


            string s3Status = status[getSensor(index, 5)];


            string s4Status = status[getSensor(index, 0)];
            Console.WriteLine("Sensors:");
            Console.WriteLine("15 , 10 , 5 , 0");
            Console.WriteLine("{0}, {1}, {2}, {3} \n",
                s1Status, s2Status, s3Status, s4Status);
        }

        private int getSensor(int index, int sensor)
        {
            if (sensor == 15)
            {
                int s = k[index] >> sensor;
                return s;
            }
            else if (sensor == 10)
            {
                int s = k[index] >> sensor & 0x00000001;
                return s;
            }
            else if (sensor == 5)
            {
                int s = k[index] >> sensor & 0x00000001;
                return s;
            }
            else
            {
                int s = k[index] & 0x00000001;
                return s;
            }


        }


        void displayAll()
        {
            for (int i = 0; i < k.Length; i++)
            {
                showStatus(i);
            }

        }

        string getBinary(int n)
        {
            string binary = Convert.ToString(n, 2);
            return binary;
        }

        int getInt(string n)
        {
            int int1 = Convert.ToInt32(n, 2);
            return int1;
        }

        private void displayLowBat()
        {
            Console.WriteLine("DISPLAYING LOW BATTERY ONLY");
            Console.WriteLine("***************************");
            for (int i = 0; i < k.Length; i++)
            {
                if (getBatLevel(i) < 3)
                {
                    Console.WriteLine("Robot #:" + i);
                }
            }
        }

        private void displayIDSensors()
        {
            Console.WriteLine("ROBOTS WITH SENSORS ON");
            Console.WriteLine("***************************");
            for (int i = 0; i < k.Length; i++)
            {
                Boolean sensorsOn = true;
                for (int b = 0; b < 4; b++)
                {
                   int test = getSensor(i, b*5);
                    if (test == 0)
                    {
                        sensorsOn = false;
                    }

                }
                if (sensorsOn == true)
                {
                    Console.WriteLine("Robot #" + i);
                    showSensors(i);
                   
                }
            }
        }

        static void Main(string[] args)
        {
            Program test = new Program();
            test.createRobots();
            test.displayAll();
            test.displayLowBat();
            test.displayIDSensors();
            int speed = 10;
            test.setSpeedAll(speed);
            Console.ReadLine();
            Console.WriteLine("SPEED SET TO:" + speed);
            test.displayAll();
            Console.ReadLine();
        }

        
    }
}

