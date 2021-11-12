using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebShopProject.Models
{
    public class ProductManager
    {

        private List<ProductModel> Products { get; set; }

        //jag har lagt till productmodels med alla kategorier, behövs bara förtydligande av olika föremål och det går att lägga
        //till om man så önskar. Jag la de ny-genererade produkterna i #regioner bara för att förtydliga ordningen
        //Nedanför har jag försökt skapa metoder för att kunna söka på olika prylar, men behöver arbeta lite mer på det (och nu är jag trött)

        //Metoderna ska kunna hänvisas till pages senare

        //Ska ni lägga till nya föremål så ändra i koden:

        public ProductModel()
        {
            Products = new List<ProductModel>() //I detta kodstycke kan ni lägga till nya föremål
            {
                #region Furniture
                new FurnitureModel()
                {
                    ID = "f01",
                    Name = "Lergoblin",
                    Image = "image here",
                    Description = "En liten figur som sjunger tvåstämmigt den kända ”Kloaksonaten” – inte särskilt vacker melodi, men underhållande!",
                    Cost = 50,
                    Height = 0.3f,
                    Width = 0.3f,
                    Weight = 0.2f,
                    Warning = "Varning: Avsaknad av avstängingsläge förekommer."
                },

                new FurnitureModel()
                {
                    ID = "f02",
                    Name = "Varma Muggen",
                    Image = "image here",
                    Description = "Är du inte trött på att behöva värma kaffet varje gång du glömt av att dricka den sista slurpen? "
                                  + "Oroa dig inte, denna magiska mugg är förtrollad med värmande magi och du behöver nu aldrig stressa dig i kaffet!",
                    Cost = 750,
                    Height = 0.5f,
                    Width = 0.5f,
                    Weight = 1,
                    Warning = "Vi ansvarar inte för eventuella för brända tungor under kaffe incidenter."
                },

                new FurnitureModel()
                {
                    ID = "f03",
                    Name = "Svävande Bärstol",
                    Image = "image here",
                    Description = "Vill du kunna sväva utan större ansträngning upp till femton meter över marken?"
                                  + "Denna lyxiga bärstol av ädelträ styrs med dina tankar och kan flyga upp till 100 kilometer i timmen!",
                    Cost = 55000,
                    Height = 2.5f,
                    Width = 1.5f,
                    Weight = 300,
                    Warning = "En explosiv ökning av fart kan bidra till en väldigt flygande åktur - även ur stolen!"
                },
                
                new FurnitureModel()
                {
                    ID = "f04",
                    Name = "Magisk Självfejande Sopkvast",
                    Image = "image here",
                    Description = "Trött på städa? Eller kanske sugen på en snabb flygtur?"
                                  + "Denna magiska kvast är självfejande och städar åt dig i samtliga rum och är samt kapabel för en snabb flygresa. Ett populärt föremål i Häxornas' Krokryggsförening.",
                    Cost = 4000,
                    Height = 1.5f,
                    Width = 0.10f,
                    Weight = 2,
                    Warning = "Säkerhetsbälte ingår inte för flygturer."
                },
                
                new FurnitureModel()
                {
                    ID = "f05",
                    Name = "Magiska Elementet",
                    Image = "image here",                                                                            // återkommer med bild av denna magiska produkt.
                    Description = "Det magiska elementet som får hela ditt hem att framstå som en solsemester."
                                  + "En revolutionerande magisk produkt som förändrar värmen för hela ditt hem.",              
                    Cost = 3500,
                    Height = 6f,
                    Width = 7f,
                    Weight = 10,
                    Warning = "Kan explodera vid en för HÖG värme halt. Vi rekomenderar att inte göra några magiska trollkarlsövningar i närheten av denna produkt, då explosion risken är hög. "
                },            


                new FurnitureModel()
                {
                    ID = "f05",
                    Name = "Magiskt kläddskåp",
                    Image = "image here",                     //Återkommer med bild av denna magiska produkt
                    Description = "En revolutionerande produkt inom den magiska sektorn. Stig in i det stora skåpet, liten som stor och kliv ut med rena kläder från topp till tå. "
                                  
                    Cost = 7500,
                    Height = 10f,
                    Width = 5f,
                    Weight = 45,
                    Warning = "Titta nogrant att du inte stiger in i detta magiska skåpet med hundskit, risken för en hemsk doft på kläderna ökar risken markant. "
                },
                #endregion Furniture
                #region Potion
                new PotionModel()
                {
                    ID = "p06",
                    Name = "Blyfot",
                    Image = "image here",
                    Description = "En passande brygd för någon som känner sig busig! Den som får i sig denna brygd kommer göra ena foten 20 kilo tyngre än den andra.",
                    Cost = 500,
                    Ingredients = "Stortån från ett grinigt troll, hårväxt från en skallig dvärg prästinnas fötter",
                    Warning = "Biverkningar kan förekomma: Dålig balansförmåga, svårt att prova skor."
                },

                new PotionModel()
                {
                    ID = "p07",
                    Name = "Nattöga",
                    Image = "image here", //återkommer med bild
                    Description = "Upplever du ett försämrat synfält när du skall ta kvasten på natten? Vår nya potion nattöga, ger dig nightvison. ",
                    Cost = 650,
                    Ingredients = "Vargspindel öga, Vatten från dödahavet.",
                    Warning = "OBS: en droppe för mycket av Nattöga, löper en stor risk för att tappa synen för alltid."
                },

                new PotionModel()
                {
                    ID = "p08",
                    Name = "Jesus vatten potion",
                    Image = "image here",      //återkommer med bild
                    Description = "Detta elexir gör det omöjliga möjligt. Vi tog hjälp av jesus att framkalla detta. En potion som gör att du kan vandra över vatten.",
                    Cost = 150,
                    Ingredients = "Hårstrå från jesus, tånagel från Bigfoot. ",
                    Warning = "Vid använding tänk på att alltid ha detta elexir i fickan, finns en stor risk att magin slutar verka och vi alla vet hur det skulle sluta ute på det öppna havet."
                },

                new PotionModel()
                {
                    ID = "p09",
                    Name = "Skäggavfall",
                    Image = "image here",   //kommer med bild inom kort!
                    Description = "Denna dryck gör din vardag som magiker enklare. Lider du av problemet skäggväxt? Två droppar av denna dryck på tungan och allt skägg åker av direkt.",
                    Cost = 99,
                    Ingredients = "Tunga från tiger, Dvärgsaliv, råttöra. ",
                    Warning = "Risk för att tappa håret på andra ställen än i ansiktet. Studier visar även på att vissa har fått en infekterad pungkula. "
                },

                new PotionModel()
                {
                    ID = "p10",
                    Name = "MegaMind",
                    Image = "image here", // bild inom kort.
                    Description = "MegaMind är ett elexir som höjer din IQ. I snitt ligger en männsikas IQ mellan 90-100. MegaMind ger dig en IQ på över 500. ",
                    Cost = 10 000,
                    Ingredients = "hjärncell från Albert Einstein, en skvätt amfetamin, uran-235  ",
                    Warning = "Då uran-235 finns i MegaMind finns det risk för att hjärncellerna dör. "
                },
                #endregion Potion
                #region Tobacco
                new TobaccoModel()
                {
                    ID = "t11",
                    Name = "",
                    Image = "image here",
                    Description = "",
                    Cost = 0,
                    Ingredients = "",
                    Warning = ""
                },

                new TobaccoModel()
                {
                    ID = "t12",
                    Name = "",
                    Image = "image here",
                    Description = "",
                    Cost = 0,
                    Ingredients = "",
                    Warning = ""
                },

                new TobaccoModel()
                {
                    ID = "t13",
                    Name = "",
                    Image = "image here",
                    Description = "",
                    Cost = 0,
                    Ingredients = "",
                    Warning = ""
                },

                new TobaccoModel()
                {
                    ID = "t14",
                    Name = "",
                    Image = "image here",
                    Description = "",
                    Cost = 0,
                    Ingredients = "",
                    Warning = ""
                },

                new TobaccoModel()
                {
                    ID = "t15",
                    Name = "",
                    Image = "image here",
                    Description = "",
                    Cost = 0,
                    Ingredients = "",
                    Warning = ""
                },
                #endregion Tobacco
            };

            //PROBLEM: Returnerar null, försöker lista ut en lösning
           //fyllt i produkterna i dem 2 första spalterna. Det som skall läggas till i dem är bilder. Detta kan jag behöva hjälp med Karl-johan <3
        }

        public List<ProductModel> FindAll()
        {
            return Products;
        }

       public ProductModel FindID(string id)
        {
            return Products.Where(p => p.ID == id).FirstOrDefault; //kopplat till ovanstående PROBLEM: Returnerar null
        }
    }

}
