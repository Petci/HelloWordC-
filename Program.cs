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
            //double w = Convert.ToDouble(Console.ReadLine()); // 9,3-at kell a konzolba írni, nem 9.3-at!
            //int q = 5;
            //int r = 9;
            //double s = 5.0;
            //Console.WriteLine(w + q);
            //Console.WriteLine(r - q);
            //Console.WriteLine(r * q);
            //Console.WriteLine(r / s);
            //Console.WriteLine(r % q);
            //Console.WriteLine("Kérem adja meg az e valós szám változó értékét:");
            //double e = Convert.ToDouble(Console.ReadLine()); // 9,3-at kell a konzolba írni, nem 9.3-at!
            //Console.WriteLine("Kérem adja meg az f egész szám változó értékét:");
            //int f = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Kérem adja meg a g egész szám változó értékét:");
            //int g = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Kérem adja meg a h valós szám változó értékét:");
            //double h = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine(e + f);
            //Console.WriteLine(g - f);
            //Console.WriteLine(g * f);
            //Console.WriteLine(g / h);
            //Console.WriteLine(g % f);
            //Console.WriteLine(g + " % " + f + " = " + g % f);
            //int x;
            //int p;
            //int n;
            //Console.WriteLine("Kérem a kezdőtőke értékét"); //Rányomni a sorszámra, majd a fejlétcnél a Debug-ra rányomni és a Debug Projectre(Ctrl-F5). Majd a step over(F8)-al tovább haladni. Miután felvettük a változókat az egér ráhúzásával kimutatja az értékeket. Egy szakasz értékét is megmutatja, mint pl: p / 100 -nál 0-t mutat, a p / 100.0-nál 0.2 -t ha p az 20.
            //x = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Kérem a kamatlábat");
            //p = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Kérem a futamidőt években");
            //n = Convert.ToInt32(Console.ReadLine());
            //double jovoertek = x * Math.Pow(1 + p / 100.0, n); //Ha p / 100-at írunk akkor az egész szám / egész szám(int/int) egész számot(int-et) ad ebben az esetekben 0-át. Míg a p / 100.0 az egész szám / valós szám(int/double), így az erednémy valós szám(double).
            //Console.WriteLine(jovoertek);
            Console.WriteLine((5 >= 4) && (3 <= 9) || !(7 > 4));
            Console.WriteLine(!((5 >= 4) || (3 <= 2) || (7 > 4)));
            //-rnd.nextInt(27)+13
            Console.WriteLine(7 / 3 + 13 / 5 + 2 * (20 - 17) / 2);
            Console.WriteLine(7 % 3 + 13 / 5 + 2 * (20 - 17) / 2);
            //-//-Random x = new Random(); !!
            //-//-int r = .nextInt(100);//random number 1-100 !!
            //-1. Deklarálj egy egész típusú változót és egy újabb paranccsal adj értéket a változónak
            int z;
            z = 7;
            Console.WriteLine(z);
            //-2. Egy egész típusú változónak létrehozáskor add meg az értékét, majd változtasd meg
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
            //Console.WriteLine("Add meg a Bruttó Árat.");
            //int BruttoAr = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Add meg az Áfát.");
            //double AFA = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine(BruttoAr / (100.0 + AFA) * 100);
            //6. Írd ki a felhasználó által megadott százalékalap és százalékláb ismeretében a százalékértéket! 
            //Console.WriteLine("Add meg a százalékalapot.");
            //int szazalekalap = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Add meg a százaléklábaz.");
            //double szazaleklab = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Százalékérték = " + szazalekalap / 100.0 * szazaleklab);
            //7. Kérj be egy egész számot. A program írja ki a konzolra: „Kérek egy egész számot.” Írd ki a szám négyzetét, négyzetgyökét, köbét és köbgyökét.
            //Console.WriteLine("Kérek egy egész számot.");
            //double ú = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(Math.Pow(ú, 2));
            //Console.WriteLine(Math.Sqrt(ú));
            //Console.WriteLine(Math.Pow(ú, 3));
            //Console.WriteLine(Math.Pow(ú, (1.0 / 3)));
            //8. Kérj be két egész számot. A program mindig írja ki a konzolra, hogy mit vár. Pl.: Kérek egy egész számot. Kérek egy másik egész számot. Írd ki a négy alapműveletet rajtuk! (*, /, +, -): Pl. 12 + 3 = 15
            //Console.WriteLine("Kérek egy egész számot.");
            //int ö = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Kérek egy másik egész számot.");
            //int ü = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(ö + ü);
            //Console.WriteLine(ö - ü);
            //Console.WriteLine(ö * ü);
            //Console.WriteLine(ö / ü);
            //9. Kérd be a termék nettó árát, az ÁFA értéket (valós szám legyen), majd írd ki a bruttó árat
            //Console.WriteLine("Nettó Ár:");
            //int nettóár = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Áfa:");
            //double ÁFA = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine(nettóár / 100 * (100 + ÁFA));
            //10. Kérd be a mértani alakzatok (téglalap, kör, háromszög) adatait, majd írd ki az alakzatok kerületét, területét. (A háromszög területét Héron képlettel számíthatod ki.)
            //Console.WriteLine("Téglalap a oldala:");
            //double teglalapa = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Téglalap b oldala:");
            //double teglalapb = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Kör sugara:");
            //double Korr = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Háromszög a oldal:");
            //double haromszoga = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Háromszög b oldala:");
            //double haromszogb = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Háromszög c oldala:");
            //double haromszogc = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Téglalap kerülete: " + (2 * teglalapa + 2 * teglalapb));
            //Console.WriteLine("Téglalap területe: " + teglalapa * teglalapb);
            //Console.WriteLine("Kör kerülete: " + 2 * Korr * Math.PI);
            //Console.WriteLine("Kör területe: " + Math.PI * Math.Pow(Korr, 2));
            //Console.WriteLine("Háromszög kerülete: " + (haromszoga + haromszogb + haromszogc));
            //double haromszogs = (haromszoga + haromszogb + haromszogc) / 2;
            //Console.WriteLine("Háromszög területe: " + (Math.Sqrt(haromszogs * (haromszogs - haromszoga) * (haromszogs - haromszogb) * (haromszogs - haromszogc))));
            //11. Kérd be a gömb sugarát, majd írd ki a térfogatát. V=(4*R3*PI/3)
            //Console.WriteLine("Gömb sugara:");
            //double gombr = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine(4 * Math.Pow(gombr, 3) * Math.PI / 3);
            //12. Számítsd ki egy bankbetét kamatos kamattal növelt értékét! A felhasználónak meg kelljen adnia a betétet, a futamidőt évben és az éves kamatlábat
            //Console.WriteLine("Kérem a kezdőtőke értékét");
            //int betet = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Kérem a kamatlábat");
            //int kamatlab = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Kérem a futamidőt években");
            //int futamido = Convert.ToInt32(Console.ReadLine());
            //double jovoertek112 = betet * Math.Pow(1 + kamatlab / 100.0, futamido);
            //Console.WriteLine(jovoertek112);


            //Harmadik óra
            int j = -5;
            if (j > 0)
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
            //1. Oldd meg a következő egyenleteket: Az egyenlet kiszámításához szükséges adatokat a billentyűzetről olvasd be! a5/c+PIa/(b+c) a+b⋅√(b/d) √((sin(n)/b∗c) (a⋅√(b+c))/(c*d)
            //Console.WriteLine("Adj meg egy a értéket");
            //double a31 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Adj meg egy b értéket");
            //double b31 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Adj meg egy c értéket");
            //double c31 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Adj meg egy d értéket");
            //double d31 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Adj meg egy n értéket");
            //double n31 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine(Math.Pow(a31, 5) / c31 + Math.PI * 3 / (b31 + c31));
            //Console.WriteLine(a31 + b31 * Math.Sqrt(b31 / d31));
            //Console.WriteLine(Math.Sqrt(Math.Sin(n31) / (b31 * c31)));
            //Console.WriteLine(a31 * Math.Sqrt(b31 + c31) / c31 * d31);
            //2. Oldd meg a fenti egyenleteket úgy, hogy megvizsgálod, hogy az egyenletek megoldhatóak-e. Pl. egy osztásban az osztó nem lehet 0, vagy a négyzetgyök alatt nem lehet negatív szám! Ha valamelyik állapot fennáll, akkor adj hibaüzenetet a hiba okáról! Ilyenkor a számítást nem szabad elvégezni!
            //if (b31 / d31 >= 0 && b31 + c31 >= 0 && c31 != 0 && b31 + c31 != 0 && b31 != 0 && d31 != 0 && Math.Sin(n31) / (b31 * c31) >= 0)
            //{
            //Console.WriteLine(Math.Pow(a31, 5) / c31 + Math.PI * 3 / (b31 + c31));
            //Console.WriteLine(a31 + b31 * Math.Sqrt(b31 / d31));
            //Console.WriteLine(Math.Sqrt(Math.Sin(n31) / (b31 * c31)));
            //Console.WriteLine(a31 * Math.Sqrt(b31 + c31) / (c31 * d31));
            //}
            //else
            //{
            //Console.WriteLine("Nem végezhető el 0-val való osztás miatt vagy a négyzzetgyök alatt negatív van.");//A radiános sinusz megoldás is lehet negatív, viszont a maradékos osztás abszolút értéket ad, emiatt valószínűleg for ciklussal kell majd megoldani. !!
            //}
            //3. Oldd meg az egyenleteket úgy, hogy a feltételt úgy állítod be, hogy akkor oldja meg a feladatot, ha az egyenlet változói megfelelőek, azaz a feltételes elágazás igaz ágában oldod számítod ki az eredményt és a hamis ágában adsz hibaüzenetet. Oldd meg úgy is az egyenleteket, hogy a feltételes elágazás hamis ágában oldod meg az egyenletet és az igaz ágában adsz hibaüzenetet!
            //a. része
            //if (b31 / d31 >= 0 && b31 + c31 >= 0 && c31 != 0 && b31 + c31 != 0 && b31 != 0 && d31 != 0 && Math.Sin(n31) / (b31 * c31) >= 0)
            //{
            //Console.WriteLine(Math.Pow(a31, 5) / c31 + Math.PI * 3 / (b31 + c31));
            //Console.WriteLine(a31 + b31 * Math.Sqrt(b31 / d31));
            //Console.WriteLine(Math.Sqrt(Math.Sin(n31) / (b31 * c31)));
            //Console.WriteLine(a31 * Math.Sqrt(b31 + c31) / (c31 * d31));
            //}
            //else
            //{
            //Console.WriteLine("Nem végezhető el 0-val való osztás miatt vagy a négyzzetgyök alatt negatív van.");
            //}
            //b része
            //if (!(b31 / d31 >= 0 && b31 + c31 >= 0 && c31 != 0 && b31 + c31 != 0 && b31 != 0 && d31 != 0 && Math.Sin(n31) / (b31 * c31) >= 0))
            //{
            //Console.WriteLine("Nem végezhető el 0-val való osztás miatt vagy a négyzzetgyök alatt negatív van.");
            //}
            //else
            //{
            //Console.WriteLine(Math.Pow(a31, 5) / c31 + Math.PI * 3 / (b31 + c31));
            //Console.WriteLine(a31 + b31 * Math.Sqrt(b31 / d31));
            //Console.WriteLine(Math.Sqrt(Math.Sin(n31) / (b31 * c31)));
            //Console.WriteLine(a31 * Math.Sqrt(b31 + c31) / (c31 * d31));
            //}
            //4.	Adj részletes hibaüzenetet abban az esetben, ha az egyenlet nem oldható meg. Azaz írd ki az összes hibalehetőséget, ami fennáll, ha az egyenlet nem oldható meg! Pl. c értéke nem lehet 0, a négyzetgyök alatt nem lehet negatív érték!
            //if (!(b31 / d31 >= 0 && b31 + c31 >= 0 && c31 != 0 && b31 + c31 != 0 && b31 != 0 && d31 != 0 && Math.Sin(n31) / (b31 * c31) >= 0))
            //{
            //Console.WriteLine("Vagy a b és d hányadosa negatív, vagy a b és c összege negatív, vagy a c értéke 0-a, vagy a b és c összege 0, vagy a b értéke 0-a, vagy a d értéke 0-a, vagy a sin(n)/b*c értéke negatív.");
            //}

        }
    }
}
