using System;


namespace TypyDanych_Zajmowana_pamięc
{
    class BoxingUnboxing
    {
        // BOXING <== konwertowanie typu wartościowego na obiektowy
        int a = 10;
        object o = a;

        // UNBOXING <== konwertowanie obiektu na wartościowy

        int b = 223;
        object ob = b;
        int c = (int)o; //<== operacja rzutowania
    }
}
