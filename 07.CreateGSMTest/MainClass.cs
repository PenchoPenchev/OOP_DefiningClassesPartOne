/*7. Write a class GSMTest to test the GSM class:
 * Create an array of few instances of the GSM class.
 * Display the information about the GSMs in the array.
 * Display the information about the static property IPhone4S.
*/

/*9. Add a property CallHistory in the GSM class to hold a list of the performed calls. Try to use the system class List<Call>.*/

/*10. Add methods in the GSM class for adding and deleting calls from the calls history. Add a method to clear the call history.*/

/*11. Add a method that calculates the total price of the calls in the call history. 
 * Assume the price per minute is fixed and is provided as a parameter.*/

namespace _07.CreateGSMTest
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    class MainClass
    {
        static void Main()
        {
            GSMTest gsmTest = new GSMTest();
            gsmTest.AddGsmInTheList();
            gsmTest.PrintAllGSMs();

            GSMCallHistoryTest test = new GSMCallHistoryTest();
            test.TestGSMCallHistory();
        }
    }

    public enum BatteryType
    {
        LiIon,
        NiMH,
        NiCd
    }

    public class Battery
    {
        private string model;
        private double? hoursIdle;
        private double? hoursTalk;
        private BatteryType type;

        public Battery()
        {

        }

        public Battery(string model)
        {
            this.Model = model;
        }

        public Battery(string model, double? hoursIdle)
            : this(model)
        {
            this.HoursIdle = hoursIdle;
        }

        public Battery(string model, double? hoursIdle, double? hoursTalk)
            : this(model, hoursIdle)
        {
            this.HoursTalk = hoursTalk;
        }

        public Battery(string model, double? hoursIdle, double? hoursTalk, BatteryType type)
            : this(model, hoursIdle, hoursTalk)
        {
            this.Type = type;
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public double? HoursIdle
        {
            get { return hoursIdle; }
            set { hoursIdle = value; }
        }

        public double? HoursTalk
        {
            get { return hoursTalk; }
            set { hoursTalk = value; }
        }

        public BatteryType Type
        {
            get { return type; }
            set { type = value; }
        }
    }

    public class Display
    {
        private double? size;
        private int? numberOfColors;

        public Display()
        {

        }

        public Display(double? size)
        {
            this.Size = size;
        }

        public Display(double? size, int? numberOfColors)
            : this(size)
        {
            this.NumberOfColors = numberOfColors;
        }

        public double? Size
        {
            get { return size; }
            set { size = value; }
        }

        public int? NumberOfColors
        {
            get { return numberOfColors; }
            set { numberOfColors = value; }
        }
    }
}
