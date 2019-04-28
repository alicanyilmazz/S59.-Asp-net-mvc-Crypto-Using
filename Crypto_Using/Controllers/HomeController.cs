using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;

namespace Crypto_Using.Controllers
{
    public class HomeController : Controller
    {
        private string sifresiz = "alican yilmaz";
        private string sifreli = "AJPq7hnmLZohF/JtTrLa1QwjifkMG2fAKtqcmztZmeIST4vB/IKbrZ3vK+t8Etbzqw==";
        public ActionResult Index()
        {
            string salt = Crypto.GenerateSalt();

            string hash = Crypto.Hash(sifresiz); //Hash e parametre vermezseniz, SHA256 ile aynı şeyi üretir.
            string hash_md5 = Crypto.Hash(sifresiz, algorithm: "md5");
            string sh1 = Crypto.SHA1(sifresiz);
            string sh256 = Crypto.SHA256(sifresiz);

            string sonuc = Crypto.HashPassword(sifresiz);
            bool dogrumu = Crypto.VerifyHashedPassword(sifreli, sifresiz);

            return View();
        }
    }
}