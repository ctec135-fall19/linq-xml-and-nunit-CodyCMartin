using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.IO;



namespace Problem_2_XML_Using_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            // Calling the static method that creates and saves xml document

            XmlCreateSave();

            // Calling the method that is creating an XML Dox using an Array

            XmlFromArray();

            // Calling method that loads an xml file and prints it 

            XmlLoad();
        
            
          

        }

        // creating a static method that creates an XML Dox and saves it
        static void XmlCreateSave()
        {
            XElement doc =

                new XElement("Animal_Shelter_Inventory",
                new XComment("Animals_available_for_adoption"),
                new XElement("Dogs", 
                    new XElement("Dog", new XAttribute("ID", "1"),
                        new XElement("Name", "Rover"),
                        new XElement("Breed", "Golden Retriever"),
                        new XElement("Age", "4"),
                        new XComment("Additional_Info:_Loves_playing_fetch!")
                        ),
                    new XElement("Dog", new XAttribute("ID", "2"),
                        new XElement("Name", "Herby"),
                        new XElement("Breed", "Husky"),
                        new XElement("Age", "2"),
                        new XComment("Additional_Info:_Needs_potty_training!")
                        )
                    ),
                new XElement("Cats",
                   new XElement("Cat", new XAttribute("ID", "1"),
                        new XElement("Name", "Mittens"),
                        new XElement("Breed", "Normal"),
                        new XElement("Age", "1"),
                        new XComment("Additional_Info:_Lazy!")
                        ),
                   new XElement("Cat", new XAttribute("ID", "2"),
                        new XElement("Name", "fluffy"),
                        new XElement("Breed", "Exotic"),
                        new XElement("Age", "7"),
                        new XComment("Additional_Info:_Loves_chasing_laser_lights!")
                        ) 
                   )

                 );          
                                    
               
            // Save to a file.
            doc.Save("AnimalInventoryWithLINQ.xml");
            Console.WriteLine("Document created. Located in bin folder. File named AnimalInventoryWithLINQ.xml");
            
            Console.WriteLine();
                                 
        }

        // Creating a method that creates an XML Doc using an array

        static void XmlFromArray()
        {
            var cars = new[]
            {
                new{ Year = "2012", Make = "Ford", Model = "Escape"},
                new{ Year = "2014", Make = "Honda", Model = "Insight"},
                new{ Year = "2016", Make = "Chevy", Model = "F-250"},
            };


            XElement carDoc =
                new XElement("Cars",
                from c in cars
                select new XElement("Car",
                    new XElement("Year", c.Year),
                    new XElement("Make", c.Make),
                    new XElement("Model", c.Model)
                )
                    
                );

            // save it 

            carDoc.Save("CarInventoryList");

            // print statement for troubleshooting purposes

            Console.WriteLine("Created second xml doc using array");
            Console.WriteLine();


        }


        // Method that loads xml file and prints it 

        static void XmlLoad()
        {
            XDocument mydoc = XDocument.Load("CarInventoryList");
            Console.WriteLine("Printing of the cars inventory doc");
            Console.WriteLine();
            Console.WriteLine(mydoc);
        }
    }
}
