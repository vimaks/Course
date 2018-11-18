using System;

namespace Hello_Class_stud
{
    //Implement class Morse_matrix derived from String_matrix, which realize IMorse_crypt
    class Morse_matrix : String_matrix, IMorse_crypt
    {
        public const int Size_2 = Alphabet.Size;
        private int offset_key = 0;
        //Implement Morse_matrix constructor with the int parameter for offset
        //Use fd(Alphabet.Dictionary_arr) and sd() methods
        public Morse_matrix()
        {
            fd(Alphabet.Dictionary_arr);
            sd();
        }

        public Morse_matrix(int offset)
        {
            offset_key = offset;
            fd(Alphabet.Dictionary_arr);
            sd();
        }
        //Implement Morse_matrix constructor with the string [,] Dict_arr and int parameter for offset
        //Use fd(Dict_arr) and sd() methods
        public Morse_matrix(string [,] Dict_arr, int offset)
        {
            offset_key = offset;

            fd(Dict_arr);
            sd();
        }



        private void fd(string[,] Dict_arr)
        {
            for (int ii = 0; ii < Size1; ii++)
                for (int jj = 0; jj < Size_2; jj++)
                    this[ii, jj] = Dict_arr[ii, jj];
        }


        private  void sd()
        {
            int off = Size_2 - offset_key;
            for (int jj = 0; jj < off; jj++)
                this[1, jj] = this[1, jj + offset_key];
            for (int jj = off; jj < Size_2; jj++)
                this[1, jj] = this[1, jj - off];
        }
        /*
        //Implement Morse_matrix operator +
        public static Morse_matrix operator +(Morse_matrix arg1, Morse_matrix arg2)
        {
            Morse_matrix resMatrix = new Morse_matrix[arg1.GetLength(0), arg2.GetLength(1)];

            for (int i = 0; i < arg2.GetLength(0); i++)
                for (int j = 0; j < arg2.GetLength(1); j++)
                    resMatrix[i, j] = arg1[i, j] + arg2[i, j];

            return resMatrix;
        }
        */
        //Realize crypt() with string parameter
        //Use indexers
        public string crypt(string s)
        {
            return s;
        }
        //Realize decrypt() with string array parameter
        //Use indexers
        public string decrypt(string[] array)
        {
            return "decrypt";
        }
        //Implement Res_beep() method with string parameter to beep the string

        public void Res_beep(string s)
        {

        }
    }
}

