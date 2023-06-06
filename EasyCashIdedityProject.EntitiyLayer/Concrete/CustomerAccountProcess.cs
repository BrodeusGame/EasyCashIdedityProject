using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentityProject.EntitiyLayer.Concrete
{
  public class CustomerAccountProcess
    {
        public int  CustomerAccountProcessID { get; set; }
        public string CustomerAccountProcessType { get; set; }
        public decimal CustomerAccountAmount { get; set; }
        public DateTime CustomerAccountProcessDate { get; set; }
       
    
    }
}
        /*
         Id - İşlemTüre(Gelen,Giden,Ödeme) - Miktar - Tarih - Alıcı - Gönderici 
         */
