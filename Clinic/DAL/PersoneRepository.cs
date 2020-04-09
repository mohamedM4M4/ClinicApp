using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Clinic.DBContext;
using Clinic.Model;
namespace Clinic.DAL
{
   public class PersoneRepository
    {  
        ClinicDBContext context = new ClinicDBContext();
        public Persone Find(string userName) => context.Persones.SingleOrDefault(p => p.UserName == userName);
        public void Remove(string userName) => context.Persones.Remove(Find(userName));
        public void Add(Persone persone)
        {
            HashAlgorithm hashAlgorithm = new SHA256CryptoServiceProvider();
            var byteValue = Encoding.UTF8.GetBytes(persone.PassWord);
            var byteHash = hashAlgorithm.ComputeHash(byteValue);
            string pass = Convert.ToBase64String(byteHash);
            persone.PassWord = pass;
            context.Persones.Add(persone);
        
        } 
        public void save() => context.SaveChanges();
      

    }
}
