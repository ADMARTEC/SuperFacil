using System.Collections.Generic;

namespace SuperFacil.Infraestructure.CrossCutting.Model
{
    public class ConfigureTwoFactor
    {
        public string SelectedProvider { get; set; }
        public ICollection<string> Providers { get; set; }
    }
}
