﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infinity.Datas
{
    namespace Querry
    {
        class Star
        {
            /// <summary>
            /// Gives a wanted propertie for a certain star class
            /// </summary>
            /// <param name="starDatas"></param>
            /// <param name="wantedStarClass"></param>
            /// <param name="wantedPropertie"></param>
            /// <param name="propertieValue"></param>
            public static void Specific(Dictionary<string, Dictionary<string, string>> starDatas, string wantedStarClass, string wantedPropertie, out string propertieValue)
            {
                propertieValue = null;

                foreach (KeyValuePair<string, Dictionary<string, string>> starClass in starDatas)
                {
                    //If it is the class user wants
                    if (starClass.Key == wantedStarClass)
                    {
                        foreach (KeyValuePair<string, string> starPropertie in starClass.Value)
                        {
                            //If propertie is user's wanted
                            if (starPropertie.Key == wantedPropertie)
                            {
                                propertieValue = starPropertie.Value;
                            }
                        }
                    }
                }
            }

            /// <summary>
            /// Gives all properties for a certain star class
            /// </summary>
            /// <param name="starDatas"></param>
            /// <param name="wantedStarClass"></param>
            /// <param name="properties"></param>
            public static void Global(Dictionary<string, Dictionary<string, string>> starDatas, string wantedStarClass, out Dictionary<string, string> properties)
            {
                properties = new Dictionary<string, string>();

                foreach (KeyValuePair<string, Dictionary<string, string>> starClass in starDatas)
                {
                    //If it is the class user wants
                    if (starClass.Key == wantedStarClass)
                    {
                        foreach (KeyValuePair<string, string> propertie in starClass.Value)
                        {
                            properties.Add(propertie.Key, propertie.Value);
                        }
                    }
                }
            }
        }
    }
}
