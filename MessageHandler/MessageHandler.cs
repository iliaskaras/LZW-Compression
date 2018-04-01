using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


class MessageHandler : IMessageHandler
{
    public void youHaventChoosedFileMessage()
    {
        string message = "Παρακαλώ επιλέξτε ένα αρχείου κειμένου, για να συνεχίσετε!";
        
        MessageBox.Show(message);
    }

    public void youMustTypeTextToCompressMessage()
    {
        string message = "Παρακαλώ πληκτρολογήστε ένα κείμενο προτού προχωρήσετε στην διαδικασία συμπίεσης.";

        MessageBox.Show(message);
    }
}

