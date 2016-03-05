//using Microsoft.Phone.Tasks;
using Phoneword.WinPhone;
using Xamarin.Forms;

[assembly: Dependency(typeof(PhoneDialer))]

namespace Phoneword.WinPhone
{
    public class PhoneDialer : IDialer
    {
        public bool Dial(string number)
        {
            //PhoneCallTask phoneCallTask = new PhoneCallTask
            //{
            //    PhoneNumber = number,
            //    DisplayName = "Phoneword"
            //};

            //phoneCallTask.Show();

            Windows.ApplicationModel.Calls.PhoneCallManager.ShowPhoneCallUI(number, $"{number} display name");

            return true;
        }
    }
}