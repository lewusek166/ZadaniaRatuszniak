// SerializacjaRamka.cpp : main project file.

#include "stdafx.h"
#include <iostream>


using namespace System;
using namespace System::IO;
using namespace System::Collections;
using namespace System::Runtime::Serialization::Formatters::Binary;
using namespace System::Runtime::Serialization;

void Rozmiar_Typow() {

	std::cout << "sizeof(bool) = " << sizeof(bool) << std::endl;
	std::cout << "sizeof(char) = " << sizeof(char) << std::endl;
	std::cout << "sizeof(unsigned char) = " << sizeof(unsigned char) << std::endl;
	std::cout << "sizeof(wchar_t) = " << sizeof(wchar_t) << std::endl;
	std::cout << "sizeof(short) = " << sizeof(short) << std::endl;
	std::cout << "sizeof(unsigned short) = " << sizeof(unsigned short) << std::endl;
	std::cout << "sizeof(int) = " << sizeof(int) << std::endl;
	std::cout << "sizeof(unsigned int) = " << sizeof(unsigned int) << std::endl;
	std::cout << "sizeof(long) = " << sizeof(long) << std::endl;
	std::cout << "sizeof(unsigned long) = " << sizeof(unsigned long) << std::endl;
	std::cout << "sizeof(long long) = " << sizeof(long long) << std::endl;
	std::cout << "sizeof(float) = " << sizeof(float) << std::endl;
	std::cout << "sizeof(double) = " << sizeof(double) << std::endl;
	std::cout << "sizeof(long double) = " << sizeof(long double) << std::endl;

}


typedef struct Ramka
{
	//wielko�� poszczeg�lnych kom�rek ramki ????	
	Byte  AdresUrzadzenia;	   //int AdresUrzadzenia;		 
	Byte  Info_Ilosc_danych[1];   //int Info_Ilosc_danych;	 
	Byte  Wartosc_Ustaona[1];     //int Wartosc_Ustaona;		 
	Byte  Nr_komendy[1];          //int Nr_komendy;			
	Byte  ilosc_bajtow_danych[1];  //int ilosc_bajtow_danych;	 
	Byte  Suma_kontrolna;       //int Suma_kontrolna;

}Ramka;


void przygotowanie_danych(Ramka ramka) {
	///suma kontrolna 
	ramka.Suma_kontrolna =  sizeof(ramka.AdresUrzadzenia +
		ramka.ilosc_bajtow_danych[0] +
		ramka.ilosc_bajtow_danych[1] +
		ramka.Info_Ilosc_danych[0] +
		ramka.Info_Ilosc_danych[1] +
		ramka.Nr_komendy[0] +
		ramka.Nr_komendy[1] +
		ramka.Wartosc_Ustaona[0] +
		ramka.Wartosc_Ustaona[1]);

	




	}
	

void Serializacja() {
//zapis do pliku bo nie wiem do konca jakiego strumienia u�y�
	//najpewniej strumienia z klasy serial Port
	FileStream^ file = gcnew FileStream("DataFile.dat", FileMode::Create);
	BinaryFormatter^ formater = gcnew BinaryFormatter;
	try
	{
		formater->Serialize(file, zmienna_zdanymi);///tutaj nie wiem czy byte czy char
	}
	catch (SerializationException^ e)
	{
		file->Close();
			
	}
 
}
////po stronie slave to smo musi byc 
void deserializacja() {

	FileStream^ file = gcnew FileStream("DataFile.dat", FileMode::Open);
	BinaryFormatter^ formater = gcnew BinaryFormatter;
	try
	{
		formater->Serialize(file, zmienna_zdanymi);///tutaj nie wiem czy byte czy char
	}
	catch (SerializationException^ e)
	{
		file->Close();

	}
}




int main()
{
	Ramka* nowaRamka = new Ramka;
	nowaRamka->AdresUrzadzenia = 0xFF;
	

	

    return 0;
}


