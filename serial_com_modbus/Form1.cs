using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;
using EasyModbus;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using EasyModbus.Exceptions;
using System.Threading;
using System.Net;
using System.Reflection.Emit;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Net.WebRequestMethods;
using System.Configuration;



namespace serial_com_modbus
{
    public partial class Form1 : Form
    {
        
        //private SerialPort serialPort1 = null;

        string dataOUT;
        //string dataIN;
        StreamWriter objStreamWriter;
        string pathfile = @"D:\My Source File\SerialData.txt";



        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-1607PLPM\\SQLEXPRESS;Initial Catalog=Alicat_final;Persist Security Info=True;User ID=Kirtika;Password=kirt5802");
        //Integrated Security = False;
        DataGridView dataGridView1 = new DataGridView();

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            cBoxCOMPORT.Items.AddRange(ports);
            string[] s = Enum.GetNames(typeof(Handshake));
            txtFlowControl.Items.AddRange(s);
            LoadRecord();

        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = cBoxCOMPORT.Text;
                serialPort1.BaudRate = Convert.ToInt32(cBoxBAUDRATE.Text);
                serialPort1.DataBits = Convert.ToInt32(cDATAbits.Text);
                serialPort1.StopBits = (StopBits)Enum.Parse(typeof(StopBits), cSTOPbits.Text);
                serialPort1.Parity = (Parity)Enum.Parse(typeof(Parity), cPARITYbits.Text);
                IPAddress address = IPAddress.Parse(txtUnitID.Text);
                serialPort1.Handshake = (Handshake)Enum.Parse(typeof(Handshake), txtFlowControl.Text, true);
                serialPort1.Open();
                progressBar1.Value = 100;


            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                progressBar1.Value = 0;
            }

        }


       

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }



        private void label5_Click_1(object sender, EventArgs e)
        {


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {



        }

        private void txtFlowControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            //FlowControl flowControl = (FlowControl)txtFlowControl.SelectedItem;
        }
        

        

        

        private void txtGas_TextChanged(object sender, EventArgs e)
        {
            //txtGas.Text = Console.Write("MFC" + txtUnitID.Text);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        enum Anticorrosive
        {
            Air,
            Ar,
            CH4,
            CO,
            CO2,
            C2H6,
            H2
        }
        enum Corrosive
        {
            NH3,
            Butylene,
            cButene,
            iButene,
            tButene,
            COS,
            Cl2,
            CH3OCH3,
            H2S,
            NF3,
            NO,
            C3H6,
            SiH4,
            SO2
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int SrNo = int.Parse(txtSrNo.Text);
            string comPort = cBoxCOMPORT.Text;
            int baudRate = int.Parse(cBoxBAUDRATE.Text);
            int databits = int.Parse(cDATAbits.Text);
            string startbits = cSTARTbits.Text;

            string stopbits = cSTOPbits.Text;
            string parity = cPARITYbits.Text;
            string device = cBoxDevice.Text;
            string UnitID = txtUnitID.Text;
            string gas = cBoxGas.Text;
            string flowcontrol = txtFlowControl.Text;
            string model = cBoxModel.Text;
            string session = cBoxType.Text;
            


            //SqlConnection con = new SqlConnection("Data Source=LAPTOP-1607PLPM\\SQLEXPRESS;Initial Catalog=Alicat_final;Persist Security Info=True;User ID=Kirtika;Password=kirt5802");
            con.Open();
            SqlCommand comm = new SqlCommand("Save in Tab('" + SrNo + "','" + comPort + "','" + baudRate + "','" + databits + "','" + startbits + "','" + stopbits + "','" + parity + "','" + device + "','" + UnitID + "','" + gas + "' ,'" + flowcontrol + "','" + model + "','" + session + "')", con);
            comm.ExecuteNonQuery();
            con.Close();
           
            MessageBox.Show("Saved");
            LoadRecord();
        }
        void LoadRecord()
        {
            SqlCommand comm = new SqlCommand("select * from Tab", con);
            SqlDataAdapter d=new SqlDataAdapter(comm);
            DataTable dt=new DataTable();
            d.Fill(dt);
            dataGridView1.DataSource = dt;
        }


        private void cBoxType_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure to delete? ", "Delete Document", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                //SqlConnection con = new SqlConnection("Data Source=LAPTOP-1607PLPM\\SQLEXPRESS;Initial Catalog=Aliact_final;Persist Security Info=True;User ID=Kirtika;Password=***********");
                con.Open();
                SqlCommand comm = new SqlCommand("Delete SessionInfo where SessionName= '" + cBoxType.Text + "'", con);
                comm.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Deleted");
                LoadRecord();
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand comm = new SqlCommand("Delete SessionInfo where SessionName= '" + cBoxType.Text + "'", con);
            SqlDataReader r = comm.ExecuteReader();
            while (r.Read())
            {
                cBoxCOMPORT.Text = r.GetValue(1).ToString();
                cBoxBAUDRATE.Text = r.GetValue(2).ToString();
                cDATAbits.Text = r.GetValue(3).ToString();
                cSTARTbits.Text = r.GetValue(4).ToString();
                cSTOPbits.Text = r.GetValue(5).ToString();
                cPARITYbits.Text = r.GetValue(6).ToString();
                txtUnitID.Text = r.GetValue(7).ToString();
                cBoxGas.Text = r.GetValue(8).ToString();
                txtFlowControl.Text = r.GetValue(9).ToString();



            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://google.com/search?q="+ cBoxDevice.Text +" " +cBoxModel.Text );
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click_2(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void cBoxCOMPORT_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cBoxBAUDRATE_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnWriteSingleRegister_Click(object sender, EventArgs e)
        {
            
        }
        private byte[] WriteSingleRegisterMsg(byte slaveAddress, ushort startAddress, byte functionCode, byte[] values)
        {
            byte[] frame = new byte[8]; // Message size
            frame[0] = slaveAddress; // Slave address
            frame[1] = functionCode; // Function code            
            frame[2] = (byte)(startAddress >> 8); // Register Address Hi
            frame[3] = (byte)startAddress; // Register Address lo
            Array.Copy(values, 0, frame, 4, values.Length); // Write Data
            byte[] crc = this.CalculateCRC(frame); // Calculate CRC
            frame[frame.Length - 2] = crc[0]; //Error Check Lo
            frame[frame.Length - 1] = crc[1]; //Error Check Hi
            return frame;
        }

        /// <summary>
        /// CRC Calculation 
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        private byte[] CalculateCRC(byte[] data)
        {
            ushort CRCFull = 0xFFFF; // Set the 16-bit register (CRC register) = FFFFH.
            byte CRCHigh = 0xFF, CRCLow = 0xFF;
            char CRCLSB;
            byte[] CRC = new byte[2];
            for (int i = 0; i < (data.Length) - 2; i++)
            {
                CRCFull = (ushort)(CRCFull ^ data[i]); // 

                for (int j = 0; j < 8; j++)
                {
                    CRCLSB = (char)(CRCFull & 0x0001);
                    CRCFull = (ushort)((CRCFull >> 1) & 0x7FFF);

                    if (CRCLSB == 1)
                        CRCFull = (ushort)(CRCFull ^ 0xA001);
                }
            }
            CRC[1] = CRCHigh = (byte)((CRCFull >> 8) & 0xFF);
            CRC[0] = CRCLow = (byte)(CRCFull & 0xFF);
            return CRC;
        }

        /// <summary>
        /// Convert UInt16 to byte array
        /// </summary>
        /// <param name="value">UInt16</param>
        /// <returns>byte[]</returns>
        public static byte[] ToByteArray(UInt16 value)
        {
            byte[] array = BitConverter.GetBytes(value);
            Array.Reverse(array);
            return array;
        }

        /// <summary>
        /// Display Data
        /// </summary>
        /// <param name="data">Data</param>
        /// <returns>Message</returns>
        private string Display(byte[] data)
        {
            string result = string.Empty;
            foreach (byte item in data)
            {
                result += string.Format("{0:X2}", item);
            }
            return result;
        }


        private void txtSendMsg_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnWriteSingleRegister_Click_1(object sender, EventArgs e)
        {
            
            try
            {
                byte slaveAddress = Convert.ToByte(slvAdd.Text);
                byte function = 6;
                ushort startAddress = 00000;
                ushort value = (ushort)txtValue.Value;
                if (serialPort1.IsOpen)
                {
                    byte[] frame = WriteSingleRegisterMsg(slaveAddress, startAddress, function, ToByteArray(value));
                    txtSendMsg.Text = Display(frame);
                    serialPort1.Write(frame, 0, frame.Length);
                    Thread.Sleep(100); // Delay 100ms
                    if (serialPort1.BytesToRead >= 5)
                    {
                        byte[] bufferReceiver = new byte[this.serialPort1.BytesToRead];
                        serialPort1.Read(bufferReceiver, 0, serialPort1.BytesToRead);
                        serialPort1.DiscardInBuffer();
                        txtReceiMsg.Text = Display(bufferReceiver);
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void slvAdd_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtValue_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtReceiMsg_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txtSendMsg_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void SlvAddText_Click(object sender, EventArgs e)
        {

        }
    }
}
