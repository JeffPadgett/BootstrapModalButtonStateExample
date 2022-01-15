using Microsoft.AspNetCore.Components;
using System.ComponentModel.DataAnnotations;

namespace BootstrapModalButtonStateExample.Shared
{
    public partial class NameInput
    {

        private string _name;
        [Required]
        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                OnNameChange.InvokeAsync(_name);
            }
        }
        [Parameter]
        public EventCallback<string> OnNameChange { get; set; }
    }
}
