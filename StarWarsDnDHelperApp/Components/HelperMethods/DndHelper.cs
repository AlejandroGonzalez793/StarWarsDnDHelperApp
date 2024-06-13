using System.Collections;
using StarWarsDnDHelperApp.Components.Models;

namespace StarWarsDnDHelperApp.Components.HelperMethods
{
    public static class DndHelper
    {
        public static int rollDiceTwenty()
        {
            Random rnd = new Random();
            int rollNumber = rnd.Next(1, 21);
            return rollNumber;
        }
            
    }
}
