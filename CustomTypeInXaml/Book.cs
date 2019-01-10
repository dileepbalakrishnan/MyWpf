using System.Windows.Markup;

[assembly: XmlnsDefinition("http://www.dileepbalakrishnan.com", "CustomTypeInXaml")]

namespace CustomTypeInXaml
{
    public class Book
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public decimal Price { get; set; }
        public int YearPublished { get; set; }

        public override string ToString()
        {
            return $"{Name} by {Author} published on {YearPublished}";
        }
    }
}
