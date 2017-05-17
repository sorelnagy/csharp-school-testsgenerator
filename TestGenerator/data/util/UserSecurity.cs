using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace TestGenerator.data.util
{
    static class UserSecurity
    {

        public static string hashPassword(String password)
        {

            String hash = null;

            if (password.Equals(""))
                return hash;

            return calculateMD5Hash(password).ToLower();

        }


        private static string calculateMD5Hash(String input)
        {

            MD5 md5 = MD5.Create();

            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hash = md5.ComputeHash(inputBytes);
            StringBuilder sb = new StringBuilder();

            for(int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }

            return sb.ToString();
        }
    }



}
