using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiteDB;

namespace OrganiserV2.Database
{
    public class SystemData
    {
        private readonly string CollectionName = "SystemCollection";

        #region Singleton
        private static SystemData _instance;
        public static SystemData Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SystemData();
                }

                return _instance;
            }
        }
        #endregion

        private SystemData()
        {
        }

        







    }
}
