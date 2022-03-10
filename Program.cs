using System;

namespace Hello_World
{
    class Program
    {
        static void Main(string[] args)
        {
            //Első óra
            //1. Írd ki a konzolra egy sorba a „Hello Világ!” szöveget!
            Console.WriteLine("Helló Világ");
            //2. Írd ki egymás mellé a Helló és Világ szót két paranccsal (szóköz legyen közöttük)! Használd a System.out.print() utasítást a feladat megoldására!
            Console.WriteLine("Helló\tVilág");
            //3. Írd ki saját publikus adataid a konzolra egy sorban! (Név, Szak, évfolyam stb.)
            Console.WriteLine("Tóth Péter Barnabás\tGazdaságinformatika\t2. Félév");
            //4. Írd ki saját publikus adataid a konzolra, három sorban! (Név, Szak, évfolyam stb.)
            Console.WriteLine("Tóth Péter Barnabás\nGazdaságinformatika\n2. Félév");
            //5. Írd ki a konzolra kedvenc versed első néhány versszakát! Az első sor a vers címe, az utolsó sor a költő neve legyen, a versszakok között legyen üres sor!
            Console.WriteLine("\nHat jó játék kisbabáknak\n\nJó játék a cicafarok,\nszélte pont egy babamarok.\nÉn húztam meg, mit akarok?\nJó játék a cicafarok.\n\nJó játék a mobilteló,\nfogalmam sincs, mire való.\nLenyálazom, aztán heló,\njó játék a mobilteló.\n\nJó játék a laptopkábel,\nfőleg, ha még nem lopták el.\nNégy fogaddal hipp-hopp rágd el,\njó játék a laptopkábel.\n\nJó játék a lapát,\nazzal ütjük apát.\nOrrot, fület lapít,\njó játék a lapát.\n\nJó játék a verseskötet,\nvan rajta egy teljes köpet.\nÁtnyálaztam, még egy jöhet,\njó játék a verseskötet.\n\nJó játék a konektor,\nén jöttem rá magamtól.\nBeledugom, hol egy toll?\nJó játék a konektor.\n\nVarró Dániel");
            //6. Készítsd el órarendedet! Használd a  \t tabulátor escape szekvenciát!
            Console.WriteLine("\t\tHétfő\t\t\t\tKedd\t\t\t\tSzerda\t\t\t\tCsütörtök\t\t\t\tPéntek\n8:00-9:30\t\t\t\t\tProgramozás alapjai 1\t\t\t\t\t\tSzámítógép- és hálózati architekróra\n9:40-11:10\t\t\t\t\t\t\t\t\tMatematika alapok 2\t\tProgramozás alapjai 1\n11:20-12:50\t\t\t\t\tGazdaságpolitika\t\t\t\t\t\tTevékenységek Számvitele és a Beszámoló\n13:00-14:30\t\t\t\t\tSzámítógép és hátózati architektúra\t\t\t\tAdatbáziskezelés\n14:40-16:10\t\t\t\t\tMatematika alapok 2\n16:20-17:50\t\t\t\t\tPénzügyek informatikusoknak");
            Console.BackgroundColor = ConsoleColor.Blue; //Kék háttér //Az első sorról lecsúszik, mig a +1-edik soron ahol már nem kéne, az ott levő szöveg kivételével meg beszinezi!! Hogy ha teljes képernyőre veszed akkor megjavul magától.
            Console.ForegroundColor = ConsoleColor.Red; //Piros betűk
            Console.WriteLine("White on blue with red.");
            Console.WriteLine("Another line.");
            Console.ResetColor(); //Reseteli az eddigi háttér és betű szint.
            Console.WriteLine("\u001B[33m\u001B[41mHelló Világ");//Sárga szín és Piros Háttér. //30-asok előtér, azaz szöveg, 40-esek a hátterek. Fekete:0 Piros:1 Zöld:2 Sárga:3 Kék:4 Magenta:5 Cián:6 Fehér:7
            Console.ResetColor();

            //Második óra
            Console.WriteLine(9 + 5);
            Console.WriteLine(9 - 5);
            Console.WriteLine(9 * 5);
            Console.WriteLine(9 / 5);
            Console.WriteLine(9 % 5); //Maradék osztás
            Console.WriteLine(9 / 5.0);
            Console.WriteLine("9 * 5 = " + 9 * 5); // + az a Konkatenálás
            Console.WriteLine("9.3 + 5 = " + 9.3 + 5); // A precedencia miatt és a balról jobbra szabály miatt, először a "9.3 + 5 = " + 9.3-at hajtja végre ami "9.3 + 5 = 9.3"-lesz konkatenálás miatt. Ezután a "9.3 + 5 = 9.3" + 5-öt hajtja végre, ami "9.3 + 5 = 9.35"-lesz még egy konkatenálás miatt.
            Console.WriteLine("9.3 + 5 = " + (9.3 + 5)); // A precedencia matematika elvén múködik.
            Console.WriteLine(9 * ((5 + 8) + 7)); // Az összetetteb zárójeleket nem {[()]} formályában, hanem ((())) formályában kell megvalósítani.
            Console.WriteLine("9 - 5 = " + (9 - 5)); // A ("9 - 5 = " + 9 - 5) NEM ÉRTELMEZHETŐ! Mert balról jobbra haladva először konkatenálást végzi el: ("9 - 5 = 9" - 5). Majd a "9 - 5 = 9", ami egy SZÖVEG, nem lehet kivonni az 5-öt. (Szöveg-5 matematikában sem értelmes.)(A - jel nem takar a kivonásnál itt több értelmet, nem úgy mint a +, am összeadás ÉS Konkatenálást is jelent.)
            Console.WriteLine(1 * 2 + 3 * 5 % 4);
            Console.WriteLine(1 + 8 % 3 * 2 - 9);
            double a = 9.3;
            int b = 5;
            int c = 9;
            double d = 5.0;
            Console.WriteLine(a + b);
            Console.WriteLine(c - b);
            Console.WriteLine(c * b);
            Console.WriteLine(c / d);
            Console.WriteLine(c % b);
            Console.WriteLine("Kérem adja meg a w valós szám változó értékét:");
            /*
            double w = Convert.ToDouble(Console.ReadLine()); // 9,3-at kell a konzolba írni, nem 9.3-at!
            int q = 5;
            int r = 9;
            double s = 5.0;
            Console.WriteLine(w + q);
            Console.WriteLine(r - q);
            Console.WriteLine(r * q);
            Console.WriteLine(r / s);
            Console.WriteLine(r % q);
            Console.WriteLine("Kérem adja meg az e valós szám változó értékét:");
            double e = Convert.ToDouble(Console.ReadLine()); // 9,3-at kell a konzolba írni, nem 9.3-at!
            Console.WriteLine("Kérem adja meg az f egész szám változó értékét:");
            int f = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kérem adja meg a g egész szám változó értékét:");
            int g = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kérem adja meg a h valós szám változó értékét:");
            double h = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(e + f);
            Console.WriteLine(g - f);
            Console.WriteLine(g * f);
            Console.WriteLine(g / h);
            Console.WriteLine(g % f);
            Console.WriteLine(g + " % " + f + " = " + g % f);
            int x;
            int p;
            int n;
            Console.WriteLine("Kérem a kezdőtőke értékét"); //Rányomni a sorszámra, majd a fejlétcnél a Debug-ra rányomni és a Debug Projectre(Ctrl-F5). Majd a step over(F8)-al tovább haladni. Miután felvettük a változókat az egér ráhúzásával kimutatja az értékeket. Egy szakasz értékét is megmutatja, mint pl: p / 100 -nál 0-t mutat, a p / 100.0-nál 0.2 -t ha p az 20.
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kérem a kamatlábat");
            p = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kérem a futamidőt években");
            n = Convert.ToInt32(Console.ReadLine());
            double jovoertek = x * Math.Pow(1 + p / 100.0, n); //Ha p / 100-at írunk akkor az egész szám / egész szám(int/int) egész számot(int-et) ad ebben az esetekben 0-át. Míg a p / 100.0 az egész szám / valós szám(int/double), így az erednémy valós szám(double).
            Console.WriteLine(jovoertek);
            //*/
            Console.WriteLine((5 >= 4) && (3 <= 9) || !(7 > 4));
            Console.WriteLine(!((5 >= 4) || (3 <= 2) || (7 > 4)));
            Console.WriteLine(7 / 3 + 13 / 5 + 2 * (20 - 17) / 2);
            Console.WriteLine(7 % 3 + 13 / 5 + 2 * (20 - 17) / 2);
            //1. Deklarálj egy egész típusú változót és egy újabb paranccsal adj értéket a változónak
            int z;
            z = 7;
            Console.WriteLine(z);
            //2. Egy egész típusú változónak létrehozáskor add meg az értékét, majd változtasd meg
            int u = 7;
            u++;
            u--;
            u += 3;
            u -= 3;
            u *= 1;
            Console.WriteLine(u);
            //3. Végeztesd el az alábbi számításokat! Az eredményt írd ki a konzolra! A műveletet is írja ki a program. Pl.: 9-2=7 9 – 2 9 * 2.5  9 / 2  9 / -2  9 % 2  9 % -2  -9 % 2  2*9+2*3%2 9 / -2.0  9 + 2 * 5  (2 + 3) * 9+2 2*9+(3+2)/2
            Console.WriteLine("9 - 2 = " + (9 - 2));
            Console.WriteLine("9 % 2 = " + 9 % 2);
            Console.WriteLine("9 / 2.0 = " + 9 / 2.0);
            Console.WriteLine("9 * 2.5 = " + 9 * 2.5);
            Console.WriteLine("9 % -2 = " + 9 % -2);// A -2-őt nem kell külön zárójelbe tenni.
            Console.WriteLine("9 + 2 * 5 = " + (9 + 2 * 5));
            Console.WriteLine("9 / 2 = " + 9 / 2);
            Console.WriteLine("-9 % 2 = " + -9 % 2);
            Console.WriteLine("(2 + 3) * 9 + 2 = " + ((2 + 3) * 9 + 2));
            Console.WriteLine("9 / -2 = " + 9 / -2);
            Console.WriteLine("2 * 9 + 2 * 3 % 2 = " + (2 * 9 + 2 * 3 % 2));
            Console.WriteLine("2 * 9 + (3 + 2) / 2 = " + (2 * 9 + (3 + 2) / 2));
            //4. Add meg a változók értékeit: a=9, b=2, d=2,5; Írasd ki a következő képletet és az értékét: z=a*b+a/b+(a+3)
            int i = 9;
            int o = 2;
            double ő = 2.5;
            Console.WriteLine(i * o + i / o + ((i + 3)));
            //5. Hozz létre egy egyész típusú változót BruttoAr néven és egy valós típusú változót AFA néven. Add meg a kezdőértékeket. Számold ki a nettó árat és írd ki a konzolra.
            /*
            Console.WriteLine("Add meg a Bruttó Árat.");
            int BruttoAr = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Add meg az Áfát.");
            double AFA = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(BruttoAr / (100.0 + AFA) * 100);
            //*/
            //6. Írd ki a felhasználó által megadott százalékalap és százalékláb ismeretében a százalékértéket! 
            /*
            Console.WriteLine("Add meg a százalékalapot.");
            int szazalekalap = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Add meg a százaléklábaz.");
            double szazaleklab = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Százalékérték = " + szazalekalap / 100.0 * szazaleklab);
            //*/
            //7. Kérj be egy egész számot. A program írja ki a konzolra: „Kérek egy egész számot.” Írd ki a szám négyzetét, négyzetgyökét, köbét és köbgyökét.
            /*
            Console.WriteLine("Kérek egy egész számot.");
            double ú = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Math.Pow(ú, 2));
            Console.WriteLine(Math.Sqrt(ú));
            Console.WriteLine(Math.Pow(ú, 3));
            Console.WriteLine(Math.Pow(ú, (1.0 / 3)));
            //*/
            //8. Kérj be két egész számot. A program mindig írja ki a konzolra, hogy mit vár. Pl.: Kérek egy egész számot. Kérek egy másik egész számot. Írd ki a négy alapműveletet rajtuk! (*, /, +, -): Pl. 12 + 3 = 15
            /*
            Console.WriteLine("Kérek egy egész számot.");
            int ö = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kérek egy másik egész számot.");
            int ü = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(ö + ü);
            Console.WriteLine(ö - ü);
            Console.WriteLine(ö * ü);
            Console.WriteLine(ö / ü);
            //*/
            //9. Kérd be a termék nettó árát, az ÁFA értéket (valós szám legyen), majd írd ki a bruttó árat
            //*
            Console.WriteLine("Nettó Ár:");
            int nettóár = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Áfa:");
            double ÁFA = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(nettóár / 100 * (100 + ÁFA));
            //*/
            //10. Kérd be a mértani alakzatok (téglalap, kör, háromszög) adatait, majd írd ki az alakzatok kerületét, területét. (A háromszög területét Héron képlettel számíthatod ki.)
            /*
            Console.WriteLine("Téglalap a oldala:");
            double teglalapa = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Téglalap b oldala:");
            double teglalapb = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Kör sugara:");
            double Korr = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Háromszög a oldal:");
            double haromszoga = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Háromszög b oldala:");
            double haromszogb = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Háromszög c oldala:");
            double haromszogc = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Téglalap kerülete: " + (2 * teglalapa + 2 * teglalapb));
            Console.WriteLine("Téglalap területe: " + teglalapa * teglalapb);
            Console.WriteLine("Kör kerülete: " + 2 * Korr * Math.PI);
            Console.WriteLine("Kör területe: " + Math.PI * Math.Pow(Korr, 2));
            Console.WriteLine("Háromszög kerülete: " + (haromszoga + haromszogb + haromszogc));
            double haromszogs = (haromszoga + haromszogb + haromszogc) / 2;
            Console.WriteLine("Háromszög területe: " + (Math.Sqrt(haromszogs * (haromszogs - haromszoga) * (haromszogs - haromszogb) * (haromszogs - haromszogc))));
            //*/
            //11. Kérd be a gömb sugarát, majd írd ki a térfogatát. V=(4*R3*PI/3)
            /*
            Console.WriteLine("Gömb sugara:");
            double gombr = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(4 * Math.Pow(gombr, 3) * Math.PI / 3);
            //*/
            //12. Számítsd ki egy bankbetét kamatos kamattal növelt értékét! A felhasználónak meg kelljen adnia a betétet, a futamidőt évben és az éves kamatlábat
            /*
            Console.WriteLine("Kérem a kezdőtőke értékét");
            int betet = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kérem a kamatlábat");
            int kamatlab = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kérem a futamidőt években");
            int futamido = Convert.ToInt32(Console.ReadLine());
            double jovoertek112 = betet * Math.Pow(1 + kamatlab / 100.0, futamido);
            Console.WriteLine(jovoertek112);
            //*/


            //Harmadik óra
            int j3 = -5;
            if (j3 > 0)
            { //Debugnál arra a sorra ugrik, amelyik feltétel teljesül.
                Console.WriteLine("A j értéke nagyobb, mint nulla.");
            }
            else
            {
                Console.WriteLine("A j értéke egyenlő 0-val, vagy kisebb 0-nál.");
            }
            Console.WriteLine("Vége a programnak");
            int k = 0;
            if (k == 0)
            {
                Console.WriteLine("A k értéke egyenlő 0-val");
            }
            else if (k < 0)
            {
                Console.WriteLine("A k egy negatív szám");
            }
            else
            {
                Console.WriteLine("A k pozitív szám");
            }
            Console.WriteLine("Vége a programnak");
            int l = 8;
            if (l >= 5)
            { //Ez a rossz hosszú és jobban leterhelő kódsor!
                if (l <= 10)
                {
                    if (l % 2 == 0)
                    {
                        Console.WriteLine("A szám 5 és 10 között van és osztható 2-vel");
                    }
                }
            }
            if (l >= 5 && l <= 10 && l % 2 == 0)
            { //Ez a helyes kód.
                Console.WriteLine("A szám 5 és 10 között van és osztható 2-vel");
            }
            int é = 12;
            if (é <= 4 || é >= 16)
            { // A || a logikai vagy, a && a logikai és.
                Console.WriteLine("é nem 5 és 15 között van");
            }
            else
            {
                Console.WriteLine("é 5 és 15 között van");
            }
            if (!(é >= 4 && é <= 16))
            { //A ! a tagadás jele. 
                Console.WriteLine("é nem 5 és 15 között van");
            }
            else
            {
                Console.WriteLine("é 5 és 15 között van");
            }
            int á = 17;
            if (!(á >= 5 && á <= 10) && á % 2 != 0)
            {
                Console.WriteLine(á + "értéke az 5 és 10 intervallum kivülre esik és páratlan");
            }
            int ev = 2000;
            int honap = 3;
            switch (honap)
            {
                case 1:
                case 3:
                case 5:
                    Console.WriteLine("31");
                    break;
                case 4:
                case 6:
                case 8:
                    Console.WriteLine("30");
                    break;
                case 2:
                    if ((ev % 4 == 0 && ev % 100 != 0) || ev % 400 == 0)
                    {
                        Console.WriteLine("29");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("28");
                        break;
                    }
            }

            String szoveg = "Egy kis ilyen";
            int kszam = 0;
            for (int msz = 0; msz < szoveg.Length; msz++)
            {
                Console.WriteLine(szoveg[msz]);
                if (szoveg[msz] != 'k')
                {
                    continue;
                }
                kszam++;
            }
            Console.WriteLine(kszam);
            //1. Oldd meg a következő egyenleteket: Az egyenlet kiszámításához szükséges adatokat a billentyűzetről olvasd be! a5/c+PIa/(b+c) a+b⋅√(b/d) √((sin(n)/b∗c) (a⋅√(b+c))/(c*d)
            /*
            Console.WriteLine("Adj meg egy a értéket");
            double a31 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Adj meg egy b értéket");
            double b31 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Adj meg egy c értéket");
            double c31 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Adj meg egy d értéket");
            double d31 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Adj meg egy n értéket");
            double n31 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(Math.Pow(a31, 5) / c31 + Math.PI * 3 / (b31 + c31));
            Console.WriteLine(a31 + b31 * Math.Sqrt(b31 / d31));
            Console.WriteLine(Math.Sqrt(Math.Sin(n31) / (b31 * c31)));
            Console.WriteLine(a31 * Math.Sqrt(b31 + c31) / c31 * d31);
            //*/
            //2. Oldd meg a fenti egyenleteket úgy, hogy megvizsgálod, hogy az egyenletek megoldhatóak-e. Pl. egy osztásban az osztó nem lehet 0, vagy a négyzetgyök alatt nem lehet negatív szám! Ha valamelyik állapot fennáll, akkor adj hibaüzenetet a hiba okáról! Ilyenkor a számítást nem szabad elvégezni!
            /*
            if (b31 / d31 >= 0 && b31 + c31 >= 0 && c31 != 0 && b31 + c31 != 0 && b31 != 0 && d31 != 0 && Math.Sin(n31) / (b31 * c31) >= 0){
            Console.WriteLine(Math.Pow(a31, 5) / c31 + Math.PI * 3 / (b31 + c31));
            Console.WriteLine(a31 + b31 * Math.Sqrt(b31 / d31));
            Console.WriteLine(Math.Sqrt(Math.Sin(n31) / (b31 * c31)));
            Console.WriteLine(a31 * Math.Sqrt(b31 + c31) / (c31 * d31));
            }else{
            Console.WriteLine("Nem végezhető el 0-val való osztás miatt vagy a négyzzetgyök alatt negatív van.");//A radiános sinusz megoldás is lehet negatív, viszont a maradékos osztás abszolút értéket ad, emiatt valószínűleg for ciklussal kell majd megoldani. !!
            }
            //*/
            //3. Oldd meg az egyenleteket úgy, hogy a feltételt úgy állítod be, hogy akkor oldja meg a feladatot, ha az egyenlet változói megfelelőek, azaz a feltételes elágazás igaz ágában oldod számítod ki az eredményt és a hamis ágában adsz hibaüzenetet. Oldd meg úgy is az egyenleteket, hogy a feltételes elágazás hamis ágában oldod meg az egyenletet és az igaz ágában adsz hibaüzenetet!
            /*
            //a. része
            if (b31 / d31 >= 0 && b31 + c31 >= 0 && c31 != 0 && b31 + c31 != 0 && b31 != 0 && d31 != 0 && Math.Sin(n31) / (b31 * c31) >= 0){
            Console.WriteLine(Math.Pow(a31, 5) / c31 + Math.PI * 3 / (b31 + c31));
            Console.WriteLine(a31 + b31 * Math.Sqrt(b31 / d31));
            Console.WriteLine(Math.Sqrt(Math.Sin(n31) / (b31 * c31)));
            Console.WriteLine(a31 * Math.Sqrt(b31 + c31) / (c31 * d31));
            }else{
            Console.WriteLine("Nem végezhető el 0-val való osztás miatt vagy a négyzzetgyök alatt negatív van.");
            }
            //b része
            if (!(b31 / d31 >= 0 && b31 + c31 >= 0 && c31 != 0 && b31 + c31 != 0 && b31 != 0 && d31 != 0 && Math.Sin(n31) / (b31 * c31) >= 0)){
            Console.WriteLine("Nem végezhető el 0-val való osztás miatt vagy a négyzzetgyök alatt negatív van.");
            }else{
            Console.WriteLine(Math.Pow(a31, 5) / c31 + Math.PI * 3 / (b31 + c31));
            Console.WriteLine(a31 + b31 * Math.Sqrt(b31 / d31));
            Console.WriteLine(Math.Sqrt(Math.Sin(n31) / (b31 * c31)));
            Console.WriteLine(a31 * Math.Sqrt(b31 + c31) / (c31 * d31));
            }
            //*/
            //4.	Adj részletes hibaüzenetet abban az esetben, ha az egyenlet nem oldható meg. Azaz írd ki az összes hibalehetőséget, ami fennáll, ha az egyenlet nem oldható meg! Pl. c értéke nem lehet 0, a négyzetgyök alatt nem lehet negatív érték!
            /*
            if (!(b31 / d31 >= 0 && b31 + c31 >= 0 && c31 != 0 && b31 + c31 != 0 && b31 != 0 && d31 != 0 && Math.Sin(n31) / (b31 * c31) >= 0)){
            Console.WriteLine("Vagy a b és d hányadosa negatív, vagy a b és c összege negatív, vagy a c értéke 0-a, vagy a b és c összege 0, vagy a b értéke 0-a, vagy a d értéke 0-a, vagy a sin(n)/b*c értéke negatív.");
            }
            //*/








            //Negyedik óra
            for (int ia = 1; ia <= 5; ia = ia + 1)
            {
                Console.WriteLine(ia);
            }

            /*
            Console.WriteLine("Kérek egy számot:");
            int nb4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(nb4 + "osztói");
            Console.WriteLine(1);
            for (int ib = 2; ib <= nb4 / 2; ib++) {
            if (nb4 % ib == 0) {
                    Console.WriteLine(ib);
            }
            }
            Console.WriteLine(nb4);
            Console.WriteLine("Kérek egy páratlan számot:");
            int nc4 = Convert.ToInt32(Console.ReadLine());
            while (nc4 % 2 == 0) {
                Console.WriteLine("A szám páros kérek egy páratlan számot!");
            nc4 = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(nc4 * 2);
            //*/
            Random rnd = new Random();
            //*
            int velSzam4;
            do {
                velSzam4 = rnd.Next(20) + 1;
            } while (velSzam4 % 2 != 0);
            Console.WriteLine(velSzam4);
            //*/
            //*
            int velszam4 = rnd.Next(5) + 1;
            int tipp;
            for (int ic4 = 1; ic4 <= 10; ic4++) {
                Console.WriteLine("Add meg a (z)" + ic4 + ". tipped:");
                tipp = Convert.ToInt32(Console.ReadLine());
                if (tipp == velszam4) {
                    Console.WriteLine("Gratulálok kitaláltad a számot!");
                    break;
                }  
            }
            for (int id4 = 1; id4 <= 10; id4++) {
                Console.WriteLine("Add meg a (z)" + id4 + ". tipped:");
                tipp = Convert.ToInt32(Console.ReadLine());
                if (tipp != velszam4) {
                    continue;
                }
                Console.WriteLine("Gratulálok kitaláltad a számot!");
                break;
            }
            //*/
            //1. Írd ki a számokat 1 -től 10 -ig egyesével.
            for (int a41 = 1; a41 <= 10; a41++)
            {
                Console.WriteLine(a41);
            }
            //2. Írd ki a számokat -15-től 30-ig kettesével.
            for (int a42 = -15; a42 <= 30; a42++)
            {
                if (a42 % 2 == 0)
                {
                    Console.WriteLine(a42);
                }

            }
            //3. Írd ki a páros számokat 10 - 30 között úgy, hogy a ciklus fejében nem használsz if-et.
            for (int a43 = 5; a43 <= 15; a43++)
            {
                Console.WriteLine(a43 * 2);

            }
            //4. Írd ki a számokat 10 -től -10 -ig visszafelé egyesével.
            for (int a44 = 10; a44 >= -10; a44--)
            {
                Console.WriteLine(a44);

            }
            //5. Írd ki a számokat 0- tól 10 -ig egynegyedes lépésközzel.
            for (double a45 = 0; a45 <= 10; a45 += 0.25)
            {
                Console.WriteLine(a45);

            }
            //6. A felhasználótól kérj be egy intervallumot A és B, egy lépésközt N, majd ezen intervallumon belül írd ki a megadott lépésközzel a számokat.
            //*
            Console.WriteLine("Adj meg egy számot:");
            double a46 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Adj meg egy másik számot:");
            double b46 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Adj meg egy lépéközt:");
            double n46 = Convert.ToDouble(Console.ReadLine()); //Ha nem egészt számat adunk meg akkor szétcsúszik a megoldás!!
            for (double i46 = a46; i46 <= b46; i46+=n46) {
            Console.WriteLine(i46);
            }
            //*/
            //7. Oldd meg, azt, ha a felhasználó az intervallumot "fordítva" adja meg, Tehát A > B, akkor a program csökkenő sorrendben, ha "normál" módon B > A akkor növekvő sorrendben írja a növekménynek megfelelően a számokat.
            //*
            Console.WriteLine("Adj meg egy egész számot:");
            int a47 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Adj meg egy másik egész számot:");
            int b47 = Convert.ToInt32(Console.ReadLine());
            if (a47 > b47) {
                for (int i47 = a47; i47 >= b47; i47--) {
                    Console.WriteLine(i47);
                }
            } else {
                for (int i471 = a47; i471 <= b47; i471++) {
                    Console.WriteLine(i471);
                }
            }
            //*/
            //8. Oldd meg azt, ha a felhasználó "fordítva", vagy "normál" adja meg a számokat, akkor a program mindig növekvően írja ki a számokat!
            //*
            Console.WriteLine("Adj meg egy egész számot:");
            int a48 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Adj meg egy másik egész számot:");
            int b48 = Convert.ToInt32(Console.ReadLine());
            if (a48 < b48) {
                for (int i481 = a48; i481 <= b48; i481++) {
                    Console.WriteLine(i481);
                }
            } else {
                for (int i48 = b48; i48 <= a48; i48++) {
                    Console.WriteLine(i48);
                }
            }
            //*/
            //9. Írj ki 10 db. véletlenszámot a 20 és 80 közötti intervallumban.
            //*
            int velSzam49;
            for (int i49 = 1; i49 <= 10; i49++) {
                velSzam49 = rnd.Next(60) + 20;
                Console.WriteLine(velSzam49);

            }
            //*/
            //10. Kérj be egy egész számot, majd írj ki ennyi csillag jelet egymás mellé!
            //*
            Console.WriteLine("Kérek egy egész számot!");
            int a410 = Convert.ToInt32(Console.ReadLine());
            for (int i410 = 1; i410 <= a410; i410++) {
                Console.Write("*");
            }
            Console.WriteLine(" ");
            //*/
            //11. Írj lotto programot. A 13+1 tippet 1,2,X eredménnyel add meg. Pl. 1. tipp -> 2, 2. tipp -> X,...
            //*
            int velszam411 = rnd.Next(13) + 1;
            int tippa411;
            for (int ia411 = 1; ia411 <= 13; ia411++) {
                Console.WriteLine("Add meg a (z)" + ia411 + ". tipped:");
                tippa411 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("1. tipp -> " + tippa411);
                if (tippa411 == velszam411) {
                    Console.WriteLine("Gratulálok kitaláltad a számot!");
                    break;
                }
            }
            //*/

            //12. Kérj be 10 számot, majd minden egyes lépésben írd ki az adott szám négyzetét.
            //*
            for (int m = 1; m <= 10; m++) {
                Console.WriteLine("Kérek egy számot");
                int a412 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(Math.Pow(a412, 2));
            }
            //*/
            //13. Kérj be 10 számot, majd minden egyes lépésben írd ki a szám szinuszát. Vigyázz, a Math.sin() függvény radiánban várja az adatot. A Math.toRadians() függvény a fokban megadott értéket átszámítja radiánba.
            //*
            for (int m = 1; m <= 10; m++) {
                Console.WriteLine("Kérek egy számot");
                int a413 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(Math.PI / 180 * a413);

            }
            //*/
            //14. Egy kockával 10-szer dobunk. Írd ki a kockadobás eredményeit számokkal. A dobások értékeit véletlenszám generálással oldd meg.
            for (int m = 1; m <= 10; m++)
            {
                int a414 = rnd.Next(5) + 1;
                Console.WriteLine(a414);

            }

            //15. Kérj be egy számot, majd írd ki az osztóit, osztóinak darabszámát! Az osztók darabszáma alapján döntsd el, hogy a szám prímszám-e!
            //*
            Console.WriteLine("Kérek egy számot");
            int a415 = Convert.ToInt32(Console.ReadLine());
            int oszt415 = 0;
            for (int m = 1; m <= a415; m++) {
                if(m%a415 == 0){
                    oszt415++;
                    Console.WriteLine(m);
                }

            }
            if (oszt415 == 2) {
                Console.WriteLine("A szám páros");

            }
            //*/

            //16. Kérj be egy számot n, majd írd ki n! értékét.
            //*
            Console.WriteLine("kérek egy számot");
            int a416 = Convert.ToInt32(Console.ReadLine());
            int b416 = 1;
            for (int m = a416; m >= 1; m--) {
                b416 = b416*a416;
                a416--;
            }
            Console.WriteLine(b416);
            //*/
            //17. Kérj be a felhasználótól egy páros számot! A program addig ne menjen tovább, amíg a felhasználó által megadott szám nem páros!
            //*
            Console.WriteLine("Kérek egy páros számot");
            int a417 = Convert.ToInt32(Console.ReadLine());
            while(a417%2 != 0){
                Console.WriteLine("Egy Páros számot kérek");
                a417 = Convert.ToInt32(Console.ReadLine());
            }
            //*/
            //18. Állíts elő egy véletlen páros számot a 20 és 80 intervallumban.
            int a418 = (rnd.Next(30) + 11) * 2;
            Console.WriteLine(a418);

            //19. Készíts számkitalálós programot! A program állítson elő egy véletlenszámot, amit a felhasználónak ki kell találnia. A program kérje be a felhasználó tippjeit. Ha a tipp kisebb, mint a program által előállított, akkor a program írja ki, hogy az én számom nagyobb, ha kisebb, akkor azt, hogy az én számom nagyobb. A program a végén írja ki, hogy hány lépésben sikerült kitalálni a számot!
            //*
            int a419 = rnd.Next(10)+1;
            Console.WriteLine("Kérek egy számot");
            int tipp419 = Convert.ToInt32(Console.ReadLine());
            int b419 = 1;
            while(a419 != tipp419){
                if(tipp419 < a419){
                    Console.WriteLine("A szám nagyobb, adj meg egy újat");
                    tipp419 = Convert.ToInt32(Console.ReadLine());
                    b419++;
                } else {
                    Console.WriteLine("A szám kisebb, adj meg egy új számot");
                    tipp419 = Convert.ToInt32(Console.ReadLine());
                    b419++;
                }
            }
            Console.WriteLine("Gratulálok eltaláltad a számot " + b419 + " lépésből!");
            //*/
            //20. Állítsd elő a szorzótáblát táblázatos formában, az alábbi módon. Hogy hányszor hányas szorzótábla legyen, azt a felhasználótól kérd be
            //*
            Console.WriteLine("Kérek egy számot"); //Szépség hibás de jó!
            int a420 = Convert.ToInt32(Console.ReadLine());
            for (int m = 0; m <= a420; m++) {
                Console.WriteLine(m);
            }
            Console.WriteLine("");
            for (int m = 1; m <= a420; m++) {
                Console.Write(m);
                for (int n = 1; n <= a420; n++) {
                    Console.Write(m*n);
                }
                Console.WriteLine("");
            }
            //*/
            //21. Írd ki a Fibonacci számsort a felhasználótól bekért határig.
            //*
            int a421 = 0;
            int b421 = 1;
            int c421;
            Console.WriteLine("Kérek egy számot");
            int d421 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(a421);
            Console.WriteLine(b421);
            for (int m = 1; m <= d421; m++) {
                c421 = a421+b421;
                Console.WriteLine(c421);
                a421 = b421;
                b421 = c421;

            }
            //*/
            //22. Kérj be a felhasználótól egy számot, majd írd ki a számnál nagyobb első prímszámot / tökéletes számot.
            //*
            Console.WriteLine("Kérek egy számot:"); // Tökéletes számmal nincs megcsinálva, míg ez a megoldott feladat.
            int n422 = Convert.ToInt32(Console.ReadLine());
            int n4221 = n422; // megjegyezzük, hogy a végén ki tudjuk írni
            Boolean primE;
            do {
                primE = true;
                for (int m = 2; m <= n422 / 2; m++) {
                    if(n422 % m == 0){
                        primE = false;
                        n422++;
                        break;
                    }
                }            
            } while (!primE);
            Console.WriteLine(n4221 + " számhoz jobbról legközelebb eső prímszám : " + n422);
            //*/
            //23.  Kérj be a felhasználótól egy számot, majd írd ki a számnál kisebb első prímszámot / tökéletes számot.
            //*
            Console.WriteLine("Kérek egy számot:");
            int n423 = Convert.ToInt32(Console.ReadLine());
            int n4231 = n423; 
            Boolean prime423;
            do {
                prime423 = true;
                for (int m = n423 / 2; m >= 2; m--) {
                    if(n423 % m == 0){
                        prime423 = false;
                        n423--;
                        break;
                    }
                }            
            } while (!prime423);
            Console.WriteLine(n4231 + " számhoz balról legközelebb eső prímszám : " + n423);
            //*/
            //24.  Kérj be a felhasználótól egy számot, majd írd ki a számhoz legközelebb álló, kisebb, vagy nagyobb prímszámot / tökéletes számot.
            //*
            Console.WriteLine("Kérek egy számot:"); // Tökéletes számmal nincs megcsinálva, míg ez a megoldott feladat.
            int n424 = Convert.ToInt32(Console.ReadLine());
            int n4241 = n424; // megjegyezzük, hogy a végén ki tudjuk írni
            int n4242 = n424;
            Boolean prime424;
            do {
                prime424 = true;
                for (int m = 2; m <= n424 / 2; m++) {
                    if(n424 % m == 0){
                        prime424 = false;
                        n424++;
                        break;
                    }
                }            
            } while (!prime424);
            do {
                prime424 = true;
                for (int m = n4242 / 2; m >= 2; m--) {
                    if(n4242 % m == 0){
                        prime424 = false;
                        n4242--;
                        break;
                    }
                }            
            } while (!prime424);
            if(n424-n4241 < n4241-n4242){
                Console.WriteLine(n4241 + " számhoz jobbról legközelebb eső prímszám : " + n424);
            } else if (n424-n4241 > n4241-n4242) {
                Console.WriteLine(n4241 + " számhoz balról legközelebbi eső prímszám : " + n4242);
            } else {
                Console.WriteLine(n4241 + "számhoz ugyan olyan közel eső prímszámok : " + n4242 + " és " + n424);
            }
            //*/
            //25. Állítsd elő a szinus, cosinus táblázatot a fenti szorzótáblához hasonlóan 0.5-ös lépésközzel.
            //*
            Console.WriteLine("Kérek egy számot");
            int a425 = Convert.ToInt32(Console.ReadLine());
            for (double m = 0; m <= a425; m += 0.5) {
                Console.WriteLine(m);
            }
            Console.WriteLine("");
            Console.Write("Sin:");
            for (double m = 1; m <= a425; m += 0.5) {
                Console.Write(Math.Sin(m));
            }
            Console.WriteLine("");
            Console.Write("Cos:");
            for (double m = 1; m <= a425; m += 0.5) {
                Console.Write(Math.Cos(m));
            }
            Console.WriteLine("");
            //*/
            //26. Kérj be a felhasználótól 10 db. páros számot! Ha a felhasználó által megadott szám páralan, akkor figyelmeztesd és úrja kérd be a számot. A program írja ki, hogy éppen hányadik szám beolvasásánál tart. Oldd meg a feladatot egy ciklus alkalmazásával is!
            //*
            int co426 = 0;
            int con426 = 0;
            int a426;
            while(co426 != 10) {
                Console.WriteLine("Kérek egy páros számot");
                a426 = Convert.ToInt32(Console.ReadLine());
                con426++;
                Console.WriteLine(con426 + ". szám beolvasva");
                if (a426%2 == 0){
                    co426++;
                } else {
                    Console.Write("A szám páratlan! ");
                }
            }
            //*/
            //27. Állíts elő 10 db. páratlan véletlenszámot! A számokat a program egymás mellett vesszővel elválasztva írja ki! Oldd meg a feladatot egy ciklus alkalmazásával is!
            int a427 = ((rnd.Next(10) + 1) * 2) - 1;
            Console.WriteLine(a427);
            for (int m = 1; m <= 9; m++)
            {
                a427 = ((rnd.Next(10) + 1) * 2) - 1;
                Console.Write("," + a427);
            }
            Console.WriteLine("");


            //Ötödik óra
            int[] nums5 = { 0, 2, 4, 6, 8 };
            Console.WriteLine("Elemek: " + "[{0}]", string.Join(", ", nums5));

            int[] szamok5 = new int[15];
            szamok5[3] = 27; //Ez a negyedik számnak írja, mert 0-val kezdődik.
            szamok5[szamok5.Length - 1] = 27;
            Console.WriteLine(szamok5);//Tömb referencia azonosítója
            Console.WriteLine("[{0}]", string.Join(", ", nums5));

            int[] szam5 = new int[10];
            for (int j = 0; j < szam5.Length; j++)
            {
                szam5[j] = rnd.Next(100) + 1;
            }
            Console.WriteLine("[{0}]", string.Join(", ", szam5));

            //*
            double[] homersekletek = new double[5];
            for (int j = 0; j < homersekletek.Length; j++) {
                Console.WriteLine("Kérem adja meg " + (j+1) +" hőmérsékletet");
                homersekletek[j] = Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine("[{0}]", string.Join(", ", homersekletek));
            //*/

            int[] szamok5a = new int[10];
            for (int j = 0; j < szamok5a.Length; j++)
            {
                szamok5a[j] = rnd.Next(100) + 1;
            }
            Console.WriteLine("[{0}]", string.Join(", ", szamok5a));
            for (int j = 0; j < szamok5a.Length; j++)
            {
                if (szamok5a[j] < 50)
                {
                    Console.Write(szamok5a[j] + ", ");
                }
            }
            Console.WriteLine("");
            /*!!foreach (int szam : szamok5a)
            { //fore -> for each.
                if (szam % 2 == 0)
                {
                    Console.Write(szam + ", ");
                }
            }
            !!//*/

            //1. Hozz létre egy 10 elemű egész számokat tartalmazni képes tömböt, majd írd ki az elemeit vesszővel elválasztva egy sorba! Állítsd át a tömb minden elemét 22-re, majd ismét írd ki!
            int[] a51 = new int[10];
            Console.WriteLine("[{0}]", string.Join(", ", a51));// Nem biztos, hogy ezt kérde, de ez is megoldás!!
            Array.Fill(a51, 22);
            Console.WriteLine("[{0}]", string.Join(", ", a51));

            //2. Tölts fel egy tömböt a természetes számok négyzeteivel 1-től 100-ig! Listázd ki a tömb elemeit!
            int[] a52 = new int[100];
            for (int j = 1; j <= a52.Length; j++)
            {
                a52[j - 1] = j * j;
            }
            Console.WriteLine("[{0}]", string.Join(", ", a52));

            //3. Hozz létre egy tömböt, akkora méretűt, amekkorát a felhasználó igényel. Töltsd fel a felhasználótól bekért egész számokkal, majd írd ki a tömböt.
            //*
            Console.WriteLine("Kérem a tömb nagyságát: ");
            int a53 = Convert.ToInt32(Console.ReadLine());
            int[] b53 = new int[a53];
            Console.WriteLine("Kérem az elemeit: ");
            for (int j = 0; j < b53.Length; j++) {
                b53[j]= Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("[{0}]", string.Join(", ", b53));
            //*/
            //4. Kérdezd meg a felhasználótól, hogy milyen típusú adatot szeretne tárolni! (egész számokat, valós számokat, vagy szövegeket)! Kérdezd meg, hogy hány ilyen adatot kíván tárolni, majd kérd be tőle az adatokat és írd ki egymás alá!
            //*
            Console.WriteLine("Vállasszon egy számot milyen adatokat akar eltárolni: 1 : egész szám; 2 : valós szám; 3 : szövegek");
            int a54 = Convert.ToInt32(Console.ReadLine());
            while(a54 != 1 && a54 != 2 && a54 != 3){
                Console.WriteLine("A megkapott érték nem megfelelő! Vállasszon egy számot milyen adatokat akar eltárolni: 1 : egész szám; 2 : valós szám; 3 : szövegek");
                a54 = Convert.ToInt32(Console.ReadLine());            
            }
            if(a54 == 1) { //Ugyan ezt megoldani Switch és Case-ekben!!
                Console.WriteLine("Mennyi adatok akar eltárolni?");
                int b54 = Convert.ToInt32(Console.ReadLine());
                int[] c54 = new int[b54];
                for (int j = 0; j < c54.Length; j++) {
                    Console.WriteLine("Kérem az következő adatot");
                    c54[j] = Convert.ToInt32(Console.ReadLine());
                }
                for (int j = 0; j < c54.Length; j++) {
                    Console.WriteLine(c54[j]);
                }
            }else if (a54 == 2) {
                Console.WriteLine("Mennyi adatok akar eltárolni?");
                int b54 = Convert.ToInt32(Console.ReadLine());
                double[] c54 = new double[b54];
                for (int j = 0; j < c54.Length; j++) {
                    Console.WriteLine("Kérem az következő adatot");
                    c54[j] = Convert.ToDouble(Console.ReadLine());                
                }
                for (int j = 0; j < c54.Length; j++) {
                    Console.WriteLine(c54[j]);
                }            
            }else if (a54 == 3) {
                Console.WriteLine("Mennyi adatok akar eltárolni?");
                int b54 = Convert.ToInt32(Console.ReadLine());
                String[] c54 = new String[b54];
                for (int j = 0; j < c54.Length; j++) {
                    Console.WriteLine("Kérem a következő adatot");
                    c54[j] = Console.ReadLine();
                }
                for (int j = 0; j < c54.Length; j++) {
                    Console.WriteLine(c54[j]);
                }
            }
            //*/
            //5. Állíts elő egy 10 elemű tömböt, amely egész számokat tartalmazhat!
            int[] a55 = new int[10];
            //a. Töltsd fel az 50..100 közötti intervallumból véletlenszámokkal! 
            for (int j = 0; j < a55.Length; j++)
            {
                a55[j] = rnd.Next(50) + 51;
            }
            //b. Írd ki a tömb elemeit vesszővel elválasztva egy sorba!
            for (int j = 0; j < a55.Length; j++)
            {
                Console.WriteLine(a55[j] + ", ");
            }
            Console.WriteLine("");
            //c. Írd ki a tömböt azon a módon, ahogy az Arrays.toString() metódus teszi. Pl. [54, 23, 45, 7, 8, 46, 81, 9, 10]
            Console.WriteLine("[{0}]", string.Join(", ", a55));
            //d. Írd ki a tömböt visszafelé.
            for (int j = a55.Length - 1; j >= 0; j--)
            {
                Console.WriteLine(a55[j] + ", ");
            }
            Console.WriteLine("");
            //e. Írd ki a tömböt a következőképpen: Az [1] és [10], a [2] és [9],.., végül az [5] és a [6] elemek különbségét.
            for (int j = 0; j < a55.Length / 2; j++)
            {
                Console.WriteLine(a55[j] - a55[9 - j]);
            }
            //f. Írd ki a tömb egymás melletti elemeinek különbségét.
            for (int j = 0; j < a55.Length - 1; j++)
            {
                Console.WriteLine(a55[j] - a55[j + 1]);
            }
            //g. Írd ki a tömbben található páros/páratlan számokat, az 50-nél kisebb, vagy 70-nél nagyobb számokat.
            for (int j = 0; j < a55.Length; j++)
            {
                if (a55[j] % 2 == 0)
                {
                    Console.WriteLine(a55[j] + " páros szám");
                }
                else
                {
                    Console.WriteLine(a55[j] + " páratlan");
                }
                if (a55[j] > 70)
                {
                    Console.WriteLine(a55[j] + " 70-nél nagyobb szám");
                }
            }
            //6. Hozz létre egy igaz-hamis értékeket tárolni képes 15 elemű tömböt. Töltsd fel véletlen logikai értékekkel. (rnd.nextBoolean() függvény használatával). Listázd ki a tömböt a következőképpen:1. Sikeres vizsga (ha true az érték)2. Sikertelen vizsga (ha false az érték)
            /* !!
            Boolean[] a56 = new Boolean[15];
            for (int j = 0; j < a56.Length; j++)
            {
                a56[j] = rnd.nextBoolean();
                if (a56[j] == true)
                {
                    Console.WriteLine(a56[j] + " sikeres vizsga");
                }
                else
                {
                    Console.WriteLine(a56[j] + " sikertelen vizsga");
                }
            }
            !!//*/
            //7. Hozz létre egy hónapneveket tartalmazó tömböt, a tömb értékeit a létrehozáskor inicializáld! Írd ki az alábbiak szerint a tartalmát: 1. hónap: január 2. hónap: február 3. …
            String[] a57 = { "január", "február", "március", "április", "május", "június", "július", "augusztus", "szeptember", "október", "november", "december" };
            int co57 = 1;
            for (int j = 0; j < a57.Length; j++)
            {
                Console.WriteLine(co57 + ". hónap: " + a57[j]);
                co57++;
            }
            //*
            //8. Készíts tömböt, amely 5 sztringet tartalmazhat!
            String[] a58 = new String[5];
            //a. Kérj be a felhasználótól 5 nevet!
            for (int j = 0; j < a58.Length; j++) {
                Console.WriteLine("Kérem a nevet: ");
                a58[j] = Console.ReadLine();
            }
            //b. Rendezd a tömböt az Arrays.sort() metódussal! 
            Array.Sort(a58);
            //c. Írd ki a neveket nagybetűs formátumban!
            Console.WriteLine("[{0}]", string.Join(", ", a58).ToUpper()); //!!
            //d. Írd ki a nevek hosszát! Pl. 1. Pisti -> 5 2. Lali -> 4
            for (int j = 0; j < a58.Length; j++) {
                Console.WriteLine(a58[j] + " -> " + a58[j].Length);
            }
            //e. Döntsd el, hogy egy adott név szerepel-e a tömbben! Használd az Arrays.binarySearch() metódust a feladat megoldására!
            Console.WriteLine("írj be egy nevet, hogy szerepel-e");
            String b58 = Console.ReadLine();
            if(Array.BinarySearch(a58, b58) > 0){
                Console.WriteLine("A név szerepel");
            } else {
                Console.WriteLine("A név nem szerepel");
            }
            //*/
            //9. Készíts két tömböt, töltsd fel őket létrehozáskor kezdőértékekkel. Döntsd el, hogy a tömbök egyenlők-e, azaz elemeik rendről –rendre megegyeznek-e! Használd az Arrays.equals() metódust a feladat elvégzésére.
            int[] a59 = { 3, 2, 1 };
            int[] b59 = { 1, 2, 3 };
            Console.WriteLine(Array.Equals(a59, b59));

            //10. Hozz létre egy 10 elemű, egész számokat tartalmazó tömböt, majd töltsd fel véletlenszámokkal az 1 és 20 intervallumban!
            //*
            int[] a510 = new int[10];
            for (int j = 0; j < a510.Length; j++) {
                a510[j] = rnd.Next(19)+1;
            }
            //a. Írd ki a tömb elemeit egy sorba, egymástól vesszővel elválasztva!
            Console.WriteLine("[{0}]", string.Join(", ", a510));
            //b. Kérj be a felhasználótól egy számot és mondd meg, hogy az adott szám melyik indexen- (indexeken, ha ismétlődő) helyezkedik el. Ha nincs ilyen szám a tömbben, akkor jelezd.
            Console.WriteLine("Kérek egy számot 1 és 20 között");
            int b510 = Convert.ToInt32(Console.ReadLine());
            int co510 = 0;
            for (int j = 0; j < a510.Length; j++) {
                if(a510[j] == b510){
                    Console.WriteLine(j+1);
                    co510++;
                }
            }
            if(co510 == 0){
                Console.WriteLine("A szám nem szerepel");
            }
            //*/
            //11. Állíts elő egy 10 elemű tömböt, amely egész számokat tartalmazhat!
            //*
            int[] a511 = new int[10];
            //c. Töltsd fel a felhasználótól bekért számokkal a tömböt! 
            for (int j = 0; j < a511.Length; j++) {
                Console.WriteLine("Kérek egy számot");
                a511[j] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("[{0}]", string.Join(", ", a511));

            //d. Töltsd fel a felhasználótól bekért páros számokkal a tömböt. A nem páros számokat ne fogadja el a program, azonban mind a 10 szám legyen meg a bekérés végén!
            int[] b511 = new int[10];
            int co511 = 0;
            int c511;
            do {
                Console.WriteLine("Kérek egy számot");
                c511 = Convert.ToInt32(Console.ReadLine());
                if(c511%2 == 0){
                    b511[co511] = c511;
                    co511++;
                }else{
                    Console.WriteLine("A szám nem páros!");
                }
            } while (co511 != 10);
            Console.WriteLine("[{0}]", string.Join(", ", b511));
            //*/
            //12. Egy 5 elemű tömbben az értékek 1 és 5 közötti véletlenszámok. Készítshisztogramot: jeleníts meg annyi csillagot, amekkorák az egyes értékek a tömbben. Pl. [4, 3, 5, 2, 1] **** *** ***** ** *
            int[] a512 = new int[5];
            for (int j = 0; j < a512.Length; j++)
            {
                a512[j] = rnd.Next(4) + 1;
                for (int m = 1; m <= a512[j]; m++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
            //13. Véletlenszerűen dobjunk 100-szor egy szabályos kockával, majd írd ki, hogy hányszor dobtunk 1-est, 2-est stb.! A kockadobásokat egy 6 elemű tömbben számláld!
            int[] a513 = new int[100]; //valószínűleg nem így!!
            for (int j = 0; j < a513.Length; j++)
            {
                a513[j] = rnd.Next(5) + 1;
            }
            int co5131 = 0;
            int co5132 = 0;
            int co5133 = 0;
            int co5134 = 0;
            int co5135 = 0;
            int co5136 = 0;
            for (int j = 0; j < a513.Length; j++)
            {
                if (a513[j] == 1)
                {
                    co5131++;
                }
                else if (a513[j] == 2)
                {
                    co5132++;
                }
                else if (a513[j] == 3)
                {
                    co5133++;
                }
                else if (a513[j] == 4)
                {
                    co5134++;
                }
                else if (a513[j] == 5)
                {
                    co5135++;
                }
                else
                {
                    co5136++;
                }
            }
            int[] b513 = { co5131, co5132, co5133, co5134, co5135, co5136 };
            Console.WriteLine("[{0}]", string.Join(", ", b513));

            //14. Hozz létre egy tömböt, amit létrehozáskor valós számokkal töltesz fel. Döntsd el, hogy a tömb növekvően rendezett-e. A program írja ki, hogy a tömb rendezett, vagy nem rendezett.
            double[] a514 = { 0.1, 1.1, 2.3 };
            Boolean boo514 = false;
            int co514 = 0;
            for (int j = 0; j < a514.Length - 1; j++)
            {
                if (a514[j] < a514[j + 1])
                {
                    co514++;
                }
            }
            if (co514 == 2)
            {
                boo514 = true;
            }
            if (boo514)
            {
                Console.WriteLine("A tömb rendezett");
            }
            else
            {
                Console.WriteLine("A tömb nem rendezett");
            }
            //15. Hozz létre két 10 elemű egész számokat tartalmazni képes tömböt A és B tömb. Az egyiket A töltsd fel 0-9- intervallumban véletlenszámokkal, a másikat B 1-100 közötti véletlenszámokkal. Írd ki a B tömb elemeit az A tömbben létrehozott számok sorrendjében! Tehát, ha az A-ban pl. 2,5,8.. van, akkor a B tömb 2., 5., és 8… elemeit írd ki egymás után
            int[] a515 = new int[10];
            int[] b515 = new int[10];
            for (int j = 0; j < a515.Length; j++)
            {
                a515[j] = rnd.Next(10);
            }
            for (int j = 0; j < b515.Length; j++)
            {
                b515[j] = rnd.Next(99) + 1;
            }
            for (int j = 0; j < b515.Length; j++)
            {
                Console.WriteLine(b515[a515[j]]);
            }

            //16. Tölts fel egy 20 elemű tömböt véletlenszámokkal a 10 és 30 intervallumban.
            int[] a516 = new int[20];
            for (int j = 0; j < a516.Length; j++)
            {
                a516[j] = rnd.Next(20) + 11;
            }
            //e. Határozd meg, hogy van –e olyan számpár a tömbben, ami a 42-őt adja eredményül. Ha igen, írd ki ezt a számpárt, majd állítsd le a programot.Megengedett, hogy egy tömbbéli elem adja ki a számot. Pl. 21.
            int b516;
            for (int j = 0; j < a516.Length; j++)
            {
                for (int m = 0; m < a516.Length; m++)
                {
                    b516 = a516[j] + a516[m];
                    if (b516 == 42)
                    {
                        Console.WriteLine("Az " + j + ". és a " + m + ".");
                    }
                }
            }
            //17. Tölts fel egy 10 elemű egész számokat tartalmazó tömböt kezdőértékekkel. Egy másik, 3 elemű tömböt is tölts fel a felhasználótól bekért egész számokkal. Döntsd el, hogy a bekért számok szekvenciája megtalálható-e a tömbben!
            //*
            int[] a517 ={0, 1, 2, 3, 4, 5, 6, 7, 8, 9};
            int[] b517 = new int[3];
            for (int j = 0; j < b517.Length; j++) {
                Console.WriteLine("Kérek egy számot");
                b517[j] = Convert.ToInt32(Console.ReadLine());
            }
            Boolean boo517 = false;
            for (int j = 0; j < a517.Length-2; j++) {
                int[] c517 = {a517[j], a517[j+1], a517[j+2]};
                if(Array.Equals(b517, c517)){
                    boo517 = true;
                }
            }
            if(boo517){
                Console.WriteLine("A sor metalálható");
            }else{
                Console.WriteLine("A sor nem található meg");
            }
            //*/
            //18. Cseréld meg egy tömb két elemét! Hogy melyik két elemet cserélje fel, azt a felhasználótól kérd be!
            int[] a518 = { 1, 2, 3, 4, 5 };
            int b518 = a518[4];
            a518[4] = a518[2];
            a518[2] = b518;
            Console.WriteLine("[{0}]", string.Join(", ", a518));
            //19. Cseréld fel egy tömb egymás mellett lévő elemeit a következőképpen. 1-2, 3-4, 4-5…9-10 elemeket.
            int[] a519 = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int b519;
            for (int j = 0; j < a519.Length; j += 2)
            {
                b519 = a519[j];
                a519[j] = a519[j + 1];
                a519[j + 1] = b519;
            }
            Console.WriteLine("[{0}]", string.Join(", ", a519));
            //20. Tölts fel egy tömböt 5 véletlenszámmal. Cseréld fel két véletlenszerűen kiválasztott elemét! Ezt addig ismételd, ameddig a tömb rendezett nem lesz.
            int[] a520 = new int[5];
            for (int j = 0; j < a520.Length; j++)
            {
                a520[j] = rnd.Next(5);
            }
            Console.WriteLine("[{0}]", string.Join(", ", a520));
            int b520;
            int rn520;
            int ra520;
            int co520;
            Boolean boo520 = true;
            do
            {
                co520 = 0;
                rn520 = rnd.Next(5);
                ra520 = rnd.Next(5);
                b520 = a520[rn520];
                a520[rn520] = a520[ra520];
                for (int j = 0; j < a520.Length - 1; j++)
                {
                    if (a520[j] < a520[j + 1] || a520[j] == a520[j + 1])
                    {
                        co520++;
                    }

                }
                if (co520 == 4)
                {
                    boo520 = false;
                }
            } while (boo520);
            Console.WriteLine("[{0}]", string.Join(", ", a520));


        }
    }
}
