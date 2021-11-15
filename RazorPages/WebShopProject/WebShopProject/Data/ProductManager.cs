﻿using System;
using WebShopProject.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebShopProject.Data
{
    public class ProductManager
    {

        private List<ProductModel> Products;

        //jag har lagt till productmodels med alla kategorier, behövs bara förtydligande av olika föremål och det går att lägga
        //till om man så önskar. Jag la de ny-genererade produkterna i #regioner bara för att förtydliga ordningen
        //Nedanför har jag försökt skapa metoder för att kunna söka på olika prylar, men behöver arbeta lite mer på det (och nu är jag trött)

        //Metoderna ska kunna hänvisas till pages senare.

        public List<ProductModel> GetProducts()
        {
            if (Products == null || !Products.Any())
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
                    Image = "wwwroot/image/Varmamuggen.png",
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
                    Name = "Sol i Plunta",
                    Image = "image here",                                                                            // återkommer med bild av denna magiska produkt.
                    Description = "Långt kvar till semestern? Oroa dig inte, ta med dig din solsemester i en enkel plunta! "
                                  + "En revolutionerande magisk produkt som inte bara värmer och lyser upp ditt hem, utan förändrar ditt humör till det bättre!",              
                    Cost = 3500,
                    Height = 6f,
                    Width = 7f,
                    Weight = 10,
                    Warning = "Varning: Bör inte konsumeras. Brukaren kommer drabbas av en mycket kraft halsbränna som sitter i en dryg vecka. Under veckan kommer brukaren andas eld och förbränner, snarare än smälter, all mat som konsumeras. "
                },            

                new FurnitureModel()
                {
                    ID = "f05",
                    Name = "Magiskt Klädskåp",
                    Image = "image here",                     //Återkommer med bild av denna magiska produkt
                    Description = "Är du trött på alla timmar du lägger på fläckiga tröjor och få bort katthår från strumpor? Denna revolutionerande produkt är mycket populär bland trollkarlar som ska ut en fredagkväll. Stig in i det stora skåpet, liten som stor och kliv ut med rena kläder från topp till tå! ",
                                  
                    Cost = 7500,
                    Height = 10f,
                    Width = 5f,
                    Weight = 45,
                    Warning = "Tyvärr tvättar skåpet inte bort dofter utan till och med stärker vissa, undvik att kliva in med stinkande kläder. "
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
                    Description = "Har dvärgarna i energiverket glömt sätta igång gasbelysningen nu igen!? Köp då en Nattöga, så behöver du inte oroa dig över att krossa näsbenet under en eventuell flygkvastsfärd. ",
                    Cost = 650,
                    Ingredients = "Ögat från en noll-ögd vargspindel, Dödligt odrickbart vatten.",
                    Warning = "OBS: Överkonsumption av denna dryck kan leda till att ena pupillern snurrar många varv i minuten likt en propeller, vilket kan distrahera något ofantligt i möte med någon annan."
                },

                new PotionModel()
                {
                    ID = "p08",
                    Name = "Jesus Karlssons' Vattenvandrare",
                    Image = "image here",      //återkommer med bild
                    Description = "Detta elixir gör det omöjliga möjligt. Ett förtrollat elixir som gör att du kan vandra över vatten som det vore mark.",
                    Cost = 150,
                    Ingredients = "Hårstrå från en långhårig helgonsgroda, malda tånaglar från ett hårigt troll. ",
                    Warning = "Vid fall och förlust av balans, kommer brukaren plaska i vattnet som vanligt."
                },

                new PotionModel()
                {
                    ID = "p09",
                    Name = "Skäggavfall",
                    Image = "image here",   //kommer med bild inom kort!
                    Description = "Jobbigt att raka bort skäggstubben varje morgon? Två droppar av denna dryck på tungan och allt skägg åker av direkt! Superenkelt!",
                    Cost = 99,
                    Ingredients = "Tunga från en rosa tiger, saliv från en sömnig dvärg, finhackade råttöron. ",
                    Warning = "Risk för att tappa håret på andra ställen än i ansiktet. Bortfall av hår kan hamna i kläder, orsaka stor irritation. "
                },

                new PotionModel()
                {
                    ID = "p10",
                    Name = "Jättesmartis Elixir",
                    Image = "image here", // bild inom kort.
                    Description = "Vill du vara supersmart som dina magikerkompisar som alltid skryter om hur häftiga eldklot de kan kasta från fingertopparna utan större anstränging? Jättesmartis är ett elixir som höjer din intelligenskvot till övermänskliga nivåer, så du kan lista ut (nästan) alla knep i vardagen!",
                    Cost = 10000,
                    Ingredients = "Tandsten från en 400-årig trollkarl, en skvätt amfetamin, uran-235  ",
                    Warning = "Bieffekt: Överkonsumption kan leda till Storkhalssyndrom och förstoring av skallloben. "
                },
                #endregion Potion
                #region Tobacco
                new TobaccoModel()
                {
                    ID = "t11",
                    Name = "Lidemans blå",
                    Image = "image here",
                    Description = "En stor exportsuccé utvecklad av dvärgarna i fiskebranchen - erbjuder en härlig smak av saltvatten, skelögd fulströmming och vit fethaj.",
                    Cost = 40,
                    Ingredients = "Bergssvampstobak, vatten, arom samt rökarom, havssalt, malen skelögd fulströmming, torkad vit fethaj ",
                    Warning = ""
                },

                new TobaccoModel()
                {
                    ID = "t12",
                    Name = "Mild Tunnelsvinstobak",
                    Image = "image here",
                    Description = "Ett passande alternativ för lite känsligare dvärgar.",
                    Cost = 60,
                    Ingredients = "Bergssvampstobak, vatten, arom samt rökarom, rökt tunnelsvinsbacon, sömnig kantarell, svett från en stressad sten",
                    Warning = ""
                },

                new TobaccoModel()
                {
                    ID = "t13",
                    Name = "Malen Prästtumme",
                    Image = "image here",
                    Description = "En ceremoniell tuggtobak som bryts ner mellan käkarna på de stubbfyllda dvärgarna under minnesstunder för gamla surmulna förfäder.",
                    Cost = 0,
                     Ingredients = "Bergssvampstobak, vatten, arom samt rökarom, aska från en kortväxt präst, torkat ölpulver, torkat kött från en grottbjörn",
                    Warning = ""
                },

                new TobaccoModel()
                {
                    ID = "t14",
                    Name = "Bennys Brödtobak",
                    Image = "image here",
                    Description = "Jobbigt att få i sig frukosten på morgonen? Ta en Bennys Brödtobak istället, få tillfredställelsen av både bröd och tobak på samma gång!",
                    Cost = 0,
                    Ingredients = "Bergsvampstobak, vatten, arom samt rökarom, brödsmulor",
                    Warning = ""
                },

                new TobaccoModel()
                {
                    ID = "t15",
                    Name = "Ronny Rödrasandes' Galenpanna",
                    Image = "image here",
                    Description = "En tuggtobak för dvärgar som behöver en riktig kick!",
                    Cost = 0,
                    Ingredients = "Bergsvampstobak, vatten, arom samt rökarom, galenskapsdroppar, toksvamp",
                    Warning = "Brukaren kommer bli extremt vresig och rättretlig, minsta lilla ord kommer framstå som en kränkning."
                },
                #endregion Tobacco
            };
         
            }
            return Products; 

          
            //Uppdaterat tobaksprodukter; inte färdigt
        }

        public List<ProductModel> FindAll()
        {
            return Products;
        }

       public ProductModel FindID(string id)
        {
            return Products.Where(product => product.ID == id).FirstOrDefault(); //kopplat till ovanstående PROBLEM: Returnerar null
        }
    }

}
