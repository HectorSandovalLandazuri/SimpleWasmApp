using System.ComponentModel.DataAnnotations;

namespace SimpleWasm.Models;

public class AddressModel
{
    [Required]
    public string StreetAddress { get; set; }
	[Required]
	public string City { get; set; }

	[Required]
	[StringLength(maximumLength:2,MinimumLength =2)]
	public string State { get; set; }
	[Required]
	[StringLength(maximumLength:10,MinimumLength =5)]
	public string ZipCode { get; set; }

}
