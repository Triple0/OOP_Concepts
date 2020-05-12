using System;

namespace oop_assignment
{
    // Demostrating Abstraction on class Category
    abstract class Category
    {
        public string categoryName = "Wall Art /  Paintings";
        public void displayCategory()
        {
            Console.WriteLine($"Below are current paintings under {categoryName}");
        }

        public virtual void type()
        {
            Console.WriteLine("This painting is Framed Print");
        }

        //https://www.artistsnetwork.com/art-techniques/beginner-artist/2-for-beginners-choosing-the-right-painting-medium/
        public virtual void Media()
        {
            Console.WriteLine("paintings can be made with many other mediums such as gouache, oil pastel, ink, pencil, markers, spray paint and silkscreen among others.");
        }

    }

    // Demonstrating inheritance and enscapulation on class Painting
    class Painting : Category
    {
        private string name;
        private string artist;
        private string medium;
        private string year;

        public string nameAccessor
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }

        }

        public string artistAccessor
        {
            get
            {
                return artist;
            }

            set
            {
                artist = value;
            }

        }

        public string mediumAccessor
        {
            get
            {
                return medium;
            }

            set
            {
                medium = value;
            }

        }

        public string yearAccessor
        {
            get
            {
                return year;
            }

            set
            {
                year = value;
            }

        }

    }

    // Displaying Polymorphism on the type and Media methods inherited from class Painting
    class Oil_Paint : Painting
    {
        public override void type()
        {
            Console.WriteLine("This is an Oil painting.");
        }
        public override void Media()
        {
            Console.WriteLine("Oil has the potential to crack, especially if used thickly. Most oils turn yellow over time, dramatically reducing luminosity in white and light value colors.");
        }

    }

    // Displaying Polymorphism on the type and Media methods inherited from class Painting
    class Acrylic : Painting
    {
        public override void type()
        {
            Console.WriteLine("This is an Acrylic painting.");
        }
        public override void Media()
        {
            Console.WriteLine("This medium offers the widest range of possibilities and is now considered more archival than all other mediums. When used correctly it will not crack or yellow, and fully cures in about two weeks.");
        }

    }

    // Displaying Polymorphism on the type and Media methods inherited from class Painting
    class Water_Color : Painting
    {
        public override void type()
        {
            Console.WriteLine("This is a Water color painting.");
        }
        public override void Media()
        {
            Console.WriteLine("This painting needs protection, such as being framed behind glass, due to paper being not as archival as panel or canvas as well as the nonpermanent nature of the watercolor paint.");
        }

    }

    // Displaying Polymorphism on the type and Media methods inherited from class Painting
    class Chalk_Pastel : Painting
    {
        public override void type()
        {
            Console.WriteLine("This is a Chalk Pastel painting.");
        }
        public override void Media()
        {
            Console.WriteLine("Pastel remains delicate on a surface and requires protection with glass and framing. Alternative protection, such as spray fixatives and sealers, will diminish pastel’s color and sheen.");
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello to Aaron's Art Gallery!");
            Console.WriteLine(""); // Used for readability

            // Instantiating a new object from class Oil_Paint
            Oil_Paint painting = new Oil_Paint();

            // Setting values of WOil_Paint object, painting
            painting.nameAccessor = "Tullips from Holland";
            painting.artistAccessor = "Pieter Wegermans";
            painting.mediumAccessor = "Painting - Oil On Canvas";
            painting.yearAccessor = "November 10th, 2014";

            painting.displayCategory();

            // Getting values of Oil_Paint object, painting
            Console.WriteLine($"{painting.nameAccessor} is in the category of {painting.categoryName}");
            Console.WriteLine(""); // Used for readability
            Console.WriteLine("Painting's Information");
            Console.WriteLine($"Painting: {painting.nameAccessor}");
            Console.WriteLine($"Artist: {painting.artistAccessor}");
            Console.WriteLine($"Medium: {painting.mediumAccessor}");
            painting.type();
            painting.Media();

            Console.WriteLine("");// Used for readability

            // Instantiating a new object from class Water_Color
            Water_Color painting2 = new Water_Color();

            // Setting values of Water_color object, painting2
            painting2.nameAccessor = "Never Alone";
            painting2.artistAccessor = "Sharon Cummings";
            painting2.mediumAccessor = "Painting - Water Color";
            painting2.yearAccessor = "January 18th, 2014";

            // Getting values of Water_color object, painting2
            Console.WriteLine($"{painting2.nameAccessor} is in the category of {painting2.categoryName}");
            Console.WriteLine(""); // Used for readability
            Console.WriteLine("Painting's Information");
            Console.WriteLine($"Painting: {painting2.nameAccessor}");
            Console.WriteLine($"Artist: {painting2.artistAccessor}");
            Console.WriteLine($"Medium: {painting2.mediumAccessor}");
            painting2.type();
            painting2.Media();
        }
    }
}
