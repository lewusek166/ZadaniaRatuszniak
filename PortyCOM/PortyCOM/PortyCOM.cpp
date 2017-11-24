// PortyCOM.cpp : main project file.

#include "stdafx.h"

#using <System.dll>

using namespace System;
using namespace System::IO::Ports;
using namespace System::Threading;


#pragma pack(1)
typedef struct Ramka
{

	unsigned __int8  AdresUrzadzenia;
	unsigned __int16  Nr_komendy;
	unsigned __int16  Info_Ilosc_danych;
	unsigned __int8 dane[9];//dane nie beda wysylane i slave na nie ma nie czekac 
	unsigned __int16 Wartosc_Ustaona;
	unsigned __int16  Suma_kontrolna;

};


void ustawienia(Ramka ramka) {
	
	ramka.AdresUrzadzenia = 0xff;
	ramka.Nr_komendy = 0xC824;
	ramka.Info_Ilosc_danych = 0;
	ramka.dane[0] = 0;
	ramka.dane[1] = 0;
	ramka.dane[2] = 0;
	ramka.dane[3] = 0;
	ramka.dane[4] = 0;
	ramka.dane[5] = 0;
	ramka.dane[6] = 0;
	ramka.dane[7] = 0;
	ramka.dane[8] = 0;
	ramka.Wartosc_Ustaona = 0xA55A;
	ramka.Suma_kontrolna =
		ramka.AdresUrzadzenia |
		ramka.Nr_komendy |
		ramka.Info_Ilosc_danych |
		ramka.dane[0] | ramka.dane[1] | ramka.dane[2] | //dodawanie bitowe
		ramka.dane[3] | ramka.dane[4] | ramka.dane[5] |
		ramka.dane[6] | ramka.dane[7] | ramka.dane[8] |
		ramka.Wartosc_Ustaona;
}


public ref class PortChat
{
private:
	static bool _continue;
	static SerialPort^ _serialPort;
	
public:
	
	void DaneDoWyslaniaZapytanie(
		unsigned __int8 Adres,
		unsigned __int8 Komenda,
		unsigned __int8 info,
		unsigned __int8 Wartosc,
		unsigned __int8 suma);
	static void PortCom();
	static String^ SetPortName(String^ defaultPortName);
	static void Read();
	

};


void PortChat::DaneDoWyslaniaZapytanie(unsigned __int8 Adres, unsigned __int8 Komenda, unsigned __int8 info, unsigned __int8 Wartosc, unsigned __int8 suma)
{	
	Adres =
}

void PortChat::PortCom()
{


	ustawienia();

	String^ message;
	StringComparer^ stringComparer = StringComparer::OrdinalIgnoreCase;
	Thread^ readThread = gcnew Thread(gcnew ThreadStart(PortChat::Read));
	//ustawienia portu szeregowego
	_serialPort = gcnew SerialPort();
	_serialPort->PortName = SetPortName(_serialPort->PortName);
	_serialPort->ReadTimeout = 500;
	_serialPort->WriteTimeout = 500;
	_serialPort->Open();
	_continue = true;
	readThread->Start();



	Console::WriteLine("Type QUIT to exit");

	while (_continue)
	{
		message = Console::ReadLine();

		if (stringComparer->Equals("quit", message))
		{
			_continue = false;
		}
		else
		{

			_serialPort->Write(ramka.AdresUrzadzenia +
				ramka.Nr_komendy +
				ramka.Info_Ilosc_danych +
			);
		}
	}

	readThread->Join();
	_serialPort->Close();
}

String ^ PortChat::SetPortName(String ^ defaultPortName)
{
	
		String^ portName;

		Console::WriteLine("Available Ports:");
		for each (String^ s in SerialPort::GetPortNames())
		{
			Console::WriteLine("   {0}", s);
		}

		Console::Write("Enter COM port value (Default: {0}): ", defaultPortName);
		portName = Console::ReadLine();

		if (portName == "")
		{
			portName = defaultPortName;
		}
		return portName;
	}

void PortChat::Read()
{
	
		while (_continue)
		{
			try
			{
				String^ message = _serialPort->ReadLine();
				Console::WriteLine(message);
			}
			catch (TimeoutException ^) {}
		}
	}



int main()
{
	PortChat::PortCom();
}



