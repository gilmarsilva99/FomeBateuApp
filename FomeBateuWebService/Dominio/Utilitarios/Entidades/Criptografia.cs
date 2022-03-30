using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace FomeBateuWebService.Dominio.Utilitarios.Entidades
{
    public class Criptografia
    {
                   
        public static string EncriptarSenha(string senha)
        {
            if (string.IsNullOrEmpty(senha))
            {
                return "";
            }

            senha += "|1234-123-123-123-123123123";
            MD5 md5 = MD5.Create();
            byte[] data = md5.ComputeHash(Encoding.Default.GetBytes(senha));
            StringBuilder sbString = new StringBuilder();
            foreach (byte b in data)
            {
                sbString.Append(b.ToString("x2"));
            }

            return sbString.ToString();
        }
    }
}