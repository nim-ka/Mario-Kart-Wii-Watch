using System;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;
using WindowsFormsApp1.Utils;
using System.Linq;




namespace WindowsFormsApp1
{

    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }





        uint startAddress = 0x00DDDFD8;
        uint offset = 0;
        long GameID;
        uint playerbase;
        uint raceData2;
        uint PosPointer;
        short MT_Charge;
        short Airtime;
        short Trick_Boost;
        short Mushroom_Boost;
        short MT_Boost;
        short All_Boost;
        uint PlayerBaseOffset = 0;
        float speed;
        ProcessMemoryReader mreader = new ProcessMemoryReader();

        int bytesOut = 0;


        private void Main_Load(object sender, EventArgs e)
        {

            Timer timer1 = new Timer();
            timer1.Interval = (1); // 1ms
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Start();




            Process process = Process.GetProcessesByName("Dolphin").ToList().FirstOrDefault();
            if(process != null)
            {
                mreader.ReadProcess = process;
                mreader.OpenProcess();

                offset = BitConverter.ToUInt32(mreader.ReadMemory((IntPtr)(startAddress + (uint)process.MainModule.BaseAddress), 4, out bytesOut), 0);
            }
            else
            {
                throw new ArgumentNullException("Dolphin is not running!");
            }

           
        }


        private void timer1_Tick(object sender, EventArgs e)
        {

            if (comboBox1.Text == "NTSC-U")
            {
                playerbase = 0x9BD110;
                raceData2 = 0x9B8F70;
                PosPointer = 0x9BE738;
            }
            else if (comboBox1.Text == "PAL")
            {
                playerbase = 0x9C18F8;
                raceData2 = 0x9BD730;
                PosPointer = 0x9C2EF8;
            }
            else if (comboBox1.Text == "NTSC-J")
            {
                playerbase = 0x9C0958;
                raceData2 = 0x9BC790;
                PosPointer = 0x9C1F58;
            }
            else if (comboBox1.Text == "NTSC-K")
            {
                playerbase = 0x9AFF38;
                raceData2 = 0x9ABD70;
                PosPointer = 0x9B1538;
            }
            else
            {
                playerbase = 0;
                raceData2 = 0;
                PosPointer = 0;
            }


        

            // PlayerBase
            PlayerBaseOffset = BitConverter.ToUInt32(mreader.ReadMemory((IntPtr)(0x7FFF0000 + playerbase), 4, out bytesOut), 0);
            byte[] offsetbytes = BitConverter.GetBytes(PlayerBaseOffset);
            Array.Reverse(offsetbytes, 0, offsetbytes.Length);
            PlayerBaseOffset = BitConverter.ToUInt32(offsetbytes, 0);

            // offset 1
            PlayerBaseOffset = BitConverter.ToUInt32(mreader.ReadMemory((IntPtr)(0x7FFF0000 + (PlayerBaseOffset - 0x80000000) + 0x20), 4, out bytesOut), 0);
            offsetbytes = BitConverter.GetBytes(PlayerBaseOffset);
            Array.Reverse(offsetbytes, 0, offsetbytes.Length);
            PlayerBaseOffset = BitConverter.ToUInt32(offsetbytes, 0);

            // offset 2        
            PlayerBaseOffset = BitConverter.ToUInt32(mreader.ReadMemory((IntPtr)(0x7FFF0000 + (PlayerBaseOffset - 0x80000000) + 0), 4, out bytesOut), 0);
            offsetbytes = BitConverter.GetBytes(PlayerBaseOffset);
            Array.Reverse(offsetbytes, 0, offsetbytes.Length);
            PlayerBaseOffset = BitConverter.ToUInt32(offsetbytes, 0);

            // offset 3
            PlayerBaseOffset = BitConverter.ToUInt32(mreader.ReadMemory((IntPtr)(0x7FFF0000 + (PlayerBaseOffset - 0x80000000) + 0x10), 4, out bytesOut), 0);
            offsetbytes = BitConverter.GetBytes(PlayerBaseOffset);
            Array.Reverse(offsetbytes, 0, offsetbytes.Length);
            PlayerBaseOffset = BitConverter.ToUInt32(offsetbytes, 0);

            // offset 4
            PlayerBaseOffset = BitConverter.ToUInt32(mreader.ReadMemory((IntPtr)(0x7FFF0000 + (PlayerBaseOffset - 0x80000000) + 0x10), 4, out bytesOut), 0);
            offsetbytes = BitConverter.GetBytes(PlayerBaseOffset);
            Array.Reverse(offsetbytes, 0, offsetbytes.Length);
            PlayerBaseOffset = BitConverter.ToUInt32(offsetbytes, 0);

            // Airtime
            Airtime = BitConverter.ToInt16(mreader.ReadMemory((IntPtr)(0x7FFF0000 + (PlayerBaseOffset - 0x80000000) + 0x21A), 2, out bytesOut), 0);
            offsetbytes = BitConverter.GetBytes(Airtime);
            Array.Reverse(offsetbytes, 0, offsetbytes.Length);
            Airtime = BitConverter.ToInt16(offsetbytes, 0);

            lblAirtime_String.Text = string.Format("{0}", Airtime);

            // MT Charge
            MT_Charge = BitConverter.ToInt16(mreader.ReadMemory((IntPtr)(0x7FFF0000 + (PlayerBaseOffset - 0x80000000) + 0xFE), 2, out bytesOut), 0);
            offsetbytes = BitConverter.GetBytes(MT_Charge);
            Array.Reverse(offsetbytes, 0, offsetbytes.Length);
            MT_Charge = BitConverter.ToInt16(offsetbytes, 0);

            // SSMT Charge
            short SSMT_Charge = BitConverter.ToInt16(mreader.ReadMemory((IntPtr)(0x7FFF0000 + (PlayerBaseOffset - 0x80000000) + 0x14C), 2, out bytesOut), 0);
            offsetbytes = BitConverter.GetBytes(SSMT_Charge);
            Array.Reverse(offsetbytes, 0, offsetbytes.Length);
            SSMT_Charge = BitConverter.ToInt16(offsetbytes, 0);

            short All_MT = Math.Max(MT_Charge, SSMT_Charge);

            lblMT.Text = string.Format("{0}", All_MT);


            // Boost
            Trick_Boost = BitConverter.ToInt16(mreader.ReadMemory((IntPtr)(0x7FFF0000 + (PlayerBaseOffset - 0x80000000) + 0x114), 4, out bytesOut), 0);
            offsetbytes = BitConverter.GetBytes(Trick_Boost);
            Array.Reverse(offsetbytes, 0, offsetbytes.Length);
            Trick_Boost = BitConverter.ToInt16(offsetbytes, 0);

            Mushroom_Boost = BitConverter.ToInt16(mreader.ReadMemory((IntPtr)(0x7FFF0000 + (PlayerBaseOffset - 0x80000000) + 0x110), 4, out bytesOut), 0);
            offsetbytes = BitConverter.GetBytes(Mushroom_Boost);
            Array.Reverse(offsetbytes, 0, offsetbytes.Length);
            Mushroom_Boost = BitConverter.ToInt16(offsetbytes, 0);

            MT_Boost = BitConverter.ToInt16(mreader.ReadMemory((IntPtr)(0x7FFF0000 + (PlayerBaseOffset - 0x80000000) + 0x10C), 4, out bytesOut), 0);
            offsetbytes = BitConverter.GetBytes(MT_Boost);
            Array.Reverse(offsetbytes, 0, offsetbytes.Length);
            MT_Boost = BitConverter.ToInt16(offsetbytes, 0);

            All_Boost = Math.Max(Trick_Boost, Mushroom_Boost);
            All_Boost = Math.Max(All_Boost, MT_Boost);

            lblBst.Text = string.Format("{0}", All_Boost);

            // Speed
            speed = BitConverter.ToSingle(mreader.ReadMemory((IntPtr)(0x7FFF0000 + (PlayerBaseOffset - 0x80000000) + 0x20), 4, out bytesOut), 0);
            offsetbytes = BitConverter.GetBytes(speed);
            Array.Reverse(offsetbytes, 0, offsetbytes.Length);
            speed = BitConverter.ToSingle(offsetbytes, 0);

            lblSpeed.Text = speed.ToString();

            //RaceData2
            raceData2 = BitConverter.ToUInt32(mreader.ReadMemory((IntPtr)(0x7FFF0000 + raceData2), 4, out bytesOut), 0);
            offsetbytes = BitConverter.GetBytes(raceData2);
            Array.Reverse(offsetbytes, 0, offsetbytes.Length);
            raceData2 = BitConverter.ToUInt32(offsetbytes, 0);

            // offset 1
            raceData2 = BitConverter.ToUInt32(mreader.ReadMemory((IntPtr)(0x7FFF0000 + (raceData2 - 0x80000000) + 0xC), 4, out bytesOut), 0);
            offsetbytes = BitConverter.GetBytes(raceData2);
            Array.Reverse(offsetbytes, 0, offsetbytes.Length);
            raceData2 = BitConverter.ToUInt32(offsetbytes, 0);

            // offset 2
            raceData2 = BitConverter.ToUInt32(mreader.ReadMemory((IntPtr)(0x7FFF0000 + (raceData2 - 0x80000000) + 0x0 ), 4, out bytesOut), 0); // Change 0x0 to 0x4 to see values of ghost WIP: Make checkbox to display the values of your ghost.
            offsetbytes = BitConverter.GetBytes(raceData2);
            Array.Reverse(offsetbytes, 0, offsetbytes.Length);
            raceData2 = BitConverter.ToUInt32(offsetbytes, 0);

            short KPT;
            
            KPT = BitConverter.ToInt16(mreader.ReadMemory((IntPtr)(0x7FFF0000 + (raceData2 - 0x80000000) + 0x28), 2, out bytesOut), 0); // not converting to Big endian since it will not display correctly 


            short CKPT;
            CKPT = BitConverter.ToInt16(mreader.ReadMemory((IntPtr)(0x7FFF0000 + (raceData2 - 0x80000000) + 0xA), 2, out bytesOut), 0);
            offsetbytes = BitConverter.GetBytes(CKPT);
            Array.Reverse(offsetbytes, 0, offsetbytes.Length);
            CKPT = BitConverter.ToInt16(offsetbytes, 0);


            lblCKPT.Text = string.Format("{0} ({1})", CKPT, KPT);

            float Race_Completion;
            Race_Completion = BitConverter.ToSingle(mreader.ReadMemory((IntPtr)(0x7FFF0000 + (raceData2 - 0x80000000) + 0xC), 4, out bytesOut), 0);
            offsetbytes = BitConverter.GetBytes(Race_Completion);
            Array.Reverse(offsetbytes, 0, offsetbytes.Length);
            Race_Completion = BitConverter.ToSingle(offsetbytes, 0);

            lblRaceComp.Text = Race_Completion.ToString();

            float Lap_Completion;
            Lap_Completion = BitConverter.ToSingle(mreader.ReadMemory((IntPtr)(0x7FFF0000 + (raceData2 - 0x80000000) + 0x1C), 4, out bytesOut), 0);
            offsetbytes = BitConverter.GetBytes(Lap_Completion);
            Array.Reverse(offsetbytes, 0, offsetbytes.Length);
            Lap_Completion = BitConverter.ToSingle(offsetbytes, 0);
            lblLapComp.Text = Lap_Completion.ToString();


            // PosPointer
            PosPointer = BitConverter.ToUInt32(mreader.ReadMemory((IntPtr)(0x7FFF0000 + PosPointer), 4, out bytesOut), 0);
            offsetbytes = BitConverter.GetBytes(PosPointer);
            Array.Reverse(offsetbytes, 0, offsetbytes.Length);
            PosPointer = BitConverter.ToUInt32(offsetbytes, 0);

            // offset 1
            PosPointer = BitConverter.ToUInt32(mreader.ReadMemory((IntPtr)(0x7FFF0000 + (PosPointer - 0x80000000) + 0x40), 4, out bytesOut), 0);
            offsetbytes = BitConverter.GetBytes(PosPointer);
            Array.Reverse(offsetbytes, 0, offsetbytes.Length);
            PosPointer = BitConverter.ToUInt32(offsetbytes, 0);

            float XPos;
            XPos = BitConverter.ToSingle(mreader.ReadMemory((IntPtr)(0x7FFF0000 + (PosPointer - 0x80000000) + 0x0), 4, out bytesOut), 0);
            offsetbytes = BitConverter.GetBytes(XPos);
            Array.Reverse(offsetbytes, 0, offsetbytes.Length);
            XPos = BitConverter.ToSingle(offsetbytes, 0);
            lblXpos.Text = XPos.ToString();

            float YPos;
            YPos = BitConverter.ToSingle(mreader.ReadMemory((IntPtr)(0x7FFF0000 + (PosPointer - 0x80000000) + 0x4), 4, out bytesOut), 0);
            offsetbytes = BitConverter.GetBytes(YPos);
            Array.Reverse(offsetbytes, 0, offsetbytes.Length);
            YPos = BitConverter.ToSingle(offsetbytes, 0);
            lblYpos.Text = YPos.ToString();

            float ZPos;
            ZPos = BitConverter.ToSingle(mreader.ReadMemory((IntPtr)(0x7FFF0000 + (PosPointer - 0x80000000) + 0x8), 4, out bytesOut), 0);
            offsetbytes = BitConverter.GetBytes(ZPos);
            Array.Reverse(offsetbytes, 0, offsetbytes.Length);
            ZPos = BitConverter.ToSingle(offsetbytes, 0);
            lblZpos.Text = ZPos.ToString();

            float Prev_XPos;
            Prev_XPos = BitConverter.ToSingle(mreader.ReadMemory((IntPtr)(0x7FFF0000 + (PosPointer - 0x80000000) - 0x160), 4, out bytesOut), 0);
            offsetbytes = BitConverter.GetBytes(Prev_XPos);
            Array.Reverse(offsetbytes, 0, offsetbytes.Length);
            Prev_XPos = BitConverter.ToSingle(offsetbytes, 0);

            float Prev_YPos;
            Prev_YPos = BitConverter.ToSingle(mreader.ReadMemory((IntPtr)(0x7FFF0000 + (PosPointer - 0x80000000) - 0x160  + 0x4), 4, out bytesOut), 0);
            offsetbytes = BitConverter.GetBytes(Prev_YPos);
            Array.Reverse(offsetbytes, 0, offsetbytes.Length);
            Prev_YPos = BitConverter.ToSingle(offsetbytes, 0);

            float Prev_ZPos;
            Prev_ZPos = BitConverter.ToSingle(mreader.ReadMemory((IntPtr)(0x7FFF0000 + (PosPointer - 0x80000000) - 0x160 + 0x8), 4, out bytesOut), 0);
            offsetbytes = BitConverter.GetBytes(Prev_ZPos);
            Array.Reverse(offsetbytes, 0, offsetbytes.Length);
            Prev_ZPos = BitConverter.ToSingle(offsetbytes, 0);

            float YVel = YPos - Prev_YPos;
            double XZspd = Math.Sqrt(((XPos - Prev_XPos) * (XPos - Prev_XPos)) + ((ZPos - Prev_ZPos) * (ZPos - Prev_ZPos)));
            float XYZspd = (float)Math.Sqrt(((XPos - Prev_XPos) * (XPos - Prev_XPos)) + ((YPos - Prev_YPos) * (YPos - Prev_YPos)) + ((ZPos - Prev_ZPos) * (ZPos - Prev_ZPos)));

            lblYVel.Text = YVel.ToString();
            lblXZspd.Text = XZspd.ToString();
            lblXYZspd.Text = XYZspd.ToString();

            // Rotation

            float QuaternionX = BitConverter.ToSingle(mreader.ReadMemory((IntPtr)(0x7FFF0000 + (PosPointer - 0x80000000) + 0x88), 4, out bytesOut), 0);
            offsetbytes = BitConverter.GetBytes(QuaternionX);
            Array.Reverse(offsetbytes, 0, offsetbytes.Length);
            QuaternionX = BitConverter.ToSingle(offsetbytes, 0);

            float QuaternionY = BitConverter.ToSingle(mreader.ReadMemory((IntPtr)(0x7FFF0000 + (PosPointer - 0x80000000) + 0x88 + 4), 4, out bytesOut), 0);
            offsetbytes = BitConverter.GetBytes(QuaternionY);
            Array.Reverse(offsetbytes, 0, offsetbytes.Length);
            QuaternionY = BitConverter.ToSingle(offsetbytes, 0);

            float QuaternionZ = BitConverter.ToSingle(mreader.ReadMemory((IntPtr)(0x7FFF0000 + (PosPointer - 0x80000000) + 0x88 + 8), 4, out bytesOut), 0);
            offsetbytes = BitConverter.GetBytes(QuaternionZ);
            Array.Reverse(offsetbytes, 0, offsetbytes.Length);
            QuaternionZ = BitConverter.ToSingle(offsetbytes, 0);

            float QuaternionW = BitConverter.ToSingle(mreader.ReadMemory((IntPtr)(0x7FFF0000 + (PosPointer - 0x80000000) + 0x88 + 12), 4, out bytesOut), 0);
            offsetbytes = BitConverter.GetBytes(QuaternionW);
            Array.Reverse(offsetbytes, 0, offsetbytes.Length);
            QuaternionW = BitConverter.ToSingle(offsetbytes, 0);


            // Quaternion to Euler

            float qx = QuaternionX;
            float qy = QuaternionY;
            float qz = QuaternionZ;
            float qw = QuaternionW;
            float qw2 = qw * qw;
            float qx2 = qx * qx;
            float qy2 = qy * qy;
            float qz2 = qz * qz;
            float h = (float)Math.Atan2(1 - 2 * qy2 - 2 * qz2, 2 * qy * qw - 2 * qx * qz);
            float a = (float)Math.Asin(2 * qx * qy + 2 * qz * qw);
            float b = (float)Math.Atan2(1 - 2 * qx2 - 2 * qz2, 2 * qx * qw - 2 * qy * qz);
            float Yvalue = (h * 180 / (float)Math.PI);
            float Zvalue = (a * 180 / (float)Math.PI);
            float Xvalue = (b * 180 / (float)Math.PI);
            Yvalue = Yvalue + 180;
            Xvalue = Xvalue - 90;

            while (Yvalue > 360)
                Yvalue -= 360;
            while (Yvalue < 0)
                Yvalue += 360;

            while (Zvalue > 360)
                Zvalue -= 360;
            while (Zvalue < 0)
                Zvalue += 360;

            while (Xvalue > 360)
                Xvalue -= 360;
            while (Xvalue < 0)
                Xvalue += 360;

            lblXRot.Text = Xvalue.ToString() + "°";
            lblYRot.Text = Yvalue.ToString() + "°";
            lblZRot.Text = Zvalue.ToString() + "°";

            GameID = BitConverter.ToInt64(mreader.ReadMemory((IntPtr)(0x7FFF0000), 8, out bytesOut), 0);
            byte[] bytes = BitConverter.GetBytes(GameID);

            label1.Text = Encoding.ASCII.GetString(bytes);

            if (label1.Text == "RMCE01")
            {
                comboBox1.SelectedItem = "NTSC-U";
            }
            if (label1.Text == "RMCP01")
            {
                comboBox1.SelectedItem = "PAL";
            }
            if (label1.Text == "RMCJ01")
            {
                comboBox1.SelectedItem = "NTSC-J";
            }
            if (label1.Text == "RMCK01")
            {
                comboBox1.SelectedItem = "NTSC-K";
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
