using System.ComponentModel.DataAnnotations;

public class ExampleModel
{
    [Required]
    [RegularExpression(@"^[0-9]{5}$", ErrorMessage = "Please enter a valid 5-digit US zip code.")]
    public string Zip { get; set; }
}
