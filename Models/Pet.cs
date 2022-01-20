using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace pet_hotel
{
    public enum PetBreedType 
    {
      Shepherd,
      Poodle,
      Beagle,
      Bulldog,
      Terrier,
      Boxer,
      Labrador,
      Retriever
    }
    public enum PetColorType 
    {
      White, 
      Black, 
      Golden, 
      Tricolor, 
      Spotted
    }
    public class Pet 
    {
      public int id { get; set; }

      [Required]
      [JsonConverter(typeof(JsonStringEnumConverter))]
      public PetBreedType PetBreed { get; set; }
    

      [Required]
      [JsonConverter(typeof(JsonStringEnumConverter))]
      public PetColorType PetColor {get; set; }

      public DateTime? checkedInAt {get; set; }

      [ForeignKey("PetOwner")]
      public int petOwnerId { get; set; }

      public PetOwner ownedBy { get; set; }
    }
}
