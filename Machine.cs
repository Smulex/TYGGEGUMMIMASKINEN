using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TYGGEGUMMIMASKINEN
{
    public class Machine
    {
        public string[] gum = new string[55];
        /// <summary>
        /// Den her constructor lavet maskinen så den er fyldt.
        /// </summary>
        public Machine()
        {
            Fill();
        }
        /// <summary>
        /// Den her metode fylder tyggegummimaskinen.
        /// Jeg er itvivl om jeg skal havde oprette et objekt for hver tyggegummi eller for hver smag,
        /// så gjorder det bare for hver smag.
        /// Kom først i tænke om den her efter jeg havde lavet det (gum[i] = new Gum("name");)
        /// </summary>
        /// <returns></returns>
        public string[] Fill()
        {
            Gum blueberry = new Gum("Blueberry");
            Gum bramble = new Gum("Bramble");
            Gum tuttiFrutti = new Gum("Tutti Frutti");
            Gum orange = new Gum("Orange");
            Gum strawberry = new Gum("Strawberry");
            Gum apple = new Gum("Apple");
            for (int i = 0; i < 55; i++)
            {
                if (i >= 0 && i < 14)
                {
                    gum[i] = blueberry.Name;
                }
                else if (i >= 14 && i < 21)
                {
                    gum[i] = bramble.Name;
                }
                else if (i >= 21 && i < 32)
                {
                    gum[i] = tuttiFrutti.Name;
                }
                else if (i >= 32 && i < 42)
                {
                    gum[i] = orange.Name;
                }
                else if (i >= 42 && i < 50)
                {
                    gum[i] = strawberry.Name;
                }
                else if (i >= 50 && i < 55)
                {
                    gum[i] = apple.Name;
                }
            }
            return gum;
        }
        /// <summary>
        /// Den her metode giver et tilfældigt tyggegummi.
        /// </summary>
        /// <returns></returns>
        public string GetGum()
        {
            Random random = new Random();
            string theGum;
            do
            {
                int index = random.Next(0, gum.Length);

                if (gum[index] != GumSpace())
                {
                    theGum = gum[index];
                    gum[index] = GumSpace();
                    return theGum;
                }
                else if (CheckEmpty())
                {
                    theGum = "The machine is empty!";
                    return theGum;
                }
            } while (true);
        }
        /// <summary>
        /// Den her metode vil jeg selv mene var ligegyldig, da det bare kunne være en string.
        /// </summary>
        /// <returns></returns>
        private string GumSpace()
        {
            string gum = "Empty";
            return gum;
        }
        /// <summary>
        /// DEn her metode tjekker om der er flere tyggegummiere i maskinen.
        /// </summary>
        /// <returns></returns>
        public bool CheckEmpty()
        {
            for (int i = 0; i < gum.Length; i++)
            {
                if (gum[i] != GumSpace())
                {
                    return false;
                }
            }
            return true;
        }
    }
}
