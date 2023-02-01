// See https://aka.ms/new-console-template for more information
using RBA_SDK;

SETTINGS_COMMUNICATION CommSet = new SETTINGS_COMMUNICATION();

// Set comm timeouts. Higher values will not decrease the communication speed but ensures that all messages are received in relatively slower environment.
SETTINGS_COMM_TIMEOUTS comm_timeouts;
uint commTimeouts = 5000;

comm_timeouts.ConnectTimeout = commTimeouts;
comm_timeouts.ReceiveTimeout = commTimeouts;
comm_timeouts.SendTimeout = commTimeouts;
RBA_API.SetCommTimeouts(comm_timeouts);

CommSet.interface_id = (uint)COMM_INTERFACE.SERIAL_INTERFACE;
//CommSet.rs232_config.ComPort = "COM7";
CommSet.rs232_config.ComPort = "COM9";
CommSet.rs232_config.BaudRate = (uint)115200;
CommSet.rs232_config.DataBits = (uint)8;
CommSet.rs232_config.Parity = (uint)0;
CommSet.rs232_config.StopBits = (uint)1;
CommSet.rs232_config.FlowControl = (uint)0;

//Connect to pin pad
var Result = RBA_API.Connect(CommSet);
