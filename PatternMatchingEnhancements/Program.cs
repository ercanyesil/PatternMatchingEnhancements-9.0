using System;

namespace PatternMatchingEnhancements
{
    class Program
    {
        static void Main(string[] args)
        {
            //    simpleType();
            //    relational();
            //    logical();
            //    not();
        }


        // C# 9.0 Pattern Matching Enhancements

        #region Simple Type Pattern
        /*
        // Bir değişkenin içerisindekideğerin belirli bir türde olup olmadığını hızlı bir şekilde kontrol etmemizi sağlayan desendir.
        // (C# 9.0)'dan önce Type Pattern ile yapılan tür bildirimlerinin yanına değişken adı tanımlaması yahut discard ifadesinin kullanılması -->
        // zaruriydi. (C# 9.0) ile bu gereksiz zorunluluk ortadan kaldırılmış ve direkt olarak tür kontrol işlemine odaklanılması sağlanmıştır. 
        
        static void simpleType()
        {
            object obj = new Person();
            switch (obj)
            {
                case Person p: // Type Pattern ile yapılan tür bildirimlerinin yanına p gibi değişken adı tanımlamak gereklidir.
                    break;
            }

            object obj = new Person();
            switch (obj)
            {
                case Person: // p gibi bir değişken adı tanımlanmasına gerek yoktur.
                    break;
            }
        }
        */
        #endregion


        #region Relational Pattern
        // Desenlerde <,>,<= ve >= operatörleri switch expressions'da kullanmamızı sağlayan bir desendir.
        // Switch ile sadece eşitlik durumuna bakmaktayken artık Relational Pattern ile tüm karşılaştırma durumlarına bakabilmektedir.
        /*
        static void relational()
        {
            int number = 111;
            string result = number switch
            {
                < 50 => "50'den küçük",
                > 50 => "50'den büyük",
                _ => "Hiçbiri"
            };
        }
        */
        #endregion


        #region Logical Patterns
        // and, or ve not gib mantıksal operatörler kullanılabilmektedir. 
        // Relational Pattern ile oldukça uyumludur.
        /*
        static void logical()
        {
            int number = 60;
            string result = number switch
            {
                > 10 and < 50 => "10'dan büyük 50'den küçük",
                > 50 or < 100 and 60 => "50'den büyük veya 100'den küçük ve 60'a eşit",
                not 51 => "51 değil"
            };

            string GetProduct(IProduct p) => switch
            {
            Technologic or Computer => "Teknolojik",
            Goggles => "Gözlük"
            };
        }
        */
        #endregion


        #region Not Patterns
        // not operatörünün kullanılabildiği bir desendir.
        /*
        static void not()
        {
            string GetProduct(IProduct p) => p switch
            {
                Technologic => "Teknolojik",
                Computer => "Bilgisayar",
                not Goggles => "Gözlük"
            };

            object obj = new Goggles();
            if (obj is not Technologic)
            {
                //....
            }
        }
        */
        #endregion






    }
}
