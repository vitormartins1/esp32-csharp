using System;
using System.Device.Gpio;
using System.Diagnostics;
using System.Threading;

var gpioController = new GpioController();
var ledPin = gpioController.OpenPin(2, PinMode.Output);

while (true)
{
    ledPin.Toggle();
    Thread.Sleep(1000);
}

//namespace nanoframework_playground {
//    public class Program {
//        public static void Main() {
//            Debug.WriteLine("Hello from nanoFramework!");

//            Thread.Sleep(Timeout.Infinite);

//            // Browse our samples repository: https://github.com/nanoframework/samples
//            // Check our documentation online: https://docs.nanoframework.net/
//            // Join our lively Discord community: https://discord.gg/gCyBu8T
//        }
//    }
//}
