using daryljohn.midterm_.Infrastructure.Domain.Model;
using Microsoft.AspNetCore.Mvc;
using daryljohn.midterm_.Infrastructure.Domain.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.PortableExecutable;

namespace daryljohn.midterm_.Infrastructure.Domain.Model
{
    public class Products
    {
        public Guid? Id { get; set; }
        public string? Name { get; set; }
        public string? EmailAddress { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public Type? Type { get; set; }
        public Guid? RoleId { get; set; }

        [ForeignKey("RoleId")]
        public Categories? Categories { get; set; }
    }

    public enum Type
    {
        Consumable = 1,
        NonConsumable = 2
    }
}