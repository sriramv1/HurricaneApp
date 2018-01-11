using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;

namespace HApp.iOS
{
    public class Application
    {
        
        // This is the main entry point of the application.
        static void Main(string[] args)
        {
            // if you want to use a different Application Delegate class from "AppDelegate"
            // you can specify it here.
            
            //MongoUrl dbConUri = "mongodb:dbuser:dbpassword@192.168.0.8:27017";
            //var client = new MongoClient(dbConUri);
            //var db = client.GetDatabase("hurricane");
            //var coll = db.GetCollection<UserLoginDetails>("UserLoginDetails");
            UIApplication.Main(args, null, "AppDelegate");
                
        }


        //public class UserLoginDetails
        //{
        //    public ObjectId Id { get; set; }
        //    public string username { get; set; }
        //    public string password { get; set; }
        //}

    }
}
