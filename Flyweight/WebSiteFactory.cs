using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    class WebSiteFactory
    {
        private Hashtable flyweights = new Hashtable();

        // 獲得網站的分類
        public WebSite GetWebSiteCategory(string key)
        {
            if (!flyweights.ContainsKey(key))
            {
                flyweights.Add(key, new ConcreteWebSite(key));
            }
            return ((WebSite)flyweights[key]);
        }

        // 獲得網站分類總數
        public int GetWebSiteCount()
        {
            return flyweights.Count;
        }

    }
}
