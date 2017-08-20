using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace COMDBG
{
    public interface IView
    {
        void SetController(Controller controller);
        //Open serial port event
        void OpenComEvent(Object sender, SerialPortEventArgs e);
        //Close serial port event
        void CloseComEvent(Object sender, SerialPortEventArgs e);
        //Serial port receive data event
        void ComReceiveDataEvent(Object sender, SerialPortEventArgs e);
    }
}
