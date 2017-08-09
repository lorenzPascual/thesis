using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Admin.Models;
namespace Admin.Services
{
    public class HandlerServices
    {
        private readonly Models.Entities database;
        public HandlerServices()
        {
            database = new Models.Entities();
        }

        //public HandlerModel getHandler(int id) {

        //    return HandlerModel;
        //}
        public bool addHandler(HandlerModel handlerModel) {
            bool returnbool=true;
            try
            {
                database.handlerModel.Add(handlerModel);
                database.SaveChanges();
            }
            catch (Exception e)
            {
                returnbool = false;
            }
            return returnbool;
        }

        public List<HandlerModel> getAllHandler() {
            return database.handlerModel.ToList();
        }

        public bool updateHandler(HandlerModel handlerModel) {

            HandlerModel handler = database.handlerModel.SingleOrDefault(hand => hand.handlerId == handlerModel.handlerId);
            handler.handlerName = handlerModel.handlerName;

            database.SaveChanges();
            return false;
        }

    }
}
