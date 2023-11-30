using System.ComponentModel.DataAnnotations;
using TTRPG_Character_Builder.Models;
using TTRPG_Character_Builder.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;



namespace TTRPGtests.Models
{
    public class CharacterTests
    {
        [Fact]
        public void CharacterModel_Validation_ShouldPassWithValidData()
        {
            var character = new Character
            {
                Name = "Legolas",
                Race = "Elf",
                Class = "Ranger",
                Strength = 17,
                Dexterity = 17,
                Constitution = 14,
                Intelligence = 15,
                Wisdom = 12,
                Charisma = 16,
                Biography = "This is a test character."
            };

            var validationResults = new List<ValidationResult>();
            var actual = Validator.TryValidateObject(character, new ValidationContext(character), validationResults, true);

            Assert.True(actual, "Expected validation to succeed with valid data.");
        }

        [Fact]
        public void CharacterModel_Validation_ShouldFailWithInvalidData()
        {
            var character = new Character
            {
                // Missing required fields like Name, Race, Class
            };

            var validationResults = new List<ValidationResult>();
            var actual = Validator.TryValidateObject(character, new ValidationContext(character), validationResults, true);

            Assert.False(actual, "Expected validation to fail with invalid data.");
        }
    }
}
