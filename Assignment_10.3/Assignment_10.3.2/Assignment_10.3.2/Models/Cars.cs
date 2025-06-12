using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment_10._3._2.Models;

public class Cars
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public string VIN { get; set; }
    public Manufacturer Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public int Price { get; set; }
    
    public enum Manufacturer
    {
        Toyota, Chevy, Ford, Honda, Nissan
    }
}