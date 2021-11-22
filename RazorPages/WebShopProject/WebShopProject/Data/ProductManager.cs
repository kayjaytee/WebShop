using System.Collections.Generic;
using System.IO;
using System.Linq;
using WebShopProject.Models;

namespace WebShopProject.Data
{
    public static class ProductManager
    {

        public static List<ProductModel> Products;

        public static List<ProductModel> GetProducts()
        {
            if (Products == null || !Products.Any())
            {
                Products = new List<ProductModel>()
                {
                #region Furniture
                new FurnitureModel()
                {
                    ID = "f01",
                    Name = "Lergoblin",
                    Image = Path.GetFileName("Lergoblin.png"),
                    Description = "En liten figur som sjunger tvåstämmigt den kända ”Kloaksonaten” – inte särskilt vacker melodi, men underhållande!",
                    Cost = 50,
                    Height = 0.3f,
                    Width = 0.3f,
                    Weight = 0.2f,
                    Warning = "OBS: Avsaknad av avstängingsläge förekommer."
                },

                new FurnitureModel()
                {
                    ID = "f02",
                    Name = "Varma Muggen",
                    Image = Path.GetFileName("Varmamuggen.png"),
                    Description = "Är du inte trött på att behöva värma kaffet varje gång du glömt av att dricka den sista slurpen? "
                                  + "Oroa dig inte, denna magiska mugg är förtrollad med värmande magi och du behöver nu aldrig stressa i dig kaffet igen!",
                    Cost = 750,
                    Height = 0.5f,
                    Width = 0.5f,
                    Weight = 1,
                    Warning = "OBS: Vi ansvarar inte för eventuella brända tungor under kaffe incidenter."
                },

                new FurnitureModel()
                {
                    ID = "f03",
                    Name = "Svävande Bärstol",
                    Image = Path.GetFileName("Svävandebärstol.jpg"),
                    Description = "Vill du kunna sväva utan större ansträngning upp till femton meter över marken?"
                                  + "Denna lyxiga bärstol av ädelträ styrs med dina tankar och kan flyga upp till 100 kilometer i timmen!",
                    Cost = 55000,
                    Height = 2.5f,
                    Width = 1.5f,
                    Weight = 300,
                    Warning = "OBS: En explosiv ökning av fart kan bidra till en väldigt flygande åktur - även ur stolen!"
                },

                new FurnitureModel()
                {
                    ID = "f04",
                    Name = "Magisk Självfejande Sopkvast",
                    Image = Path.GetFileName("Magiskhäxkvast.png"),
                    Description = "Trött på städa? Eller kanske sugen på en snabb flygtur?"
                                  + "Denna magiska kvast är självfejande och städar åt dig i samtliga rum och kan samt användas till en snabb flygresa. Ett populärt föremål i Häxornas' Krokryggsförening.",
                    Cost = 4000,
                    Height = 1.5f,
                    Width = 0.10f,
                    Weight = 2,
                    Warning = " OBS: Tyvärr har en stopp-funktion inte implanterats i kvastens flygläge. Förvänta dig en bruten näsa efter snabb åktur."
                },

                new FurnitureModel()
                {
                    ID = "f05",
                    Name = "Sol i Burk",
                    Image = Path.GetFileName("Soliburk.jpg"),                                                                        // återkommer med bild av denna magiska produkt.
                    Description = "Långt kvar till semestern? Oroa dig inte, ta med dig din solsemester i en enkel burk! "
                                  + "En revolutionerande magisk produkt som inte bara värmer och lyser upp ditt hem, utan förändrar ditt humör till det bättre!",
                    Cost = 3500,
                    Height = 6f,
                    Width = 7f,
                    Weight = 10,
                    Warning = "VARNING: Bör inte konsumeras. Brukaren kommer drabbas av en mycket kraft halsbränna som sitter i drygt en veckas tid. Under veckan kommer brukaren andas eld och förbränner, snarare än smälter, all mat som konsumeras. "
                },

                new FurnitureModel()
                {
                    ID = "f16",
                    Name = "Magiskt Klädskåp",
                    Image = Path.GetFileName("Magisktklädskåp.jpg"),
                    Description = "Är du trött på alla timmar du lägger på fläckiga tröjor och få bort katthår från strumpor? Denna revolutionerande produkt är mycket populär bland trollkarlar som ska ut en fredagkväll. Stig in i det stora skåpet, liten som stor och kliv ut med rena kläder från topp till tå! ",

                    Cost = 7500,
                    Height = 10f,
                    Width = 5f,
                    Weight = 45,
                    Warning = "OBS: Se till att du har ordentligt med kläder på innan du kliver in. Skåpet kan ibland missta hud för kläder, därmed lämna en väldigt kosmetisk bieffekt, 'Lakansjukan.'"
                    + "Precis som ett litet barn som vanligen bär alldeles för stora kläder kommer du bära en alldeles för stor hud, vilken veckar sig som ett evigt sidenlakan som trolltrampats.'"
                },
                #endregion Furniture
                #region Potion
                new PotionModel()
                {
                    ID = "p06",
                    Name = "Blyfot",
                    Image = Path.GetFileName("Blyfot.jpg"),
                    Description = "En passande brygd för någon som känner sig busig! Den som får i sig denna brygd kommer göra ena foten 20 kilo tyngre än den andra.",
                    Cost = 500,
                    Ingredients = "Stortån från ett grinigt troll, hårväxt från en skallig dvärg prästinnas fötter",
                    Warning = "Biverkningar kan förekomma: Dålig balansförmåga, svårt att prova skor."
                },

                new PotionModel()
                {
                    ID = "p07",
                    Name = "Gunvalds' Nattöga",
                    Image = Path.GetFileName("Nattöga.jpg"), //återkommer med bild
                    Description = "Har dvärgarna i energiverket glömt sätta igång gasbelysningen nu igen!? Köp då en Nattöga, så behöver du inte oroa dig över att krossa näsbenet under en eventuell flygkvastsfärd. ",
                    Cost = 650,
                    Ingredients = "Ögat från en noll-ögd vargspindel, Dödligt odrickbart vatten.",
                    Warning = "BIEFFEKTER: Överkonsumption av denna dryck kan leda till Vindögdhet. Ögonen kommer fara runt som två frihetsberövade mördarstorkar vilket kan vara ytterst irriterande för den som försöker tala med den drabbade."
                },

                new PotionModel()
                {
                    ID = "p08",
                    Name = "Jesus Karlssons' Vattenvandrare",
                    Image = Path.GetFileName("jesusvattenvandring.jfif"),      //återkommer med bild
                    Description = "Detta elixir gör det omöjliga möjligt. Ett förtrollat elixir som gör att du kan vandra över vatten som det vore mark och utan att förstöra skosulan!.",
                    Cost = 150,
                    Ingredients = "Hårstrå från en långhårig helgonsgroda, malda tånaglar från ett hårigt troll. ",
                    Warning = "OBS: Vid fall eller förlust av balans, kommer brukaren plaska i vattnet som vanligt."
                },

                new PotionModel()
                {
                    ID = "p09",
                    Name = "Sune Surstrumpas' Få-Hår-Tillbaka",
                    Image = Path.GetFileName("fåhårtillbaka.jfif"),
                    Description = "Jobbigt att inte kunna väva skägget som en riktig dvärg? Trött på tonårsfjun? Eller en blänkande hjässa? Två droppar av denna dryck på tungan och du får all hårväxt du kan drömma om!",
                    Cost = 99,
                    Ingredients = "Tunga från en rosa tiger, saliv från en sömnig dvärg, finhackade råttöron. ",
                    Warning = "BIEFFEKTER: Överkonsumption kommer leda till mer hår än kanske önskvärt. Alla ytor på kroppen kommer täckas tjockt, stripigt hår, ungefär som på en liten vildhund med begynnande skabb."
                },

                new PotionModel()
                {
                    ID = "p10",
                    Name = "Jättesmartis Elixir",
                    Image = Path.GetFileName("Jättesmartis.jpg"),
                    Description = "Vill du vara supersmart som dina magikerkompisar som alltid skryter om hur häftiga eldklot de kan kasta från fingertopparna utan större anstränging? Jättesmartis är ett elixir som höjer din intelligenskvot till övermänskliga nivåer, så du kan lista ut (nästan) alla knep i vardagen!",
                    Cost = 10000,
                    Ingredients = "Tandsten från en 400-årig trollkarl, Bobbys' Blåsbubblor, Alviskt Skosnöre  ",
                    Warning = "BIEFFEKTER: Överkonsumption kan leda till Storkhalssyndrom och den stackars brukaren kommer ha en tre gånger så lång hals som normalt, något som dock lämpar sig utomordentligt för spanning upp genom gatubrunnar. "
                },
                #endregion Potion
                #region Tobacco
                new TobaccoModel()
                {
                    ID = "t11",
                    Name = "Lidemans Blå",
                    Image = Path.GetFileName("Lidemansblå.jpg"),
                    Description = "En stor exportsuccé utvecklad av dvärgarna i fiskebranchen - erbjuder en härlig smak av saltvatten, skelögd fulströmming och vit fethaj.",
                    Cost = 40,
                    Ingredients = "Bergssvampstobak, vatten, arom samt rökarom, havssalt, malen skelögd fulströmming, torkad vit fethaj ",
                    Warning = "Denna tobaken kan definitivt skada din hälsa och är beroendeframkallande, men riktigt gött att tugga!"
                },

                new TobaccoModel()
                {
                    ID = "t12",
                    Name = "Mild Tunnelsvinstobak",
                    Image = Path.GetFileName("Mildtunnelsvinstobak.jpg"),
                    Description = "Ett passande alternativ för lite känsligare dvärgar, med smak av en härlig dvärgisk frukost i Stubbiska Saluhallen.",
                    Cost = 60,
                    Ingredients = "Bergssvampstobak, vatten, arom samt rökarom, rökt tunnelsvinsbacon, sömnig kantarell, svett från en stressad sten",
                    Warning = "Denna tobaken kan definitivt skada din hälsa och är beroendeframkallande, men riktigt gött att tugga!"
                },

                new TobaccoModel()
                {
                    ID = "t13",
                    Name = "Malen Prästtumme",
                    Image = Path.GetFileName("Malenprästtumme.jpeg"),
                    Description = "En ceremoniell tuggtobak som bryts ner mellan käkarna på de stubbfyllda dvärgarna under heliga minnesstunder för gamla surmulna förfäder.",
                    Cost = 80,
                    Ingredients = "Bergssvampstobak, vatten, arom samt rökarom, aska från en kortväxt präst, torkat ölpulver, torkat kött från en grottbjörn",
                    Warning = "Denna tobaken kan definitivt skada din hälsa och är beroendeframkallande, men värsta av allt är att du kommer få höra dvärgiska körsånger på i huvudet."
                },

                new TobaccoModel()
                {
                    ID = "t14",
                    Name = "Bennys Brödtobak",
                    Image = Path.GetFileName("Bennysbrödtobak.jpg"),
                    Description = "Jobbigt att få i sig frukosten på morgonen? Ta en Bennys Brödtobak istället, få tillfredställelsen av både bröd och tobak på samma gång!",
                    Cost = 15,
                    Ingredients = "Bergsvampstobak, vatten, arom samt rökarom, brödsmulor",
                    Warning = "OBS: Lite av en blåsning skulle jag vilja säga, det är bara lite tuggtobak blandat med brödsmulor- oops skrev jag det offentligt?"
                },

                new TobaccoModel()
                {
                    ID = "t15",
                    Name = "Ronny Rödrasandes' Galenpanna",
                    Image = Path.GetFileName("Ronnyrödrasandesgalenpanna.png"),
                    Description = "En tuggtobak för dvärgar som behöver en riktig kick! Tuggas intensivt av bråkstakar som aldrig får nog.",
                    Cost = 95,
                    Ingredients = "Bergsvampstobak, vatten, arom samt rökarom, galenskapsdroppar, toksvamp",
                    Warning = "Brukaren kommer bli extremt vresig och rättretlig, minsta lilla ord kommer framstå som en kränkning och brukaren kommer med stor sannolikhet hamna i en knytnävesbatalj inom kommande timmarna."
                },
                #endregion Tobacco
                };

            }
            return Products;
        }

        public static List<ProductModel> FindAll()
        {
            return Products;
        }

        public static void GenerateNewProduct(string id, string name, string image, string description, decimal cost, string warning)
        {
            ProductModel product = new ProductModel();

            product.ID = id;
            product.Name = name;
            product.Image = image;
            product.Description = description;
            product.Cost = cost;
            product.Warning = warning;

           Products.Add(product);


        }

    }

}
