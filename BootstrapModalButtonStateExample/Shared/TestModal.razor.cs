using Microsoft.AspNetCore.Components;

namespace BootstrapModalButtonStateExample.Shared
{
    public partial class TestModal
    {
        private int _loanCount;
        public int LoanCount
        {
            get => _loanCount;
            set 
            {
                _loanCount = value;

                OnLoanCountChange.InvokeAsync(_loanCount);
            }
        }

        [Parameter]
        public EventCallback<int> OnLoanCountChange { get; set; } 

    }

}