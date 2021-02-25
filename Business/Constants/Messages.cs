using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {   //publicler pascalCase yazılır
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string ProductListed = "Ürünler Listelendi";
        public static string MaintenanceTime = "Site Bakımda";

        public static string ProductCountOfCategoryError ="Her kategoride en fazla 10 ürün bulunabilir";

        public static string ProductNameAlreadyExist = "Bu isimde başka bir ürün bulunmaktadır";

        public static string CategoryLimitExceded = "Kategori limiti aşıma uğradığından yeni ürün eklenemedi";
    }
}
