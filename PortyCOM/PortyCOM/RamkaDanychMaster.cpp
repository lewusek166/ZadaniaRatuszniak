

#include "stdafx.h"

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


void ustawienia() {
	Ramka ramka;
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