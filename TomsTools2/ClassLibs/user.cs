using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TomsTools2.ClassLibs
{

  


    public class user
    {

        public int _permissionLevel { get; set; }
        public string _username { get; set; }
        public bool _isValid { get; set; }


        public user(string username)
        {
            _username = username;
            isValid();
        }

        private void setPermissions()
        {
            switch (_username)
            {
                case "tom":
                    _permissionLevel = 1;
                    break;
                case "admin":
                    _permissionLevel = 2;
                    break;
                case "suser":
                    _permissionLevel = 3;
                    break;
                case "punch":
                    _permissionLevel = 4;
                    break;
                case "bend":
                    _permissionLevel = 5;
                    break;
                case "weld":
                    _permissionLevel = 6;
                    break;
                case "buff":
                    _permissionLevel = 7;
                    break;
                case "paint":
                    _permissionLevel = 8;
                    break;
                case "pack":
                    _permissionLevel = 9;
                    break;
                case "dispatch":
                    _permissionLevel = 10;
                    break;
                case "laser":
                    _permissionLevel = 11;
                    break;


            }
        }

        public void isValid()
        {
            bool userLoopCheck = false;

            List<string> userList = new List<string>();
            userList.Add("tom");
            userList.Add("admin");
            userList.Add("suser");
            userList.Add("punch");
            userList.Add("bend");
            userList.Add("weld");
            userList.Add("buff");
            userList.Add("paint");
            userList.Add("pack");
            userList.Add("dispatch");
            userList.Add("laser");

            foreach (string item in userList)
            {
                var pattern = @"\b" + Regex.Escape(_username) + @"\b";
                var result = Regex.IsMatch(item, pattern); // returns false

                if (result == true)
                {
                    userLoopCheck = true;
                }


            }

            if (userLoopCheck == true)
            {
                setPermissions();
                _isValid = true;
               
            }
            else
            {
                _isValid = false;
            }
        }




        

    }




    
}
