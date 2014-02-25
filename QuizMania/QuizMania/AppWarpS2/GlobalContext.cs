// Commenting
using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using com.shephertz.app42.gaming.multiplayer.client;
using System.Collections.Generic;

namespace QuizMania
{
    public class GlobalContext
    {
        public static String localUsername = "TestUser";
        public static String opponentName="No Opponent";
        public static bool AmIOwner = false;
        //create your game at apphq and find the api key and secret key
        public static String API_KEY = "";
        public static String HOST_NAME = "";
        public static String GameRoomId = "";
        public static List<string> joinedUsers=new List<string>();
        public static Dictionary<string, object> tableProperties = null;
        public static WarpClient warpClient;
        public static bool IsConnectedToAppWarp = false;
        public static int MaxUsersInRoom = 2;
        public static ConnectionListener conListenObj;
        public static String FacebookAppId = "555239294541353";
        public static String FacebookAccessToken="";
        public static String UserFacebookId = "";
        public static String RemoteFacebookId = "";
        public static String RemoteFacebookName = "";
        public static RoomReqListener roomReqListenerObj;
        public static NotificationListener notificationListenerObj;
        public static ZoneRequestListener zoneRequestListenerobj;
    }
}
