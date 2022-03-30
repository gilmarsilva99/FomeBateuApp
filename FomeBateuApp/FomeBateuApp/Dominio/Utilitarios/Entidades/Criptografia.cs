using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace FomeBateuWebService.Dominio.Utilitarios.Entidades
{
    public static class Criptografia
    {
        private const string Salt = "58D19E9F-8F0A-46FE-A6F5-3E6D6CC69BCD";

        //public static string DecriptarParametros(string parametro)
        //{
        //    byte[] toEncryptArray = Convert.FromBase64String(parametro);

        //    MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
        //    byte[] keyArray = hashmd5.ComputeHash(Encoding.UTF8.GetBytes(Salt));
        //    hashmd5.Clear();

        //    TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider()
        //    {
        //        Key = keyArray,
        //        Mode = CipherMode.ECB,
        //        Padding = PaddingMode.PKCS7
        //    };

        //    ICryptoTransform cTransform = tdes.CreateDecryptor();
        //    byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);

        //    tdes.Clear();
        //    return Encoding.UTF8.GetString(resultArray);
        //}

        //public static string HashArquivo(string filename)
        //{
        //    using MD5 md5 = MD5.Create();
        //    using FileStream stream = File.OpenRead(filename);
        //    return Encoding.Default.GetString(md5.ComputeHash(stream));
        //}

        //public static string HashArquivo(byte[] conteudo)
        //{
        //    using MD5 md5 = MD5.Create();
        //    return Encoding.Default.GetString(md5.ComputeHash(conteudo));
        //}

        //public static string EncriptarSenha(string senha)
        //{
        //    if (string.IsNullOrEmpty(senha))
        //    {
        //        return "";
        //    }

        //    senha += "|1234-123-123-123-123123123";
        //    MD5 md5 = MD5.Create();
        //    byte[] data = md5.ComputeHash(Encoding.Default.GetBytes(senha));
        //    StringBuilder sbString = new StringBuilder();
        //    foreach (byte b in data)
        //    {
        //        sbString.Append(b.ToString("x2"));
        //    }

        //    return sbString.ToString();
        //}

        //public static bool ConteudoAssinaturaValida(string conteudo, string assinatura, string chaveSecreta)
        //{
        //    const string prefixoSha1 = "sha1=";

        //    if (string.IsNullOrWhiteSpace(conteudo))
        //    {
        //        throw new ArgumentNullException(nameof(conteudo));
        //    }

        //    if (string.IsNullOrWhiteSpace(assinatura))
        //    {
        //        throw new ArgumentNullException(nameof(assinatura));
        //    }

        //    if (!assinatura.StartsWith(prefixoSha1, StringComparison.OrdinalIgnoreCase))
        //    {
        //        return false;
        //    }

        //    string signatureSemPrefixo = assinatura.Substring(prefixoSha1.Length);

        //    byte[] chaveSecretaBytes = Encoding.UTF8.GetBytes(chaveSecreta);
        //    byte[] conteudoBytes = Encoding.UTF8.GetBytes(conteudo);

        //    using HMACSHA1 hmSha1 = new HMACSHA1(chaveSecretaBytes);
        //    byte[] hash = hmSha1.ComputeHash(conteudoBytes);

        //    string hashString = ParaHexString(hash);

        //    return hashString.Equals(signatureSemPrefixo);
        //}

        //private static string ParaHexString(IReadOnlyCollection<byte> bytes)
        //{
        //    StringBuilder builder = new StringBuilder(bytes.Count * 2);
        //    foreach (byte byteValue in bytes)
        //    {
        //        builder.AppendFormat("{0:x2}", byteValue);
        //    }

        //    return builder.ToString();
        //}
    }
}
