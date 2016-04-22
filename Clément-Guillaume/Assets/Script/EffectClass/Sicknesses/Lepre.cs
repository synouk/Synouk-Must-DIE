using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


    public class Lepre : BaseSickness
    {
        public Lepre()
        {
            string name = "Lepre";
            int priceToRemove = 850;
            string description = "Evitez la guitar!";
        }   
        
       public override void affectToHeros(BaseHerosClass heros)
        {
            heros.Damage = Convert.ToInt32(heros.Damage * 0.5);
        }   

        public override void cancelAffectToHeros(BaseHerosClass heros)
        {
        heros.Damage = Convert.ToInt32(heros.Damage * 2);
        }
    }  

