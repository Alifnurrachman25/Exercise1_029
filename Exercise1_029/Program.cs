using System;

namespace Exercise1_029
{
    class Program //membuat class program
    {
        //deklarasi array int dengan ukuran 49
        private int[] alif = new int[49];

        //deklarasi variabel int untuk menyimpan banyaknya data pada array
        private int n;

        //fungsi / method untuk menerima masukan
        public void read()
        {
            //menerima angka untuk menentukan banyaknya data yang disimpan pada array
            while (true)
            {
                Console.Write("Masukkan banyaknya elemen pada array"); //membuat teks "Masukkan banyaknya elemen pada array"
                string s = Console.ReadLine(); //membaca s sebagai string
                n = Int32.Parse(s); //merubah perwakilan string yang merupakan angka ke 32 bit integer
                if (n <= 49) //memakai metode if else untuk ukuran kurang dari sama dengan 49
                    break;
                else //memakai metode if else jika user memasukkan lebih dari 49 elemen akan keluar teks
                    Console.WriteLine("\nArray dapat mempunyai maksimal 49 elemen. \n"); //membuat teks "Array dapat mempunyai maksimal 49 elemen."
            }
            Console.WriteLine(""); // membuat space kosong
            Console.WriteLine("------------------------------"); // membuat batasan garis
            Console.WriteLine(" Masukkan elemen array "); //membuat teks " Masukkan elemen array "
            Console.WriteLine("------------------------------"); // membuat batasan garis

            //pengguna memasukkan elemen pada array
            for (int i = 0; i < n; i++)
            {
                Console.Write("<" + ( i+1 ) + ">" );
                string s1 = Console.ReadLine();
                alif[i] = Int32.Parse(s1);

            }
        }
        //fungsi / method untuk menampilkan
        public void display()
        {
            //menampilkan array yang tersusun
            Console.WriteLine(""); //membuat space kosong
            Console.WriteLine("------------------------------------"); //membuat batasan garis
            Console.WriteLine(" Elemen array yang telah tersusun "); //membuat teks " Elemen array yang telah tersusun "
            Console.WriteLine("------------------------------------"); //membuat batasan garis
            for (int ar = 0; ar < n; ar++)
            {
                Console.WriteLine(alif[ar]);
            }
            Console.WriteLine(""); //membuat space kosong
        }
        
        //fungsi / method untuk bubblesort array
        public void BubbleSortArray ()
        {
            for(int i = 1; i < n; i++)// untuk n - 1 passes
            {
                //pada pass i,bandingkan n - i elemen pertama dengan elemen selanjutnya
                for (int ar = 0; ar < n - i; ar++)
                {
                    if (alif[ar] > alif[ar + 1]) //jika elemen tidak dalam urutan yang benar
                    {
                        //tukar elemen
                        int temp; //membuat temporary
                        temp = alif[ar]; //mendeklarasikan alif[ar]; sebagai temporary
                        alif[ar] = alif[ar + 1]; //memindahkan alif[ar + 1] ke posisi alif[ar] yang dimana sebagai temporary
                        alif[ar + 1] = temp; // alif[ar + 1] sudah berada di posisi alif[ar] yang dimana sebagai temporary
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            //membuat objek dari bubblesort class
            Program myList = new Program();

            //pemanggilan fungsi untuk menerima elemen array
            myList.read();

            //pemanggilan fungsi untuk mengurutkan array
            myList.BubbleSortArray();

            //pemanggilan fungsi untuk menampilkan array yang tersusun
            myList.display();

            //Exit
            Console.WriteLine("\n\nTekan tombol apa saja untuk keluar.");
            Console.Read();
        }
    }
}
