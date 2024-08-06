// 1 ile 100 arasında rastgele seçilen sayıyı bulma oyunu  
Console.WriteLine("SAYI TAHMİN OYUNUNA HOŞGELDİNİZ ");
 
Console.WriteLine("------------------------------- \n\n"); 

Console.WriteLine("1 İLE 100 ARASINDAN BİR SAYI SEÇTİM HAYDİ TAHMİN ETMEYE ÇALIŞ!!!"); 
int tutulan;
int tahmin;
Random rnd=new Random();

tutulan=rnd.Next(1,100);
Console.WriteLine($"TUTUGUM SAYI:{tutulan}'İDİ"); 
for(int i=1; i<=3; i++){
 Console.WriteLine($"{i}.TAHMİNİNİ SÖYLE65");
 tahmin=Convert.ToInt32(Console.ReadLine()); 

  if(tahmin==tutulan) {
    Console.WriteLine($"TEBRİKLER {i} DENEMEDE BULDUN!!");
    break;
 }if(i==1){
     if(tutulan>tahmin){
       Console.WriteLine("İPUCU1 !!TUTTUGUM SAYI TAHMİNİNDEN DAHA BÜYÜK BİR SAYI ");
       } 

       else
       {
        Console.WriteLine("İPUCU1 !!TUTTUGUM SAYI TAHMİNİNDEN DAHA KÜÇÜK BİR SAYI ");  
       }
     }
     if(i==2){
        if(tutulan%2==0 && tutulan<tahmin){
             Console.WriteLine(" İPUCU2 !!TUTTUGUM SAYI ÇİFT BİR SAYI VE 2.TAHMİNİNDEN KÜÇÜK BİR SAYI ");  
        }else if(tutulan%2==1 && tutulan>tahmin){
             Console.WriteLine(" İPUCU2 !!TUTTUGUM SAYI TEK BİR SAYI VE 2.TAHMİNİNDEN BÜYÜK BİR SAYI "); 
        }
     }
     }
 
Console.WriteLine("**********OYUN BİTTİ**********\n\n"); 
 Console.WriteLine($"TUTUGUM SAYI:{tutulan}'İDİ"); 



