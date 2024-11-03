// See https://aka.ms/new-console-template for more information
using System;

namespace ComputerBuilderExample;

public class Computer {

	//required parameters
	public string RAM { get; }  
	public string HDD { get; }
	public string CPU { get; }
	
	
	//optional parameters
	public bool isGraphicsCardEnabled { get; }
	public bool isBluetoothEnabled { get; }
	
	private Computer(Builder builder) {
		HDD = builder.HDD;
		CPU = builder.CPU;
		RAM = builder.RAM;
		isBluetoothEnabled = builder.isBluetoothEnabled;
		isGraphicsCardEnabled = builder.isGraphicsCardEnabled;
	}

    public string toString() {
        return " CPU: " + CPU + " RAM: " + RAM + " HDD: " + HDD;
    }
	
	public class Builder{
		//required parameters
		public string RAM { get; }
		public string HDD { get; }
		public string CPU { get; }
		
		
		//optional parameters
		public bool isGraphicsCardEnabled { get; private set; }
		public bool isBluetoothEnabled { get; private set; }
		
		public Builder(String ram, String hdd, String cpu) {
			RAM = ram;
			HDD = hdd;
			CPU = cpu;
		}

		public Builder setGraphicsCardEnabled(bool isGraphicsCardEnabled) {
			this.isGraphicsCardEnabled = isGraphicsCardEnabled;
			return this;
		}

		public Builder setBluetoothEnabled(bool isBluetoothEnabled) {
			this.isBluetoothEnabled = isBluetoothEnabled;
			return this;
		}
		
		public Computer build() {
			return new Computer(this);
		}
	}
}

class Program
{
    static void Main(string[] args)
    {
        Computer computer1 = new Computer.Builder("16GB", "1TB", "Intel i7")
                                .setGraphicsCardEnabled(true)
                                .build();

        Console.WriteLine(computer1.toString());
    }
}