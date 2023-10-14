using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components;
using Omnidroid_Start.Shared;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;

namespace Omnidroid_Start.Client
{
    public class Universal
    {
        public static bool? IfModuleHost { get; set; }
        public string? Terms1Prefix { get; set; }
        [Required]
        public string? RefGender { get; set; }
        [Required]
        public string? LastName { get; set; }
        public string? NotMaidenName { get; set; }
        public string? FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string? Terms1Suffix { get; set; }
        public string? refCountry { get; set; }
        public string? EMail { get; set; }
        public string? Phone { get; set; }
        public bool IfModuleMarried { get; set; }
        public bool IfModuleTitledProfession { get; set; }
        public bool IfModuleDescent { get; set; }
        public string? EchelonName { get; set; }

    }
}
