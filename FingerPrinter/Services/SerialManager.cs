using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FingerPrinter.Services
{
    public class SerialManager
    {
        private static SerialManager? _instance;
        private SerialPort _serialPort;
        public SerialPort SerialPort => _serialPort;
        public event Action<string> DataReceived;

        private SerialManager() { 
            _serialPort = new SerialPort(); 
            _serialPort.DataReceived += OnDataReceived;
        }

        public static SerialManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SerialManager();
                }
                return _instance;
            }
        }

        public void Connect(string portName, int baudRate)
        {
            if (!_serialPort.IsOpen)
            {
                _serialPort.PortName = portName;
                _serialPort.BaudRate = baudRate;
                _serialPort.Open();
            }
        }

        public void Disconnect()
        {
            if (_serialPort.IsOpen)
            {
                _serialPort.Close();
            }
        }

        public void SendCommand(string command)
        {
            if (_serialPort.IsOpen)
            {
                _serialPort.WriteLine(command);
            }
        }

        public string GetPortName()
        {
            return _serialPort.IsOpen ? _serialPort.PortName : "No port connected";
        }

        public int GetBaudrate()
        {
            return _serialPort.IsOpen ? _serialPort.BaudRate : 9600;
        }

        public string[] GetAvailablePortNames()
        {
            return SerialPort.GetPortNames();
        }

        private void OnDataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                string data = _serialPort.ReadExisting();
                DataReceived?.Invoke(data);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error reading serial data: " + ex.Message);
            }
        }
    }
}
