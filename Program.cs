string user,type;
string pass;
//untuk ordermobil
string car;

Console.WriteLine("selamat datang di Dealer International");
Console.WriteLine("***************************************");
Console.WriteLine("masukan username =");
user = Console.ReadLine();

if(user=="Rayya"){
    Console.Write("Masukan Password =");
    pass = Console.ReadLine();
    if(pass=="22421012"){ //baris admin
        Console.WriteLine("Selamat Datang Rayya Rambu(admin)");
         Console.WriteLine();
         Console.WriteLine("Selamat Datang di Store");
         Console.WriteLine("************************");
         Console.WriteLine("Pilihan Mobil Untuk Anda");
         Console.WriteLine("1.Honda  kode=h0nd4");
         Console.WriteLine("2.Toyota kode=t0y0t4");
         Console.WriteLine("Masukan kode mobil =");
         car = Console.ReadLine();
         if(car=="h0nd4"){  //MERK honda
           Console.WriteLine("Pilihan Type Honda ");
           Console.WriteLine("---------------------");
           Console.WriteLine("1.Honda Civic R     kode=c1v1cr");
           Console.WriteLine("2.Honda Civic Turbo kode=c1v1ct");
           Console.WriteLine("---------------------");
           Console.WriteLine("Masukan Kode type mobil pilihan =");
           type = Console.ReadLine();
           if(type=="c1v1cr"){ //type honda
           double harga=1000000000;
           double potongan,diskon,total;

            Console.WriteLine("Honda Civic R");
            Console.WriteLine("...............");
            Console.WriteLine("Transmisi = MT");
            Console.WriteLine("Kapasitas = 5kursi");
            Console.WriteLine("Tenaga = 301hp");
            Console.WriteLine("Harga = Rp. "+harga);
            Console.WriteLine("+++++++++++++++++++++++++++");
            Console.WriteLine("Masukan Diskon =");
            diskon = double.Parse(Console.ReadLine());
            potongan = harga*diskon;
            Console.WriteLine("Anda mendapat potongan ="+potongan);
            Console.WriteLine("--------------------------------");
            total=harga-potongan;
            Console.WriteLine("Harga Mobil ="+total);
           }else if(type=="c1v1ct"){ //type honda
             double harga=500000000;
           double potongan,diskon,total;

            Console.WriteLine("Honda Civic Turbo");
            Console.WriteLine("...............");
            Console.WriteLine("Transmisi = CVT");
            Console.WriteLine("Kapasitas = 5kursi");
            Console.WriteLine("Tenaga = 171hp");
            Console.WriteLine("Harga = Rp. "+harga);
            Console.WriteLine("+++++++++++++++++++++++++++");
            Console.WriteLine("Masukan Diskon =");
            diskon = double.Parse(Console.ReadLine());
            potongan = harga*diskon;
            Console.WriteLine("Anda mendapat potongan ="+potongan);
            Console.WriteLine("--------------------------------");
            total=harga-potongan;
            Console.WriteLine("Harga Mobil ="+total);

           }else{ Console.WriteLine("Type mobil honda tidak tersedia"); }
        
           //pindah baris merk


        }else if(car=="t0yot4"){ //merk toyota
           Console.WriteLine("Pilihan Type Toyota ");
           Console.WriteLine("---------------------");
           Console.WriteLine("1.Toyota yaris    kode=y4r1s");
           Console.WriteLine("2.Toyota agya     kode=4gy4");
           Console.WriteLine("---------------------");
           Console.WriteLine("Masukan Kode type mobil pilihan =");
           type = Console.ReadLine();
           if(type=="y4r1s"){ //type toyota
           double harga=300000000;
           double potongan,diskon,total;

            Console.WriteLine("Toyota Yaris");
            Console.WriteLine("...............");
            Console.WriteLine("Transmisi = MT");
            Console.WriteLine("Kapasitas = 5kursi");
            Console.WriteLine("Tenaga = 106hp");
            Console.WriteLine("Harga = Rp. "+harga);
            Console.WriteLine("+++++++++++++++++++++++++++");
            Console.WriteLine("Masukan Diskon =");
            diskon = double.Parse(Console.ReadLine());
            potongan = harga*diskon;
            Console.WriteLine("Anda mendapat potongan ="+potongan);
            Console.WriteLine("--------------------------------");
            total=harga-potongan;
            Console.WriteLine("Harga Mobil ="+total);
           }else if(type=="4gy4"){ //type toyota
             double harga=150000000;
             double potongan,diskon,total;

            Console.WriteLine("Toyota Agya");
            Console.WriteLine("...............");
            Console.WriteLine("Transmisi = L");
            Console.WriteLine("Kapasitas = 5kursi");
            Console.WriteLine("Tenaga = 87hp");
            Console.WriteLine("Harga = Rp. "+harga);
            Console.WriteLine("+++++++++++++++++++++++++++");
            Console.WriteLine("Masukan Diskon =");
            diskon = double.Parse(Console.ReadLine());
            potongan = harga*diskon;
            Console.WriteLine("Anda mendapat potongan ="+potongan);
            Console.WriteLine("--------------------------------");
            total=harga-potongan;
            Console.WriteLine("Harga Mobil ="+total);

           }else{ Console.WriteLine("Type Mobil Toyota tidak tersedia");} //akhir pilihan type toyota
           
        }else{ //akhir pilihan merk
            Console.WriteLine("Merk Mobil tidak tersedia");
        }
//baris untuk userrr

    }else if(pass=="22421013"){
        Console.WriteLine("Selamat Datang Rayya Rambani(user)");
         Console.WriteLine();
         Console.WriteLine("Selamat Datang di Store");
         Console.WriteLine("************************");
         Console.WriteLine("Pilihan Mobil Untuk Anda");
         Console.WriteLine("1.Honda  kode=h0nd4");
         Console.WriteLine("2.Toyota kode=t0y0t4");
         Console.WriteLine("Masukan kode mobil =");
         car = Console.ReadLine();
         if(car=="h0nd4"){
           Console.WriteLine("Pilihan Type Honda ");
           Console.WriteLine("---------------------");
           Console.WriteLine("1.Honda Civic R     kode=c1v1cr");
           Console.WriteLine("2.Honda Civic Turbo kode=c1v1ct");
           Console.WriteLine("---------------------");
           Console.WriteLine("Masukan Kode type mobil pilihan =");
           type = Console.ReadLine();
           if(type=="c1v1cr"){ 
           double harga=1000000000;
           

            Console.WriteLine("Honda Civic R");
            Console.WriteLine("...............");
            Console.WriteLine("Transmisi = MT");
            Console.WriteLine("Kapasitas = 5kursi");
            Console.WriteLine("Tenaga = 301hp");
            Console.WriteLine("Harga = Rp. "+harga);
            Console.WriteLine("+++++++++++++++++++++++++++");
           
           }else if(type=="c1v1ct"){
             double harga=500000000;

            Console.WriteLine("Honda Civic Turbo");
            Console.WriteLine("...............");
            Console.WriteLine("Transmisi = CVT");
            Console.WriteLine("Kapasitas = 5kursi");
            Console.WriteLine("Tenaga = 171hp");
            Console.WriteLine("Harga = Rp. "+harga);
            Console.WriteLine("+++++++++++++++++++++++++++");
           }else{ Console.WriteLine("Type Mobil Honda tidak tersedia");}
           


        }else if(car=="t0yot4"){
           Console.WriteLine("Pilihan Type Toyota ");
           Console.WriteLine("---------------------");
           Console.WriteLine("1.Toyota yaris    kode=y4r1s");
           Console.WriteLine("2.Toyota agya     kode=4gy4");
           Console.WriteLine("---------------------");
           Console.WriteLine("Masukan Kode type mobil pilihan =");
           type = Console.ReadLine();
           if(type=="y4r1s"){
           double harga=300000000;
       

            Console.WriteLine("Toyota Yaris");
            Console.WriteLine("...............");
            Console.WriteLine("Transmisi = MT");
            Console.WriteLine("Kapasitas = 5kursi");
            Console.WriteLine("Tenaga = 106hp");
            Console.WriteLine("Harga = Rp. "+harga);
            Console.WriteLine("+++++++++++++++++++++++++++");
           
           }else if(type=="4gy4"){
             double harga=150000000;

            Console.WriteLine("Toyota Agya");
            Console.WriteLine("...............");
            Console.WriteLine("Transmisi = L");
            Console.WriteLine("Kapasitas = 5kursi");
            Console.WriteLine("Tenaga = 87hp");
            Console.WriteLine("Harga = Rp. "+harga);
            Console.WriteLine("+++++++++++++++++++++++++++");
           
           }else{ Console.WriteLine("Type Mobil Toyota tidak tersedia");}
        }else{ Console.WriteLine("Merk Mobil tidak tersedia");}
        
        

    }else{
        Console.WriteLine("User password error"); //userpassword rayya
    }

//baris arya

}else if(user=="arya"){
     Console.WriteLine("Masukan Password =");
    pass = Console.ReadLine();
    if(pass=="22421033"){ 
         Console.WriteLine("Selamat Datang Arya Maulana");
         Console.WriteLine();
         Console.WriteLine("Selamat Datang di Store");
         Console.WriteLine("************************");
         Console.WriteLine("Pilihan Mobil Untuk Anda");
         Console.WriteLine("1.Honda  kode=h0nd4");
         Console.WriteLine("2.Toyota kode=t0y0t4");
         Console.WriteLine("Masukan kode mobil =");
         car = Console.ReadLine();
        if(car=="h0nd4"){
           Console.WriteLine("Pilihan Type Honda ");
           Console.WriteLine("---------------------");
           Console.WriteLine("1.Honda Civic R     kode=c1v1cr");
           Console.WriteLine("2.Honda Civic Turbo kode=c1v1ct");
           Console.WriteLine("---------------------");
           Console.WriteLine("Masukan Kode type mobil pilihan =");
           type = Console.ReadLine();
           if(type=="c1v1cr"){ 
           double harga=1000000000;
           

            Console.WriteLine("Honda Civic R");
            Console.WriteLine("...............");
            Console.WriteLine("Transmisi = MT");
            Console.WriteLine("Kapasitas = 5kursi");
            Console.WriteLine("Tenaga = 301hp");
            Console.WriteLine("Harga = Rp. "+harga);
            Console.WriteLine("+++++++++++++++++++++++++++");
           
           }else if(type=="c1v1ct"){
             double harga=500000000;

            Console.WriteLine("Honda Civic Turbo");
            Console.WriteLine("...............");
            Console.WriteLine("Transmisi = CVT");
            Console.WriteLine("Kapasitas = 5kursi");
            Console.WriteLine("Tenaga = 171hp");
            Console.WriteLine("Harga = Rp. "+harga);
            Console.WriteLine("+++++++++++++++++++++++++++");
           }else{ Console.WriteLine("Type Mobil Honda tidak tersedia");}
           


        }else if(car=="t0y0t4"){
           Console.WriteLine("Pilihan Type Toyota ");
           Console.WriteLine("---------------------");
           Console.WriteLine("1.Toyota yaris    kode=y4r1s");
           Console.WriteLine("2.Toyota agya     kode=4gy4");
           Console.WriteLine("---------------------");
           Console.WriteLine("Masukan Kode type mobil pilihan =");
           type = Console.ReadLine();
           if(type=="y4r1s"){
           double harga=300000000;
       

            Console.WriteLine("Toyota Yaris");
            Console.WriteLine("...............");
            Console.WriteLine("Transmisi = MT");
            Console.WriteLine("Kapasitas = 5kursi");
            Console.WriteLine("Tenaga = 106hp");
            Console.WriteLine("Harga = Rp. "+harga);
            Console.WriteLine("+++++++++++++++++++++++++++");
           
           }else if(type=="4gy4"){
             double harga=150000000;

            Console.WriteLine("Toyota Agya");
            Console.WriteLine("...............");
            Console.WriteLine("Transmisi = L");
            Console.WriteLine("Kapasitas = 5kursi");
            Console.WriteLine("Tenaga = 87hp");
            Console.WriteLine("Harga = Rp. "+harga);
            Console.WriteLine("+++++++++++++++++++++++++++");
           
           }else{ Console.WriteLine("Type Mobil Toyota tidak tersedia");}
        }else{ Console.WriteLine("Merk Mobil tidak tersedia");}
       //baris arya2

    }else if(pass=="22421034"){
        Console.WriteLine("Selamat Datang Arya Sabathani");
          Console.WriteLine();
         Console.WriteLine("Selamat Datang di Store");
         Console.WriteLine("************************");
         Console.WriteLine("Pilihan Mobil Untuk Anda");
         Console.WriteLine("1.Honda  kode=h0nd4");
         Console.WriteLine("2.Toyota kode=t0y0t4");
         Console.WriteLine("Masukan kode mobil =");
         car = Console.ReadLine();
        if(car=="h0nd4"){
           Console.WriteLine("Pilihan Type Honda ");
           Console.WriteLine("---------------------");
           Console.WriteLine("1.Honda Civic R     kode=c1v1cr");
           Console.WriteLine("2.Honda Civic Turbo kode=c1v1ct");
           Console.WriteLine("---------------------");
           Console.WriteLine("Masukan Kode type mobil pilihan =");
           type = Console.ReadLine();
           if(type=="c1v1cr"){ 
           double harga=1000000000;
           

            Console.WriteLine("Honda Civic R");
            Console.WriteLine("...............");
            Console.WriteLine("Transmisi = MT");
            Console.WriteLine("Kapasitas = 5kursi");
            Console.WriteLine("Tenaga = 301hp");
            Console.WriteLine("Harga = Rp. "+harga);
            Console.WriteLine("+++++++++++++++++++++++++++");
           
           }else if(type=="c1v1ct"){
             double harga=500000000;

            Console.WriteLine("Honda Civic Turbo");
            Console.WriteLine("...............");
            Console.WriteLine("Transmisi = CVT");
            Console.WriteLine("Kapasitas = 5kursi");
            Console.WriteLine("Tenaga = 171hp");
            Console.WriteLine("Harga = Rp. "+harga);
            Console.WriteLine("+++++++++++++++++++++++++++");
           }else{ Console.WriteLine("Type Mobil Honda tidak tersedia");}
           


        }else if(car=="t0yot4"){
           Console.WriteLine("Pilihan Type Toyota ");
           Console.WriteLine("---------------------");
           Console.WriteLine("1.Toyota yaris    kode=y4r1s");
           Console.WriteLine("2.Toyota agya     kode=4gy4");
           Console.WriteLine("---------------------");
           Console.WriteLine("Masukan Kode type mobil pilihan =");
           type = Console.ReadLine();
           if(type=="y4r1s"){
           double harga=300000000;
       

            Console.WriteLine("Toyota Yaris");
            Console.WriteLine("...............");
            Console.WriteLine("Transmisi = MT");
            Console.WriteLine("Kapasitas = 5kursi");
            Console.WriteLine("Tenaga = 106hp");
            Console.WriteLine("Harga = Rp. "+harga);
            Console.WriteLine("+++++++++++++++++++++++++++");
           
           }else if(type=="4gy4"){
             double harga=150000000;

            Console.WriteLine("Toyota Agya");
            Console.WriteLine("...............");
            Console.WriteLine("Transmisi = L");
            Console.WriteLine("Kapasitas = 5kursi");
            Console.WriteLine("Tenaga = 87hp");
            Console.WriteLine("Harga = Rp. "+harga);
            Console.WriteLine("+++++++++++++++++++++++++++");
           
           }else{ Console.WriteLine("Type Mobil Toyota tidak tersedia");}
        }else{ Console.WriteLine("Merk Mobil tidak tersedia");}
        
    }else{ Console.WriteLine("Password Anda Salah");}
}else{
        Console.WriteLine("User error");
    }
    


