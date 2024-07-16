using System;

namespace SampleConApp{
    class Machine{
            public RegistorDevice {get; ,set;}
            public updtaeDeviceDetails {get; ,set;}
            public  GetAllRegistoredDevice{get; ,set;}
            public RegistorDevice{get; ,set;}
        public override string ToString(){
            return string.Format("the SIno is {0} and the make is {1} very inp model is (2) the cots is (3) and the price is {4}",
            this.SINo,this.Make,this.Model,this.Price);
        }
    
    }
    class MachineDatabase{
        private void RegistorDevice(Machine mac) {
                while(true){
            System.Console.WriteLine("enter the details of the device you want");
            System.Console.WriteLine("sino: ");
            string sino = Console.ReadLine();

            System.Console.WriteLine("make: ");
            string make = Console.ReadLine();

            System.Console.WriteLine("model: ");
            string model = Console.ReadLine();

            System.Console.WriteLine("price:");
            int price = Console.ReadLine();
            Machine newMachine = new Machine{ Name = name, Make = make,Model = model,Price = price }
            machine.Add(newMachine);
                }
        }
    public Machine(string sino , string make,string model,int price){
        Name = name;
        Make = make;
        Model = model;
        Price = price;
    }
    public void updtaeDeviceDetails(string sino, Machine mac){
        System.Console.WriteLine("enter the name of the  device to update ");
        var device = device.Find(d=> name == name);
        if (device!=null)
        {
            device.name = newName;
            device.make = newmake;
            device.model = newModel;
            device.price = newPrice;
            System.Console.WriteLine("deviec updated succesfully");
        }
        else
        {
            System.Console.WriteLine("device not found ");
        }
    }

    public List<Machine> GetAllRegistoredDevice(){
            return devices;
    }
    static void Main(string[] args)
    {
        RegistorDevice();
    }

    }
}