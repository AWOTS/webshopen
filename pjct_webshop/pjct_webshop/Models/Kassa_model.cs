using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace pjct_webshop.Models
{
    public class Kassa_model
    {
        public void AddToCart(Produkt_model temp)
        {
            Controllers.MainController.varukorgsList.Add(temp);
        }
        public void RemoveFromCart(Produkt_model temp)
        {
            Controllers.MainController.varukorgsList.RemoveAll(x => x.Id.Equals(temp.Id));
        }
        public void UpdateAmount(Produkt_model temp, int newAmount)
        {
            bool done = false;
            int amountNow = 0;
            AllProduct_model listUpdate = new AllProduct_model();
            listUpdate.GetAll();
            foreach (Produkt_model item in Controllers.MainController.varukorgsList)
            {
                if (item.Id==temp.Id)
                {
                    amountNow++;
                }
            }
            foreach (Produkt_model item in listUpdate.lista)
            {
                if (temp.Id == item.Id && !done)
                {
                    done = true;
                    if (item.amount >= newAmount)
                    {
                        for (; amountNow < newAmount; amountNow++)
                        {
                            Controllers.MainController.varukorgsList.Add(item);
                        }
                        for (; amountNow > newAmount; amountNow--)
                        {
                            Controllers.MainController.varukorgsList.RemoveAt(Controllers.MainController.varukorgsList.FindIndex(x=>x.Id==temp.Id));
                        }
                    }
                }
            }
        }

    }


}