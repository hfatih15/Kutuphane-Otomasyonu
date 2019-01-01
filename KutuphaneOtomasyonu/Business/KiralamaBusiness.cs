using KutuphaneOtomasyonu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneOtomasyonu.Business
{
    class KiralamaBusiness
    {
        public int Kiralama(KitapKiralaViewModel KiralaModel)
        {
            MyContext db = new MyContext();
            using (var tran = db.Database.BeginTransaction())
            {
                try
                {
                    var kirala = new Kiralama()
                    {
                        UyeID = KiralaModel.UyeID,
                        KitapID = KiralaModel.KitapID,
                        AlindigiTarih = KiralaModel.AlindigiTarih,

                    };
                    var uye = db.Uyeler.Find(KiralaModel.UyeID);
                    uye.VarMi = true;
                    var kitap = db.Kitaplar.Find(KiralaModel.KitapID);
                    kitap.Adet--;
                    db.Kiralama.Add(kirala);
                    db.SaveChanges();
                    tran.Commit();
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    throw ex;
                }
            }
            return 1;


        }
    }
}